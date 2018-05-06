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
                    cBoxSurPro.DataSource = db.STAN_MATERIALY_NAZWY.ToList();
                    cBoxSurPro.DisplayMember = "PELNA_NAZWA_MATERIALU";
                    cBoxSurPro.ValueMember = "ID_MATERIALU";
                    txtBoxRAkcji.Text = "DODAWANIE";
                }
                else
                {
                    txtBoxRAkcji.Text = "ODBIÓR";

                }
            }
            else
            {
                if (dane == null)
                {
                    lblItem.Text = "Produkt :";
                    cBoxSurPro.DataSource = db.STAN_PRODUKTY_NAZWY.ToList();
                    cBoxSurPro.DisplayMember = "NAZWA_PRODUKTU";
                    cBoxSurPro.ValueMember = "ID_PRODUKTU";
                    txtBoxRAkcji.Text = "DODAWANIE";
                }
                else
                {
                    txtBoxRAkcji.Text = "ODBIÓR";

                }
            }
        }
    }
}
