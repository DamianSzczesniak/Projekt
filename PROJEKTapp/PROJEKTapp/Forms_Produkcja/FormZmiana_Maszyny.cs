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
            textBox1.Text = maszyny.MODEL;
            textBox2.Text = maszyny.MARKA;
            textBox3.Text = maszyny.PRĘDKOŚĆ.ToString();
            textBox4.Text = maszyny.KOSZT_ZA_H.ToString();
            textBox5.Text = maszyny.TYP_MASZYNY;
            textBox6.Text = maszyny.POSUW.ToString();



        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            MODELE_MASZYN noweModele_Maszyn = new MODELE_MASZYN();
            noweModele_Maszyn.MODEL = this.textBox1.Text;
            noweModele_Maszyn.MARKA = this.textBox2.Text;
            noweModele_Maszyn.TYP_MASZYNY = this.textBox5.Text;
            noweModele_Maszyn.PRĘDKOŚĆ = int.Parse(this.textBox3.Text);
            noweModele_Maszyn.POSUW = int.Parse(this.textBox6.Text);
            noweModele_Maszyn.KOSZT_ZA_H = decimal.Parse(this.textBox4.Text);

            db.MODELE_MASZYN.Add(noweModele_Maszyn);
            db.SaveChanges();
        }

        

        private void Aktualizuj_Click(object sender, EventArgs e)
        {
            {
                //edycja
                maszyny.MODEL = this.textBox1.Text;
                maszyny.MARKA = this.textBox2.Text;
                maszyny.TYP_MASZYNY = this.textBox5.Text;
                maszyny.PRĘDKOŚĆ = int.Parse(this.textBox3.Text);
                maszyny.POSUW = int.Parse(this.textBox6.Text);
                maszyny.KOSZT_ZA_H = decimal.Parse(this.textBox4.Text);

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
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }

    }
}
