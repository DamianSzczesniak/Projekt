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
    public partial class FormStatystyki : Form
    {
        KWZP_PROJEKTEntities db;
        bool ladowanieformularzazokienkami;
        List<zestawienie> list = new List<zestawienie>();

        public FormStatystyki(KWZP_PROJEKTEntities db, bool ladowanieformularzazokienkami)
        {
            this.db = db;
            this.ladowanieformularzazokienkami = ladowanieformularzazokienkami;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStatystyki_Load(object sender, EventArgs e)
        {
            if (ladowanieformularzazokienkami == true)
            {
                ladowanieformularzazokienkami = false;
                btnRozliczenieProjektow.Show();
                dateTimePickerPoczatek.Value = DateTime.Today.AddYears(-1);
                dateTimePickerKoniec.Value = DateTime.Today;
                zrodloDanych();
                polaSum();
            }
            else
            {
                ladowanieformularzazokienkami = true;
                btnRozliczenieProjektow.Hide();
                pnlRozliczenie.Hide();
            }
        }

        private void btnPracownicy_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormKadry kadry = new FormKadry(db, ladowanieformularzazokienkami);
            kadry.Show();
            this.Close();
        }

        private void btnWynagrodzenia_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormWynagordzenie wynagrodzenie = new FormWynagordzenie(db, ladowanieformularzazokienkami);
            wynagrodzenie.Show();
            this.Close();
        }

        private void btnUrlopy_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormUrlopy urlopy = new FormUrlopy(db, ladowanieformularzazokienkami);
            urlopy.Show();
            this.Close();
        }

        private void btnSzkolenia_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormSzkolenie szkolenie = new FormSzkolenie(db, ladowanieformularzazokienkami);
            szkolenie.Show();
            this.Close();
        }

        private void btnStatystyki_Click(object sender, EventArgs e)
        {
            if (ladowanieformularzazokienkami == true)
            {
                ladowanieformularzazokienkami = false;
                btnRozliczenieProjektow.Show();
                dateTimePickerPoczatek.Value = DateTime.Today.AddYears(-1);
                dateTimePickerKoniec.Value = DateTime.Today;
                zrodloDanych();
                polaSum();
            }
            else
            {
                ladowanieformularzazokienkami = true;
                btnRozliczenieProjektow.Hide();
                pnlRozliczenie.Hide();
            }
        }

        private void btnRozliczenieProjektow_Click(object sender, EventArgs e)
        {
            pnlRozliczenie.Show();
            dateTimePickerPoczatek.Value = DateTime.Today.AddYears(-1);
            dateTimePickerKoniec.Value = DateTime.Today;
            zrodloDanych();
            polaSum();
        }
        private void zrodloDanych()
        {
            zestawienieBindingSource.DataSource = db.zestawienie.Where(a => a.DATA_REALIZACJI >= dateTimePickerPoczatek.Value && a.DATA_REALIZACJI <= dateTimePickerKoniec.Value && a.ID_STATUSU_ZLECENIA > 8).ToList();
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
            foreach (zestawienie element in db.zestawienie.Where(a => a.DATA_REALIZACJI >= dateTimePickerPoczatek.Value && a.DATA_REALIZACJI <= dateTimePickerKoniec.Value && a.ID_STATUSU_ZLECENIA > 8).ToList())
            {
                decimal przychod = decimal.Parse(element.Kwota_pobrana_za_zlecenie.ToString());
                int intprzychod = Decimal.ToInt32(przychod);
                sumPrzychod += intprzychod;
                decimal koszt = decimal.Parse(element.Kosz_wykonania_zlecenia.ToString());
                int intkoszt = Decimal.ToInt32(koszt);
                sumKoszt += intkoszt;
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
            else if (sumDochod == 0)
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
