using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp
{
    public partial class FormNoweZlecenie : Form
    {
        KWZP_PROJEKTEntities db = new KWZP_PROJEKTEntities();
        public FormNoweZlecenie()
        {
            InitializeComponent();
           
            cBox_Produkty_Oferta.DataSource = db.PRODUKT.ToList();
            cBox_Produkty_Oferta.DisplayMember = "NAZWA_PRODUKTU";
            cBox_Produkty_Oferta.ValueMember = "Id_Produktu";
        }
        
    
    

        private void btn_Dodaj_Zlecenie_Click(object sender, EventArgs e)
        {
            ZLECENIA noweZlecenie = new ZLECENIA();
            noweZlecenie.DATA_REALIZACJI = DateTime.Parse(txtBox_Data_Realizacji.Text);
            noweZlecenie.DATA_ZLECENIA = DateTime.Parse(txtBox_Data_Zlecenia.Text);
            noweZlecenie.ID_FIRMY = int.Parse(txtBox_Firma.Text);

            db.ZLECENIA.Add(noweZlecenie);
            db.SaveChanges();

            txtBox_Data_Realizacji.Clear();
            txtBox_Data_Zlecenia.Clear();
            txtBox_Firma.Clear();




        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void groupBoxNowe_ZLecenie_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Dodaj_Oferta_Click(object sender, EventArgs e)
        {

            int n = dataGridViewOferta.Rows.Add();
            dataGridViewOferta.Rows[n].Cells[0].Value = cBox_Produkty_Oferta.SelectedValue;
            dataGridViewOferta.Rows[n].Cells[1].Value = cBox_Produkty_Oferta.Text;
            dataGridViewOferta.Rows[n].Cells[2].Value = txtBox_Ilosc_Oferta.Text;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
