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
    public partial class PracStan : Form
    {
        KWZP_PROJEKTEntities db = new KWZP_PROJEKTEntities();
        public PracStan(KWZP_PROJEKTEntities kwzpProjektEntitie)
        {
            InitializeComponent();
            cbStanowisko.DataSource = db.STANOWISKO.ToList();
            cbStanowisko.DisplayMember = "Nazwa";
            cbStanowisko.ValueMember = "Id_Stanowisko";
        }

        private void PracStan_Load(object sender, EventArgs e)
        {
            this.dgwPracStan.DataSource = db.PRACOWNICY_STANOWISKA.Where(x => x.NAZWISKO.StartsWith(txtWyszukaj.Text))
                .Where(x=> x.STANOWISKO.Equals(cbStanowisko.Text)).ToList();
        }

        private void cbStanowisko_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgwPracStan.DataSource = db.PRACOWNICY_STANOWISKA.Where(x => x.NAZWISKO.StartsWith(txtWyszukaj.Text))
                .Where(x => x.STANOWISKO.Equals(cbStanowisko.Text)).ToList();
        }

        private void txtWyszukaj_TextChanged(object sender, EventArgs e)
        {
            this.dgwPracStan.DataSource = db.PRACOWNICY_STANOWISKA.Where(x => x.NAZWISKO.StartsWith(txtWyszukaj.Text))
                            .Where(x => x.STANOWISKO.Equals(cbStanowisko.Text)).ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
