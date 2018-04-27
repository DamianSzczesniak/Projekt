using PROJEKTapp.Forms;
using PROJEKTapp.Forms_NoweZlecenie;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace PROJEKTapp
{
    public partial class FormNoweZlecenie : Form
    {
        KWZP_PROJEKTEntities db;


        public FormNoweZlecenie(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();

            
            cbBoxFirmy.DisplayMember = "NAZWA_FIRMY";
            cbBoxFirmy.ValueMember = "ID_FIRMY";
            cbBoxFirmy.DropDownStyle = ComboBoxStyle.DropDownList;
            
            
            cBox_Produkty_Oferta.DataSource = db.PRODUKT.ToList();
            cBox_Produkty_Oferta.DisplayMember = "NAZWA_PRODUKTU";
            cBox_Produkty_Oferta.ValueMember = "Id_Produktu";
            cBox_Produkty_Oferta.DropDownStyle = ComboBoxStyle.DropDownList;

            txtBox_Data_Zlecenia.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        
    
        private void btn_Dodaj_Zlecenie_Click(object sender, EventArgs e)
        {
            ZLECENIA noweZlecenie = new ZLECENIA();
            noweZlecenie.DATA_REALIZACJI = DateTime.Parse(txtBox_Data_Realizacji.Text);
            noweZlecenie.DATA_ZLECENIA = DateTime.Parse(txtBox_Data_Zlecenia.Text);
            noweZlecenie.ID_FIRMY = int.Parse(cbBoxFirmy.SelectedValue.ToString());

            db.ZLECENIA.Add(noweZlecenie);
            db.SaveChanges();

            txtBox_Data_Realizacji.Clear();
            txtBox_Data_Zlecenia.Clear();
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

        
        private void btnPrzedstaw_Oferte_Click(object sender, EventArgs e)
        {
            FormOferta FormOferta = new FormOferta();
            FormOferta.Show();
        }

        
        private void btnWybierzFirme_Click(object sender, EventArgs e)
        {
            using (FormFirmyDoZlecenia formFirmyDoZlecenia = new FormFirmyDoZlecenia(db))
            {
                formFirmyDoZlecenia.ShowDialog();
               
                if (! cbBoxFirmy.DataSource.Equals(db.FIRMY.ToList()))
                {
                    cbBoxFirmy.DataSource = db.FIRMY.ToList();
                }
            }
        }

        private void FormNoweZlecenie_Load(object sender, EventArgs e)
        {
            cbBoxFirmy.DataSource = db.FIRMY.ToList();
        }
    }
}
