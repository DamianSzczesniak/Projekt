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
    public partial class FormZmiana_Maszyny : Form
    {
        KWZP_PROJEKTEntities db;
        MODELE_MASZYN maszyny;
        object send;
        string tryb;
        
        public FormZmiana_Maszyny(KWZP_PROJEKTEntities db, object send, string tryb)
        {
            this.send = send;
            this.db = db;
            this.tryb = tryb;
            InitializeComponent();

            MODELE_MASZYN maszyny = new MODELE_MASZYN();
            maszyny = (MODELE_MASZYN)send;
            textBoxModel.Text = maszyny.MODEL;
            textBoxMarka.Text = maszyny.MARKA;
            textBoxPredkosc.Text = maszyny.PRĘDKOŚĆ.ToString();
            textBoxCenaZaH.Text = maszyny.KOSZT_ZA_H.ToString();
            textBoxTypMaszyny.Text = maszyny.TYP_MASZYNY;
            textBoxPosuw.Text = maszyny.POSUW.ToString();

        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            MODELE_MASZYN noweModele_Maszyn = new MODELE_MASZYN();
            noweModele_Maszyn.MODEL = this.textBoxModel.Text;
            noweModele_Maszyn.MARKA = this.textBoxMarka.Text;
            noweModele_Maszyn.TYP_MASZYNY = this.textBoxTypMaszyny.Text;
            noweModele_Maszyn.PRĘDKOŚĆ = int.Parse(this.textBoxPredkosc.Text);
            noweModele_Maszyn.POSUW = int.Parse(this.textBoxPosuw.Text);
            noweModele_Maszyn.KOSZT_ZA_H = decimal.Parse(this.textBoxCenaZaH.Text);

            db.MODELE_MASZYN.Add(noweModele_Maszyn);
            db.SaveChanges();
        }

        

        private void Aktualizuj_Click(object sender, EventArgs e)
        {
            {
                //edycja
                maszyny.MODEL = this.textBoxModel.Text;
                maszyny.MARKA = this.textBoxMarka.Text;
                maszyny.TYP_MASZYNY = this.textBoxTypMaszyny.Text;
                maszyny.PRĘDKOŚĆ = int.Parse(this.textBoxPredkosc.Text);
                maszyny.POSUW = int.Parse(this.textBoxPosuw.Text);
                maszyny.KOSZT_ZA_H = decimal.Parse(this.textBoxCenaZaH.Text);

                foreach (Control control in this.panelMaszyny.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        if (!textBox.Name.Contains("text"));

                    }
                }

                db.SaveChanges();
            }
        }

        private void WyczyscDane_Click(object sender, EventArgs e)
        {
            {
                textBoxModel.Clear();
                textBoxMarka.Clear();
                textBoxPredkosc.Clear();
                textBoxCenaZaH.Clear();
                textBoxTypMaszyny.Clear();
                textBoxPosuw.Clear();
            }
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

  


    }
}
