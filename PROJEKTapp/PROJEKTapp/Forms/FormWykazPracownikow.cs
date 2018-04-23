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
        //PRACOWNICY pracownik;
        KWZP_PROJEKTEntities db = new KWZP_PROJEKTEntities();//połaczenie z bazą danych

        public FormWykazPracownikow(KWZP_PROJEKTEntities db)
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormPracownicy Pracownicy = new FormPracownicy(db);
            Pracownicy.Show();
        }

        private void FormWykazPracownikow_Load(object sender, EventArgs e)
        {
            var bspracownicy = from p in db.PRACOWNICY
                               join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                               join s in db.STANOWISKO on sp.ID_STANOWISKO equals s.ID_STANOWISKO
                               select new { p.ID_PRACOWNIK, p.NAZWISKO, p.IMIE, p.TELEFON, s.NAZWA };
            this.ListaPracownikow.DataSource = bspracownicy.ToList();
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
        private void btnUsun_Click(object sender, EventArgs e)
        {
            var bspracownicy = from p in db.PRACOWNICY
                             join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                             join s in db.STANOWISKO on sp.ID_STANOWISKO equals s.ID_STANOWISKO
                             select new { p.ID_PRACOWNIK, p.NAZWISKO, p.IMIE, p.TELEFON, s.NAZWA };

            PracownikDane pracownik = new PracownikDane();
            pracownik.DeletePracownik(Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value));
            ListaPracownikow.DataSource = bspracownicy.ToList();
            ListaPracownikow.Refresh();
        }

        private void btnZaktualizuj_Click(object sender, EventArgs e)
        {
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

            PRACOWNICY pracownik = new PRACOWNICY();
            //PracownikDane pracownik = new PracownikDane();
            int Id_Pracownik = (Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value));
            //pracownik.WyswietlPracownik(Convert.ToInt32(ListaPracownikow.CurrentRow.Cells[0].Value));
            pracownik = (from p in db.PRACOWNICY
                         //from ad in p.ADRESY_PRACOWNICY
                         //join a in db.ADRESY_PRACOWNICY on ad.ID_ADRESU equals a.ID_ADRESU
                         where p.ID_PRACOWNIK==Id_Pracownik
                         select p).First();

            txtboxNazwisko.Text = pracownik.NAZWISKO;
            txtboxImie.Text = pracownik.IMIE;
            txtboxTel.Text = pracownik.TELEFON;
            txtboxPesel.Text = pracownik.PESEL;
            
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

            ListaPracownikow.Show();
            btnDodaj.Show();
            btnUsun.Show();
            btnZaktualizuj.Show();
            btnZaktualizaujZapisz.Hide();
            LWyszukaj.Text = "Wyszukaj nazwisko";
            txtWyszukajNazwisko.Clear();
        }
    }
}
