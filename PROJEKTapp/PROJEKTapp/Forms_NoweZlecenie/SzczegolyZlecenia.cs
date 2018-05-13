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
        int id ;
        KWZP_PROJEKTEntities db;
        int maxDlugosc = 0;
        
        public SzczegolyZlecenia(int id, KWZP_PROJEKTEntities db)
        {
            this.db = db;
            this.id = id; ;
            InitializeComponent();
        }

        private void SzczegolyZlecenia_Load(object sender, EventArgs e)
        {
            

            ZLECENIA zlecenia = db.ZLECENIA.Where(a => a.ID_ZLECENIA == id).First();
            AKTUALNY_STATUS_ZLECEN azlecenie = db.AKTUALNY_STATUS_ZLECEN.Where(a => a.ID_ZLECENIA == id).First();
            if (azlecenie.Status != 1)
            {
                btnZam.Hide();
            }
            FIRMY firma = db.FIRMY.Where(a => a.ID_FIRMY == zlecenia.ID_FIRMY).First();
            txtFirma.Text = firma.NAZWA_FIRMY;
            txtBox_Data_Realizacji.Text = ((DateTime)zlecenia.DATA_REALIZACJI).ToShortDateString();
            txtBox_Data_Zlecenia.Text = ((DateTime)zlecenia.DATA_ZLECENIA).ToShortDateString();
            OFERTA oferta = db.OFERTA.Where(a => a.ID_ZLECENIA == zlecenia.ID_ZLECENIA).First();
            decimal dcena = decimal.Parse(oferta.KOSZT_CALKOWITY_PRODUKCJI.ToString());
            int cena = Decimal.ToInt32(dcena);
            txtBoxCena.Text  = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", cena);
            dataGridViewOferta.DataSource = db.ZLECENIA_PRODUKTY_NAZWY.Where(a => a.ID_ZLECENIA == id).ToList();

            List<CZAS_PRACY_MASZYN> czasyPracy = this.db.CZAS_PRACY_MASZYN.Where(x => x.ID_ZLECENIA == id).ToList();
            List<CZAS_PRACY_NARZEDZI> czasyPracyNarzedzi = this.db.CZAS_PRACY_NARZEDZI.Where(x => x.ID_ZLECENIA ==id).ToList();
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
            }
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
        }

        private void btnZam_Click(object sender, EventArgs e)
        {
            ZamowienieMaterialu zamowienieMaterialu = new ZamowienieMaterialu(db, id);
            zamowienieMaterialu.Show();
        }
    }
}
