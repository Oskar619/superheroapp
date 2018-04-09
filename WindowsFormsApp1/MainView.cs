using Newtonsoft.Json;
using SuperHeroAppRepo.Entities;
using SuperHeroAppRepo.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private List<SuperHero> Heroes { get; set; }
        private SuperHero _selectedHero;
        private int _selectedPower;

        private async void OnLoad(object sender, EventArgs e)
        {
            await LoadComboBox();
        }

        private async Task LoadComboBox()
        {
            using (var repo = new SuperHeroRepository())
            {
                Heroes = await repo.GetListAsync();
                cbLoadedSuperHeroes.DataSource = Heroes;
                cbLoadedSuperHeroes.DisplayMember = "SuperHeroName";
                cbLoadedSuperHeroes.ValueMember = "Id";
                if (Heroes.Count > 0) cbLoadedSuperHeroes.SelectedIndex = 0;
            }
        }

        private void ReloadSelectedHero()
        {
            using (var repo = new SuperHeroRepository())
            {
                Heroes.Remove(_selectedHero);
                var hero = repo.GetById(_selectedHero.Id);
                _selectedHero = hero;
                Heroes.Add(_selectedHero);
                SetHero(_selectedHero);
            }
        }

        private void LoadAssembly_Click(object sender, EventArgs e)
        {
            var assemblyLoader = new AssemblyLoader();
            assemblyLoader.FormClosed += AssemblyLoader_FormClosed;
            assemblyLoader.ShowDialog();
        }

        private async void AssemblyLoader_FormClosed(object sender, FormClosedEventArgs e)
        {
            await LoadComboBox();
        }

        private void cbLoadedSuperHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hero = cbLoadedSuperHeroes.SelectedItem as SuperHero;
            SetHero(hero);
        }

        private void SetHero(SuperHero hero)
        {
            if (hero == null) return;
            _selectedHero = hero;
            this.txtDateOfBirth.Text = String.Format("{0:MMM d, yyyy}", hero.DateOfBirth);

            this.txtRealName.Text = hero.Name;
            if(hero.Powers == null)
            {
                using (var repo = new SuperHeroPowerRepository())
                {
                    hero.Powers = repo.GetFilteredList(x => x.SuperHeroId == hero.Id);
                }
            }
            this.lbPowers.DataSource = hero.Powers;
            this.lbPowers.DisplayMember = "PowerName";
            this.lbPowers.ValueMember = "Id";
            if(hero.Powers.Count > 0)
            {
                lbPowers.SetSelected(0, true);
            }
            else
            {
                _selectedPower = 0;
            }


            byte[] bytes = Convert.FromBase64String(hero.Base64Img);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            this.pbProfilePicture.Image = image;
            this.pbProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAddPower_Click(object sender, EventArgs e)
        {
            var editor = new PowerPopup();
            editor.FormClosing += Editor_FormClosing;
            editor.selectedHero = _selectedHero;
            editor.ShowDialog();
        }

        private void lbPowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pw = (SuperHeroPower)lbPowers.SelectedItem;
            if(pw != null)
            {
                _selectedPower = pw.Id;
            }
            else
            {
                _selectedPower = 0;
            }
            CheckEditorButtons();
        }

        private void CheckEditorButtons()
        {
            btnAddPower.Enabled = true;
            btnDeletePower.Enabled = _selectedPower > 0;
            btnEditPower.Enabled = _selectedPower > 0;
        }

        private void btnEditPower_Click(object sender, EventArgs e)
        {
            var editor = new PowerPopup();
            editor.selectedHero = _selectedHero;
            editor.selectedPowerId = _selectedPower;
            editor.FormClosing += Editor_FormClosing;
            editor.ShowDialog();
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            var pf = sender as PowerPopup;
            if(pf != null)
            {
                if (pf.UpdateRequired)
                {
                    ReloadSelectedHero();
                }
            }
        }

        private void btnDeletePower_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure you want to delete this power?", "Power Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.No)
            {
                return;
            }
            using (var repo = new SuperHeroPowerRepository())
            {
                repo.Delete(_selectedPower);
                repo.Save();
            }
            ReloadSelectedHero();
        }

        private void exportAsXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedHero == null) return;
            var result = MessageBox.Show("Do you want to include the image (as a base64 string) in the export?", "Export details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var includeImage = result == DialogResult.Yes;
            var itemToExport = new SerializableSuperHero(_selectedHero, includeImage);

            XmlSerializer serializer = new XmlSerializer(typeof(SerializableSuperHero));
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    serializer.Serialize(writer, itemToExport);
                    xml = sww.ToString();
                    var exportView = new ExportView();
                    exportView.SetData(xml);
                    exportView.ShowDialog();
                }
            }
        }

        private void exportAsJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedHero == null) return;
            var result = MessageBox.Show("Do you want to include the image (as a base64 string) in the export?", "Export details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var includeImage = result == DialogResult.Yes;
            var itemToExport = new SerializableSuperHero(_selectedHero, includeImage);

            var serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            var json = "";
            using(var sww = new StringWriter())
            using (JsonWriter writer = new JsonTextWriter(sww))
            {
                serializer.Serialize(writer, itemToExport);
                json = sww.ToString();
                var exportView = new ExportView();
                exportView.SetData(json);
                exportView.ShowDialog();
            }
        }
    }
}
