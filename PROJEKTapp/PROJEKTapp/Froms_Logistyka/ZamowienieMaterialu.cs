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

        public ZamowienieMaterialu(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            comboBoxNrZlecenia.DataSource = db.ZLECENIA.ToList();
            comboBoxNrZlecenia.ValueMember = "ID_ZLECENIA";
            comboBoxNrZlecenia.SelectedValue = "ID_ZLECENIA";
    
        }


        private void BtnShow_MouseClick_1(object sender, MouseEventArgs e)
        { 
            
        }

        private void BtnSprDost_MouseClick(object sender, MouseEventArgs e)
        {
            int g = int.Parse(comboBoxNrZlecenia.SelectedValue.ToString());
            db.STAN_MATERIALY_NAZWY.Where(i => i.ID_ZLECENIA == g).ToList();
        }

    }
}
