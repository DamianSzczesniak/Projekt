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
        int formload;

        public FormWynagordzenie(KWZP_PROJEKTEntities db, int formload)
        {
            this.db = db;
            this.formload = formload;
            InitializeComponent();
        }

        private void FormWynagordzenie_Load(object sender, EventArgs e)
        {
            //if (formload ==1)
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (formload == 1)
            {
                //formload = 0;
                //pnlUserControl.Show();
                //pnlUserSearch.Show();
                //pnlUserField.Hide();

                //var bspracownicy = from p in db.PRACOWNICY
                //                   join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                //                   join s in db.STANOWISKO on sp.ID_STANOWISKO equals s.ID_STANOWISKO
                //                   select new { p.ID_PRACOWNIK, p.NAZWISKO, p.IMIE, p.TELEFON, s.NAZWA };
                //this.ListaPracownikow.DataSource = bspracownicy.ToList();
                //ListaPracownikow.Columns[0].HeaderText = "NUMER";
                //ListaPracownikow.Columns[0].Width = 60;
                //ListaPracownikow.Columns[4].HeaderText = "STANOWISKO";
            }
            else
            {
                formload = 1;
                //pnlUserControl.Hide();
                //pnlUserSearch.Hide();
                //pnlUserField.Hide();
            }
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
            formload = 1;
            FormStatystyki statystyki = new FormStatystyki(db, formload);
            statystyki.Show();
            this.Close();
        }
    }
}


