using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Forms_NoweZlecenie
{
    public partial class HistoriaStatusyZlecenia : Form
    {
        KWZP_PROJEKTEntities db;
        AKTUALNY_STATUS_ZLECEN_NAZWY aKTUALNY_STATUS;
        public HistoriaStatusyZlecenia(KWZP_PROJEKTEntities db, AKTUALNY_STATUS_ZLECEN_NAZWY aKTUALNY_STATUS)
        {
            this.db = db;
            this.aKTUALNY_STATUS = aKTUALNY_STATUS;
            InitializeComponent();
        }

        private void HistoriaStatusyZlecenia_Load(object sender, EventArgs e)
        {
            var s = db.HISTORIA_STATUS_ZLECENIA.Where(h => h.ID_ZLECENIA == aKTUALNY_STATUS.ID_ZLECENIA);
            hISTORIASTATUSZLECENIABindingSource.DataSource = s.ToList() ;
        }
    }
}
