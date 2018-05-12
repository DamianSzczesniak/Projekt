using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp
{
    public partial class ZleceniaPosredniczacy : Form
    {
        KWZP_PROJEKTEntities db;
        int uprawnienia;
        public ZleceniaPosredniczacy(KWZP_PROJEKTEntities db, int uprawnienia)
        {
            this.db = db;
            this.uprawnienia = uprawnienia;
            InitializeComponent();
        }

        private void btnNoweZlecenie_Click(object sender, EventArgs e)
        {

            FormNoweZlecenie NoweZlecenie = new FormNoweZlecenie(new ZLECENIA(), db);
                NoweZlecenie.Show();

           
          

        }
        private void btnStatusyZlecen_Click(object sender, EventArgs e)
        {
            ZleceniaStatusy zleceniaStatusy = new ZleceniaStatusy(db, uprawnienia);
            zleceniaStatusy.Show();
        }
    }
}
