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
    public partial class FormSzkolenie : Form
    {
        KWZP_PROJEKTEntities db;//połaczenie z bazą danych
        bool ladowanieformularzazokienkami;
        bool ZapiszUsun;
        PRACOWNICY pracownik;

        public FormSzkolenie(KWZP_PROJEKTEntities db, bool ladowanieformularzazokienkami)
        {
            this.db = db;
            this.ladowanieformularzazokienkami = ladowanieformularzazokienkami;
            InitializeComponent();

            int rok = DateTime.Now.Year;
            for (int i = rok - 5; i <= rok + 5; i++)
            {
                cbRokSzkolenia.Items.Add(i.ToString());
            }
            cbRokSzkolenia.SelectedIndex = 5;

            cbSzkolenia.DataSource = db.SZKOLENIA.Where(szkolenia => ((szkolenia.DATA_START.Year).ToString()).Equals(cbRokSzkolenia.SelectedItem.ToString())).ToList();
            cbSzkolenia.DisplayMember = "NAZWA_SZKOLENIA";
            cbSzkolenia.SelectedItem = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSzkolenie_Load(object sender, EventArgs e)
        {
            if (ladowanieformularzazokienkami == true)
            {
                pnlSzkoleniaControl.Show();
                pnlUserSearch.Show();
                pnlNoweSzkolenie.Hide();
                pnlDodajSzkolenie.Hide();
                ladowanieformularzazokienkami = false;
                this.ListaPracownikow.DataSource = db.PRACOWNICY_ZATRUDNIENI.ToList();
                ListaPracownikow.Columns[0].HeaderText = "NUMER";
                ListaPracownikow.Columns[0].Width = 60;
                ListaPracownikow.Columns[4].HeaderText = "STANOWISKO";
            }
            else
            {
                pnlSzkoleniaControl.Hide();
                pnlUserSearch.Hide();
                pnlNoweSzkolenie.Hide();
                ladowanieformularzazokienkami = true;
            }
        }

        private void btnSzkolenia_Click(object sender, EventArgs e)
        {
            if (ladowanieformularzazokienkami == true)
            {
                ladowanieformularzazokienkami = false;
                pnlSzkoleniaControl.Show();
                pnlUserSearch.Show();
                pnlNoweSzkolenie.Hide();
                this.ListaPracownikow.DataSource =
                ListaPracownikow.Columns[0].HeaderText = "NUMER";
                ListaPracownikow.Columns[0].Width = 60;
                ListaPracownikow.Columns[4].HeaderText = "STANOWISKO";
            }
            else
            {
                ladowanieformularzazokienkami = true;
                pnlSzkoleniaControl.Hide();
                pnlUserSearch.Hide();
                pnlNoweSzkolenie.Hide();
            }
        }

        private void btnUrlopy_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormUrlopy urlopy = new FormUrlopy(db, ladowanieformularzazokienkami);
            urlopy.Show();
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
            ladowanieformularzazokienkami = true;
            FormWynagordzenie wynagrodzenie = new FormWynagordzenie(db, ladowanieformularzazokienkami);
            wynagrodzenie.Show();
            this.Close();
        }

        private void btnStatystyki_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormStatystyki statystyki = new FormStatystyki(db, ladowanieformularzazokienkami);
            statystyki.Show();
            this.Close();
        }

        private void btnNoweSzkolenie_Click(object sender, EventArgs e)
        {
            pnlDodajSzkolenie.Hide();
            pnlNoweSzkolenie.Show();
        }

        private void btnZapiszDodaj_Click(object sender, EventArgs e)
        {
            SZKOLENIA szkolenie = new SZKOLENIA();
            szkolenie.NAZWA_SZKOLENIA = this.txtboxNazwa.Text;
            szkolenie.OPIS_SZKOLENIA = this.txtboxOpis.Text;
            szkolenie.DATA_START = this.dtpStart.Value;
            szkolenie.DATA_KONIEC = this.dtpKoniec.Value;
            db.SZKOLENIA.Add(szkolenie);
            db.SaveChanges();
            pnlDodajSzkolenie.Hide();
        }


        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            txtboxNazwa.Clear();
            txtboxOpis.Clear();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            pnlNoweSzkolenie.Hide();
            txtboxNazwa.Clear();
            txtboxOpis.Clear();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ZapiszUsun = true;
            btnSprawdz.Show();
            pnlDodajSzkolenie.Show();
            int ID = Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value);
            this.pracownik = db.PRACOWNICY.Where(pracownik => pracownik.ID_PRACOWNIK == ID).First();
            lblPracownik.Text = "Szkolenie pracownika " + pracownik.IMIE + " " + pracownik.NAZWISKO;

            KalendarzSzkolenia.BoldedDates = new DateTime[] {};

            foreach (SZKOLENIA szkolenie in pracownik.SZKOLENIA)
            {
                int dlugoscSzkolenia = szkolenie.DATA_KONIEC.Subtract(szkolenie.DATA_START).Days;
                DateTime aktualnaData = szkolenie.DATA_START;
                for (int i = 0; i < dlugoscSzkolenia; i++)
                {
                    KalendarzSzkolenia.BoldedDates = KalendarzSzkolenia.BoldedDates.Concat(new DateTime[] { aktualnaData.AddDays(i) }).ToArray();
                }
            }
        }

        private void btnAnulujSzkolenie_Click(object sender, EventArgs e)
        {
            pnlDodajSzkolenie.Hide();
        }

        private void btnZapiszSzkolenie_Click(object sender, EventArgs e)
        {
            if (ZapiszUsun == true)
            {
                if (cbSzkolenia.SelectedValue == null)
                {
                    MessageBox.Show("Najpierw wybierz szkolenie");
                }
                else
                {
                    int ID = Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value);
                    pracownik = db.PRACOWNICY.Where(x => x.ID_PRACOWNIK == ID).First();
                    SZKOLENIA szkolenie;
                    szkolenie = ((SZKOLENIA)this.cbSzkolenia.SelectedValue);
                    pracownik.SZKOLENIA.Add(szkolenie);
                    db.SaveChanges();
                    pnlDodajSzkolenie.Hide();
                }
            }
            else
            {
                if (cbSzkolenia.SelectedValue == null)
                {
                    MessageBox.Show("Najpierw wybierz szkolenie");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Czy chcesz usunąć szkolenie pracownikowi: " + ListaPracownikow.CurrentRow.Cells[1].Value + " " + ListaPracownikow.CurrentRow.Cells[2].Value, "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int ID = Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value);
                        PRACOWNICY pracownik = db.PRACOWNICY.Where(x => x.ID_PRACOWNIK == ID).First();
                        SZKOLENIA s = pracownik.SZKOLENIA.Where(szkol => szkol.NAZWA_SZKOLENIA.Equals(cbSzkolenia.Text)).First();
                        try
                        {
                            pracownik.SZKOLENIA.Remove(s);
                            db.SaveChanges();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Usunięcie pracownika nie powiodło się");
                        }
                        ListaPracownikow.Refresh();
                        pnlDodajSzkolenie.Hide();
                        btnSprawdz.Show();
                        cbSzkolenia.SelectedItem = null;
                    }
                }
            }
        }

        private void cbRokSzkolenia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSzkolenia.DataSource = db.SZKOLENIA.Where(szkolenia => ((szkolenia.DATA_START.Year).ToString()).Equals(cbRokSzkolenia.SelectedItem.ToString())).ToList();
            cbSzkolenia.SelectedItem = null;
        }

        private void btnSprawdz_Click(object sender, EventArgs e)
        {
            KalendarzSzkolenia.SelectionStart = ((SZKOLENIA)this.cbSzkolenia.SelectedValue).DATA_START;
            KalendarzSzkolenia.SelectionEnd = ((SZKOLENIA)this.cbSzkolenia.SelectedValue).DATA_KONIEC;

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            ZapiszUsun = false;
            pnlDodajSzkolenie.Show();
            btnSprawdz.Hide();
            cbSzkolenia.SelectedItem = null;
            int ID = Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value);
            lblPracownik.Text = "Szkolenie pracownika " + ListaPracownikow.CurrentRow.Cells[1].Value + " " + ListaPracownikow.CurrentRow.Cells[2].Value;
            cbSzkolenia.DataSource = db.SZKOLENIA_PRACOWNIKA.Where(szkolenia => ((szkolenia.ID_PRACOWNIK).Equals(ID)))
                .Where(dataSzkolenia => ((dataSzkolenia.DATA_START.Year).ToString()).Equals(cbRokSzkolenia.SelectedItem.ToString())).ToList();
            cbSzkolenia.DisplayMember = "NAZWA_SZKOLENIA";
        }

        private void ListaPracownikow_MouseClick(object sender, MouseEventArgs e)
        {
            int ID = Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value);
            dgvSzkoleniaPracownika.DataSource = db.SZKOLENIA_PRACOWNIKA.Where(pracownik => pracownik.ID_PRACOWNIK.Equals(ID)).ToList();
            ListaPracownikow.Refresh();
            this.dgvSzkoleniaPracownika.Columns[5].Visible = false;
        }
    }
}
