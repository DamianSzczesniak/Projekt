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
    public partial class FormFirmyNoweZlecenie : Form
    {
        KWZP_PROJEKTEntities db = new KWZP_PROJEKTEntities();
        public FormFirmyNoweZlecenie()
        {
            InitializeComponent();
            dataGridFirmy.DataSource = db.FIRMY.ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
