using SuperHeroBase;
using SuperHeroAppRepo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using SuperHeroAppRepo.Repositories;

namespace WindowsFormsApp1
{
    public partial class AssemblyLoader : Form
    {
        public AssemblyLoader()
        {
            InitializeComponent();
        }

        private List<Type> _compatibleClasses;
        private string _assemblyName;
        private Assembly _assembly;


        private void OnLoad(object sender, EventArgs e)
        {
            btnDone.Enabled = false;
            comboBox1.Enabled = false;
            cbResources.Enabled = false;
            openFileDialog1.Filter = "(*.dll)|*.dll";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    _assembly = Assembly.LoadFrom(file);
                    _assemblyName = _assembly.FullName;
                    lblAssemblyFilePath.Text = file;
                    _compatibleClasses = (from type in _assembly.GetTypes()
                                            where typeof(ISuperHero).IsAssignableFrom(type)
                                            select type).ToList();

                    if(_compatibleClasses.Count > 0)
                    {
                        comboBox1.Enabled = true;
                        comboBox1.DataSource = _compatibleClasses;
                        comboBox1.DisplayMember = "FullName";
                        comboBox1.ValueMember = "FullName";
                        cbResources.Enabled = true;
                        BindingSource bs = new BindingSource();
                        bs.DataSource = GetImageList();
                        cbResources.DataSource = bs;
                    }
                    else
                    {
                        MessageBox.Show("No classes that derive from ISuperHero interface were found on the selected DLL.");
                    }
                }
                catch (IOException)
                {
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {
            btnDone.Enabled = (comboBox1.SelectedIndex > -1 && this.textBox1.Text != "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            SuperHero currentHero;
            using (var repo = new SuperHeroRepository())
            {
                currentHero = repo.GetByAssemblyName(_assemblyName);
                bool alreadyExists = currentHero != null;
                if (alreadyExists)
                {
                    DialogResult rs = MessageBox.Show("The selected assembly already exists on the record. Do you want to overwrite it?", "Superhero already exists", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (rs == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    currentHero = new SuperHero();
                }
                if (alreadyExists) repo.ResetPowers(currentHero);
                var selectedType = _compatibleClasses.FirstOrDefault(x => x.FullName == comboBox1.SelectedValue.ToString());
                var hero = (ISuperHero)Activator.CreateInstance(selectedType);
                currentHero.AssemblyName = _assemblyName;
                currentHero.DateOfBirth = hero.DateOfBirth;
                currentHero.Name = hero.Name;
                currentHero.StringPowers = hero.Powers;
                currentHero.SuperHeroName = this.textBox1.Text;
                currentHero.Base64Img = GetSelectedImageBase64();
                currentHero.Powers = new List<SuperHeroPower>();
                foreach (var str in hero.Powers)
                {
                    currentHero.Powers.Add(new SuperHeroPower()
                    {
                        PowerName = str,
                        SuperHero = currentHero
                    });
                }

                if (alreadyExists)
                    repo.Update(currentHero);
                else
                    repo.Insert(currentHero);

                repo.Save();

            }
            Close();
        }

        public List<string> GetImageList()
        {
            var resourceFiles = _assembly.GetManifestResourceNames().ToList();
            var resources = new List<string>();
            foreach (var s in resourceFiles)
            {
                var rm = new ResourceManager(s, _assembly);

                var rst = s.Substring(0, s.IndexOf(".resource"));
                var type = _assembly.GetType(rst, false);

                if (type != null)
                {
                    var rs = type.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                    foreach (var res in rs)
                    {
                        if(res.PropertyType == typeof(Bitmap))
                            resources.Add(res.Name);
                    }
                }

            }

            return resources;
        }

        private string GetSelectedImageBase64()
        {
            var selectedImgStr = cbResources.SelectedValue;
            var resourceFiles = _assembly.GetManifestResourceNames().ToList();
            foreach (var s in resourceFiles)
            {
                var rm = new ResourceManager(s, _assembly);

                var rst = s.Substring(0, s.IndexOf(".resource"));
                var type = _assembly.GetType(rst, false);

                if (type != null)
                {
                    var rs = type.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                    foreach (var res in rs)
                    {
                        if (res.Name == selectedImgStr.ToString())
                        {
                            var img = res.GetValue(null, null) as Bitmap;
                            return GetBase64(img);
                        }
                    }
                }

            }

            return "";
        }

        private string GetBase64(Bitmap bp)
        {
            MemoryStream ms = new System.IO.MemoryStream();
            bp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] byteImage = ms.ToArray();
            var SigBase64 = Convert.ToBase64String(byteImage);
            return SigBase64;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
