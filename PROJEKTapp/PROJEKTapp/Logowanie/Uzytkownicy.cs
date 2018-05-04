using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Logowanie
{
    public partial class Uzytkownicy : Form
    {
        KWZP_PROJEKTEntities db;
        public Uzytkownicy(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void Uzytkownicy_Load(object sender, EventArgs e)
        {
            DGW_KOnta_Uzytkownikow.DataSource = db.SPIS_UZYTKOWNIKOW.ToList();
        }
    }
}
