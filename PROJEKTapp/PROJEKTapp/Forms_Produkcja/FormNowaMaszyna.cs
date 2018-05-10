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
    public partial class FormNowaMaszyna : Form
    {
        KWZP_PROJEKTEntities db;
        public FormNowaMaszyna(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void DodajMaszyne_Click(object sender, EventArgs e)
        {
            MODELE_MASZYN noweModele_Maszyn = new MODELE_MASZYN();
            noweModele_Maszyn.MODEL = this.textBoxModel.Text;
            noweModele_Maszyn.MARKA = this.textBoxMarka.Text;
            noweModele_Maszyn.TYP_MASZYNY = this.textBoxTypMaszyny.Text;
            noweModele_Maszyn.PRĘDKOŚĆ = int.Parse(this.textBoxPredkosc.Text);
            noweModele_Maszyn.POSUW = int.Parse(this.textBoxPosuw.Text);
            noweModele_Maszyn.KOSZT_ZA_H = decimal.Parse(this.textBoxCenazaH.Text);

            db.MODELE_MASZYN.Add(noweModele_Maszyn);
            db.SaveChanges();
        }

        private void WyczyscDane_Click(object sender, EventArgs e)
        {
            textBoxModel.Clear();
            textBoxMarka.Clear();
            textBoxPredkosc.Clear();
            textBoxCenazaH.Clear();
            textBoxTypMaszyny.Clear();
            textBoxPosuw.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPredkosc.Text))
            {
                int parsedVal;
                if (!int.TryParse(textBoxPredkosc.Text, out parsedVal))
                {
                    MessageBox.Show("To pole może zawierać tylko liczbę. ");
                    textBoxPredkosc.Clear();
                    return;
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPosuw.Text))
            {
                int parsedVal;
                if (!int.TryParse(textBoxPosuw.Text, out parsedVal))
                {
                    MessageBox.Show("To pole może zawierać tylko liczbę. ");
                    textBoxPosuw.Clear();
                    return;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCenazaH.Text))
            {
                int parsedVal;
                if (!int.TryParse(textBoxCenazaH.Text, out parsedVal))
                {
                    MessageBox.Show("To pole może zawierać tylko liczbę. ");
                    textBoxCenazaH.Clear();
                    return;
                }
            }
        }

    }
}
