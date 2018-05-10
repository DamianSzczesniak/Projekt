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
            noweModele_Maszyn.MODEL = this.textBox1.Text;
            noweModele_Maszyn.MARKA = this.textBox2.Text;
            noweModele_Maszyn.TYP_MASZYNY = this.textBox5.Text;
            noweModele_Maszyn.PRĘDKOŚĆ = int.Parse(this.textBox3.Text);
            noweModele_Maszyn.POSUW = int.Parse(this.textBox6.Text);
            noweModele_Maszyn.KOSZT_ZA_H = decimal.Parse(this.textBox4.Text);

            db.MODELE_MASZYN.Add(noweModele_Maszyn);
            db.SaveChanges();
        }

        private void WyczyscDane_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                int parsedVal;
                if (!int.TryParse(textBox3.Text, out parsedVal))
                {
                    MessageBox.Show("To pole może zawierać tylko liczbę. ");
                    textBox3.Clear();
                    return;
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                int parsedVal;
                if (!int.TryParse(textBox6.Text, out parsedVal))
                {
                    MessageBox.Show("To pole może zawierać tylko liczbę. ");
                    textBox6.Clear();
                    return;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                int parsedVal;
                if (!int.TryParse(textBox4.Text, out parsedVal))
                {
                    MessageBox.Show("To pole może zawierać tylko liczbę. ");
                    textBox4.Clear();
                    return;
                }
            }
        }
    }
}
