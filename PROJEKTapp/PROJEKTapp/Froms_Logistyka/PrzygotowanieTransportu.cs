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
        string IdDostawy;
        public PrzygotowanieTransportu(KWZP_PROJEKTEntities db)
        {
            InitializeComponent();
            this.db = db;



            ComboNumerDostawy.DataSource = db.DOSTAWA.ToList();
            ComboNumerDostawy.DisplayMember = "ID_DOSTAWY";

            this.dataGridTransport.DataSource = db.PRZYGOTOWANIE_TRANSPORTU.Where(x => x.ID_POJAZDU.ToString() == IdDostawy).ToList();

        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboNumerDostawy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IdDostawy = int.Parse(ComboNumerDostawy.SelectedValue)ToString();
            textBox1.Text = IdDostawy.ToString();
        }
    }
}
