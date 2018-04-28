using PROJEKTapp.Forms;
using PROJEKTapp.Forms.Forms_Logistyka;
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
    public partial class FormLogistyka : Form

    {
        KWZP_PROJEKTEntities db ;
        public FormLogistyka()
        {
            InitializeComponent();
        }

        private void FormLogistyka_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_zmiana_stat_Click(object sender, EventArgs e)
        {
            FormZmianaStanuMagazynu ZmianaStanuMagazynu = new FormZmianaStanuMagazynu(db);
            ZmianaStanuMagazynu.Show();
        }

        private void Btn_kreat_fak_Click(object sender, EventArgs e)
        {
            FormListaFaktur KreatorFaktur = new FormListaFaktur(db);
            KreatorFaktur.Show();
            
        }

        private void Btn_przyg_trans_Click(object sender, EventArgs e)
        {
            PrzygotowanieTransportu PrzygotwanieTransportu = new PrzygotowanieTransportu(db);
            PrzygotwanieTransportu.Show();
        }

        private void Btn_zam_mat_Click(object sender, EventArgs e)
        {
            ZamowienieMaterialu ZamowienieMaterialu = new ZamowienieMaterialu(db);
            ZamowienieMaterialu.Show();
        }
    }

}
