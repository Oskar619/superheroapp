using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperHeroAppRepo.Entities;
using SuperHeroAppRepo.Repositories;

namespace WindowsFormsApp1
{
    public partial class PowerPopup : Form
    {
        public int selectedPowerId = 0;
        public SuperHero selectedHero;
        public bool UpdateRequired;
        public PowerPopup()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedHero == null) return;
            SuperHeroPower pw;
            using (var repo = new SuperHeroPowerRepository())
            {
                if (selectedPowerId == 0)
                {
                    pw = new SuperHeroPower();
                    pw.PowerName = textBox1.Text;
                    pw.SuperHeroId = selectedHero.Id;
                    repo.Insert(pw);
                }
                else
                {
                    pw = selectedHero.Powers.FirstOrDefault(x => x.Id == selectedPowerId);
                    if (pw != null) pw.PowerName = textBox1.Text;
                    repo.Update(pw);
                }
                repo.Save();
            }
            UpdateRequired = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PowerPopup_Load(object sender, EventArgs e)
        {
            if (selectedPowerId > 0)
            {
                var power = selectedHero.Powers.FirstOrDefault(x => x.Id == selectedPowerId);
                if (power != null)
                    textBox1.Text = power.PowerName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text != "";
        }
    }
}
