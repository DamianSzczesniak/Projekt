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
    public partial class FormWykazPracownikow : Form
    {
        KWZP_PROJEKTEntities db = new KWZP_PROJEKTEntities(); //połaczenie z bazą danych

        public FormWykazPracownikow(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            btnDodaj.Font = new Font(btnDodaj.Font.FontFamily, 9);
            btnZaktualizuj.Font = new Font(btnZaktualizuj.Font.FontFamily, 9);
            btnUsun.Font = new Font(btnUsun.Font.FontFamily, 9);

            cbStanowisko.DataSource = db.STANOWISKO.ToList();
            cbStanowisko.DisplayMember = "Nazwa";
            cbStanowisko.ValueMember = "Id_Stanowisko";

            cbMiasto.DataSource = db.MIASTA.ToList();
            cbMiasto.DisplayMember = "Nazwa";
            cbMiasto.ValueMember = "Id_Miasta";

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e) //pokazuje pola do dodawania pracownika
        {
            lblImie.Show();
            txtboxPesel.Show();
            lblNazwisko.Show();
            lblTel.Show();
            lblPesel.Show();
            lblUlica.Show();
            lblNrbudynku.Show();
            lblNrlokalu.Show();
            lblKodpocztowy.Show();
            lblMiasto.Show();
            lblKraj.Show();
            lblStanowisko.Show();
            lblDataStart.Show();
            txtboxImie.Show();
            txtboxNazwisko.Show();
            txtboxTel.Show();
            txtboxUlica.Show();
            txtNrbudynku.Show();
            txtboxNrlokalu.Show();
            txtboxKodpocztowy.Show();
            cbMiasto.Show();
            txtboxKraj.Show();
            cbStanowisko.Show();
            txtDataRozpoczeciaPracy.Show();
            ListaPracownikow.Hide();
            btnDodaj.Hide();
            btnUsun.Hide();
            btnZaktualizuj.Hide();
            btnZaktualizaujZapisz.Hide();
            LWyszukaj.Text = "Dodawanie pracownika";
            txtWyszukajNazwisko.Hide();
            btnWyczysc.Show();
            btnDodajZapisz.Show();
            btnAnuluj.Show();
        }

        private void Insertpracownik(string nazwisko, string imie, string telefon, string pesel,
            string ulica, string nrbudynku, string nrlokalu, string kodpocztowy, int miasto, string kraj,
            DateTime data, int stanowisko)
        {
            PracownikDane pracownikdane = new PracownikDane();
            pracownikdane.Add(nazwisko, imie, telefon, pesel, ulica, nrbudynku, nrlokalu, kodpocztowy, miasto, kraj, data, stanowisko);
        }

        private void btnDodajZapisz_Click(object sender, EventArgs e) //zapisuje dodanego pracownika
        {
            if (txtboxImie.Text == "" || txtboxNazwisko.Text == "" || txtboxTel.Text == "" || txtboxPesel.Text == "" || txtboxUlica.Text == "" || txtNrbudynku.Text == "" || txtboxNrlokalu.Text == "" || txtboxKodpocztowy.Text == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola");
            }
            else
            {
                Insertpracownik(txtboxNazwisko.Text,
                                  txtboxImie.Text,
                                  txtboxTel.Text,
                                  txtboxPesel.Text,
                                  txtboxUlica.Text,
                                  txtNrbudynku.Text,
                                  txtboxNrlokalu.Text,
                                  txtboxKodpocztowy.Text,
                                  (int)cbMiasto.SelectedValue,
                                  txtboxKraj.Text,
                                  txtDataRozpoczeciaPracy.Value,
                                  (int)cbStanowisko.SelectedValue);
                lblImie.Hide();
                txtboxPesel.Hide();
                lblNazwisko.Hide();
                lblTel.Hide();
                lblPesel.Hide();
                lblUlica.Hide();
                lblNrbudynku.Hide();
                lblNrlokalu.Hide();
                lblKodpocztowy.Hide();
                lblMiasto.Hide();
                lblKraj.Hide();
                lblStanowisko.Hide();
                lblDataStart.Hide();
                txtboxImie.Hide();
                txtboxNazwisko.Hide();
                txtboxTel.Hide();
                txtboxUlica.Hide();
                txtNrbudynku.Hide();
                txtboxNrlokalu.Hide();
                txtboxKodpocztowy.Hide();
                cbMiasto.Hide();
                txtboxKraj.Hide();
                cbStanowisko.Hide();
                txtDataRozpoczeciaPracy.Hide();
                btnWyczysc.Hide();
                btnDodajZapisz.Hide();
                btnAnuluj.Hide();
                ListaPracownikow.Show();
                btnDodaj.Show();
                btnUsun.Show();
                btnZaktualizuj.Show();
                btnZaktualizaujZapisz.Hide();
                LWyszukaj.Text = "Wyszukaj nazwisko";
                txtWyszukajNazwisko.Clear();
                txtboxNazwisko.Clear();
                txtboxImie.Clear();
                txtboxKodpocztowy.Clear();
                txtboxTel.Clear();
                txtboxPesel.Clear();
                txtboxUlica.Clear();
                txtNrbudynku.Clear();
                txtboxNrlokalu.Clear();
                var bspracownicy = from p in db.PRACOWNICY
                                   join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                                   join s in db.STANOWISKO on sp.ID_STANOWISKO equals s.ID_STANOWISKO
                                   select new { p.ID_PRACOWNIK, p.NAZWISKO, p.IMIE, p.TELEFON, s.NAZWA };
                ListaPracownikow.DataSource = bspracownicy.ToList();
                ListaPracownikow.Refresh();
            }
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            txtboxNazwisko.Clear();
            txtboxImie.Clear();
            txtboxKodpocztowy.Clear();
            txtboxTel.Clear();
            txtboxPesel.Clear();
            txtboxUlica.Clear();
            txtNrbudynku.Clear();
            txtboxNrlokalu.Clear();
        }

        private void FormWykazPracownikow_Load(object sender, EventArgs e)
        {
            ListaPracownikow.Font = new Font("Tahoma", 12);
            
            var bspracownicy = from p in db.PRACOWNICY
                               join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                               join s in db.STANOWISKO on sp.ID_STANOWISKO equals s.ID_STANOWISKO
                               select new { p.ID_PRACOWNIK, p.NAZWISKO, p.IMIE, p.TELEFON, s.NAZWA };
            this.ListaPracownikow.DataSource = bspracownicy.ToList();
        }

        private void txtWyszukajNazwisko_TextChanged(object sender, EventArgs e) //Wyszukiwarka po nazwisku
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
        private void btnUsun_Click(object sender, EventArgs e)
        {
           PracownikDane pracownik = new PracownikDane();
            DialogResult result = MessageBox.Show("Czy chcesz usunąć dane pracownika: " + ListaPracownikow.CurrentRow.Cells[1].Value + " " + ListaPracownikow.CurrentRow.Cells[2].Value, "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var bspracownicy = from p in db.PRACOWNICY
                                   join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                                   join s in db.STANOWISKO on sp.ID_STANOWISKO equals s.ID_STANOWISKO
                                   select new { p.ID_PRACOWNIK, p.NAZWISKO, p.IMIE, p.TELEFON, s.NAZWA };

                pracownik.DeletePracownik(Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value));
                ListaPracownikow.DataSource = bspracownicy.ToList();
                ListaPracownikow.Refresh();
            }
        }

        private void btnZaktualizuj_Click(object sender, EventArgs e) //otwiera pola potrzeben do edycji pracownika
        {
            btnAnuluj.Show();
            lblImie.Show();
            lblNazwisko.Show();
            lblTel.Show();
            lblPesel.Show();
            lblUlica.Show();
            lblNrbudynku.Show();
            lblNrlokalu.Show();
            lblKodpocztowy.Show();
            lblMiasto.Show();
            lblKraj.Show();
            lblStanowisko.Show();
            lblDataStart.Show();
            txtboxImie.Show();
            txtboxNazwisko.Show();
            txtboxTel.Show();
            txtboxPesel.Show();
            txtboxUlica.Show();
            txtNrbudynku.Show();
            txtboxNrlokalu.Show();
            txtboxKodpocztowy.Show();
            cbMiasto.Show();
            txtboxKraj.Show();
            cbStanowisko.Show();
            txtDataRozpoczeciaPracy.Show();
            ListaPracownikow.Hide();
            btnDodaj.Hide();
            btnUsun.Hide();
            btnZaktualizuj.Hide();
            btnZaktualizaujZapisz.Show();
            LWyszukaj.Text = "Pracownik";
            txtWyszukajNazwisko.Text = ListaPracownikow.CurrentRow.Cells[1].Value.ToString();
            btnWyczysc.Hide();
            btnDodajZapisz.Hide();
            txtboxNazwisko.Clear();
            txtboxImie.Clear();
            txtboxKodpocztowy.Clear();
            txtboxTel.Clear();
            txtboxPesel.Clear();
            txtboxUlica.Clear();
            txtNrbudynku.Clear();
            txtboxNrlokalu.Clear();

            PRACOWNIK_DANE pracownikDane = new PRACOWNIK_DANE();
            int Id_Pracownik = (Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value));
            pracownikDane = (from p in db.PRACOWNIK_DANE
                             where p.ID_PRACOWNIK == Id_Pracownik
                             select p).First();

            txtboxNazwisko.Text = pracownikDane.NAZWISKO;
            txtboxImie.Text = pracownikDane.IMIE;
            txtboxTel.Text = pracownikDane.TELEFON;
            txtboxPesel.Text = pracownikDane.PESEL;
            txtboxUlica.Text = pracownikDane.ULICA;
            txtboxNrlokalu.Text = pracownikDane.NR_LOKALU;
            txtNrbudynku.Text = pracownikDane.NR_BUDYNKU;
            txtboxKodpocztowy.Text = pracownikDane.KOD_POCZTOWY;
            cbMiasto.Text = pracownikDane.MIASTO;
            txtboxKraj.Text = pracownikDane.KRAJ;
            cbStanowisko.Text = pracownikDane.STANOWISKO;
            txtDataRozpoczeciaPracy.Value = pracownikDane.DATA_START;
        }

        private void UpdatePracownik(int ID, string nazwisko, string imie, string telefon, string pesel, string ulica, string nrbudynku, string nrlokalu, string kodpocztowy, int miasto, string kraj)
        {
            PracownikDane pracownikdane = new PracownikDane();
            pracownikdane.UpdatePracownik(ID, nazwisko, imie, telefon, pesel, ulica, nrbudynku, nrlokalu, kodpocztowy, miasto, kraj);
        }
        private void btnZaktualizaujZapisz_Click(object sender, EventArgs e)
        {
            lblImie.Hide();
            lblNazwisko.Hide();
            lblTel.Hide();
            lblPesel.Hide();
            lblUlica.Hide();
            lblNrbudynku.Hide();
            lblNrlokalu.Hide();
            lblKodpocztowy.Hide();
            lblMiasto.Hide();
            lblKraj.Hide();
            lblStanowisko.Hide();
            lblDataStart.Hide();
            txtboxImie.Hide();
            txtboxPesel.Hide();
            txtboxNazwisko.Hide();
            txtboxTel.Hide();
            txtboxUlica.Hide();
            txtNrbudynku.Hide();
            txtboxNrlokalu.Hide();
            txtboxKodpocztowy.Hide();
            cbMiasto.Hide();
            txtboxKraj.Hide();
            cbStanowisko.Hide();
            txtDataRozpoczeciaPracy.Hide();
            btnWyczysc.Hide();
            btnDodajZapisz.Hide();

            int ID = (Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value));
            //// pracownikDane.STANOWISKO = (int)cbStanowisko.SelectedValue;
            // pracownikDane.DATA_START = this.txtDataRozpoczeciaPracy.Value;
            // //UpdatePracownik(pracownikDane);

            UpdatePracownik(ID, txtboxNazwisko.Text, txtboxImie.Text, txtboxTel.Text, txtboxPesel.Text, txtboxUlica.Text, txtNrbudynku.Text, txtboxNrlokalu.Text, txtboxKodpocztowy.Text, (int)cbMiasto.SelectedValue, txtboxKraj.Text);

            ListaPracownikow.Show();
            btnDodaj.Show();
            btnUsun.Show();
            btnZaktualizuj.Show();
            btnAnuluj.Hide();
            btnZaktualizaujZapisz.Hide();
            LWyszukaj.Text = "Wyszukaj nazwisko";
            txtWyszukajNazwisko.Clear();
            txtboxNazwisko.Clear();
            txtboxImie.Clear();
            txtboxKodpocztowy.Clear();
            txtboxTel.Clear();
            txtboxPesel.Clear();
            txtboxUlica.Clear();
            txtNrbudynku.Clear();
            txtboxNrlokalu.Clear();
        }

        private void btnAnuluj_Click(object sender, EventArgs e) //anuluj dodawanie
        {
            ListaPracownikow.Show();
            txtboxPesel.Hide();
            btnDodaj.Show();
            btnUsun.Show();
            btnZaktualizuj.Show();
            lblImie.Hide();
            lblNazwisko.Hide();
            lblTel.Hide();
            lblPesel.Hide();
            lblUlica.Hide();
            lblNrbudynku.Hide();
            lblNrlokalu.Hide();
            lblKodpocztowy.Hide();
            lblMiasto.Hide();
            lblKraj.Hide();
            lblStanowisko.Hide();
            lblDataStart.Hide();
            txtboxImie.Hide();
            txtboxNazwisko.Hide();
            txtboxTel.Hide();
            txtboxUlica.Hide();
            txtNrbudynku.Hide();
            txtboxNrlokalu.Hide();
            txtboxKodpocztowy.Hide();
            cbMiasto.Hide();
            txtboxKraj.Hide();
            cbStanowisko.Hide();
            txtDataRozpoczeciaPracy.Hide();
            btnWyczysc.Hide();
            btnDodajZapisz.Hide();
            btnAnuluj.Hide();
            ListaPracownikow.Show();
            btnDodaj.Show();
            btnUsun.Show();
            btnZaktualizuj.Show();
            btnZaktualizaujZapisz.Hide();
            LWyszukaj.Text = "Wyszukaj nazwisko";
            txtWyszukajNazwisko.Show();
            txtWyszukajNazwisko.Clear();
            txtboxNazwisko.Clear();
            txtboxImie.Clear();
            txtboxKodpocztowy.Clear();
            txtboxTel.Clear();
            txtboxPesel.Clear();
            txtboxUlica.Clear();
            txtNrbudynku.Clear();
            txtboxNrlokalu.Clear();
        }
    }
}
