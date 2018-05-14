namespace PROJEKTapp.Forms
{
    partial class PrzygotowanieTransportu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Back_3 = new System.Windows.Forms.Button();
            this.TopBar_3 = new System.Windows.Forms.PictureBox();
            this.dataGridTransport = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ComboNumerDostawy = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ButtonDodajDostawe = new System.Windows.Forms.Button();
            this.ButtonUsunDostawy = new System.Windows.Forms.Button();
            this.ButtonEdytujDostawe = new System.Windows.Forms.Button();
            this.lblIdZlecenia = new System.Windows.Forms.Label();
            this.groupBoxDodaj = new System.Windows.Forms.Panel();
            this.dataGridViewAdresy = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.dataGridViewDostepnePojazdy = new System.Windows.Forms.DataGridView();
            this.comboBoxZlecenie = new System.Windows.Forms.ComboBox();
            this.lblDlTrasy = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblIdPojazdu = new System.Windows.Forms.Label();
            this.checkBoxWszytkie = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBoxDodaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdresy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDostepnePojazdy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = ".../Logistyka/Przygotowanie transportu";
            // 
            // Btn_Back_3
            // 
            this.Btn_Back_3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Back_3.FlatAppearance.BorderSize = 0;
            this.Btn_Back_3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back_3.Image = global::PROJEKTapp.Properties.Resources.return2;
            this.Btn_Back_3.Location = new System.Drawing.Point(0, 0);
            this.Btn_Back_3.Name = "Btn_Back_3";
            this.Btn_Back_3.Size = new System.Drawing.Size(80, 56);
            this.Btn_Back_3.TabIndex = 9;
            this.Btn_Back_3.UseVisualStyleBackColor = false;
            this.Btn_Back_3.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // TopBar_3
            // 
            this.TopBar_3.Image = global::PROJEKTapp.Properties.Resources.top_bar1;
            this.TopBar_3.Location = new System.Drawing.Point(204, 0);
            this.TopBar_3.Name = "TopBar_3";
            this.TopBar_3.Size = new System.Drawing.Size(960, 72);
            this.TopBar_3.TabIndex = 8;
            this.TopBar_3.TabStop = false;
            // 
            // dataGridTransport
            // 
            this.dataGridTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransport.Location = new System.Drawing.Point(16, 145);
            this.dataGridTransport.Name = "dataGridTransport";
            this.dataGridTransport.Size = new System.Drawing.Size(641, 611);
            this.dataGridTransport.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Numer dostawy:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1340, 2);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ComboNumerDostawy
            // 
            this.ComboNumerDostawy.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboNumerDostawy.FormattingEnabled = true;
            this.ComboNumerDostawy.Location = new System.Drawing.Point(176, 107);
            this.ComboNumerDostawy.Name = "ComboNumerDostawy";
            this.ComboNumerDostawy.Size = new System.Drawing.Size(121, 32);
            this.ComboNumerDostawy.TabIndex = 18;
            this.ComboNumerDostawy.SelectedIndexChanged += new System.EventHandler(this.ComboNumerDostawy_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 56);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox3.Location = new System.Drawing.Point(1162, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 56);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // ButtonDodajDostawe
            // 
            this.ButtonDodajDostawe.BackColor = System.Drawing.Color.Lime;
            this.ButtonDodajDostawe.FlatAppearance.BorderSize = 0;
            this.ButtonDodajDostawe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDodajDostawe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonDodajDostawe.Location = new System.Drawing.Point(844, 108);
            this.ButtonDodajDostawe.Name = "ButtonDodajDostawe";
            this.ButtonDodajDostawe.Size = new System.Drawing.Size(115, 31);
            this.ButtonDodajDostawe.TabIndex = 23;
            this.ButtonDodajDostawe.Text = "Dodaj";
            this.ButtonDodajDostawe.UseVisualStyleBackColor = false;
            this.ButtonDodajDostawe.Click += new System.EventHandler(this.ButtonDodajDostawe_Click);
            // 
            // ButtonUsunDostawy
            // 
            this.ButtonUsunDostawy.BackColor = System.Drawing.Color.Red;
            this.ButtonUsunDostawy.FlatAppearance.BorderSize = 0;
            this.ButtonUsunDostawy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUsunDostawy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonUsunDostawy.Location = new System.Drawing.Point(1084, 107);
            this.ButtonUsunDostawy.Name = "ButtonUsunDostawy";
            this.ButtonUsunDostawy.Size = new System.Drawing.Size(115, 31);
            this.ButtonUsunDostawy.TabIndex = 24;
            this.ButtonUsunDostawy.Text = "Usuń";
            this.ButtonUsunDostawy.UseVisualStyleBackColor = false;
            // 
            // ButtonEdytujDostawe
            // 
            this.ButtonEdytujDostawe.BackColor = System.Drawing.Color.LightGray;
            this.ButtonEdytujDostawe.FlatAppearance.BorderSize = 0;
            this.ButtonEdytujDostawe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdytujDostawe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonEdytujDostawe.Location = new System.Drawing.Point(963, 108);
            this.ButtonEdytujDostawe.Name = "ButtonEdytujDostawe";
            this.ButtonEdytujDostawe.Size = new System.Drawing.Size(115, 31);
            this.ButtonEdytujDostawe.TabIndex = 25;
            this.ButtonEdytujDostawe.Text = "Edytuj";
            this.ButtonEdytujDostawe.UseVisualStyleBackColor = false;
            // 
            // lblIdZlecenia
            // 
            this.lblIdZlecenia.AutoSize = true;
            this.lblIdZlecenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdZlecenia.Location = new System.Drawing.Point(16, 26);
            this.lblIdZlecenia.Name = "lblIdZlecenia";
            this.lblIdZlecenia.Size = new System.Drawing.Size(94, 20);
            this.lblIdZlecenia.TabIndex = 54;
            this.lblIdZlecenia.Text = "ID Zlecenia:";
            // 
            // groupBoxDodaj
            // 
            this.groupBoxDodaj.Controls.Add(this.dataGridViewAdresy);
            this.groupBoxDodaj.Controls.Add(this.button1);
            this.groupBoxDodaj.Controls.Add(this.buttonZapisz);
            this.groupBoxDodaj.Controls.Add(this.dataGridViewDostepnePojazdy);
            this.groupBoxDodaj.Controls.Add(this.comboBoxZlecenie);
            this.groupBoxDodaj.Controls.Add(this.lblDlTrasy);
            this.groupBoxDodaj.Controls.Add(this.textBox4);
            this.groupBoxDodaj.Controls.Add(this.lblAdres);
            this.groupBoxDodaj.Controls.Add(this.lblIdPojazdu);
            this.groupBoxDodaj.Controls.Add(this.lblIdZlecenia);
            this.groupBoxDodaj.Location = new System.Drawing.Point(663, 145);
            this.groupBoxDodaj.Name = "groupBoxDodaj";
            this.groupBoxDodaj.Size = new System.Drawing.Size(689, 611);
            this.groupBoxDodaj.TabIndex = 27;
            this.groupBoxDodaj.Visible = false;
            // 
            // dataGridViewAdresy
            // 
            this.dataGridViewAdresy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdresy.Location = new System.Drawing.Point(20, 273);
            this.dataGridViewAdresy.Name = "dataGridViewAdresy";
            this.dataGridViewAdresy.Size = new System.Drawing.Size(666, 123);
            this.dataGridViewAdresy.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(77, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 31);
            this.button1.TabIndex = 68;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.BackColor = System.Drawing.Color.Lime;
            this.buttonZapisz.FlatAppearance.BorderSize = 0;
            this.buttonZapisz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZapisz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonZapisz.Location = new System.Drawing.Point(294, 535);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(115, 31);
            this.buttonZapisz.TabIndex = 66;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDostepnePojazdy
            // 
            this.dataGridViewDostepnePojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDostepnePojazdy.Location = new System.Drawing.Point(20, 103);
            this.dataGridViewDostepnePojazdy.Name = "dataGridViewDostepnePojazdy";
            this.dataGridViewDostepnePojazdy.Size = new System.Drawing.Size(666, 118);
            this.dataGridViewDostepnePojazdy.TabIndex = 65;
            // 
            // comboBoxZlecenie
            // 
            this.comboBoxZlecenie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxZlecenie.FormattingEnabled = true;
            this.comboBoxZlecenie.Location = new System.Drawing.Point(121, 25);
            this.comboBoxZlecenie.Name = "comboBoxZlecenie";
            this.comboBoxZlecenie.Size = new System.Drawing.Size(183, 26);
            this.comboBoxZlecenie.TabIndex = 64;
            this.comboBoxZlecenie.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDlTrasy
            // 
            this.lblDlTrasy.AutoSize = true;
            this.lblDlTrasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDlTrasy.Location = new System.Drawing.Point(21, 416);
            this.lblDlTrasy.Name = "lblDlTrasy";
            this.lblDlTrasy.Size = new System.Drawing.Size(110, 20);
            this.lblDlTrasy.TabIndex = 62;
            this.lblDlTrasy.Text = "Długość trasy:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(141, 413);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(183, 26);
            this.textBox4.TabIndex = 63;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdres.Location = new System.Drawing.Point(16, 236);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(55, 20);
            this.lblAdres.TabIndex = 60;
            this.lblAdres.Text = "Adres:";
            // 
            // lblIdPojazdu
            // 
            this.lblIdPojazdu.AutoSize = true;
            this.lblIdPojazdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdPojazdu.Location = new System.Drawing.Point(16, 80);
            this.lblIdPojazdu.Name = "lblIdPojazdu";
            this.lblIdPojazdu.Size = new System.Drawing.Size(141, 20);
            this.lblIdPojazdu.TabIndex = 58;
            this.lblIdPojazdu.Text = "Dostępne pojazdy:";
            // 
            // checkBoxWszytkie
            // 
            this.checkBoxWszytkie.AutoSize = true;
            this.checkBoxWszytkie.Font = new System.Drawing.Font("Arial", 15F);
            this.checkBoxWszytkie.Location = new System.Drawing.Point(303, 110);
            this.checkBoxWszytkie.Name = "checkBoxWszytkie";
            this.checkBoxWszytkie.Size = new System.Drawing.Size(118, 27);
            this.checkBoxWszytkie.TabIndex = 28;
            this.checkBoxWszytkie.Text = "Wszystkie";
            this.checkBoxWszytkie.UseVisualStyleBackColor = true;
            this.checkBoxWszytkie.CheckedChanged += new System.EventHandler(this.checkBoxWszytkie_CheckedChanged);
            // 
            // PrzygotowanieTransportu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.checkBoxWszytkie);
            this.Controls.Add(this.groupBoxDodaj);
            this.Controls.Add(this.ButtonEdytujDostawe);
            this.Controls.Add(this.ButtonUsunDostawy);
            this.Controls.Add(this.ButtonDodajDostawe);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ComboNumerDostawy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridTransport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Back_3);
            this.Controls.Add(this.TopBar_3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrzygotowanieTransportu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przygotowanie_Transportu";
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBoxDodaj.ResumeLayout(false);
            this.groupBoxDodaj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdresy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDostepnePojazdy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopBar_3;
        private System.Windows.Forms.Button Btn_Back_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridTransport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ComboNumerDostawy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ButtonDodajDostawe;
        private System.Windows.Forms.Button ButtonUsunDostawy;
        private System.Windows.Forms.Button ButtonEdytujDostawe;
        private System.Windows.Forms.Label lblIdZlecenia;
        private System.Windows.Forms.Panel groupBoxDodaj;
        private System.Windows.Forms.CheckBox checkBoxWszytkie;
        private System.Windows.Forms.ComboBox comboBoxZlecenie;
        private System.Windows.Forms.Label lblDlTrasy;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblIdPojazdu;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.DataGridView dataGridViewDostepnePojazdy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewAdresy;
    }
}