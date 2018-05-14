using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PROJEKTapp.Forms;
using PROJEKTapp.Froms_Logistyka;


namespace PROJEKTapp.Forms_NoweZlecenie
{
    public partial class SzczegolyZlecenia : Form
    {
        int id;
        KWZP_PROJEKTEntities db;
        int maxDlugosc = 0;

        public SzczegolyZlecenia(int id, KWZP_PROJEKTEntities db)
        {
            this.db = db;
            this.id = id;
            InitializeComponent();
            
        }

        private void SzczegolyZlecenia_Load(object sender, EventArgs e)
        {

          
            ZLECENIA zlecenia = db.ZLECENIA.Where(a => a.ID_ZLECENIA == id).First();
            statusButtony();

            FIRMY firma = db.FIRMY.Where(a => a.ID_FIRMY == zlecenia.ID_FIRMY).First();
            txtFirma.Text = firma.NAZWA_FIRMY;
            txtBox_Data_Realizacji.Text = ((DateTime)zlecenia.DATA_REALIZACJI).ToShortDateString();
            txtBox_Data_Zlecenia.Text = ((DateTime)zlecenia.DATA_ZLECENIA).ToShortDateString();
            OFERTA oferta = db.OFERTA.Where(a => a.ID_ZLECENIA == zlecenia.ID_ZLECENIA).First();
            decimal dcena = decimal.Parse(oferta.KOSZT_CALKOWITY_PRODUKCJI.ToString());
            int cena = Decimal.ToInt32(dcena);
            txtBoxCena.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", cena);
            dataGridViewOferta.DataSource = db.ZLECENIA_PRODUKTY_NAZWY.Where(a => a.ID_ZLECENIA == id).ToList();

            List<CZAS_PRACY_MASZYN> czasyPracy = this.db.CZAS_PRACY_MASZYN.Where(x => x.ID_ZLECENIA == id).ToList();
            List<CZAS_PRACY_NARZEDZI> czasyPracyNarzedzi = this.db.CZAS_PRACY_NARZEDZI.Where(x => x.ID_ZLECENIA == id).ToList();
            DateTime aktualnaData = DateTime.Now;
            Random random = new Random();
            int doWyprodukowania = 0;
            int srednia;
            chart1.Series.Clear();

            foreach (CZAS_PRACY_MASZYN czasPracy in czasyPracy)
            {
                for (int i = 0; i < czasPracy.ILOSC_DNI_PRACY; i++)
                {
                    if (maxDlugosc < i)
                    {
                        maxDlugosc = i;
                    }
                }
            }

            foreach (ZLECENIE_PRODUKT zlecenieProduktu in zlecenia.ZLECENIE_PRODUKT)
            {
                doWyprodukowania = (int)zlecenieProduktu.ILOSC;
                srednia = 1 + ((int)doWyprodukowania / 10);

                //maxDlugosc);
                Series seria = new Series();
                seria.XValueType = ChartValueType.DateTime;
                for (int i = 0; i < 10; i++)
                //maxDlugosc; i++)
                {
                    int produkcja = random.Next(0, srednia);
                    seria.Points.AddXY(DateTime.Now.AddDays(i), produkcja);
                    doWyprodukowania = doWyprodukowania - produkcja;
                }
                chart1.Series[zlecenieProduktu.PRODUKT.NAZWA_PRODUKTU] = seria;
                seria.LegendText = zlecenieProduktu.PRODUKT.NAZWA_PRODUKTU;
            }
        }

        private void statusButtony()
        {
            
            KWZP_PROJEKTEntities kWZP_ = new KWZP_PROJEKTEntities();
            db = kWZP_;
            db.AKTUALNY_STATUS_ZLECEN = kWZP_.AKTUALNY_STATUS_ZLECEN;
            db.SaveChanges();
            
            AKTUALNY_STATUS_ZLECEN_NAZWY azlecenie = db.AKTUALNY_STATUS_ZLECEN_NAZWY.Where(a => a.ID_ZLECENIA == id).First();

            txtBAktualnyStatus.Text = azlecenie.ETAP;
            btnMagazynuj.Hide();
            btn_Pobierz_Materialy_produkcja.Hide();
            btn_składuj_produkty_w_Magazynie.Hide();
            btnPobierzTransport.Hide();
            btnRobimyTransport.Hide();
            btnKlientOdebral.Hide();
            btnWystawFakture.Hide();
            btnWystawFaktureKopia.Hide();

            switch (azlecenie.Status)
            {
                case 1:
                    btnZam.Show();

                    break;
                case 2:
                    btnDostarczonoMaterialy.Show();
                    break;
                case 3:
                    btnMagazynuj.Show();
                    break;
                case 4:
                    RezerwujMaszyny.Show();
                    break;
                case 5:
                    btn_Pobierz_Materialy_produkcja.Show();
                    btn_składuj_produkty_w_Magazynie.Show();
                    break;
                case 6:
                    btnPobierzTransport.Show();
                    break;
                case 7:
                    btnRobimyTransport.Show();
                    btnKlientOdebral.Show();
                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:
                    btnWystawFakture.Show();
                    break;
                case 11:
                    btnWystawFaktureKopia.Show();
                    
                    break;

            }
            this.Refresh();

        }

