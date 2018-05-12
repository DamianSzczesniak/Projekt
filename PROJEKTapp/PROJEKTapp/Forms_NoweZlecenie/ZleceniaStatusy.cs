using PROJEKTapp.Forms_NoweZlecenie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp
{
    public partial class ZleceniaStatusy : Form
    {
        KWZP_PROJEKTEntities db;
        int uprawnienia;
        public ZleceniaStatusy(KWZP_PROJEKTEntities db, int uprawnienia)
        {
            this.db = db;
            this.uprawnienia = uprawnienia;


            InitializeComponent();
        }

        private void ZleceniaStatusy_Load(object sender, EventArgs e)
        {
            // StatusZleceniaDGV.DataSource = db.AKTUALNY_STATUS_ZLECEN_NAZWY.ToList();

            SprawdzanieUprawnien(uprawnienia);

        }


        public void SprawdzanieUprawnien(int uprawnienia)
        {
            switch (uprawnienia)
            {
                case 1:
                    statusdetalezlecenieBindingSource.DataSource = db.Status_detale_zlecenie.ToList();
                    break;
                case 2:
                    statusdetalezlecenieBindingSource.DataSource = db.Status_detale_zlecenie.Where(a => a.Status.Value < 5 || a.Status.Value > 5 && a.Status.Value < 10).ToList();
                    btnHZlecen.Hide();
                    break;
                case 3:
                    statusdetalezlecenieBindingSource.DataSource = db.Status_detale_zlecenie.Where(a => a.Status.Value < 7 && a.Status.Value > 3).ToList();
                    btnHZlecen.Hide();
                    break;
                case 4:
                    statusdetalezlecenieBindingSource.DataSource = db.Status_detale_zlecenie.Where(a => a.Status.Value > 8).ToList();
                    btnHZlecen.Hide();
                    break;

            }
        }

        private void btnNastepnyStatus_Click(object sender, EventArgs e)
        {
            if ((statusdetalezlecenieBindingSource.Current as Status_detale_zlecenie).Status < db.STATUS_ZLECENIA.ToList().LongCount() )
            {
                
                DATA_STATUSU_ZLECENIA dataStatusuZlecenia = new DATA_STATUSU_ZLECENIA();
                Status_detale_zlecenie zlecenie = statusdetalezlecenieBindingSource.Current as Status_detale_zlecenie;
                if (!(uprawnienia == 2 && (int.Parse(zlecenie.Status.ToString()) + 1 == 5 || int.Parse(zlecenie.Status.ToString()) + 1 == 10)))
                {
                    if (!(uprawnienia == 3 && int.Parse(zlecenie.Status.ToString()) + 1 == 7 ))
                    {
                        
                        dataStatusuZlecenia.ID_ZLECENIA = zlecenie.ID_ZLECENIA;
                        dataStatusuZlecenia.ID_STATUSU_ZLECENIA = int.Parse(zlecenie.Status.ToString()) + 1;
                        dataStatusuZlecenia.DATA_ZMIANY = DateTime.Now;
                        db.DATA_STATUSU_ZLECENIA.Add(dataStatusuZlecenia);
                        db.SaveChanges();

                        KWZP_PROJEKTEntities nDB = new KWZP_PROJEKTEntities();
                        db.Status_detale_zlecenie = nDB.Status_detale_zlecenie;
                        SprawdzanieUprawnien(uprawnienia);
                    }
                }
            }

        }

        private void btnHZlecen_Click(object sender, EventArgs e)
        {
            Status_detale_zlecenie s = statusdetalezlecenieBindingSource.Current as Status_detale_zlecenie;
            using (HistoriaStatusyZlecenia historiaStatusyZlecenia = new HistoriaStatusyZlecenia(db, s ))
            {
                if (historiaStatusyZlecenia.ShowDialog() == DialogResult.OK)
                {
                    
                    
                }
            }
        }

        private void btnszczegoly_Click(object sender, EventArgs e)
        {
            Status_detale_zlecenie s = statusdetalezlecenieBindingSource.Current as Status_detale_zlecenie;
            int id = s.ID_ZLECENIA;
           
            using (SzczegolyZlecenia szczegoly = new SzczegolyZlecenia(id, db))
            {
                if (szczegoly.ShowDialog() == DialogResult.OK)
                {


                }
            }
        }
    }
}
    

