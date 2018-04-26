using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Forms.Forms_Logistyka
{
    public partial class FormListaFaktur : Form
    {
        KWZP_PROJEKTEntities kwzpProjektEntities = new KWZP_PROJEKTEntities();
        public FormListaFaktur(KWZP_PROJEKTEntities kwzpProjektEntities)
        {
            InitializeComponent();
        }

        private void ButtonNowaFaktura_Click(object sender, EventArgs e)
        {
            KreatorFaktur KreatorFaktur = new KreatorFaktur(kwzpProjektEntities);
            KreatorFaktur.Show();
        }
    }
}
