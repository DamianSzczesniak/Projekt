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

            comboBoxFirmy.Hide();

            txtzlozenia.Hide();
            txtZamowienia.Hide();
            lvlFirmy.Hide();
            btnZapisz.Hide();
            lblDZ.Hide();
            lblReal.Hide();

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

        private void BtnNoweZam_Click(object sender, EventArgs e)
        {
            lvlFirmy.Show();
            btnZapisz.Show();
            lblDZ.Show();
            lblReal.Show();
            comboBoxFirmy.Show();
            comboBoxFirmy.DataSource = db.FIRMY.ToList();
            comboBoxFirmy.DisplayMember = "NAZWA_FIRMY";
            comboBoxFirmy.ValueMember = "ID_FIRMY";
            txtZamowienia.Show();
            txtzlozenia.Show();
            txtzlozenia.Text = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime data = DateTime.Now;
            DateTime dateTime = data.AddDays(3);
            txtZamowienia.Text = dateTime.ToString("dd/MM/yyyy");
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            ZAMOWIENIA zAMOWIENIA = new ZAMOWIENIA();
            DateTime data = DateTime.Now;
            zAMOWIENIA.DATA_REALIZACJI = data.AddDays(3);
            zAMOWIENIA.DATA_ZAMOWIENIA = data;
            zAMOWIENIA.ID_FIRMY = int.Parse(comboBoxFirmy.SelectedValue.ToString());
            db.ZAMOWIENIA.Add(zAMOWIENIA);
            DATA_STATUSU_ZLECENIA dATA_STATUSU_ = new DATA_STATUSU_ZLECENIA();
            dATA_STATUSU_.DATA_ZMIANY = data;
            dATA_STATUSU_.ID_ZLECENIA = int.Parse(comboBoxNrZlecenia.SelectedValue.ToString());
            dATA_STATUSU_.ID_STATUSU_ZLECENIA = 2;
            db.DATA_STATUSU_ZLECENIA.Add(dATA_STATUSU_);


            MessageBox.Show("Akcje zapisano pomyślne .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();



        }

    }
}
