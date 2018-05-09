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
            int k = int.Parse(comboBoxNrZlecenia.SelectedValue.ToString());
            this.GridVwZapMat.DataSource = db.ZAPOTRZEBOWANIE_MATERIAL.Where(x => x.ID_ZLECENIA == k).ToList();

        }
        private void comboBoxNrZlecenia_SelectedIndexChanged(object sender, EventArgs e)
        {
            NRZlecenia = (ZLECENIA)comboBoxNrZlecenia.SelectedValue;
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

        private void comboBoxNrZlecenia_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }

}
