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
    public partial class FormRozliczenieProjektu : Form
    {
        KWZP_PROJEKTEntities db;
        List<zestawienie> list = new List<zestawienie>();
        public FormRozliczenieProjektu(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRozliczenieProjektu_Load(object sender, EventArgs e)
        {
            dateTimePickerPoczatek.Value = DateTime.Today.AddYears(-1);
            dateTimePickerKoniec.Value = DateTime.Today;
            zrodloDanych();
            polaSum();
           

        }

        private void zrodloDanych()
        {
            zestawienieBindingSource.DataSource = db.zestawienie.Where(a => a.DATA_REALIZACJI >= dateTimePickerPoczatek.Value && a.DATA_REALIZACJI <= dateTimePickerKoniec.Value).ToList();
            foreach (DataGridViewRow Myrow in dgvRozliczenie.Rows)
            {
                if (Convert.ToInt32(Myrow.Cells[3].Value) < 0)
                {
                    Myrow.Cells[3].Style.BackColor = Color.Red;
                }
                else
                {
                    Myrow.Cells[3].Style.BackColor = Color.Green;
                }
            }
        }

        private void polaSum()
        {
            int sumPrzychod = 0;
            int sumKoszt = 0;
            int sumDochod = 0;
            foreach (zestawienie element in db.zestawienie.Where(a => a.DATA_REALIZACJI >= dateTimePickerPoczatek.Value && a.DATA_REALIZACJI <= dateTimePickerKoniec.Value).ToList())
            {
                decimal przychod = decimal.Parse(element.Kwota_pobrana_za_zlecenie.ToString());
                int intprzychod = Decimal.ToInt32(przychod);
                sumPrzychod += intprzychod;
                decimal koszt = decimal.Parse(element.Kosz_wykonania_zlecenia.ToString());
                int intkoszt = Decimal.ToInt32(koszt);
                sumKoszt += intkoszt ;
                decimal dochod = decimal.Parse(element.Saldo.ToString());
                int intdochod = Decimal.ToInt32(dochod);
                sumDochod += intdochod;
            }
            txtBoxSPrzychod.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", sumPrzychod);
            txtBoxSKoszty.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", sumKoszt);
            txtBoxSDochod.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", sumDochod);
            if (sumDochod > 0)
            {
                txtBoxSDochod.BackColor = Color.Green;
            }
            else if(sumDochod == 0)
            {
                txtBoxSDochod.BackColor = Color.Yellow;
            }
            else
            {
                txtBoxSDochod.BackColor = Color.Red;
            }
        }

        private void dateTimePickerPoczatek_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerKoniec.Value <= dateTimePickerPoczatek.Value)
            {
                MessageBox.Show("Data początku okresu powinna być mniejsz od daty konca okresu. ");
                dateTimePickerPoczatek.Focus();
            }
            else
            {
                zrodloDanych();
                polaSum();
            }
        }

        private void dateTimePickerKoniec_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerKoniec.Value <= dateTimePickerPoczatek.Value)
            {
                MessageBox.Show("Data początku okresu powinna być mniejsz od daty konca okresu. ");
                dateTimePickerKoniec.Focus();
            }
            else
            {
                zrodloDanych();
                polaSum();
            }
        }
    }
}
