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
            NARZEDZIA nowenarzedzia= new NARZEDZIA();
            //doedycji ponizej
           // nowaFirma.NAZWA_FIRMY = this.textBox4.Text;
            //nowaFirma.NIP = this.textBox3.Text;
            //nowaFirma.POJAZDY.Add(db.POJAZDY.First());
            //db.FIRMY.Add(nowaFirma);
            //db.SaveChanges();
        }
    }
}
