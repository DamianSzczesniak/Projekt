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
            this.dataGridView_faktura = new System.Windows.Forms.DataGridView();
            this.btnGeneruj = new System.Windows.Forms.Button();
            this.txtbox_nr_faktury = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_nr_zlec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_data_wyst = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_data_plat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_kwota = new System.Windows.Forms.TextBox();
            this.txtbox_wal = new System.Windows.Forms.TextBox();
            this.txtbox_wal_zl = new System.Windows.Forms.TextBox();
            this.txtbox_kwota_zl = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_faktura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_faktura
            // 
            this.dataGridView_faktura.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_faktura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_faktura.Location = new System.Drawing.Point(37, 60);
            this.dataGridView_faktura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_faktura.Name = "dataGridView_faktura";
            this.dataGridView_faktura.RowTemplate.Height = 24;
            this.dataGridView_faktura.Size = new System.Drawing.Size(733, 843);
            this.dataGridView_faktura.TabIndex = 19;
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.Location = new System.Drawing.Point(207, 14);
            this.btnGeneruj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(97, 42);
            this.btnGeneruj.TabIndex = 22;
            this.btnGeneruj.Text = "Generuj";
            this.btnGeneruj.UseVisualStyleBackColor = true;
            this.btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // txtbox_nr_faktury
            // 
            this.txtbox_nr_faktury.Location = new System.Drawing.Point(417, 94);
            this.txtbox_nr_faktury.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_nr_faktury.Name = "txtbox_nr_faktury";
            this.txtbox_nr_faktury.Size = new System.Drawing.Size(87, 22);
            this.txtbox_nr_faktury.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(307, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Faktura nr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(61, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Numer zlecenia:";
            // 
            // txtbox_nr_zlec
            // 
            this.txtbox_nr_zlec.Location = new System.Drawing.Point(208, 254);
            this.txtbox_nr_zlec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_nr_zlec.Name = "txtbox_nr_zlec";
            this.txtbox_nr_zlec.Size = new System.Drawing.Size(63, 22);
            this.txtbox_nr_zlec.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(455, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Data wystawienia:";
            // 
            // txtbox_data_wyst
            // 
            this.txtbox_data_wyst.Location = new System.Drawing.Point(663, 254);
            this.txtbox_data_wyst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_data_wyst.Name = "txtbox_data_wyst";
            this.txtbox_data_wyst.Size = new System.Drawing.Size(87, 22);
            this.txtbox_data_wyst.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(413, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Data płatności:";
            // 
            // txtbox_data_plat
            // 
            this.txtbox_data_plat.Location = new System.Drawing.Point(592, 388);
            this.txtbox_data_plat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_data_plat.Name = "txtbox_data_plat";
            this.txtbox_data_plat.Size = new System.Drawing.Size(87, 22);
            this.txtbox_data_plat.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(431, 500);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Kwota:";
            // 
            // txtbox_kwota
            // 
            this.txtbox_kwota.Location = new System.Drawing.Point(609, 500);
            this.txtbox_kwota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_kwota.Name = "txtbox_kwota";
            this.txtbox_kwota.Size = new System.Drawing.Size(87, 22);
            this.txtbox_kwota.TabIndex = 37;
            // 
            // txtbox_wal
            // 
            this.txtbox_wal.Location = new System.Drawing.Point(719, 500);
            this.txtbox_wal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_wal.Name = "txtbox_wal";
            this.txtbox_wal.Size = new System.Drawing.Size(35, 22);
            this.txtbox_wal.TabIndex = 39;
            // 
            // txtbox_wal_zl
            // 
            this.txtbox_wal_zl.Location = new System.Drawing.Point(719, 528);
            this.txtbox_wal_zl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_wal_zl.Name = "txtbox_wal_zl";
            this.txtbox_wal_zl.Size = new System.Drawing.Size(35, 22);
            this.txtbox_wal_zl.TabIndex = 40;
            // 
            // txtbox_kwota_zl
            // 
            this.txtbox_kwota_zl.Location = new System.Drawing.Point(609, 528);
            this.txtbox_kwota_zl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_kwota_zl.Name = "txtbox_kwota_zl";
            this.txtbox_kwota_zl.Size = new System.Drawing.Size(87, 22);
            this.txtbox_kwota_zl.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(61, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Pracownik:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(451, 289);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Miejsce wystawienia:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(663, 286);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 22);
            this.textBox1.TabIndex = 45;
            this.textBox1.Text = "Warszawa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(61, 361);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Dane firmy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(119, 874);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 12);
            this.label5.TabIndex = 50;
            this.label5.Text = "Osoba upoważniona do wysawienia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(461, 874);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 12);
            this.label11.TabIndex = 51;
            this.label11.Text = "Osoba upoważniona do odbioru";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox4.Location = new System.Drawing.Point(388, 869);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(265, 1);
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox3.Location = new System.Drawing.Point(75, 869);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(265, 1);
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Location = new System.Drawing.Point(37, 139);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(732, 1);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_nazwa_firmy
            // 
            this.textBox_nazwa_firmy.Location = new System.Drawing.Point(207, 357);
            this.textBox_nazwa_firmy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_nazwa_firmy.Name = "textBox_nazwa_firmy";
            this.textBox_nazwa_firmy.Size = new System.Drawing.Size(127, 22);
            this.textBox_nazwa_firmy.TabIndex = 52;
            // 
            // textBox_adres_email
            // 
            this.textBox_adres_email.Location = new System.Drawing.Point(207, 386);
            this.textBox_adres_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_adres_email.Name = "textBox_adres_email";
            this.textBox_adres_email.Size = new System.Drawing.Size(127, 22);
            this.textBox_adres_email.TabIndex = 53;
            // 
            // textBox_nr_telefonu
            // 
            this.textBox_nr_telefonu.Location = new System.Drawing.Point(207, 412);
            this.textBox_nr_telefonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_nr_telefonu.Name = "textBox_nr_telefonu";
            this.textBox_nr_telefonu.Size = new System.Drawing.Size(127, 22);
            this.textBox_nr_telefonu.TabIndex = 54;
            // 
            // textBox_nip
            // 
            this.textBox_nip.Location = new System.Drawing.Point(207, 438);
            this.textBox_nip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_nip.Name = "textBox_nip";
            this.textBox_nip.Size = new System.Drawing.Size(127, 22);
            this.textBox_nip.TabIndex = 55;
            // 
            // comboBoxPracownik
            // 
            this.comboBoxPracownik.FormattingEnabled = true;
            this.comboBoxPracownik.Location = new System.Drawing.Point(207, 289);
            this.comboBoxPracownik.Name = "comboBoxPracownik";
            this.comboBoxPracownik.Size = new System.Drawing.Size(127, 24);
            this.comboBoxPracownik.TabIndex = 56;
            // 
            // KreatorFaktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 937);
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
            this.Controls.Add(this.txtbox_kwota_zl);
            this.Controls.Add(this.txtbox_wal_zl);
            this.Controls.Add(this.txtbox_wal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_kwota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbox_data_plat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_data_wyst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_nr_zlec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_nr_faktury);
            this.Controls.Add(this.btnGeneruj);
            this.Controls.Add(this.dataGridView_faktura);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KreatorFaktur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreator_Faktur";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_faktura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_faktura;
        private System.Windows.Forms.Button btnGeneruj;
        private System.Windows.Forms.TextBox txtbox_nr_faktury;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_nr_zlec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_data_wyst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_data_plat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_kwota;
        private System.Windows.Forms.TextBox txtbox_wal;
        private System.Windows.Forms.TextBox txtbox_wal_zl;
        private System.Windows.Forms.TextBox txtbox_kwota_zl;
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
    }
}