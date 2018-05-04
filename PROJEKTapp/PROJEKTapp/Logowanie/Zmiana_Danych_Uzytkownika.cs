using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Logowanie
{
    public partial class Zmiana_Danych_Uzytkownika : Form
    {
        KWZP_PROJEKTEntities db;
        SPIS_UZYTKOWNIKOW dane;
        public Zmiana_Danych_Uzytkownika(SPIS_UZYTKOWNIKOW dane, KWZP_PROJEKTEntities db)
        {
            this.db = db;
            this.dane = dane;
            InitializeComponent();
        }

        private void Zmiana_Danych_Uzytkownika_Load(object sender, EventArgs e)
        {
            if (dane != null)
            {
                cBPracownik.Hide();
                txtBoxPESEL.Text = dane.PESEL;
                cBPoziom.DataSource = db.UPRAWNIENIA.ToList();
                cBPoziom.ValueMember = "ID_UPRAWNIENIA";
                cBPoziom.DisplayMember = "NAZWA";
                cBPoziom.SelectedIndex = dane.UPRAWNIENIA - 1;
                txtBLogin.Text = dane.NAZWA_LOGOWANIE;
                txtBHaslo.Text = dane.HASLO;
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (dane != null)
            {
                UZYTKOWNICY s = new UZYTKOWNICY();
                s.ID_PRACOWNIK = dane.ID_PRACOWNIK;
                s.UPRAWNIENIA = int.Parse(cBPoziom.SelectedValue.ToString());
                s.NAZWA_LOGOWANIE = txtBLogin.Text;
                s.HASLO = txtBHaslo.Text;
                s.ID_UZYTKOWNIKA = dane.ID_UZYTKOWNIKA;
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
