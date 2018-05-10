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
            noweNarzedzie.NAZWA = this.textBox1.Text;
            noweNarzedzie.MODEL = this.textBox2.Text;
            noweNarzedzie.NR_EWIDENCYJNY = this.textBox3.Text;
            noweNarzedzie.KOSZT_ZA_H = decimal.Parse(this.textBox4.Text);


            db.NARZEDZIA.Add(noweNarzedzie);
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
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

