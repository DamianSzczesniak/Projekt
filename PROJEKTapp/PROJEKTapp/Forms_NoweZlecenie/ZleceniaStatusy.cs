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
                    aKTUALNYSTATUSZLECENNAZWYBindingSource.DataSource = db.AKTUALNY_STATUS_ZLECEN_NAZWY.ToList();
                    break;
                case 2:
                    aKTUALNYSTATUSZLECENNAZWYBindingSource.DataSource = db.AKTUALNY_STATUS_ZLECEN_NAZWY.Where(a => a.Status.Value < 5 || a.Status.Value > 5 && a.Status.Value < 10).ToList();
                    break;
                case 3:
                    aKTUALNYSTATUSZLECENNAZWYBindingSource.DataSource = db.AKTUALNY_STATUS_ZLECEN_NAZWY.Where(a => a.Status.Value < 7 && a.Status.Value > 3).ToList();
                    break;
                case 4:
                    aKTUALNYSTATUSZLECENNAZWYBindingSource.DataSource = db.AKTUALNY_STATUS_ZLECEN_NAZWY.Where(a => a.Status.Value > 8).ToList();
                    break;

            }
        }

        private void btnNastepnyStatus_Click(object sender, EventArgs e)
        {
            if ((aKTUALNYSTATUSZLECENNAZWYBindingSource.Current as AKTUALNY_STATUS_ZLECEN_NAZWY).Status < db.STATUS_ZLECENIA.ToList().LongCount() )
            {
                
                DATA_STATUSU_ZLECENIA dataStatusuZlecenia = new DATA_STATUSU_ZLECENIA();
                AKTUALNY_STATUS_ZLECEN_NAZWY zlecenie = aKTUALNYSTATUSZLECENNAZWYBindingSource.Current as AKTUALNY_STATUS_ZLECEN_NAZWY;
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
                        db.AKTUALNY_STATUS_ZLECEN_NAZWY = nDB.AKTUALNY_STATUS_ZLECEN_NAZWY;
                        SprawdzanieUprawnien(uprawnienia);
                    }
                }
            }

        }
    }
}
    

