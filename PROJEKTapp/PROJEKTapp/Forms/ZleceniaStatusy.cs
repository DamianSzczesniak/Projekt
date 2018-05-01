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
    public partial class ZleceniaStatusy : Form
    {
        KWZP_PROJEKTEntities db;
        int uprawnienia;
        public ZleceniaStatusy(KWZP_PROJEKTEntities db, int uprawnienia)
        {
            this.db = db;
            this.uprawnienia = uprawnienia;

            
            InitializeComponent();
        }

        private void ZleceniaStatusy_Load(object sender, EventArgs e)
        {
            StatusZleceniaDGV.DataSource = db.AKTUALNY_STATUS_ZLECEN_NAZWY.ToList();
        }
    }
}
