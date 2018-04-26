using PROJEKTapp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp
{
    public partial class Form1 : Form
    {
        KWZP_PROJEKTEntities db;

        public Form1()
        {
            InitializeComponent();
            db = new KWZP_PROJEKTEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //wylaczenie aplikacji
            Application.Exit();
        }

        private void btnLogistyka_Click(object sender, EventArgs e)
        {
            FormLogistyka Logistyka = new FormLogistyka();
            Logistyka.Show();
        }

        private void btnKadry_Click(object sender, EventArgs e)
        {
            bool ladowanieformularzazokienkami = false;
            FormKadry Kadry = new FormKadry(db, ladowanieformularzazokienkami);
            Kadry.Show();
        }

        private void btnProdukcja_Click(object sender, EventArgs e)
        {
            Produkcja_glowny Produkcja_glowny = new Produkcja_glowny();
            Produkcja_glowny.Show();
        }

        private void buttonNoweZlecenie_Click(object sender, EventArgs e)
        {
            FormNoweZlecenie NoweZlecenie = new FormNoweZlecenie();
            NoweZlecenie.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(db);
            form2.Show();
        }
    }
}
