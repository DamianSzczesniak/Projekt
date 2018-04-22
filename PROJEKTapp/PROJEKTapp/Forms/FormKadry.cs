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
    public partial class FormKadry : Form
    {
        KWZP_PROJEKTEntities kwzpProjektEntities = new KWZP_PROJEKTEntities();//połaczenie z bazą danych
        public FormKadry()
        {
            InitializeComponent();
        }

        

        private void FormKadry_Load(object sender, EventArgs e)
        {

        }
        

        private void btnPracownicy_Click(object sender, EventArgs e)
        {
            FormPracownicy Pracownicy = new FormPracownicy(kwzpProjektEntities);
            Pracownicy.Show();
        }

        private void btnExit_Click(object sender, EventArgs e) =>
            this.Close();
    }
}
