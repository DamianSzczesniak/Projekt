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
        int cena;

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
            FAKTURY fAKTURY = new FAKTURY();
            fAKTURY.ID_PRACOWNIKA = int.Parse(comboBoxPracownik.SelectedValue.ToString());
            fAKTURY.ID_ZLECENIA = id;
            fAKTURY.KWOTA = cena;
            fAKTURY.DATA_WYSTAWIENIA = DateTime.Today;
            fAKTURY.DATA_PLATNOSCI = DateTime.Parse(txtbox_data_plat.Text);
            fAKTURY.ID_WALUTA = int.Parse(comboBox_kwotaWal.SelectedIndex.ToString())+1;
            db.FAKTURY.Add(fAKTURY);
            db.SaveChanges();

            DATA_STATUSU_ZLECENIA dATA_STATUSU_3 = new DATA_STATUSU_ZLECENIA();
            dATA_STATUSU_3.DATA_ZMIANY = DateTime.Today;
            dATA_STATUSU_3.ID_ZLECENIA = id;
            dATA_STATUSU_3.ID_STATUSU_ZLECENIA = 11;
            db.DATA_STATUSU_ZLECENIA.Add(dATA_STATUSU_3);
            db.SaveChanges();

            MessageBox.Show("Faktura została wystawiona .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void KreatorFaktur_Load(object sender, EventArgs e)
        {
            if (!kopia)
            {

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

                txtbox_kwota.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", cena);

                comboBox_kwotaWal.DataSource = db.AKTUALNY_KURS.ToList();
                comboBox_kwotaWal.DisplayMember = "NAZWA";
                comboBox_kwotaWal.ValueMember = "KURS_DO_PLN";
            }
            else
            {
                btnSave.Hide();

                FAKTURY fAKTURY = db.FAKTURY.Where(a => a.ID_ZLECENIA == id).First();
                txtbox_nr_faktury.Text = fAKTURY.ID_FAKTURY.ToString();
                txtbox_data_wyst.Text = DateTime.Parse(fAKTURY.DATA_WYSTAWIENIA.ToString()).ToShortDateString();
                txtbox_data_plat.Text = DateTime.Parse(fAKTURY.DATA_PLATNOSCI.ToString()).ToShortDateString();

                txtbox_data_plat.ReadOnly = true;
                textBoxMW.ReadOnly = true;


                txtbox_nr_zlec.Text = fAKTURY.ID_ZLECENIA.ToString();

                ZLECENIA zlecenie = db.ZLECENIA.Where(a => a.ID_ZLECENIA == id).First();
                textBox_nazwa_firmy.Text = zlecenie.FIRMY.NAZWA_FIRMY.ToString();
                textBox_adres_email.Text = zlecenie.FIRMY.ADRES_EMAIL.ToString();
                textBox_nip.Text = zlecenie.FIRMY.NIP.ToString();
                textBox_nr_telefonu.Text = zlecenie.FIRMY.NR_TELEFONU.ToString();

                var dict = new Dictionary<int, string>();
                foreach (PRACOWNICY row in db.PRACOWNICY.Where(a => a.ID_PRACOWNIK == fAKTURY.ID_PRACOWNIKA).ToList())
                {
                    dict.Add(row.ID_PRACOWNIK, row.IMIE + " " + row.NAZWISKO + "  PESEL : " + row.PESEL);
                }
                comboBoxPracownik.DataSource = dict.ToList();
                comboBoxPracownik.ValueMember = "Key";
                comboBoxPracownik.DisplayMember = "Value";

                comboBox_kwotaWal.DataSource = db.AKTUALNY_KURS.Where(a => a.ID_WALUTY == fAKTURY.ID_WALUTA).ToList();
                comboBox_kwotaWal.DisplayMember = "NAZWA";
                comboBox_kwotaWal.ValueMember = "KURS_DO_PLN";
                comboBox_kwotaWal.DropDownStyle = ComboBoxStyle.Simple;


                switch (comboBox_kwotaWal.SelectedIndex)
                {
                    case 0:
                        {
                            decimal cena1 = decimal.Parse(fAKTURY.KWOTA.ToString());
                            int cena = decimal.ToInt32(cena1);
                            txtbox_kwota.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", cena);
                            break;
                        }
                    case 1:
                        {
                            decimal cena1 = decimal.Parse(fAKTURY.KWOTA.ToString());
                            int cena = decimal.ToInt32(cena1);
                            txtbox_kwota.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("fr-FR"), "{0:C}", cena);
                            break;
                        }
                    case 2:
                        {
                            decimal cena1 = decimal.Parse(fAKTURY.KWOTA.ToString());
                            int cena = decimal.ToInt32(cena1);
                            txtbox_kwota.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-GB"), "{0:C}", cena);
                            break;
                        }
                    case 3:
                        {
                            decimal cena1 = decimal.Parse(fAKTURY.KWOTA.ToString());
                            int cena = decimal.ToInt32(cena1);
                            txtbox_kwota.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:C}", cena);
                            break;
                        }
                    case 4:
                        {
                            decimal cena1 = decimal.Parse(fAKTURY.KWOTA.ToString());
                            int cena = decimal.ToInt32(cena1);
                            txtbox_kwota.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("it-CH"), "{0:C}", cena);
                            break;
                        }

                }

            }
        }

        private void comboBox_kwotaWal_DropDownClosed(object sender, EventArgs e)
        {
            switch (comboBox_kwotaWal.SelectedIndex)
            {
                case 0:
                    {
                        OFERTA oferta = db.OFERTA.Where(a => a.ID_ZLECENIA == id).First();
                        decimal dcena = decimal.Parse(oferta.KOSZT_CALKOWITY_PRODUKCJI.ToString());
                        
                        Decimal cena1 = Decimal.Parse(comboBox_kwotaWal.SelectedValue.ToString());
                        Decimal cenaS = dcena * cena1;
                         cena = Decimal.ToInt32(cenaS);
                        txtbox_kwota.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", cena);
                        break;
                    }
                case 1:
                    {
                        OFERTA oferta = db.OFERTA.Where(a => a.ID_ZLECENIA == id).First();
                        decimal dcena = decimal.Parse(oferta.KOSZT_CALKOWITY_PRODUKCJI.ToString());
                       
                        Decimal cena1 =  Decimal.Parse(comboBox_kwotaWal.SelectedValue.ToString());
                        Decimal cenaS = dcena * cena1;
                        cena = Decimal.ToInt32(cenaS);
                        txtbox_kwota.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("fr-FR"), "{0:C}", cena);
                        break;
                    }
                case 2:
                    {
                        OFERTA oferta = db.OFERTA.Where(a => a.ID_ZLECENIA == id).First();
                        decimal dcena = decimal.Parse(oferta.KOSZT_CALKOWITY_PRODUKCJI.ToString());
                        
                        Decimal cena1 = Decimal.Parse(comboBox_kwotaWal.SelectedValue.ToString());
                        Decimal cenaS = dcena * cena1;
                         cena = Decimal.ToInt32(cenaS);
                        txtbox_kwota.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-GB"), "{0:C}", cena);
                        break;
                    }
                case 3:
                    {
                        OFERTA oferta = db.OFERTA.Where(a => a.ID_ZLECENIA == id).First();
                        decimal dcena = decimal.Parse(oferta.KOSZT_CALKOWITY_PRODUKCJI.ToString());
                        
                        Decimal cena1 = Decimal.Parse(comboBox_kwotaWal.SelectedValue.ToString());
                        Decimal cenaS = dcena * cena1;
                         cena = Decimal.ToInt32(cenaS);
                        txtbox_kwota.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:C}", cena);
                        break;
                    }
                case 4:
                    {
                        OFERTA oferta = db.OFERTA.Where(a => a.ID_ZLECENIA == id).First();
                        decimal dcena = decimal.Parse(oferta.KOSZT_CALKOWITY_PRODUKCJI.ToString());
                       
                        Decimal cena1 = Decimal.Parse(comboBox_kwotaWal.SelectedValue.ToString());
                        Decimal cenaS = dcena * cena1;
                         cena = Decimal.ToInt32(cenaS);
                        txtbox_kwota.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("it-CH"), "{0:C}", cena);
                        break;
                    }
            }
        }
    } 

}
