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
        public PrzygotowanieTransportu(KWZP_PROJEKTEntities db)
        {
            InitializeComponent();
            this.db = db;
            ComboNumerDostawy.DataSource = db.DOSTAWA.ToList();
            ComboNumerDostawy.DisplayMember = "ID_DOSTAWY";
            
            comboBoxZlecenie.DataSource = db.ID_ZLECEN_BEZ_TRANSPORTU;
            comboBoxZlecenie.DisplayMember = "ID_ZLECENIA";

            dataGridViewAdresy.DataSource = db.ADRESY_DOSTAWA.ToList();

        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboNumerDostawy_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridTransport.DataSource = db.PRZYGOTOWANIE_TRANSPORTU.Where(x => x.ID_POJAZDU == ((DOSTAWA)ComboNumerDostawy.SelectedValue).ID_DOSTAWY).ToList();
        }

        private void ButtonDodajDostawe_Click(object sender, EventArgs e)
        {
            groupBoxDodaj.Show();
            dataGridViewDostepnePojazdy.DataSource = db.STAN_PRODUKTY_NAZWY.ToList();
        }

        private void checkBoxWszytkie_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWszytkie.Checked)
            {
                this.dataGridTransport.DataSource = db.PRZYGOTOWANIE_TRANSPORTU.ToList();
            }
            else
            {
                this.dataGridTransport.DataSource = db.PRZYGOTOWANIE_TRANSPORTU.Where(x => x.ID_POJAZDU == ((DOSTAWA)ComboNumerDostawy.SelectedValue).ID_DOSTAWY).ToList();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}