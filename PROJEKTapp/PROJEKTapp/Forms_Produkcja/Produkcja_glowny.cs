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

    public partial class Produkcja_glowny : Form
    {
        KWZP_PROJEKTEntities db;
        DateTime data = DateTime.Today;
        public Produkcja_glowny(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnExitProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWykorzystaneMaszyny_Click(object sender, EventArgs e)
        {
            Forms_Produkcja.FormWykorzystaneMaszyny WykorzystaneMaszyny = new Forms_Produkcja.FormWykorzystaneMaszyny(db);
            WykorzystaneMaszyny.Show();
        }

        private void btnEwidencja_Click(object sender, EventArgs e)
        {
            Forms_Produkcja.FormObciazenie obciazenie = new Forms_Produkcja.FormObciazenie(db);
            obciazenie.Show();
        }

        private void btnGabaryty_Click(object sender, EventArgs e)
        {
            Forms_Produkcja.FormGabaryty gabaryty = new Forms_Produkcja.FormGabaryty(db);
            gabaryty.Show();
        }

        private void Produkcja_glowny_Load(object sender, EventArgs e)
        {
            ladowanieDanych();
        }
        
        private void ladowanieDanych()
        {
            List<int> listID = new List<int>();
            List<PRACOWNICY_STANOWISKA> pracownicyNaStanowiska = new List<PRACOWNICY_STANOWISKA>();
            pRACOWNICYWPRACYBindingSource.DataSource = db.PRACOWNICY_W_PRACY.Where(x => x.DATA_DZIEN == data).ToList();
            List<PRACOWNICY_W_PRACY> pracownicWPracy = db.PRACOWNICY_W_PRACY.Where(x => x.DATA_DZIEN == data).ToList();
            foreach (PRACOWNICY_W_PRACY element in pracownicWPracy)
            {
                int id = element.ID_PRACOWNIK;
                listID.Add(id);
            }
            List<PRACOWNICY_STANOWISKA> pRACOWNICY_STANOWISKAs = db.PRACOWNICY_STANOWISKA.Where(x => x.ID_PRACOWNIK <= 10).ToList();
            foreach (PRACOWNICY_STANOWISKA element in pRACOWNICY_STANOWISKAs)
            {
               if(!listID.Contains(element.ID_PRACOWNIK))
                {
                    pracownicyNaStanowiska.Add(element);
                }
            }

            pRACOWNICYSTANOWISKABindingSource.DataSource = pracownicyNaStanowiska;


        }

        private void btnEwidencjaMaszyn_Click(object sender, EventArgs e)
        {
            Forms_Produkcja.FormSpis spis = new Forms_Produkcja.FormSpis(db);
            spis.Show();
        }

        private void btnDodajPracownika_Click(object sender, EventArgs e)
        {
            PRACOWNICY_STANOWISKA wybranyPracownik;
            wybranyPracownik = pRACOWNICYSTANOWISKABindingSource.Current as PRACOWNICY_STANOWISKA;
            REALIZACJA_PRODUKCJA realizacja = db.REALIZACJA_PRODUKCJA.Where(x => x.DATA_DZIEN == data).First();
            ZESPOL_LUDZI pracownikDoWpisania = new ZESPOL_LUDZI();
            pracownikDoWpisania.ID_REALIZACJA_PRODUKCJA = realizacja.ID_REALIZACJA_PRODUKCJA;
            pracownikDoWpisania.ID_PRACOWNIK = wybranyPracownik.ID_PRACOWNIK;
            db.ZESPOL_LUDZI.Add(pracownikDoWpisania);
            db.SaveChanges();
            KWZP_PROJEKTEntities ndb = new KWZP_PROJEKTEntities();
            db = ndb;
            db.PRACOWNICY_W_PRACY = ndb.PRACOWNICY_W_PRACY;
            db.SaveChanges();
            ladowanieDanych();

        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            PRACOWNICY_W_PRACY wybranyPracownik;
            wybranyPracownik = pRACOWNICYWPRACYBindingSource.Current as PRACOWNICY_W_PRACY;
            REALIZACJA_PRODUKCJA realizacja = db.REALIZACJA_PRODUKCJA.Where(x => x.DATA_DZIEN == data).First();
            ZESPOL_LUDZI usun = db.ZESPOL_LUDZI.Where(x=> x.ID_PRACOWNIK == wybranyPracownik.ID_PRACOWNIK && x.ID_REALIZACJA_PRODUKCJA == realizacja.ID_REALIZACJA_PRODUKCJA).First();
            db.ZESPOL_LUDZI.Remove(usun);
            db.SaveChanges();
            KWZP_PROJEKTEntities ndb = new KWZP_PROJEKTEntities();
            db = ndb;
            db.PRACOWNICY_W_PRACY = ndb.PRACOWNICY_W_PRACY;
            db.SaveChanges();
            ladowanieDanych();
        }
    }
}
