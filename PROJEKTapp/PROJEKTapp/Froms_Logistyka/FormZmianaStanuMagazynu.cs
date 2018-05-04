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
    public partial class FormZmianaStanuMagazynu : Form
    {
        KWZP_PROJEKTEntities db;
        public FormZmianaStanuMagazynu(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonZmianaStanu_Click(object sender, EventArgs e)
        {

        }
    }
}