    private void RezerwujMaszyny_Click(object sender, EventArgs e)
        {
            ZLECENIA zlecenia = db.ZLECENIA.Where(a => a.ID_ZLECENIA == id).First();
            List<CZAS_PRACY_MASZYN> czasyPracy = this.db.CZAS_PRACY_MASZYN.Where(x => x.ID_ZLECENIA == id).ToList();
            List<CZAS_PRACY_NARZEDZI> czasyPracyNarzedzi = this.db.CZAS_PRACY_NARZEDZI.Where(x => x.ID_ZLECENIA == id).ToList();
            DateTime aktualnaData = DateTime.Now;

            foreach (CZAS_PRACY_MASZYN czasPracy in czasyPracy)
            {
                for (int i = 0; i < czasPracy.ILOSC_DNI_PRACY; i++)
                {
                    REALIZACJA_PRODUKCJA realizacjaProdukcjiM = new REALIZACJA_PRODUKCJA();
                    realizacjaProdukcjiM.ID_ZLECENIA = zlecenia.ID_ZLECENIA;
                    realizacjaProdukcjiM.DATA_DZIEN = aktualnaData.AddDays(i);
                    MASZYNY maszyna = db.MASZYNY.Where(m => m.ID_MASZYNY == czasPracy.ID_MASZYNY).First();
                    ZESPOL_MASZYN zespolMaszyn = new ZESPOL_MASZYN();
                    zespolMaszyn.MASZYNY = maszyna;
                    zespolMaszyn.REALIZACJA_PRODUKCJA = realizacjaProdukcjiM;
                    realizacjaProdukcjiM.ZESPOL_MASZYN.Add(zespolMaszyn);
                    db.REALIZACJA_PRODUKCJA.Add(realizacjaProdukcjiM);
                }
            }
            foreach (CZAS_PRACY_NARZEDZI czasPracy in czasyPracyNarzedzi)
            {
                for (int i = 0; i < czasPracy.ILOSC_DNI_PRACY; i++)
                {

                    REALIZACJA_PRODUKCJA realizacjaProdukcjiN = new REALIZACJA_PRODUKCJA();
                    realizacjaProdukcjiN.ID_ZLECENIA = id;
                    realizacjaProdukcjiN.DATA_DZIEN = aktualnaData.AddDays(i);
                    NARZEDZIA narzedzie = db.NARZEDZIA.Where(m => m.ID_NARZEDZIA == czasPracy.ID_NARZEDZIA).First();
                    ZESPOL_NARZEDZI zespolNarzedzi = new ZESPOL_NARZEDZI();
                    zespolNarzedzi.NARZEDZIA = narzedzie;
                    zespolNarzedzi.REALIZACJA_PRODUKCJA = realizacjaProdukcjiN;
                    realizacjaProdukcjiN.ZESPOL_NARZEDZI.Add(zespolNarzedzi);
                    db.REALIZACJA_PRODUKCJA.Add(realizacjaProdukcjiN);
                }
            }
            DateTime data = DateTime.Now;
            DATA_STATUSU_ZLECENIA dATA_STATUSU_ = new DATA_STATUSU_ZLECENIA();
            dATA_STATUSU_.DATA_ZMIANY = data;
            dATA_STATUSU_.ID_ZLECENIA = id;
            dATA_STATUSU_.ID_STATUSU_ZLECENIA = 5;
            db.DATA_STATUSU_ZLECENIA.Add(dATA_STATUSU_);
            db.SaveChanges();
            MessageBox.Show("Informacje zapisano pomyślne .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDostarczonoMaterialy.Hide();
            statusButtony();
            RezerwujMaszyny.Hide();
            statusButtony();
        }

        private void btnZam_Click(object sender, EventArgs e)
        {
            using (ZamowienieMaterialu zamowienieMaterialu = new ZamowienieMaterialu(db, id))
            {
                if (zamowienieMaterialu.ShowDialog() == DialogResult.OK)
                {
                    statusButtony();
                    btnZam.Hide();
                }
            }
         
           
           
        }

        private void SzczegolyZlecenia_Enter(object sender, EventArgs e)
        {
           
            statusButtony();
        }

        private void btnDostarczonoMaterialy_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            DATA_STATUSU_ZLECENIA dATA_STATUSU_ = new DATA_STATUSU_ZLECENIA();
            dATA_STATUSU_.DATA_ZMIANY = data;
            dATA_STATUSU_.ID_ZLECENIA = id;
            dATA_STATUSU_.ID_STATUSU_ZLECENIA = 3;
            db.DATA_STATUSU_ZLECENIA.Add(dATA_STATUSU_);
            db.SaveChanges();
            MessageBox.Show("Informacje zapisano pomyślne .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDostarczonoMaterialy.Hide();
            statusButtony();
        }

        private void btnMagazynuj_Click(object sender, EventArgs e)
        {
            int akcja = 1;
            using (FormZmianaStanuMagazynu ZmianaStanuMagazynu = new FormZmianaStanuMagazynu(db, id, akcja))
            {
                if (ZmianaStanuMagazynu.ShowDialog() == DialogResult.OK)
                {
                    statusButtony();
                    
                }
            }

            
            

        }

        private void btn_Pobierz_Materialy_produkcja_Click(object sender, EventArgs e)
        {
            int akcja = 2;
            using (FormZmianaStanuMagazynu ZmianaStanuMagazynu = new FormZmianaStanuMagazynu(db, id, akcja))
            {
                if (ZmianaStanuMagazynu.ShowDialog() == DialogResult.OK)
                {
                    statusButtony();

                }
            }
        }

        private void btn_składuj_produkty_w_Magazynie_Click(object sender, EventArgs e)
        {
            int akcja = 3;
            using (FormZmianaStanuMagazynu ZmianaStanuMagazynu = new FormZmianaStanuMagazynu(db, id, akcja))
            {
                if (ZmianaStanuMagazynu.ShowDialog() == DialogResult.OK)
                {
                    statusButtony();

                }
            }
        }

        private void btnPobierzTransport_Click(object sender, EventArgs e)
        {
            int akcja = 4;
            using (FormZmianaStanuMagazynu ZmianaStanuMagazynu = new FormZmianaStanuMagazynu(db, id, akcja))
            {
                if (ZmianaStanuMagazynu.ShowDialog() == DialogResult.OK)
                {
                    statusButtony();

                }
            }
        }

        private void btnKlientOdebral_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            DATA_STATUSU_ZLECENIA dATA_STATUSU_ = new DATA_STATUSU_ZLECENIA();
            dATA_STATUSU_.DATA_ZMIANY = data;
            dATA_STATUSU_.ID_ZLECENIA = id;
            dATA_STATUSU_.ID_STATUSU_ZLECENIA = 8;
            db.DATA_STATUSU_ZLECENIA.Add(dATA_STATUSU_);
            db.SaveChanges();
         

            DATA_STATUSU_ZLECENIA dATA_STATUSU_2 = new DATA_STATUSU_ZLECENIA();
            dATA_STATUSU_2.DATA_ZMIANY = data;
            dATA_STATUSU_2.ID_ZLECENIA = id;
            dATA_STATUSU_2.ID_STATUSU_ZLECENIA = 9;
            db.DATA_STATUSU_ZLECENIA.Add(dATA_STATUSU_2);
            db.SaveChanges();

            DATA_STATUSU_ZLECENIA dATA_STATUSU_3 = new DATA_STATUSU_ZLECENIA();
            dATA_STATUSU_3.DATA_ZMIANY = data;
            dATA_STATUSU_3.ID_ZLECENIA = id;
            dATA_STATUSU_3.ID_STATUSU_ZLECENIA = 10;
            db.DATA_STATUSU_ZLECENIA.Add(dATA_STATUSU_3);
            db.SaveChanges();

            MessageBox.Show("Informacje zapisano pomyślne .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDostarczonoMaterialy.Hide();
            statusButtony();
        }

        private void btnRobimyTransport_Click(object sender, EventArgs e)
        {

        }

        private void btnWystawFakture_Click(object sender, EventArgs e)
        {
            
            using (KreatorFaktur kReator = new KreatorFaktur(db, id, false))
            {
                if (kReator.ShowDialog() == DialogResult.OK)
                {
                    statusButtony();

                }
            }
        }

        private void btnWystawFaktureKopia_Click(object sender, EventArgs e)
        {
            using (KreatorFaktur kReator = new KreatorFaktur(db, id, true))
            {
                if (kReator.ShowDialog() == DialogResult.OK)
                {
                    statusButtony();

                }
            }
        }
    }
}
