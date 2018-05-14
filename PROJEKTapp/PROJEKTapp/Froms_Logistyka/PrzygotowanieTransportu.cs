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
    public partial class PrzygotowanieTransportu : Form
    {
        KWZP_PROJEKTEntities db;
        int id;
        public PrzygotowanieTransportu(KWZP_PROJEKTEntities db, int id)
        {
            this.id = id;
            this.db = db;
            InitializeComponent();
            pRODUKTYPOZOSTALEDOTRANSPORTUBindingSource.DataSource = db.PRODUKTY_POZOSTALE_DO_TRANSPORTU.Where(a => a.ID_ZLECENIA == id).ToList();

            ;


            
            var dict1 = new Dictionary<int, string>();
            ZLECENIA zLECENIA = db.ZLECENIA.Where(a => a.ID_ZLECENIA == id).First();
            ;
            foreach (FIRMY row in db.FIRMY.Where(a => a.ID_FIRMY == zLECENIA.FIRMY.ID_FIRMY).ToList())
            {
                dict1.Add(row.ID_FIRMY, row.NAZWA_FIRMY + "    NIP :   " + row.NIP);
            }
            cBoxFirma.DataSource = dict1.ToList();
            cBoxFirma.ValueMember = "Key";
            cBoxFirma.DisplayMember = "Value";

            ;

            var dict2 = new Dictionary<int, string>();
            foreach (POJAZDY row in db.POJAZDY.ToList())
            {
                dict2.Add(row.ID_POJAZDU, row.MARKA + "     " + row.MODEL + "    NR Rejestracyjny : " + row.NUMER_REJESTRACYJNY);
            }
            cBoxPojazd.DataSource = dict2.ToList();
            cBoxPojazd.ValueMember = "Key";
            cBoxPojazd.DisplayMember = "Value";


            var dict3 = new Dictionary<int, string>();
            foreach (ADRESY row in db.ADRESY.ToList())
            {
                dict3.Add(row.ID_ADRESU, row.KRAJ + " Miasto :  " + row.MIASTA.NAZWA + " Ulica: " + row.ULICA + " nr. Budynku " + row.NR_BUDYNKU);
            }
            cBoxAdress.DataSource = dict3.ToList();
            cBoxAdress.ValueMember = "Key";
            cBoxAdress.DisplayMember = "Value";





        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnWydelegujTransport_Click(object sender, EventArgs e)
        {

            DOSTAWA dOSTAWA = new DOSTAWA();
            dOSTAWA.DLUGOSC_TRASY = 100;
            dOSTAWA.ID_ADRESU = int.Parse(cBoxAdress.SelectedValue.ToString());
            dOSTAWA.ID_FIRMY = int.Parse(cBoxFirma.SelectedValue.ToString());
            db.DOSTAWA.Add(dOSTAWA);
            db.SaveChanges();
            DATA_STATUSU_ZLECENIA dATA_STATUSU_3 = new DATA_STATUSU_ZLECENIA();
            dATA_STATUSU_3.DATA_ZMIANY = DateTime.Today;
            dATA_STATUSU_3.ID_ZLECENIA = id;
            dATA_STATUSU_3.ID_STATUSU_ZLECENIA = 8;
            db.DATA_STATUSU_ZLECENIA.Add(dATA_STATUSU_3);
            db.SaveChanges();

            MessageBox.Show("Proces dostawy został uruchomiony .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();



        }
    }
}
