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
    public partial class Zmiana_Danych_Uzytkownika : Form
    {
        KWZP_PROJEKTEntities db;
        int id_uzytkownika;
        public Zmiana_Danych_Uzytkownika(int id_uzytkownika, KWZP_PROJEKTEntities db)
        {
            this.db = db;
            this.id_uzytkownika = id_uzytkownika;
            InitializeComponent();
        }
    }
}
