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
    public partial class ZmianaHasla : Form
    {
        KWZP_PROJEKTEntities db;
        int id_uzytkownika;

        public ZmianaHasla(KWZP_PROJEKTEntities db, int id_uzytkownika)
        {
            this.db = db;
            this.id_uzytkownika = id_uzytkownika;
            InitializeComponent();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            var user = db.UZYTKOWNICY.FirstOrDefault(u => u.ID_UZYTKOWNIKA == id_uzytkownika);
            if (user.HASLO == txtBoxAHaslo.Text)
            {
                user.HASLO = txtBoxNHaslo.Text;
                MessageBox.Show("Hasło zostało poprawnie zmienione. ", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Podano niepoprawne aktualne hasło. ", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
    }
}
