namespace PROJEKTapp.Forms
{
    partial class KreatorFaktur
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_faktura = new System.Windows.Forms.DataGridView();
            this.txtbox_nr_faktury = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_nr_zlec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_data_plat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_kwota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_nazwa_firmy = new System.Windows.Forms.TextBox();
            this.textBox_adres_email = new System.Windows.Forms.TextBox();
            this.textBox_nr_telefonu = new System.Windows.Forms.TextBox();
            this.textBox_nip = new System.Windows.Forms.TextBox();
            this.comboBoxPracownik = new System.Windows.Forms.ComboBox();
            this.txtbox_data_wyst = new System.Windows.Forms.TextBox();
            this.comboBox_kwotaWal = new System.Windows.Forms.ComboBox();
            this.aKTUALNYKURSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.lblNip = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.lblWaluta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_faktura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKTUALNYKURSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_faktura
            // 
            this.dataGridView_faktura.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_faktura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_faktura.Location = new System.Drawing.Point(28, 49);
            this.dataGridView_faktura.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_faktura.Name = "dataGridView_faktura";
            this.dataGridView_faktura.RowTemplate.Height = 24;
            this.dataGridView_faktura.Size = new System.Drawing.Size(550, 685);
            this.dataGridView_faktura.TabIndex = 19;
            // 
            // txtbox_nr_faktury
            // 
            this.txtbox_nr_faktury.Location = new System.Drawing.Point(323, 78);
            this.txtbox_nr_faktury.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_nr_faktury.Name = "txtbox_nr_faktury";
            this.txtbox_nr_faktury.ReadOnly = true;
            this.txtbox_nr_faktury.Size = new System.Drawing.Size(66, 20);
            this.txtbox_nr_faktury.TabIndex = 23;
            this.txtbox_nr_faktury.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(230, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Faktura nr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(46, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Numer zlecenia:";
            // 
            // txtbox_nr_zlec
            // 
            this.txtbox_nr_zlec.Location = new System.Drawing.Point(176, 166);
            this.txtbox_nr_zlec.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_nr_zlec.Name = "txtbox_nr_zlec";
            this.txtbox_nr_zlec.ReadOnly = true;
            this.txtbox_nr_zlec.Size = new System.Drawing.Size(111, 20);
            this.txtbox_nr_zlec.TabIndex = 31;
            this.txtbox_nr_zlec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(320, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Data wystawienia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(320, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Data płatności:";
            // 
            // txtbox_data_plat
            // 
            this.txtbox_data_plat.Location = new System.Drawing.Point(447, 329);
            this.txtbox_data_plat.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_data_plat.Name = "txtbox_data_plat";
            this.txtbox_data_plat.Size = new System.Drawing.Size(116, 20);
            this.txtbox_data_plat.TabIndex = 35;
            this.txtbox_data_plat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(320, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Kwota:";
            // 
            // txtbox_kwota
            // 
            this.txtbox_kwota.Location = new System.Drawing.Point(397, 412);
            this.txtbox_kwota.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_kwota.Name = "txtbox_kwota";
            this.txtbox_kwota.ReadOnly = true;
            this.txtbox_kwota.Size = new System.Drawing.Size(107, 20);
            this.txtbox_kwota.TabIndex = 37;
            this.txtbox_kwota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(46, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Pracownik:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(320, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Miejsce wystawienia:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(496, 216);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 45;
            this.textBox1.Text = "Warszawa";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(46, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Dane firmy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(89, 710);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 7);
            this.label5.TabIndex = 50;
            this.label5.Text = "Osoba upoważniona do wysawienia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(405, 710);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 7);
            this.label11.TabIndex = 51;
            this.label11.Text = "Osoba upoważniona do odbioru";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox4.Location = new System.Drawing.Point(350, 706);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(199, 1);
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox3.Location = new System.Drawing.Point(56, 706);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 1);
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Location = new System.Drawing.Point(28, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(549, 1);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_nazwa_firmy
            // 
            this.textBox_nazwa_firmy.Location = new System.Drawing.Point(101, 382);
            this.textBox_nazwa_firmy.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nazwa_firmy.Name = "textBox_nazwa_firmy";
            this.textBox_nazwa_firmy.ReadOnly = true;
            this.textBox_nazwa_firmy.Size = new System.Drawing.Size(132, 20);
            this.textBox_nazwa_firmy.TabIndex = 52;
            this.textBox_nazwa_firmy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_adres_email
            // 
            this.textBox_adres_email.Location = new System.Drawing.Point(79, 550);
            this.textBox_adres_email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_adres_email.Name = "textBox_adres_email";
            this.textBox_adres_email.ReadOnly = true;
            this.textBox_adres_email.Size = new System.Drawing.Size(184, 20);
            this.textBox_adres_email.TabIndex = 53;
            this.textBox_adres_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_nr_telefonu
            // 
            this.textBox_nr_telefonu.Location = new System.Drawing.Point(101, 492);
            this.textBox_nr_telefonu.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nr_telefonu.Name = "textBox_nr_telefonu";
            this.textBox_nr_telefonu.ReadOnly = true;
            this.textBox_nr_telefonu.Size = new System.Drawing.Size(132, 20);
            this.textBox_nr_telefonu.TabIndex = 54;
            this.textBox_nr_telefonu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_nip
            // 
            this.textBox_nip.Location = new System.Drawing.Point(101, 434);
            this.textBox_nip.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nip.Name = "textBox_nip";
            this.textBox_nip.ReadOnly = true;
            this.textBox_nip.Size = new System.Drawing.Size(132, 20);
            this.textBox_nip.TabIndex = 55;
            this.textBox_nip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxPracownik
            // 
            this.comboBoxPracownik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPracownik.FormattingEnabled = true;
            this.comboBoxPracownik.Location = new System.Drawing.Point(49, 272);
            this.comboBoxPracownik.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPracownik.Name = "comboBoxPracownik";
            this.comboBoxPracownik.Size = new System.Drawing.Size(278, 21);
            this.comboBoxPracownik.TabIndex = 56;
            // 
            // txtbox_data_wyst
            // 
            this.txtbox_data_wyst.Location = new System.Drawing.Point(488, 166);
            this.txtbox_data_wyst.Name = "txtbox_data_wyst";
            this.txtbox_data_wyst.ReadOnly = true;
            this.txtbox_data_wyst.Size = new System.Drawing.Size(75, 20);
            this.txtbox_data_wyst.TabIndex = 57;
            this.txtbox_data_wyst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_kwotaWal
            // 
            this.comboBox_kwotaWal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.aKTUALNYKURSBindingSource, "KURS_DO_PLN", true));
            this.comboBox_kwotaWal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kwotaWal.FormattingEnabled = true;
            this.comboBox_kwotaWal.Location = new System.Drawing.Point(410, 382);
            this.comboBox_kwotaWal.Name = "comboBox_kwotaWal";
            this.comboBox_kwotaWal.Size = new System.Drawing.Size(80, 21);
            this.comboBox_kwotaWal.TabIndex = 58;
            this.comboBox_kwotaWal.DropDownClosed += new System.EventHandler(this.comboBox_kwotaWal_DropDownClosed);
            // 
            // aKTUALNYKURSBindingSource
            // 
            this.aKTUALNYKURSBindingSource.DataSource = typeof(PROJEKTapp.AKTUALNY_KURS);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(487, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Location = new System.Drawing.Point(125, 367);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(73, 13);
            this.lblNazwa.TabIndex = 60;
            this.lblNazwa.Text = "Nazwa Firmy :";
            // 
            // lblNip
            // 
            this.lblNip.AutoSize = true;
            this.lblNip.Location = new System.Drawing.Point(149, 419);
            this.lblNip.Name = "lblNip";
            this.lblNip.Size = new System.Drawing.Size(31, 13);
            this.lblNip.TabIndex = 61;
            this.lblNip.Text = "NIP :";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(129, 474);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(69, 13);
            this.lbl_telefon.TabIndex = 62;
            this.lbl_telefon.Text = "Nr Telefonu :";
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(128, 532);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(74, 13);
            this.lbl_Mail.TabIndex = 63;
            this.lbl_Mail.Text = "Adres E-mail : ";
            // 
            // lblWaluta
            // 
            this.lblWaluta.AutoSize = true;
            this.lblWaluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWaluta.Location = new System.Drawing.Point(320, 382);
            this.lblWaluta.Name = "lblWaluta";
            this.lblWaluta.Size = new System.Drawing.Size(60, 16);
            this.lblWaluta.TabIndex = 64;
            this.lblWaluta.Text = "Waluta:";
            // 
            // KreatorFaktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 761);
            this.Controls.Add(this.lblWaluta);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lblNip);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBox_kwotaWal);
            this.Controls.Add(this.txtbox_data_wyst);
            this.Controls.Add(this.comboBoxPracownik);
            this.Controls.Add(this.textBox_nip);
            this.Controls.Add(this.textBox_nr_telefonu);
            this.Controls.Add(this.textBox_adres_email);
            this.Controls.Add(this.textBox_nazwa_firmy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_kwota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbox_data_plat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_nr_zlec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_nr_faktury);
            this.Controls.Add(this.dataGridView_faktura);
            this.Name = "KreatorFaktur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreator_Faktur";
            this.Load += new System.EventHandler(this.KreatorFaktur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_faktura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKTUALNYKURSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_faktura;
        private System.Windows.Forms.TextBox txtbox_nr_faktury;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_nr_zlec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_data_plat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_kwota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_nazwa_firmy;
        private System.Windows.Forms.TextBox textBox_adres_email;
        private System.Windows.Forms.TextBox textBox_nr_telefonu;
        private System.Windows.Forms.TextBox textBox_nip;
        private System.Windows.Forms.ComboBox comboBoxPracownik;
        private System.Windows.Forms.TextBox txtbox_data_wyst;
        private System.Windows.Forms.ComboBox comboBox_kwotaWal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Label lblNip;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.Label lblWaluta;
        private System.Windows.Forms.BindingSource aKTUALNYKURSBindingSource;
    }
}