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
    public partial class FormRezerwacjaMaszyn : Form
    {
        KWZP_PROJEKTEntities db;
        DateTime data = new DateTime();
        int id;

        public FormRezerwacjaMaszyn(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            this.cboxWybierzZlecenie.DataSource = db.ZLECENIA.ToList();
            this.cboxWybierzZlecenie.DisplayMember = "ID_ZLECENIA";
        }

        private void btnExitRezerwacjaMaszyn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxWybierzZlecenie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RezerwujMaszyny_Click(object sender, EventArgs e)
        {
           List<CZAS_PRACY_MASZYN> CzasyPracy = this.db.CZAS_PRACY_MASZYN.Where(x => x.ID_ZLECENIA == ((ZLECENIA) cboxWybierzZlecenie.SelectedValue).ID_ZLECENIA).ToList();
        }
    }
}
