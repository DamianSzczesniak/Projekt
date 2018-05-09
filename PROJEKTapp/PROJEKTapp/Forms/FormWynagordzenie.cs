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
    public partial class FormWynagordzenie : Form
    {
        KWZP_PROJEKTEntities db;
        bool ladowanieformularzazokienkami;

        public FormWynagordzenie(KWZP_PROJEKTEntities db, bool ladowanieformularzazokienkami)
        {
            this.db = db;
            this.ladowanieformularzazokienkami = ladowanieformularzazokienkami;
            InitializeComponent();
            
        }

        private void FormWynagordzenie_Load(object sender, EventArgs e)
        {
            //if (formload ==1)
            dgvWyplaty.DataSource = db.PENSJE.ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (ladowanieformularzazokienkami == true)
            {
                //formload = 0;
                //pnlUserControl.Show();
                //pnlUserSearch.Show();
                //pnlUserField.Hide();
                //this.ListaPracownikow.DataSource = db.PRACOWNICY_OSTATNIE_STANOWISKO.ToList();
                //ListaPracownikow.Columns[0].HeaderText = "NUMER";
                //ListaPracownikow.Columns[0].Width = 60;
                //ListaPracownikow.Columns[4].HeaderText = "STANOWISKO";
            }
            else
            {
                ladowanieformularzazokienkami = true;
                //pnlUserControl.Hide();
                //pnlUserSearch.Hide();
                //pnlUserField.Hide();
            }
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
            ladowanieformularzazokienkami = true;
            FormStatystyki statystyki = new FormStatystyki(db, ladowanieformularzazokienkami);
            statystyki.Show();
            this.Close();
        }
    }
}


