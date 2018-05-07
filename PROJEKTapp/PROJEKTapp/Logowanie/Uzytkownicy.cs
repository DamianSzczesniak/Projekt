using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Logowanie
{
    public partial class Uzytkownicy : Form
    {
        KWZP_PROJEKTEntities db;
        public Uzytkownicy(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void Uzytkownicy_Load(object sender, EventArgs e)
        {
            sPISUZYTKOWNIKOWBindingSource.DataSource = db.SPIS_UZYTKOWNIKOW.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {


            using (Zmiana_Danych_Uzytkownika zDU = new Zmiana_Danych_Uzytkownika(null, db))
            {
                if (zDU.ShowDialog() == DialogResult.OK)
                {
                    KWZP_PROJEKTEntities ndb = new KWZP_PROJEKTEntities();

                    db = ndb;
                    sPISUZYTKOWNIKOWBindingSource.DataSource = db.SPIS_UZYTKOWNIKOW.ToList();
                }
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            SPIS_UZYTKOWNIKOW dane = sPISUZYTKOWNIKOWBindingSource.Current as SPIS_UZYTKOWNIKOW;

            using (Zmiana_Danych_Uzytkownika zDU = new Zmiana_Danych_Uzytkownika(dane, db))
            {
                if (zDU.ShowDialog() == DialogResult.OK)
                {
                    KWZP_PROJEKTEntities ndb = new KWZP_PROJEKTEntities();

                    db = ndb;
                    sPISUZYTKOWNIKOWBindingSource.DataSource = db.SPIS_UZYTKOWNIKOW.ToList();

                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy jesteś pewien że chcesz usunąć ten rekord?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SPIS_UZYTKOWNIKOW dane = sPISUZYTKOWNIKOWBindingSource.Current as SPIS_UZYTKOWNIKOW;
                var user = db.UZYTKOWNICY.FirstOrDefault(u => u.ID_UZYTKOWNIKA == dane.ID_UZYTKOWNIKA);
                try
                {
                    db.UZYTKOWNICY.Remove(user);
                    db.SaveChanges();
                  
                    KWZP_PROJEKTEntities ndb = new KWZP_PROJEKTEntities();
                    db = ndb;
                    sPISUZYTKOWNIKOWBindingSource.DataSource = db.SPIS_UZYTKOWNIKOW.ToList();

                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException exc)
                {
                    db.UZYTKOWNICY.Attach(user);
                    MessageBox.Show("Te Konto Uzytowniak jest referencją dla innych danych, nie można jej usunąć.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
