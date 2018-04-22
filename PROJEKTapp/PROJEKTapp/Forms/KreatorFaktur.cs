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
    public partial class KreatorFaktur : Form
    {
        public KreatorFaktur(KWZP_PROJEKTEntities kwzpProjektEntities)
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
