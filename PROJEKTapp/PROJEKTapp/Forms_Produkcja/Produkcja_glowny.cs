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

    public partial class Produkcja_glowny : Form
    {
        KWZP_PROJEKTEntities kwzpProjektEntities = new KWZP_PROJEKTEntities();
        public Produkcja_glowny()
        {
            InitializeComponent();
        }

        private void Produkcja_glowny_Load(object sender, EventArgs e)
        {

        }

        private void btnExitProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWykorzystaneMaszyny_Click(object sender, EventArgs e)
        {
            Forms_Produkcja.FormWykorzystaneMaszyny WykorzystaneMaszyny = new Forms_Produkcja.FormWykorzystaneMaszyny(kwzpProjektEntities);
            WykorzystaneMaszyny.Show();
        }

        private void btnEwidencja_Click(object sender, EventArgs e)
        {
            Forms_Produkcja.FormObciazenie obciazenie = new Forms_Produkcja.FormObciazenie(kwzpProjektEntities);
            obciazenie.Show();
        }
    }
}
