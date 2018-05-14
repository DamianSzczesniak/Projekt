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
        int id;
        bool kopia;

        public KreatorFaktur(KWZP_PROJEKTEntities db, int id, bool kopia)
        {
            this.kopia = kopia;
            this.id = id;
            this.db = db;
            InitializeComponent();

            //comboBoxPracownik.DataSource = db.PRACOWNICY.ToList();
            //comboBoxPracownik.DisplayMember = "Nazwisko";
            //FAKTURY nowaFaktura = new FAKTURY();
            //nowaFaktura.ID_ZLECENIA = zlecenie.ID_ZLECENIA;
            //DateTime dataWystawienia = DateTime.Now;
            //DateTime dataPlatnosci = dataWystawienia.AddDays(30);
            //nowaFaktura.DATA_WYSTAWIENIA = dataWystawienia;
            //nowaFaktura.DATA_PLATNOSCI = dataPlatnosci;
            ////nowaFaktura.KWOTA = KOSZT?

            //txtbox_data_plat.Text = dataPlatnosci.ToShortDateString();
            //txtbox_data_wyst.Text = dataWystawienia.ToShortDateString();
            //int kwota = 50000;
            //txtbox_kwota.Text = kwota.ToString();
            //txtbox_kwota;
            //txtbox_kwota_zl;
            //txtbox_nr_faktury.Text = ;
            // txtbox_nr_zlec;
            //txtbox_wal;
            //comboBox_kwotaWal.DataSource = db.FAKTURY.ToList();

            //comboBox_kwotaWal.DisplayMember = "WALUTA";
            

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void KreatorFaktur_Load(object sender, EventArgs e)
        {
            if (kopia)
            {
                btnSave.Hide();
            }

            txtbox_nr_faktury.Text = db.FAKTURY.Max(a => a.ID_FAKTURY + 1).ToString();
            DateTime data = DateTime.Today;
            txtbox_data_wyst.Text = data.ToShortDateString();
            DateTime data2 = data.AddMonths(1);
            txtbox_data_plat.Text = data2.ToShortDateString();
            txtbox_nr_zlec.Text = id.ToString();
            var dict = new Dictionary<int, string>();
            foreach (PRACOWNICY row in db.PRACOWNICY.ToList())
            {
                dict.Add(row.ID_PRACOWNIK, row.IMIE + " " + row.NAZWISKO + "  PESEL : " + row.PESEL);
            }
            comboBoxPracownik.DataSource = dict.ToList();
            comboBoxPracownik.ValueMember = "Key";
            comboBoxPracownik.DisplayMember = "Value";

            ZLECENIA zlecenie = db.ZLECENIA.Where(a => a.ID_ZLECENIA == id).First();
            textBox_nazwa_firmy.Text = zlecenie.FIRMY.NAZWA_FIRMY.ToString();
            textBox_adres_email.Text = zlecenie.FIRMY.ADRES_EMAIL.ToString();
            textBox_nip.Text = zlecenie.FIRMY.NIP.ToString();
            textBox_nr_telefonu.Text = zlecenie.FIRMY.NR_TELEFONU.ToString();

            OFERTA oferta = db.OFERTA.Where(a => a.ID_ZLECENIA == id).First();
            decimal dcena = decimal.Parse(oferta.KOSZT_CALKOWITY_PRODUKCJI.ToString());
            int cena = Decimal.ToInt32(dcena);
            txtbox_kwota.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}" , cena);

             
        }
    } 

}
