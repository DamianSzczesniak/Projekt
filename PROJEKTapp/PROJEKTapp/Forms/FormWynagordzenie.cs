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
    public partial class FormWynagordzenie : Form
    {
        KWZP_PROJEKTEntities db;
        bool ladowanieformularzazokienkami;

        public FormWynagordzenie(KWZP_PROJEKTEntities db, bool ladowanieformularzazokienkami)
        {
            this.db = db;
            this.ladowanieformularzazokienkami = ladowanieformularzazokienkami;
            InitializeComponent();

        }
        private void Ladowanie_DgvWyplaty()
        {
            dgvWyplaty.DataSource = db.PENSJE.Where(miesiac => miesiac.DATA_START < dtpMiesiac.Value).Where(datakoniec => datakoniec.DATA_KONIEC > dtpMiesiac.Value || datakoniec.DATA_KONIEC == null).ToList();
            dgvWyplaty.Columns[0].Visible = false;
            dgvWyplaty.Columns[3].Visible = false;
            dgvWyplaty.Columns[4].Visible = false;
            dgvWyplaty.Columns[5].Visible = false;
            dgvWyplaty.Columns[7].Visible = false;
            dgvWyplaty.Columns[8].Visible = false;
            dgvWyplaty.Columns[6].DefaultCellStyle.Format = "c2";
        }
        private void FormWynagordzenie_Load(object sender, EventArgs e)
        {
            if (ladowanieformularzazokienkami == true)
            {
                pnlWynagordzenia.Show();
                Ladowanie_DgvWyplaty();
            }
            else
            {
                pnlWynagordzenia.Hide();
            }
        }

        private void txtWyszukajNazwisko_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtWyszukajNazwisko.Text))
            {
                this.dgvWyplaty.DataSource = db.PENSJE.Where(miesiac => miesiac.DATA_START < dtpMiesiac.Value).Where(datakoniec => datakoniec.DATA_KONIEC > dtpMiesiac.Value || datakoniec.DATA_KONIEC == null).ToList();
            }
            else
            {
                this.dgvWyplaty.DataSource = db.PENSJE.Where(miesiac => miesiac.DATA_START < dtpMiesiac.Value).Where(datakoniec => datakoniec.DATA_KONIEC > dtpMiesiac.Value || datakoniec.DATA_KONIEC == null).Where(x => x.NAZWISKO.StartsWith(txtWyszukajNazwisko.Text)).ToList();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPracownicy_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormKadry kadry = new FormKadry(db, ladowanieformularzazokienkami);
            kadry.Show();
            this.Close();
        }

        private void btnWynagrodzenia_Click(object sender, EventArgs e)
        {
            if (ladowanieformularzazokienkami == true)
            {
                ladowanieformularzazokienkami = false;
                pnlWynagordzenia.Show();
            }
            else
            {
                ladowanieformularzazokienkami = true;
                pnlWynagordzenia.Hide();
            }
        }
            private void btnUrlopy_Click(object sender, EventArgs e)
            {
                ladowanieformularzazokienkami = true;
                FormUrlopy urlopy = new FormUrlopy(db, ladowanieformularzazokienkami);
                urlopy.Show();
                this.Close();
            }

            private void btnSzkolenia_Click(object sender, EventArgs e)
            {
            ladowanieformularzazokienkami = true;
                FormSzkolenie szkolenie = new FormSzkolenie(db, ladowanieformularzazokienkami);
                szkolenie.Show();
                this.Close();
            }

        private void btnStatystyki_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormStatystyki statystyki = new FormStatystyki(db, ladowanieformularzazokienkami);
            statystyki.Show();
            this.Close();
        }

        private void dtpMiesiac_ValueChanged(object sender, EventArgs e)
        {
            Ladowanie_DgvWyplaty();
        }
    }
}


