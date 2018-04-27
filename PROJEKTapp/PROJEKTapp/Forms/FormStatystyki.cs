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
        bool ladowanieformularzazokienkami;

        public FormStatystyki(KWZP_PROJEKTEntities db, bool ladowanieformularzazokienkami)
        {
            this.db = db;
            this.ladowanieformularzazokienkami = ladowanieformularzazokienkami;
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
            ladowanieformularzazokienkami = true;
            FormKadry kadry = new FormKadry(db, ladowanieformularzazokienkami);
            kadry.Show();
            this.Close();
        }

        private void btnWynagrodzenia_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormWynagordzenie wynagrodzenie = new FormWynagordzenie(db, ladowanieformularzazokienkami);
            wynagrodzenie.Show();
            this.Close();
        }

        private void btnUrlopy_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormUrlopy urlopy = new FormUrlopy(db, ladowanieformularzazokienkami);
            urlopy.Show();
            this.Close();
        }

        private void btnSzkolenia_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormSzkolenie szkolenie = new FormSzkolenie(db, ladowanieformularzazokienkami);
            szkolenie.Show();
            this.Close();
        }

        private void btnStatystyki_Click(object sender, EventArgs e)
        {

        }
    }
}
