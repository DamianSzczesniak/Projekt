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
    public partial class FormNoweNarzedzie : Form
    {
        KWZP_PROJEKTEntities db;
        public FormNoweNarzedzie(KWZP_PROJEKTEntities db)
           
        {
                this.db = db;
                InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NARZEDZIA noweNarzedzie = new NARZEDZIA();
            noweNarzedzie.NAZWA = this.textBoxNazwa.Text;
            noweNarzedzie.MODEL = this.textBoxModel.Text;
            noweNarzedzie.NR_EWIDENCYJNY = this.textBoxNrEwidencyjny.Text;
            noweNarzedzie.KOSZT_ZA_H = decimal.Parse(this.textBoxCenaZaH.Text);


            db.NARZEDZIA.Add(noweNarzedzie);
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxNazwa.Clear();
            textBoxModel.Clear();
            textBoxNrEwidencyjny.Clear();
            textBoxCenaZaH.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNrEwidencyjny.Text))
            {
                int parsedVal;
                if (!int.TryParse(textBoxNrEwidencyjny.Text, out parsedVal))
                {
                    MessageBox.Show("To pole może zawierać tylko liczbę. ");
                    textBoxNrEwidencyjny.Clear();
                    return;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCenaZaH.Text))
            {
                int parsedVal;
                if (!int.TryParse(textBoxCenaZaH.Text, out parsedVal))
                {
                    MessageBox.Show("To pole może zawierać tylko liczbę. ");
                    textBoxCenaZaH.Clear();
                    return;
                }
            }
        }
    }
}

