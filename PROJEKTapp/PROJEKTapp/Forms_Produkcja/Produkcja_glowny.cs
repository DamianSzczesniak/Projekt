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
        DateTime data = new DateTime();
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

        private void btnEwidencjaMaszyn_Click(object sender, EventArgs e)
        {
            Forms_Produkcja.FormEwidencja ewidencja = new Forms_Produkcja.FormEwidencja(db);
            ewidencja.Show();
        }

        private void btnRezerwacjaMaszyn_Click(object sender, EventArgs e)
        {
            Forms_Produkcja.FormRezerwacjaMaszyn rezerwacja = new Forms_Produkcja.FormRezerwacjaMaszyn(db);
            rezerwacja.Show();
        }

        private void Produkcja_glowny_Load(object sender, EventArgs e)
        {
            GridPracownicyWPracy.DataSource = db.PRACOWNICY_W_PRACY.Where(x => x.DATA_DZIEN == data).ToList();
        }
    }
}
