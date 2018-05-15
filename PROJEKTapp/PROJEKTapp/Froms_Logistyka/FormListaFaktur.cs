using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Forms.Forms_Logistyka
{

    public partial class FormListaFaktur : Form
    {
        KWZP_PROJEKTEntities db;
        ZLECENIA wybraneZlecenie;
        FAKTURY nowaFaktura;

        public FormListaFaktur(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            var idfaktura = from fa in db.FAKTURY
                            join z in db.ZLECENIA on fa.ID_ZLECENIA equals z.ID_ZLECENIA
                            join f in db.FIRMY on z.ID_FIRMY equals f.ID_FIRMY
                            join p in db.PRACOWNICY on fa.ID_PRACOWNIKA equals p.ID_PRACOWNIK
                            select new { fa.ID_FAKTURY, f.NAZWA_FIRMY, f.ADRES_EMAIL, f.NR_TELEFONU, f.NIP, fa.ID_ZLECENIA, fa.DATA_WYSTAWIENIA, fa.DATA_PLATNOSCI, fa.KWOTA, fa.ID_WALUTA, p.IMIE, p.NAZWISKO };
            this.dataGridView_lista_faktur.DataSource = idfaktura.ToList();
            
            
        }

        private void ButtonNowaFaktura_Click(object sender, EventArgs e)
        {
          
            //if ((ZLECENIA)Combo_wyb_zlecenia.SelectedValue == wybraneZlecenie )
            //{
            //    KreatorFaktur KreatorFaktur = new KreatorFaktur(db, wybraneZlecenie);
            //    KreatorFaktur.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Podano nieprawidłowy numer zlecenia");
            //}
        }
            

        

        private void Btn_Back_5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckcBZaplacono_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcBZaplacono.Checked)
            {

                var idfaktura = from fa in db.FAKTURY.Where(a => a.CZY_OPLACONA == false)
                                join z in db.ZLECENIA on fa.ID_ZLECENIA equals z.ID_ZLECENIA
                                join f in db.FIRMY on z.ID_FIRMY equals f.ID_FIRMY
                                join p in db.PRACOWNICY on fa.ID_PRACOWNIKA equals p.ID_PRACOWNIK
                                select new { fa.ID_FAKTURY, f.NAZWA_FIRMY, f.ADRES_EMAIL, f.NR_TELEFONU, f.NIP, fa.ID_ZLECENIA, fa.DATA_WYSTAWIENIA, fa.DATA_PLATNOSCI, fa.KWOTA, fa.ID_WALUTA, p.IMIE, p.NAZWISKO };
                this.dataGridView_lista_faktur.DataSource = idfaktura.ToList();
            }
            else
            {
                var idfaktura = from fa in db.FAKTURY
                                join z in db.ZLECENIA on fa.ID_ZLECENIA equals z.ID_ZLECENIA
                                join f in db.FIRMY on z.ID_FIRMY equals f.ID_FIRMY
                                join p in db.PRACOWNICY on fa.ID_PRACOWNIKA equals p.ID_PRACOWNIK
                                select new { fa.ID_FAKTURY, f.NAZWA_FIRMY, f.ADRES_EMAIL, f.NR_TELEFONU, f.NIP, fa.ID_ZLECENIA, fa.DATA_WYSTAWIENIA, fa.DATA_PLATNOSCI, fa.KWOTA, fa.ID_WALUTA, p.IMIE, p.NAZWISKO };
                this.dataGridView_lista_faktur.DataSource = idfaktura.ToList();
            }
        }
    }
}
