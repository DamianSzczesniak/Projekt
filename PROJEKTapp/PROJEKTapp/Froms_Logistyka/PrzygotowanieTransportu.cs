using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;

namespace PROJEKTapp.Forms
{
    public partial class PrzygotowanieTransportu : Form
    {
        decimal dystans;
        string address;
        double latA = 52.253233;
        double longA = 20.899630;
        double latB;
        double longB;
        KWZP_PROJEKTEntities db;
        public PrzygotowanieTransportu(KWZP_PROJEKTEntities db)
        {
            InitializeComponent();
            this.db = db;
            ComboNumerDostawy.DataSource = db.DOSTAWA.ToList();
            ComboNumerDostawy.DisplayMember = "ID_DOSTAWY";

            comboBoxZlecenie.DataSource = db.ID_ZLECEN_BEZ_TRANSPORTU.ToList();
            comboBoxZlecenie.DisplayMember = "ID_ZLECENIA";

            comboBoxFirmy.DataSource = db.FIRMY.ToList();
            comboBoxFirmy.DisplayMember = "NAZWA_FIRMY";

            dataGridViewAdresy.DataSource = db.ADRESY_DOSTAWA.ToList();

        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboNumerDostawy_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridTransport.DataSource = db.PRZYGOTOWANIE_TRANSPORTU.Where(x => x.ID_POJAZDU == ((DOSTAWA)ComboNumerDostawy.SelectedValue).ID_DOSTAWY).ToList();
        }

        private void ButtonDodajDostawe_Click(object sender, EventArgs e)
        {
            groupBoxDodaj.Show();
            //dataGridViewDostepnePojazdy.DataSource = db.STAN_PRODUKTY_NAZWY.ToList();
        }

        private void checkBoxWszytkie_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWszytkie.Checked)
            {
                this.dataGridTransport.DataSource = db.PRZYGOTOWANIE_TRANSPORTU.ToList();
            }
            else
            {
                this.dataGridTransport.DataSource = db.PRZYGOTOWANIE_TRANSPORTU.Where(x => x.ID_POJAZDU == ((DOSTAWA)ComboNumerDostawy.SelectedValue).ID_DOSTAWY).ToList();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonUsunDostawy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy napewno chcesz usunąć tą dostawę?", "OSTRZEŻENIE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //delete record
            }
            else if (dr == DialogResult.Cancel)
            {
                //
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            //db.SaveChanges();
        }

        private void buttonOszacujTrase_Click(object sender, EventArgs e)
        {


            string requestUri = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false", Uri.EscapeDataString(address));
            WebRequest request = WebRequest.Create(requestUri);
            WebResponse response = request.GetResponse();
            XDocument xdoc = XDocument.Load(response.GetResponseStream());
            XElement result = xdoc.Element("GeocodeResponse").Element("result");
            XElement locationElement = result.Element("geometry").Element("location");
            XElement xEllatB = locationElement.Element("lat");
            XElement xEllngB = locationElement.Element("lng");

            latB = Convert.ToDouble((xEllatB.ToString().Substring(5, 9)));
            longB = Convert.ToDouble((xEllngB.ToString().Substring(5, 9)));

            //string a = xEllatB.ToString().Substring(5, 9);
            //string b = xEllngB.ToString().Substring(5, 9);

            double theDistance = (Math.Sin(DegreesToRadians(latA)) *
            Math.Sin(DegreesToRadians(latB)) +
            Math.Cos(DegreesToRadians(latA)) *
            Math.Cos(DegreesToRadians(latB)) *
            Math.Cos(DegreesToRadians(longA - longB)));
            dystans = Math.Ceiling(Convert.ToDecimal((RadianToDegree(Math.Acos(theDistance)))) * 69.09M * 1.6093M);

            textBoxdlugoscTrasy.Text = dystans.ToString() + " km";

        }

        private void dataGridViewAdresy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewAdresy.Rows[index];
            string ulica = selectedRow.Cells[0].Value.ToString();
            string nrbudynku = selectedRow.Cells[1].Value.ToString();
            string nrlokalu = selectedRow.Cells[2].Value.ToString();
            string miasto = selectedRow.Cells[4].Value.ToString();
            string kraj = selectedRow.Cells[5].Value.ToString();

            address = ulica + " " + nrbudynku + "/" + nrlokalu + " " + miasto + " " + kraj;
        }

        private double DegreesToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
    }
}