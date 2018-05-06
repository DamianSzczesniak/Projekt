using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Froms_Logistyka
{
    public partial class AkcjaMagazynProduktów : Form
    {
        KWZP_PROJEKTEntities db;
        bool materialy;
        object dane;
        public AkcjaMagazynProduktów(KWZP_PROJEKTEntities db, bool materialy,object dane)
        {
            this.db = db;
            this.materialy = materialy;
            this.dane = dane;
            InitializeComponent();
        }

        private void AkcjaMagazynProduktów_Load(object sender, EventArgs e)
        {
            if (materialy)
            {
                if (dane == null)
                {
                    lblItem.Text = "Materiał :";
                    cBoxSurPro.DataSource = db.MATERIAL.ToList();
                    cBoxSurPro.DisplayMember = "PELNA_NAZWA_MATERIALU";
                    cBoxSurPro.ValueMember = "ID_MATERIALU";
                    txtBoxRAkcji.Text = "DODAWANIE";
                }
                else
                {
                    STAN_MATERIALY_NAZWY sTAN_MATERIALY_NAZWY = dane as STAN_MATERIALY_NAZWY;
                    txtBoxRAkcji.Text = "ODBIÓR";
                    lblItem.Text = "Materiał :";
                    cBoxSurPro.DataSource = db.MATERIAL.Where( a => a.ID_MATERIALU == sTAN_MATERIALY_NAZWY.ID_MATERIALU).ToList();
                    cBoxSurPro.DisplayMember = "PELNA_NAZWA_MATERIALU";
                    cBoxSurPro.ValueMember = "ID_MATERIALU";
                    cBoxLokalizacja.DataSource = db.LOKALIZACJA.Where(a => a.ID_LOKALIZACJI == sTAN_MATERIALY_NAZWY.ID_LOKALIZACJI).ToList();
                    cBoxLokalizacja.DisplayMember = "ID_LOKALIZACJI";
                    cBoxLokalizacja.ValueMember = "ID_LOKALIZACJI";
                    cBoxPrzypisaneZlecenie.DataSource = db.ZLECENIA.Where(a => a.ID_ZLECENIA == sTAN_MATERIALY_NAZWY.ID_ZLECENIA).ToList();
                    cBoxPrzypisaneZlecenie.DisplayMember = "ID_ZLECENIA";
                    cBoxPrzypisaneZlecenie.ValueMember = "ID_ZLECENIA";
                }
            }
            else
            {
                if (dane == null)
                {
                    lblItem.Text = "Produkt :";
                    cBoxSurPro.DataSource = db.PRODUKT.ToList();
                    cBoxSurPro.DisplayMember = "NAZWA_PRODUKTU";
                    cBoxSurPro.ValueMember = "ID_PRODUKTU";
                    txtBoxRAkcji.Text = "DODAWANIE";
                }
                else
                {
                    STAN_PRODUKTY_NAZWY sTAN_PRODUKTY_NAZWY = dane as STAN_PRODUKTY_NAZWY;
                    txtBoxRAkcji.Text = "ODBIÓR";
                    lblItem.Text = "Produkt :";
                    cBoxSurPro.DataSource = db.PRODUKT.Where(a => a.ID_PRODUKTU == sTAN_PRODUKTY_NAZWY.ID_PRODUKTU).ToList();
                    cBoxSurPro.DisplayMember = "NAZWA_PRODUKTU";
                    cBoxSurPro.ValueMember = "ID_PRODUKTU";
                    cBoxLokalizacja.DataSource = db.LOKALIZACJA.Where(a => a.ID_LOKALIZACJI == sTAN_PRODUKTY_NAZWY.ID_LOKALIZACJI).ToList();
                    cBoxLokalizacja.DisplayMember = "ID_LOKALIZACJI";
                    cBoxLokalizacja.ValueMember = "ID_LOKALIZACJI";
                    cBoxPrzypisaneZlecenie.DataSource = db.ZLECENIA.Where(a => a.ID_ZLECENIA == sTAN_PRODUKTY_NAZWY.ID_ZLECENIA).ToList();
                    cBoxPrzypisaneZlecenie.DisplayMember = "ID_ZLECENIA";
                    cBoxPrzypisaneZlecenie.ValueMember = "ID_ZLECENIA";



                }
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (materialy)
            {
                if (dane == null)
                {

                }
                else
                {
                    STAN_MATERIALY_NAZWY sTAN_MATERIALY_NAZWY = dane as STAN_MATERIALY_NAZWY;
                    if (int.Parse(txtBoxIlosc.Text) > 0 && int.Parse(txtBoxIlosc.Text) <= int.Parse(sTAN_MATERIALY_NAZWY.STAN.ToString()))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Nie można pobrać z danej lokalizacji większej liczby materiałów, przypisanych danemu zleceniu, niż się w niej znajduje .", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                if (dane == null)
                {

                }
                else
                {
                    STAN_PRODUKTY_NAZWY sTAN_PRODUKTY_NAZWY = dane as STAN_PRODUKTY_NAZWY;
                    if (int.Parse(txtBoxIlosc.Text) > 0 && int.Parse(txtBoxIlosc.Text) <= int.Parse(sTAN_PRODUKTY_NAZWY.STAN.ToString()))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Nie można pobrać z danej lokalizacji większej liczby produktów, przypisanych danemu zleceniu, niż się w niej znajduje .", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            
        }
    }
}
