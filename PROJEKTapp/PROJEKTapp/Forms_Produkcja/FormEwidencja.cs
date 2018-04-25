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
    public partial class FormEwidencja : Form
    {
        KWZP_PROJEKTEntities db;
        NARZEDZIA narzedzia;
        MODELE_MASZYN maszyny;

        public FormEwidencja(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            this.Zapisz.Text = "Zapisz";
            this.Aktualizuj.Text = "Edytuj";
            this.WyczyscDane.Text = "Wyczyść dane";

            this.ZapiszM.Text = "Zapisz";


            narzedzia = db.NARZEDZIA.First();

            this.textBox1.Text = narzedzia.NAZWA;
            this.textBox2.Text = narzedzia.MODEL;
            this.textBox3.Text = narzedzia.NR_EWIDENCYJNY;
            this.textBox4.Text = narzedzia.KOSZT_ZA_H.ToString();
            narzedzia.KOSZT_ZA_H = decimal.Parse(this.textBox4.Text);

            maszyny = db.MODELE_MASZYN.First();

            this.textBox5.Text = maszyny.MODEL;
            this.textBox6.Text = maszyny.MARKA;
            this.textBox7.Text = maszyny.TYP_MASZYNY;
            this.textBox8.Text = maszyny.PRĘDKOŚĆ.ToString();
            maszyny.PRĘDKOŚĆ = int.Parse(this.textBox8.Text);
            this.textBox9.Text = maszyny.POSUW.ToString();
            maszyny.POSUW = int.Parse(this.textBox9.Text);
            this.textBox10.Text = maszyny.KOSZT_ZA_H.ToString();
            maszyny.KOSZT_ZA_H = decimal.Parse(this.textBox4.Text);

        }

        private void btnExitEwidencja_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void WyczyscDane_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Aktualizuj_Click(object sender, EventArgs e)
        {
            //edycja
        }

        private void ZapiszM_Click(object sender, EventArgs e)
        {
            //dodawanie

        }

        private void WyczyscDaneM_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }
    }
}
