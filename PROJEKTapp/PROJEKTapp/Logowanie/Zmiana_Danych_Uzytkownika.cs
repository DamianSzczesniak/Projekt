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
                txtBoxPESEL.Text = dane.IMIE + " " + dane.NAZWISKO + "  PESEL : " + dane.PESEL;
                cBPoziom.DataSource = db.UPRAWNIENIA.ToList();
                cBPoziom.ValueMember = "ID_UPRAWNIENIA";
                cBPoziom.DisplayMember = "NAZWA";
                cBPoziom.SelectedIndex = dane.UPRAWNIENIA - 1;
                
                txtBLogin.Text = dane.NAZWA_LOGOWANIE;
                txtBHaslo.Text = dane.HASLO;
            }
            else
            {
                txtBoxPESEL.Hide();

                var dict = new Dictionary<int, string>();
                foreach (PRACOWNICY row in db.PRACOWNICY.ToList())
                {
                    dict.Add(row.ID_PRACOWNIK, row.IMIE + " " + row.NAZWISKO + "  PESEL : " + row.PESEL);
                }
                cBPracownik.DataSource = dict.ToList();
                cBPracownik.ValueMember = "Key";
                cBPracownik.DisplayMember = "Value";
                

                //cBPracownik.DataSource = db.PRACOWNICY.ToList();
                //cBPracownik.ValueMember = "ID_PRACOWNIK";
                //cBPracownik.DisplayMember = "PESEL";
                cBPoziom.DataSource = db.UPRAWNIENIA.ToList();
                cBPoziom.ValueMember = "ID_UPRAWNIENIA";
                cBPoziom.DisplayMember = "NAZWA";
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
                try
                {
                    db.Entry(s).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Akcje zapisano pomyślne .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception esc)
                {
                   
                    KWZP_PROJEKTEntities nDB = new KWZP_PROJEKTEntities();
                    db = nDB;
                    db.Entry(s).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Akcje zapisano pomyślne .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                UZYTKOWNICY s = new UZYTKOWNICY();
                s.ID_PRACOWNIK = int.Parse(cBPracownik.SelectedValue.ToString());
                s.UPRAWNIENIA = int.Parse(cBPoziom.SelectedValue.ToString());
                s.NAZWA_LOGOWANIE = txtBLogin.Text;
                s.HASLO = txtBHaslo.Text;
                db.UZYTKOWNICY.Add(s);
                db.SaveChanges();
                this.Close();
            }
        }

        private void txtBoxPESEL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
