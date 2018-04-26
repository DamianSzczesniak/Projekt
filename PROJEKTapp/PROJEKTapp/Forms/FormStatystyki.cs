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
    public partial class FormStatystyki : Form
    {
        KWZP_PROJEKTEntities db;
        int formload;

        public FormStatystyki(KWZP_PROJEKTEntities db, int formload)
        {
            this.db = db;
            this.formload = formload;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStatystyki_Load(object sender, EventArgs e)
        {

        }

        private void btnPracownicy_Click(object sender, EventArgs e)
        {
            formload = 1;
            FormKadry kadry = new FormKadry(db, formload);
            kadry.Show();
            this.Close();
        }

        private void btnWynagrodzenia_Click(object sender, EventArgs e)
        {
            formload = 1;
            FormWynagordzenie wynagrodzenie = new FormWynagordzenie(db, formload);
            wynagrodzenie.Show();
            this.Close();
        }

        private void btnUrlopy_Click(object sender, EventArgs e)
        {
            formload = 1;
            FormUrlopy urlopy = new FormUrlopy(db, formload);
            urlopy.Show();
            this.Close();
        }

        private void btnSzkolenia_Click(object sender, EventArgs e)
        {
            formload = 1;
            FormSzkolenie szkolenie = new FormSzkolenie(db, formload);
            szkolenie.Show();
            this.Close();
        }

        private void btnStatystyki_Click(object sender, EventArgs e)
        {

        }
    }
}
