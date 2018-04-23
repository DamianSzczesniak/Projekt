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

    public partial class FormObciazenie : Form
    {
        string data;
        string tryb = "Obciążenie Maszyn";
        KWZP_PROJEKTEntities db = new KWZP_PROJEKTEntities();

        public FormObciazenie(KWZP_PROJEKTEntities kwzpProjektEntities)
        {
            InitializeComponent();
        }

        private void FormObciazenie_Load(object sender, EventArgs e)
        {
            data = dateWybierzDate.Value.ToShortDateString();
            this.GridObciazenie.DataSource = db.OBCIAZENIE_MASZYN.Where(x => x.DATA_DZIEN.ToString().Equals(data)).ToList();
        }

        private void btnExitObciazenie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tryb = cboxTryb.Text.ToString();
            if (tryb == "Obciążenie Maszyn")
            {
                this.GridObciazenie.DataSource = db.OBCIAZENIE_MASZYN.Where(x => x.DATA_DZIEN.ToString().Equals(data)).ToList();
            }
            else
            {
                this.GridObciazenie.DataSource = db.OBCIAZENIE_NARZEDZI.Where(x => x.DATA_DZIEN.ToString().Equals(data)).ToList();
            }
        }

        private void dateWybierzDate_ValueChanged(object sender, EventArgs e)
        {
            data = dateWybierzDate.Value.ToShortDateString();

            if (tryb == "Obciążenie Maszyn")
            {
                this.GridObciazenie.DataSource = db.OBCIAZENIE_MASZYN.Where(x => x.DATA_DZIEN.ToString().Equals(data)).ToList();
            }
            else
            {
                this.GridObciazenie.DataSource = db.OBCIAZENIE_NARZEDZI.Where(x => x.DATA_DZIEN.ToString().Equals(data)).ToList();
            }
        }
    }
}
