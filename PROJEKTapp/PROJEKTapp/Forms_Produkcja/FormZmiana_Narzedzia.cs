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
    
    public partial class FormZmiana_Narzedzia : Form
    {
        KWZP_PROJEKTEntities db;
        NARZEDZIA narzedzie;
        public FormZmiana_Narzedzia()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelMaszyny_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ZapiszM_Click(object sender, EventArgs e)
        {
            NARZEDZIA noweNarzedzie = new NARZEDZIA();
            noweNarzedzie.NAZWA = this.textBox5.Text;
            noweNarzedzie.MODEL = this.textBox6.Text;
            noweNarzedzie.NR_EWIDENCYJNY = this.textBox7.Text;
            noweNarzedzie.KOSZT_ZA_H = decimal.Parse(this.textBox8.Text);
         

            db.NARZEDZIA.Add(noweNarzedzie);
            db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //edycja
         
            narzedzie.NAZWA = this.textBox5.Text;
            narzedzie.MODEL = this.textBox6.Text;
            narzedzie.NR_EWIDENCYJNY = this.textBox7.Text;
            narzedzie.KOSZT_ZA_H = decimal.Parse(this.textBox8.Text);

            foreach (Control control in this.panelNarzedzia.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (!textBox.Name.Contains("text")) ;

                }
            }

            db.SaveChanges();
        }

        private void WyczyscDaneM_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        
        }
    }
    }

