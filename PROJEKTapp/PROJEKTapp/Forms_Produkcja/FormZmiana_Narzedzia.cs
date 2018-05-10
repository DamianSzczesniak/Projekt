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
        object send;
        string tryb;
        public FormZmiana_Narzedzia(KWZP_PROJEKTEntities db, object send, string tryb)
        {
            this.db = db;
            this.send = send;
            this.tryb = tryb;
            InitializeComponent();

            NARZEDZIA narzedzia = new NARZEDZIA();
            narzedzia = (NARZEDZIA)send;
            textBoxNazwa.Text = narzedzia.NAZWA;
            textBoxModel.Text = narzedzia.MODEL;
            textBoxNrEwidencyjny.Text = narzedzia.NR_EWIDENCYJNY.ToString();
            textBoxKosztZaH.Text = narzedzia.KOSZT_ZA_H.ToString();

        }


        private void ZapiszM_Click(object sender, EventArgs e)
        {
            NARZEDZIA noweNarzedzie = new NARZEDZIA();
            noweNarzedzie.NAZWA = this.textBoxNazwa.Text;
            noweNarzedzie.MODEL = this.textBoxModel.Text;
            noweNarzedzie.NR_EWIDENCYJNY = this.textBoxNrEwidencyjny.Text;
            noweNarzedzie.KOSZT_ZA_H = decimal.Parse(this.textBoxKosztZaH.Text);
         

            db.NARZEDZIA.Add(noweNarzedzie);
            db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //edycja
         
            narzedzie.NAZWA = this.textBoxNazwa.Text;
            narzedzie.MODEL = this.textBoxModel.Text;
            narzedzie.NR_EWIDENCYJNY = this.textBoxNrEwidencyjny.Text;
            narzedzie.KOSZT_ZA_H = decimal.Parse(this.textBoxKosztZaH.Text);

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
            textBoxNazwa.Clear();
            textBoxModel.Clear();
            textBoxNrEwidencyjny.Clear();
            textBoxKosztZaH.Clear();
        
        }

    
    }
    }

