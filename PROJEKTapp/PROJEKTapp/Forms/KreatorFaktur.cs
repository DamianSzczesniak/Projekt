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
        public KreatorFaktur(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            Combo_wyb_zlec.DataSource = db.FAKTURY.ToList();
            Combo_wyb_zlec.ValueMember = "ID_ZLECENIA";

           

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
                                where z.ID_ZLECENIA ==1
                                select new { fa.ID_FAKTURY, f.NAZWA_FIRMY, f.ADRES_EMAIL, f.NR_TELEFONU, f.NIP, fa.ID_ZLECENIA, fa.DATA_WYSTAWIENIA, fa.DATA_PLATNOSCI, fa.KWOTA, fa.WALUTA, p.IMIE, p.NAZWISKO };
                this.dataGridView_faktura.DataSource = idfaktura.ToList();

                KREATOR_FAKTUR kreator_faktur = new KREATOR_FAKTUR();
                //int Id_zlecenia = (dataGridView_faktura.CurrentRow.Cells[0].Value);
                //kreator_faktur = (from fa in db.FAKTURY
                // where fa.ID_ZLECENIA == Id_zlecenia
                // select fa).First();

                

                //txtbox_nr_faktury.Text = "ID_FAKTURY" ;
                //txtbox_nr_zlec.Text = "ID_ZLECENIA";
                //listBox_dane_firmy.DataSource = db.FIRMY.ToList();
                //listBox_dane_firmy.ValueMember = ("SELECT NAZWA_FIRMY, ADRES_EMAIL, NR_TELEFORNU, NIP FROM FIRMY");
                //txtbox_pracownik.Text = "SELECT NAZWISKO, IMIE FROM PRACOWNICY";
                //txtbox_data_wyst.Text = "DATA_WYSTAWIENIA";
                //txtbox_data_plat.Text = "DATA_PLATNOSCI";
                //txtbox_kwota.Text = "KWOTA";
                //txtbox_wal_zl.Text = "ZL";

                

            }
        }

        private void dataGridView_faktura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void Combo_wyb_zlec_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

    internal class KREATOR_FAKTUR
    {
       
    }
}
