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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogistyka_Click(object sender, EventArgs e)
        {
            FormLogistyka Logistyka = new FormLogistyka();
            Logistyka.Show();
        }

        private void btnKadry_Click(object sender, EventArgs e)
        {
            FormKadry Kadry = new FormKadry();
            Kadry.Show();
        }

        private void btnProdukcja_Click(object sender, EventArgs e)
        {
            FormProdukcja Produkcja = new FormProdukcja();
            Produkcja.Show();
        }
    }
}
