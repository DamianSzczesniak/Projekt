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
    public partial class ZamowienieMaterialu : Form
    {
        KWZP_PROJEKTEntities db;
        ZLECENIA NRZlecenia;
        ZAMOWIENIA NoweZamowienie;

        public ZamowienieMaterialu(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            comboBoxNrZlecenia.DataSource = db.AKTUALNY_STATUS_ZLECEN.Where(a => a.Status == 1).ToList();
            comboBoxNrZlecenia.ValueMember = "ID_ZLECENIA";
           

        }
        

        private void BtnNoweZam_MouseClick(object sender, MouseEventArgs e)
        {

            if ((ZLECENIA)comboBoxNrZlecenia.SelectedValue == NRZlecenia)
            {
               // NoweZamowienie NoweZamowienie = new NoweZamowienie(db, NRZlecenia);
               // Show();
            }
            else
            {
                MessageBox.Show("Podano nieprawidłowy numer zlecenia");
            }
        }

      

        private void Btn_Back_5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxNrZlecenia.SelectedValue.ToString());
            sUMAZAPOTRZEBOWANIAMATERIALZLECENIEBindingSource.DataSource = db.SUMA_ZAPOTRZEBOWANIA_MATERIAL_ZLECENIE.Where(a => a.ID_ZLECENIA == id).ToList();
        }
    }

}
