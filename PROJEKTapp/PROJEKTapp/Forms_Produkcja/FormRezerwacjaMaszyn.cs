using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROJEKTapp.Forms_Produkcja
{
    public partial class FormRezerwacjaMaszyn : Form
    {
        KWZP_PROJEKTEntities db;

        public FormRezerwacjaMaszyn(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            this.cboxWybierzZlecenie.DataSource = db.ZLECENIA.ToList();
            this.cboxWybierzZlecenie.DisplayMember = "ID_ZLECENIA";
        }

        private void btnExitRezerwacjaMaszyn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxWybierzZlecenie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RezerwujMaszyny_Click(object sender, EventArgs e)
        {
            List<CZAS_PRACY_MASZYN> czasyPracy = this.db.CZAS_PRACY_MASZYN.Where(x => x.ID_ZLECENIA == ((ZLECENIA)cboxWybierzZlecenie.SelectedValue).ID_ZLECENIA).ToList();
            List<CZAS_PRACY_NARZEDZI> czasyPracyNarzedzi = this.db.CZAS_PRACY_NARZEDZI.Where(x => x.ID_ZLECENIA == ((ZLECENIA)cboxWybierzZlecenie.SelectedValue).ID_ZLECENIA).ToList();
            this.GridSprawdzenie.DataSource = czasyPracy;
            DateTime aktualnaData = DateTime.Now;
            ZLECENIA zlecenie = (ZLECENIA)cboxWybierzZlecenie.SelectedValue;
            int maxDlugosc = 0;
            Random random = new Random();
            int doWyprodukowania = 0;
            int srednia;
            chart1.Series.Clear();

            foreach (CZAS_PRACY_MASZYN czasPracy in czasyPracy)
            {
                for (int i = 0; i < czasPracy.ILOSC_DNI_PRACY; i++)
                {
                    REALIZACJA_PRODUKCJA realizacjaProdukcjiM = new REALIZACJA_PRODUKCJA();
                    realizacjaProdukcjiM.ID_ZLECENIA = zlecenie.ID_ZLECENIA;
                    realizacjaProdukcjiM.DATA_DZIEN = aktualnaData.AddDays(i);
                    MASZYNY maszyna = db.MASZYNY.Where(m => m.ID_MASZYNY == czasPracy.ID_MASZYNY).First();
                    ZESPOL_MASZYN zespolMaszyn = new ZESPOL_MASZYN();
                    zespolMaszyn.MASZYNY = maszyna;
                    zespolMaszyn.REALIZACJA_PRODUKCJA = realizacjaProdukcjiM;
                    realizacjaProdukcjiM.ZESPOL_MASZYN.Add(zespolMaszyn);
                    db.REALIZACJA_PRODUKCJA.Add(realizacjaProdukcjiM);

                    if(maxDlugosc < i)
                    {
                        maxDlugosc = i;
                    }
                }
            }
            foreach (CZAS_PRACY_NARZEDZI czasPracy in czasyPracyNarzedzi)
            {
                for (int i = 0; i < czasPracy.ILOSC_DNI_PRACY; i++)
                {

                    REALIZACJA_PRODUKCJA realizacjaProdukcjiN = new REALIZACJA_PRODUKCJA();
                    realizacjaProdukcjiN.ID_ZLECENIA = ((ZLECENIA)cboxWybierzZlecenie.SelectedValue).ID_ZLECENIA;
                    realizacjaProdukcjiN.DATA_DZIEN = aktualnaData.AddDays(i);
                    NARZEDZIA narzedzie = db.NARZEDZIA.Where(m => m.ID_NARZEDZIA == czasPracy.ID_NARZEDZIA).First();
                    ZESPOL_NARZEDZI zespolNarzedzi = new ZESPOL_NARZEDZI();
                    zespolNarzedzi.NARZEDZIA = narzedzie;
                    zespolNarzedzi.REALIZACJA_PRODUKCJA = realizacjaProdukcjiN;
                    realizacjaProdukcjiN.ZESPOL_NARZEDZI.Add(zespolNarzedzi);
                    db.REALIZACJA_PRODUKCJA.Add(realizacjaProdukcjiN);
                }
            }
            db.SaveChanges();

            foreach (ZLECENIE_PRODUKT zlecenieProduktu in zlecenie.ZLECENIE_PRODUKT)
            {
                doWyprodukowania = (int)zlecenieProduktu.ILOSC;
                srednia = 1+((int)doWyprodukowania / maxDlugosc);
                Series seria = new Series();
                seria.XValueType = ChartValueType.DateTime;
                for (int i = 0; i < maxDlugosc; i++)
                {
                    int produkcja = random.Next(0, srednia);
                    seria.Points.AddXY(DateTime.Now.AddDays(i), produkcja);
                    doWyprodukowania = doWyprodukowania - produkcja;
                }
                chart1.Series[zlecenieProduktu.PRODUKT.NAZWA_PRODUKTU] = seria;
            }

        }
    }
}
