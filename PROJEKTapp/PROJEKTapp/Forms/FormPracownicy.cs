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
        public FormPracownicy()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("KWZP_PROJEKTEntities");
                SqlCommand cmd = new SqlCommand("AddPracownik", con);
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                cmd.Parameters.Add("@Imie", SqlDbType.VarChar).Value = txtboxImie.Text;
                cmd.Parameters.Add("@Nazwisko", SqlDbType.VarChar).Value = txtboxNazwisko.Text;
                cmd.Parameters.Add("@Tel", SqlDbType.VarChar).Value = txtboxTel.Text;
                cmd.Parameters.Add("@PESEL", SqlDbType.VarChar).Value = txtboxPesel.Text;
                cmd.Parameters.Add("@Stanowisko", SqlDbType.Char).Value = txtboxStanowisko.Text;
                cmd.Parameters.Add("@Ulica", SqlDbType.VarChar).Value = txtboxUlica.Text;
                cmd.Parameters.Add("@Nrbudynku", SqlDbType.VarChar).Value = textboxNrbudynku.Text;
                cmd.Parameters.Add("@Nrlokalu", SqlDbType.VarChar).Value = txtboxNrlokalu.Text;
                cmd.Parameters.Add("@Kodpocztowy", SqlDbType.VarChar).Value = txtboxKodpocztowy.Text;
                cmd.Parameters.Add("@Kraj", SqlDbType.VarChar).Value = txtboxKraj.Text;
                cmd.Parameters.Add("@Miasto", SqlDbType.VarChar).Value = txtboxMiasto.Text;
                cmd.Parameters.Add("@DataRozpoczeciaPracy", SqlDbType.Date).Value = txtDataRozpoczeciaPracy.Text;
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
