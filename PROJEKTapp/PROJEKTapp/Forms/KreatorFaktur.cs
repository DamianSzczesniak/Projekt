using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Forms
{
    public partial class KreatorFaktur : Form
    {
        KWZP_PROJEKTEntities db;
        FIRMY firma;
        FAKTURY faktury;
        
        
                public KreatorFaktur(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            Combo_wyb_zlec.DataSource = db.FAKTURY.ToList();
            Combo_wyb_zlec.ValueMember = "ID_ZLECENIA";
            Combo_wyb_zlec.Items.Add(listBox_dane_firmy.Text);

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            {
               var idfaktura = from fa in db.FAKTURY
                                join z in db.ZLECENIA on fa.ID_ZLECENIA equals z.ID_ZLECENIA
                                join f in db.FIRMY on z.ID_FIRMY equals f.ID_FIRMY
                                join p in db.PRACOWNICY on fa.ID_PRACOWNIKA equals p.ID_PRACOWNIK
                                where z.ID_ZLECENIA ==(int)Combo_wyb_zlec.SelectedValue
                                select new { fa.ID_FAKTURY, f.NAZWA_FIRMY, f.ADRES_EMAIL, f.NR_TELEFONU, f.NIP, fa.ID_ZLECENIA, fa.DATA_WYSTAWIENIA, fa.DATA_PLATNOSCI, fa.KWOTA, fa.WALUTA, p.IMIE, p.NAZWISKO };

                this.dataGridView_faktura.DataSource = idfaktura.ToList();

                // listBox_dane_firmy.DataSource = db.FIRMY.ToArray();

                FAKTURY faktury = db.FAKTURY.Where(f => f.ID_ZLECENIA == (int)Combo_wyb_zlec.SelectedValue).First();
                // faktury.ID_FAKTURY = txtbox_nr_faktury.Text;
                // faktury.DATA_WYSTAWIENIA = txtbox_data_wyst.Text;

                PRACOWNICY pracownicy = new PRACOWNICY();
                           pracownicy.IMIE = this.txtbox_pracownik.Text;
                //pracownicy.NAZWISKO = this.txtbox_pracownik.Text;

                ZLECENIA zlecenia = db.ZLECENIA.Where(z => z.ID_ZLECENIA == (int)Combo_wyb_zlec.SelectedValue).First();
                //zlecenia.ID_ZLECENIA = txtbox_nr_zlec.Text;




                
            }
        }

        private void listBox_dane_firmy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox_dane_firmy.DataSource = db.FIRMY.ToArray();
        }

       
    }

}
