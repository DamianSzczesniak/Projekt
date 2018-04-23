using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Forms_Produkcja
{
    public partial class FormEwidencja : Form
    {
        public FormEwidencja(KWZP_PROJEKTEntities kwzpProjektEntities)
        {
            InitializeComponent();
        }

        private void btnExitEwidencja_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
