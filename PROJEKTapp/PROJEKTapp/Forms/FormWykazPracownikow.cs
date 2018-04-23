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
        PRACOWNICY pracownik;
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
            //usówanie rekordu
        }

        private void btnZaktualizuj_Click(object sender, EventArgs e)
        {
            //otwierania formularza do edycji, trzeba przypisać dane powiązane z zaznaczonym rzędem w ListaPracownikow + przciążenieformularza
            string id_pracownik = ListaPracownikow.CurrentRow.Cells[0].Value.ToString();
            FormPracownicy Pracownicy = new FormPracownicy(db, id_pracownik);
            Pracownicy.Show();
        }

    }
}
