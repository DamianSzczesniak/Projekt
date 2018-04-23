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
    public partial class FormGabaryty : Form
    {
        KWZP_PROJEKTEntities db = new KWZP_PROJEKTEntities();
        string tryb = "Masa";

        public FormGabaryty(KWZP_PROJEKTEntities kwzpProjektEntities)
        {
            InitializeComponent();
        }

        private void btnExitGabaryty_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxTryb_SelectedIndexChanged(object sender, EventArgs e)
        {
            tryb = cboxTryb.Text.ToString();
            if (tryb == "Wymiar")
            {
                this.GridMasaWymiar.DataSource = db.GABARYT_PRODUTKU.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
            }
            else
            {
                this.GridMasaWymiar.DataSource = db.MASA_PRODUKTU.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
            }
        }

        private void FormGabaryty_Load(object sender, EventArgs e)
        {
            if (tryb == "Wymiar")
            {
                this.GridMasaWymiar.DataSource = db.GABARYT_PRODUTKU.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
            }
            else
            {
                this.GridMasaWymiar.DataSource = db.MASA_PRODUKTU.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
            }
        }

        private void txtNazwaProduktu_TextChanged(object sender, EventArgs e)
        {
            if (tryb == "Wymiar")
            {
                this.GridMasaWymiar.DataSource = db.GABARYT_PRODUTKU.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
            }
            else
            {
                this.GridMasaWymiar.DataSource = db.MASA_PRODUKTU.Where(x => x.NAZWA_PRODUKTU.StartsWith(txtNazwaProduktu.Text)).ToList();
            }
        }
    }
}
