using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Forms
{
    public partial class Form2 : Form
    {
        KWZP_PROJEKTEntities db;
        FIRMY firma;

        public Form2(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
            this.button1.Text = "Show";
            this.button2.Text = "Hide";
            this.button3.Text = "Save changes";


            firma = db.FIRMY.First();

            this.textBox1.Text = firma.NAZWA_FIRMY;
            this.textBox2.Text = firma.NIP;

            this.checkBox1.Checked = firma.POJAZDY.Count > 2;

            int currentY = 150;
            foreach(POJAZDY pojazd in firma.POJAZDY)
            {
                TextBox textBox = new TextBox();
                Label label = new Label();
                label.Text = pojazd.MARKA + " " + pojazd.MODEL;
                label.Location = new Point(5, currentY);
                textBox.Text = pojazd.NUMER_REJESTRACYJNY;
                textBox.Location = new Point(150, currentY);
                textBox.Name = "txt" + pojazd.ID_POJAZDU;
                this.panel1.Controls.Add(label);
                this.panel1.Controls.Add(textBox);
                currentY += 25;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //edycja
            firma.NAZWA_FIRMY = this.textBox1.Text;
            firma.NIP = this.textBox2.Text;

        

            //usuwanie
            //db.FIRMY.Remove(firma);
            db.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //dodawanie
            FIRMY nowaFirma = new FIRMY();
            nowaFirma.NAZWA_FIRMY = this.textBox4.Text;
            nowaFirma.NIP = this.textBox3.Text;
            nowaFirma.POJAZDY.Add(db.POJAZDY.First());
            db.FIRMY.Add(nowaFirma);
            db.SaveChanges();
        }
    }
}
