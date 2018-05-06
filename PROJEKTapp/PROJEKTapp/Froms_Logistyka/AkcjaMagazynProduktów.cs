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
                    
                  
                }
            }
        }
    }
}
