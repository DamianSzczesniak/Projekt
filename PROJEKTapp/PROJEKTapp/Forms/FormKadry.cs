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
        KWZP_PROJEKTEntities db;//połaczenie z bazą danych
        bool trybprzyciskuzapisedycja; //Rozrużnainie zapisu z edycji i zapisu nowego użytkownika
        bool ladowanieformularzazokienkami; //rozrużnianie sposobu otiwerania formularza (z otwartmi lub zamkniętymi panlami)
        PRACOWNICY pracownik;
        ADRESY_PRACOWNICY adrespracownik;
        STANOWISKO_PRACOWNICY pracownikstanowisko;
        STAWKA_PRACOWNICY pracownikstawka;

        public FormKadry(KWZP_PROJEKTEntities db, bool ladowanieformularzazokienkami)
        {
            this.db = db;
            this.ladowanieformularzazokienkami = ladowanieformularzazokienkami;
            InitializeComponent();

            cbStanowisko.DataSource = db.STANOWISKO.ToList();
            cbStanowisko.DisplayMember = "Nazwa";
            cbStanowisko.ValueMember = "Id_Stanowisko";

            cbMiasto.DataSource = db.MIASTA.ToList();
            cbMiasto.DisplayMember = "Nazwa";
            cbMiasto.ValueMember = "Id_Miasta";

            cbOkres.DataSource = db.OKRES.ToList();
            cbOkres.DisplayMember = "Nazwa";
            //cbOkres.ValueMember = "Id_okres";

            cbStawka.DataSource = db.STAWKA.Where(stawka => stawka.ID_OKRES.Equals(((OKRES)this.cbOkres.SelectedValue).ID_OKRES)).ToList();
            cbStawka.DisplayMember = "Wartosc";
           // cbStawka.ValueMember = "Id_Stawka";
        }


        private void FormKadry_Load(object sender, EventArgs e)
        {
            if (ladowanieformularzazokienkami == true)
            {
                pnlUserControl.Show();
                pnlUserSearch.Show();
                pnlUserField.Hide();
                ladowanieformularzazokienkami = false;
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
                pnlUserControl.Hide();
                pnlUserSearch.Hide();
                pnlUserField.Hide();
                ladowanieformularzazokienkami = true;
            }
        }

        private void btnPracownicy_Click(object sender, EventArgs e)
        {
            if (ladowanieformularzazokienkami == true)
            {
                ladowanieformularzazokienkami = false;
                pnlUserControl.Show();
                pnlUserSearch.Show();
                pnlUserField.Hide();

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
                ladowanieformularzazokienkami = true;
                pnlUserControl.Hide();
                pnlUserSearch.Hide();
                pnlUserField.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e) =>
            this.Close();

        private void btnUrlopy_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormUrlopy urlopy = new FormUrlopy(db, ladowanieformularzazokienkami);
            urlopy.Show();
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            {
                chbEdycjaStanoiwska.Hide();
                pnlUserField.Show();
                czyscform();
                trybprzyciskuzapisedycja = true;
                txtboxKraj.Text = "Polska";
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            pnlUserField.Show();
            trybprzyciskuzapisedycja = false;
            chbEdycjaStanoiwska.Show();

            int ID = Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value);
            pracownik = db.PRACOWNICY.Where(x => x.ID_PRACOWNIK == ID).First();
            txtboxNazwisko.Text = pracownik.NAZWISKO;
            txtboxImie.Text = pracownik.IMIE;
            txtboxTel.Text = pracownik.TELEFON;
            txtboxPesel.Text = pracownik.PESEL;
            adrespracownik = pracownik.ADRESY_PRACOWNICY.First();
            txtboxUlica.Text = adrespracownik.ULICA;
            txtboxNrlokalu.Text = adrespracownik.NR_LOKALU;
            txtboxNrbudynku.Text = adrespracownik.NR_BUDYNKU;
            txtboxKodpocztowy.Text = adrespracownik.KOD_POCZTOWY;
            cbMiasto.SelectedValue = adrespracownik.ID_MIASTA;
            txtboxKraj.Text = adrespracownik.KRAJ;
            pracownikstawka = pracownik.STAWKA_PRACOWNICY.Last();
            cbStawka.SelectedValue = pracownikstawka.ID_STAWKA;
            pracownikstanowisko = pracownik.STANOWISKO_PRACOWNICY.First();
            cbStanowisko.SelectedValue = pracownikstanowisko.ID_STANOWISKO;
            txtDataRozpoczeciaPracy.Value = pracownikstanowisko.DATA_START;
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy chcesz usunąć dane pracownika: " + ListaPracownikow.CurrentRow.Cells[1].Value + " " + ListaPracownikow.CurrentRow.Cells[2].Value, "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var bspracownicy = from p in db.PRACOWNICY
                                   join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                                   join s in db.STANOWISKO on sp.ID_STANOWISKO equals s.ID_STANOWISKO
                                   select new { p.ID_PRACOWNIK, p.NAZWISKO, p.IMIE, p.TELEFON, s.NAZWA };
                int ID = Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value);
                PRACOWNICY pracownik = db.PRACOWNICY.Where(x => x.ID_PRACOWNIK == ID).First();
                //STANOWISKO_PRACOWNICY stanowisko = db.STANOWISKO_PRACOWNICY.Where(s => s.ID_PRACOWNIK.Equals(ID)).First(); //Czy da sie wszytkie rekordy
                db.PRACOWNICY.Remove(pracownik);
                db.SaveChanges();
                ListaPracownikow.DataSource = bspracownicy.ToList();
                ListaPracownikow.Refresh();
                pnlUserField.Hide();
            } 
        }


        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            pnlUserField.Hide();
            czyscform();
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            czyscform();
        }
        private void czyscform()
        {
            foreach (Control control in this.pnlUserField.Controls)
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

        private void btnZapiszDodaj_Click(object sender, EventArgs e)
        {
                if (txtboxImie.Text == "" || txtboxNazwisko.Text == "" || txtboxTel.Text == "" || txtboxPesel.Text == "" || txtboxUlica.Text == "" || txtboxNrbudynku.Text == "" || txtboxNrlokalu.Text == "" || txtboxKodpocztowy.Text == "")
                {
                    MessageBox.Show("Wypełnij wszystkie pola");
                }
                else if (trybprzyciskuzapisedycja == true) //Tworzenie nowego pracownika
                {
                    PRACOWNICY pracownik = new PRACOWNICY();
                    pracownik.NAZWISKO = this.txtboxNazwisko.Text;
                    pracownik.IMIE = this.txtboxImie.Text;
                    pracownik.TELEFON = this.txtboxTel.Text;
                    pracownik.PESEL = this.txtboxPesel.Text;
                    ADRESY_PRACOWNICY adrespracownika = new ADRESY_PRACOWNICY();
                    adrespracownika.ULICA = this.txtboxUlica.Text;
                    adrespracownika.NR_BUDYNKU = this.txtboxNrbudynku.Text;
                    adrespracownika.NR_LOKALU = this.txtboxNrlokalu.Text;
                    adrespracownika.KOD_POCZTOWY = this.txtboxKodpocztowy.Text;
                    adrespracownika.ID_MIASTA = (int)cbMiasto.SelectedValue;
                    adrespracownika.KRAJ = this.txtboxKraj.Text;
                    STANOWISKO_PRACOWNICY pracownikstanowisko = new STANOWISKO_PRACOWNICY();
                    pracownikstanowisko.ID_STANOWISKO = (int)cbStanowisko.SelectedValue;
                    pracownikstanowisko.DATA_START = txtDataRozpoczeciaPracy.Value;
                if (chbDataKoniec.Checked == true)
                {
                    pracownikstanowisko.DATA_KONIEC = txtDataKoniec.Value;
                }
                    STAWKA_PRACOWNICY stawkapracownika = new STAWKA_PRACOWNICY();
                    stawkapracownika.ID_STAWKA = (int)cbStawka.SelectedValue;
                    stawkapracownika.DATA_START = txtDataRozpoczeciaPracy.Value;
                    pracownik.STAWKA_PRACOWNICY.Add(stawkapracownika);
                    pracownik.STANOWISKO_PRACOWNICY.Add(pracownikstanowisko);
                    pracownik.ADRESY_PRACOWNICY.Add(adrespracownika);
                    db.PRACOWNICY.Add(pracownik);
                    db.SaveChanges();
                    var bspracownicy = from p in db.PRACOWNICY
                                       join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                                       join s in db.STANOWISKO on sp.ID_STANOWISKO equals s.ID_STANOWISKO
                                       select new { p.ID_PRACOWNIK, p.NAZWISKO, p.IMIE, p.TELEFON, s.NAZWA };
                    ListaPracownikow.DataSource = bspracownicy.ToList();
                    ListaPracownikow.Refresh();
                }
            else
            {//Edycja istniejącego pracownika
                int ID = Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value);
                pracownik = db.PRACOWNICY.Where(x => x.ID_PRACOWNIK == ID).First();
                pracownik.NAZWISKO = this.txtboxNazwisko.Text;
                pracownik.IMIE = this.txtboxImie.Text;
                pracownik.TELEFON = this.txtboxTel.Text;
                pracownik.PESEL = this.txtboxPesel.Text;
                adrespracownik = pracownik.ADRESY_PRACOWNICY.First();
                adrespracownik.ULICA = this.txtboxUlica.Text;
                adrespracownik.NR_BUDYNKU = this.txtboxNrbudynku.Text;
                adrespracownik.NR_LOKALU = this.txtboxNrlokalu.Text;
                adrespracownik.KOD_POCZTOWY = this.txtboxKodpocztowy.Text;
                adrespracownik.ID_MIASTA = (int)cbMiasto.SelectedValue;
                adrespracownik.KRAJ = this.txtboxKraj.Text;
                //Zmienić na dodawanie nowego stanowiska
                if (chbEdycjaStanoiwska.Checked == true)
                {
                    STANOWISKO_PRACOWNICY pracownikstanowisko = new STANOWISKO_PRACOWNICY();
                    pracownikstanowisko.ID_STANOWISKO = (int)cbStanowisko.SelectedValue;
                    pracownikstanowisko.DATA_START = txtDataRozpoczeciaPracy.Value;
                    if (chbDataKoniec.Checked == true)
                    {
                        pracownikstanowisko.DATA_KONIEC = txtDataKoniec.Value;
                    }
                    pracownik.STANOWISKO_PRACOWNICY.Add(pracownikstanowisko);
                }
                db.SaveChanges();
                var bspracownicy = from p in db.PRACOWNICY
                                   join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                                   join s in db.STANOWISKO on sp.ID_STANOWISKO equals s.ID_STANOWISKO
                                   select new { p.ID_PRACOWNIK, p.NAZWISKO, p.IMIE, p.TELEFON, s.NAZWA };
                ListaPracownikow.DataSource = bspracownicy.ToList();
                ListaPracownikow.Refresh();
                czyscform();
            }
           
        }

        private void btnSzkolenia_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormSzkolenie szkolenie = new FormSzkolenie(db, ladowanieformularzazokienkami);
            szkolenie.Show();
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

        private void chbDataKoniec_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDataKoniec.Checked == true)
                txtDataKoniec.Show();
            else
                txtDataKoniec.Hide();
        }

        private void cbOkres_SelectedValueChanged(object sender, EventArgs e)
        {
            cbStawka.DataSource = db.STAWKA.Where(stawka => stawka.ID_OKRES.Equals(((OKRES)this.cbOkres.SelectedValue).ID_OKRES)).ToList();
            cbStawka.DisplayMember = "Wartosc";
            cbStawka.ValueMember = "Id_Stawka";
        }
    }
}
