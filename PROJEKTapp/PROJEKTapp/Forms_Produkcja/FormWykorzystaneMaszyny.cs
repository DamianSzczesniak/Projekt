using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Forms_Produkcja
{
    public partial class FormWykorzystaneMaszyny : Form
    {
        string tryb;
        KWZP_PROJEKTEntities db;

        public FormWykorzystaneMaszyny(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnExitWykorzystaneMaszyny_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormWykorzystaneMaszyny_Load(object sender, EventArgs e)
        {
            this.GridWykorzystaneMaszyny.DataSource = db.WYKORZYSTANE_MASZYNY.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
        }

        private void txtNazwaProduktu_TextChanged(object sender, EventArgs e)
        {
            if (tryb == "Wykorzystane Maszyny")
            {
                this.GridWykorzystaneMaszyny.DataSource = db.WYKORZYSTANE_MASZYNY.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
            }
            else if (tryb == "Wykorzystane Narzędzia")
            {
                this.GridWykorzystaneMaszyny.DataSource = db.WYKORZYSTANE_NARZEDZIA.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
            }
            else
            {
                this.GridWykorzystaneMaszyny.DataSource = db.WYKORZYSTANE_PROCESY.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
            }
        }

        private void cboxWybierzTryb_SelectedIndexChanged(object sender, EventArgs e)
        {
            tryb = cboxWybierzTryb.Text.ToString();


            if (tryb == "Wykorzystane Maszyny")
            {
                this.GridWykorzystaneMaszyny.DataSource = db.WYKORZYSTANE_MASZYNY.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
            }
            else if (tryb == "Wykorzystane Narzędzia")
            {
                this.GridWykorzystaneMaszyny.DataSource = db.WYKORZYSTANE_NARZEDZIA.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
            }
            else
            {
                this.GridWykorzystaneMaszyny.DataSource = db.WYKORZYSTANE_PROCESY.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
            }
        }

        private void lblNazwaProduktu_Click(object sender, EventArgs e)
        {

        }

        private void GridWykorzystaneMaszyny_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTrybFiltracji_Click(object sender, EventArgs e)
        {

        }
    }
}
