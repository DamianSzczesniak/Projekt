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
    public partial class ZmianaHasla : Form
    {
        KWZP_PROJEKTEntities db;
        int id_uzytkownika;

        public ZmianaHasla(KWZP_PROJEKTEntities db, int id_uzytkownika)
        {
            this.db = db;
            this.id_uzytkownika = id_uzytkownika;
            InitializeComponent();
        }
    }
}
