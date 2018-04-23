using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp
{
    public partial class FormPracownicy : Form
    {
        KWZP_PROJEKTEntities db;

        public FormPracownicy(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            cbStanowisko.DataSource = db.STANOWISKO.ToList();
            cbStanowisko.DisplayMember = "Nazwa";
            cbStanowisko.ValueMember = "Id_Stanowisko";

            cbMiasto.DataSource = db.MIASTA.ToList();
            cbMiasto.DisplayMember = "Nazwa";
            cbMiasto.ValueMember = "Id_Miasta";
            btnUpdate.Hide();
        }

        public FormPracownicy(KWZP_PROJEKTEntities db, string id_pracownik)
        {
            this.db = db;
            int ID = Int32.Parse(id_pracownik);
            PracownikDane pracownikwyswietl = new PracownikDane(ID);
            InitializeComponent();
            cbStanowisko.DataSource = db.STANOWISKO.ToList();
            cbStanowisko.DisplayMember = "Nazwa";
            cbStanowisko.ValueMember = "Id_Stanowisko";

            cbMiasto.DataSource = db.MIASTA.ToList();
            cbMiasto.DisplayMember = "Nazwa";
            cbMiasto.ValueMember = "Id_Miasta";

            btnDodaj.Hide();

            //txtboxNazwisko.Text = pracownik.NAZWISKO;
            //txtboxImie.Text = pracownik.IMIE;
            //txtboxKodpocztowy.Text = "";
            //txtboxTel.Text = pracownik.TELEFON;
            //txtboxPesel.Text = pracownik.PESEL;
            //txtboxUlica.Text = "";
            //txtNrbudynku.Text = "";
            //txtboxNrlokalu.Text = "" ;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void Insertpracownik(string nazwisko, string imie, string telefon, string pesel,
            string ulica, string nrbudynku, string nrlokalu, string kodpocztowy, int miasto, string kraj,
            DateTime data, int stanowisko)
        {
                    PracownikDane pracownikdane = new PracownikDane();
                    pracownikdane.Add(nazwisko, imie, telefon, pesel, ulica, nrbudynku, nrlokalu, kodpocztowy, miasto, kraj, data, stanowisko);
                }

        protected void btnDodaj_Click(object sender, EventArgs e)
                {
            if (txtboxImie.Text == "" || txtboxNazwisko.Text == "" || txtboxTel.Text == "" || txtboxPesel.Text == "" || txtboxUlica.Text == "" || txtNrbudynku.Text == "" || txtboxNrlokalu.Text == "" || txtboxKodpocztowy.Text == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola");
            }
            else
            {
                 Insertpracownik(txtboxNazwisko.Text,
                                   txtboxImie.Text,
                                   txtboxTel.Text,
                                   txtboxPesel.Text,
                                   txtboxUlica.Text,
                                   txtNrbudynku.Text,
                                   txtboxNrlokalu.Text,
                                   txtboxKodpocztowy.Text,
                                   (int)cbMiasto.SelectedValue,
                                   txtboxKraj.Text,
                                   txtDataRozpoczeciaPracy.Value,
                                   (int)cbStanowisko.SelectedValue
                                   );
            }
        }
        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            txtboxNazwisko.Clear();
            txtboxImie.Clear();
            txtboxKodpocztowy.Clear();
            txtboxTel.Clear();
            txtboxPesel.Clear();
            txtboxUlica.Clear();
            txtNrbudynku.Clear();
            txtboxNrlokalu.Clear();
        }
    }
}
