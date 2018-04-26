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
    public partial class FormUrlopy : Form
    {
        KWZP_PROJEKTEntities db;
        int formload;
        int contzapis;

        public FormUrlopy(KWZP_PROJEKTEntities db, int formload)
        {
            this.formload = formload;
            this.db = db;
            InitializeComponent();

            cbTypUrlopu.DataSource = db.WOLNE.ToList();
            cbTypUrlopu.DisplayMember = "NAZWA";
            cbTypUrlopu.ValueMember = "ID_WOLNE";
        }

        private void FormUrlopy_Load(object sender, EventArgs e)
        {
            if (formload == 1)
            {
                pnlUrlopyControl.Show();
                pnlUserSearch.Show();
                pnlWolne.Hide();
                formload = 0;
                var bspracownicy = from p in db.PRACOWNICY
                                   join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                                   join s in db.STANOWISKO on sp.ID_STANOWISKO equals s.ID_STANOWISKO
                                   select new { p.ID_PRACOWNIK, p.NAZWISKO, p.IMIE, p.TELEFON, s.NAZWA };
                this.ListaPracownikow.DataSource = bspracownicy.ToList();
                ListaPracownikow.Columns[0].HeaderText = "NUMER";
                ListaPracownikow.Columns[0].Width = 60;
                ListaPracownikow.Columns[4].HeaderText = "STANOWISKO";
            }
            else
            {
                pnlUrlopyControl.Hide();
                pnlUserSearch.Hide();
                pnlWolne.Hide();
                formload = 1;
            }
        }

        private void btnUrlopy_Click(object sender, EventArgs e)
        {

            if (formload == 1)
            {
                pnlUrlopyControl.Show();
                pnlUserSearch.Show();
                pnlWolne.Hide();
                formload = 0;
                var bspracownicy = from p in db.PRACOWNICY
                                   join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                                   join s in db.STANOWISKO on sp.ID_STANOWISKO equals s.ID_STANOWISKO
                                   select new { p.ID_PRACOWNIK, p.NAZWISKO, p.IMIE, p.TELEFON, s.NAZWA };
                this.ListaPracownikow.DataSource = bspracownicy.ToList();
                ListaPracownikow.Columns[0].HeaderText = "NUMER";
                ListaPracownikow.Columns[0].Width = 60;
                ListaPracownikow.Columns[4].HeaderText = "STANOWISKO";
            }
            else
            {
                pnlUrlopyControl.Hide();
                pnlUserSearch.Hide();
                pnlWolne.Hide();
                formload = 1;
            }
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
        private void txtWyszukajNazwisko_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtWyszukajNazwisko.Text))
            {
                var bspracownicy = from p in db.PRACOWNICY
                                   join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                                   join s in db.STANOWISKO on sp.ID_STANOWISKO equals s.ID_STANOWISKO
                                   select new { p.ID_PRACOWNIK, p.NAZWISKO, p.IMIE, p.TELEFON, s.NAZWA };
                this.ListaPracownikow.DataSource = bspracownicy.ToList();
            }
            else
            {
                this.ListaPracownikow.DataSource = db.PRACOWNICY.Where(x => x.NAZWISKO.StartsWith(txtWyszukajNazwisko.Text)).ToList();
            }
        }

        private void czyscform()
        {
            foreach (Control control in this.pnlWolne.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox.Name.Contains("txtbox"))
                    {
                        (control as TextBox).Clear();
                    }
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            pnlWolne.Show();
            czyscform();
            contzapis = 1;
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            pnlWolne.Show();
            czyscform();
            contzapis = 0;

            int ID = Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value);

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {

        }

        private void btnZapiszDodaj_Click(object sender, EventArgs e)
        {
            if (contzapis ==1)
            {
                WOLNE_PRACOWNICY wolnepracownik = new WOLNE_PRACOWNICY();
                wolnepracownik.DATA_KONIEC = txtDataKoniec.Value;
                wolnepracownik.DATA_START = txtDataStart.Value;
                wolnepracownik.ID_WOLNE = (int)cbTypUrlopu.SelectedValue;
                wolnepracownik.ID_PRACOWNIK = Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value);
                db.SaveChanges();
                ListaPracownikow.Refresh();
                pnlUrlopyControl.Hide();
            }
            else
            {
                //zapis edycji
            }
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            czyscform();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            pnlWolne.Hide();
            czyscform();
        }
    }
}
