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
           //  = db.SPIS_UZYTKOWNIKOW.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (Zmiana_Danych_Uzytkownika zDU = new Zmiana_Danych_Uzytkownika(0, db))
            {
                //if (frmDEF.ShowDialog() == DialogResult.OK)
                //{
                //    FirmyBindingSource.DataSource = db.FIRMY.ToList();
                //    db.SaveChanges();
                //}
            }
        }
    }
}
