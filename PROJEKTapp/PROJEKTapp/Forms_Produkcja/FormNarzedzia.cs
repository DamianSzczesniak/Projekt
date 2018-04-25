using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Forms_Produkcja
{
    public partial class FormNarzedzia : Form
    {
        KWZP_PROJEKTEntities db;
        NARZEDZIA narzedzia;

        public FormNarzedzia(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            this.Zapisz.Text = "Zapisz";
            this.Aktualizuj.Text = "Edytuj";
            this.WyczyscDane.Text = "Wyczyść dane";

            narzedzia = db.NARZEDZIA.First();

            this.textBox1.Text = narzedzia.NAZWA;
            this.textBox2.Text = narzedzia.MODEL;
            this.textBox3.Text = narzedzia.NR_EWIDENCYJNY;
            this.textBox4.Text = narzedzia.KOSZT_ZA_H.ToString();
            narzedzia.KOSZT_ZA_H = decimal.Parse(this.textBox4.Text);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            //dodawanie
            NARZEDZIA noweNarzedzia = new NARZEDZIA();
            noweNarzedzia.NAZWA = this.textBox1.Text;
            noweNarzedzia.MODEL = this.textBox2.Text;
            noweNarzedzia.NR_EWIDENCYJNY = this.textBox3.Text;
            noweNarzedzia.KOSZT_ZA_H = decimal.Parse(this.textBox4.Text);
            db.NARZEDZIA.Add(noweNarzedzia);
            db.SaveChanges();
        }

        private void Aktualizuj_Click(object sender, EventArgs e)
        {

        }

        private void WyczyscDane_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
