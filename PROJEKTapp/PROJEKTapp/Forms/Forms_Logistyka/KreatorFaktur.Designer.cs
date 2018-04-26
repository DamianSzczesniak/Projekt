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
            this.Combo_wyb_zlec = new System.Windows.Forms.ComboBox();
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
            this.txtbox_pracownik = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox_dane_firmy = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.dataGridView_faktura.Location = new System.Drawing.Point(28, 49);
            this.dataGridView_faktura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_faktura.Name = "dataGridView_faktura";
            this.dataGridView_faktura.RowTemplate.Height = 24;
            this.dataGridView_faktura.Size = new System.Drawing.Size(550, 685);
            this.dataGridView_faktura.TabIndex = 19;
            // 
            // Combo_wyb_zlec
            // 
            this.Combo_wyb_zlec.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_wyb_zlec.FormattingEnabled = true;
            this.Combo_wyb_zlec.Location = new System.Drawing.Point(28, 12);
            this.Combo_wyb_zlec.Name = "Combo_wyb_zlec";
            this.Combo_wyb_zlec.Size = new System.Drawing.Size(121, 32);
            this.Combo_wyb_zlec.TabIndex = 21;
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.Location = new System.Drawing.Point(155, 11);
            this.btnGeneruj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(73, 34);
            this.btnGeneruj.TabIndex = 22;
            this.btnGeneruj.Text = "Generuj";
            this.btnGeneruj.UseVisualStyleBackColor = true;
            this.btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // txtbox_nr_faktury
            // 
            this.txtbox_nr_faktury.Location = new System.Drawing.Point(313, 76);
            this.txtbox_nr_faktury.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_nr_faktury.Name = "txtbox_nr_faktury";
            this.txtbox_nr_faktury.Size = new System.Drawing.Size(66, 20);
            this.txtbox_nr_faktury.TabIndex = 23;
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
            this.label3.Location = new System.Drawing.Point(46, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Numer zlecenia:";
            // 
            // txtbox_nr_zlec
            // 
            this.txtbox_nr_zlec.Location = new System.Drawing.Point(180, 208);
            this.txtbox_nr_zlec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_nr_zlec.Name = "txtbox_nr_zlec";
            this.txtbox_nr_zlec.Size = new System.Drawing.Size(48, 20);
            this.txtbox_nr_zlec.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(341, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Data wystawienia:";
            // 
            // txtbox_data_wyst
            // 
            this.txtbox_data_wyst.Location = new System.Drawing.Point(497, 206);
            this.txtbox_data_wyst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_data_wyst.Name = "txtbox_data_wyst";
            this.txtbox_data_wyst.Size = new System.Drawing.Size(66, 20);
            this.txtbox_data_wyst.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(310, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Data płatności:";
            // 
            // txtbox_data_plat
            // 
            this.txtbox_data_plat.Location = new System.Drawing.Point(444, 315);
            this.txtbox_data_plat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_data_plat.Name = "txtbox_data_plat";
            this.txtbox_data_plat.Size = new System.Drawing.Size(66, 20);
            this.txtbox_data_plat.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(323, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Kwota:";
            // 
            // txtbox_kwota
            // 
            this.txtbox_kwota.Location = new System.Drawing.Point(457, 406);
            this.txtbox_kwota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_kwota.Name = "txtbox_kwota";
            this.txtbox_kwota.Size = new System.Drawing.Size(66, 20);
            this.txtbox_kwota.TabIndex = 37;
            // 
            // txtbox_wal
            // 
            this.txtbox_wal.Location = new System.Drawing.Point(539, 406);
            this.txtbox_wal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_wal.Name = "txtbox_wal";
            this.txtbox_wal.Size = new System.Drawing.Size(27, 20);
            this.txtbox_wal.TabIndex = 39;
            // 
            // txtbox_wal_zl
            // 
            this.txtbox_wal_zl.Location = new System.Drawing.Point(539, 429);
            this.txtbox_wal_zl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_wal_zl.Name = "txtbox_wal_zl";
            this.txtbox_wal_zl.Size = new System.Drawing.Size(27, 20);
            this.txtbox_wal_zl.TabIndex = 40;
            // 
            // txtbox_kwota_zl
            // 
            this.txtbox_kwota_zl.Location = new System.Drawing.Point(457, 429);
            this.txtbox_kwota_zl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_kwota_zl.Name = "txtbox_kwota_zl";
            this.txtbox_kwota_zl.Size = new System.Drawing.Size(66, 20);
            this.txtbox_kwota_zl.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(46, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Pracownik:";
            // 
            // txtbox_pracownik
            // 
            this.txtbox_pracownik.Location = new System.Drawing.Point(179, 233);
            this.txtbox_pracownik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_pracownik.Name = "txtbox_pracownik";
            this.txtbox_pracownik.Size = new System.Drawing.Size(138, 20);
            this.txtbox_pracownik.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(338, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Miejsce wystawienia:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(497, 232);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 45;
            this.textBox1.Text = "Warszawa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(46, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Dane firmy:";
            // 
            // listBox_dane_firmy
            // 
            this.listBox_dane_firmy.FormattingEnabled = true;
            this.listBox_dane_firmy.Location = new System.Drawing.Point(47, 315);
            this.listBox_dane_firmy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_dane_firmy.Name = "listBox_dane_firmy";
            this.listBox_dane_firmy.Size = new System.Drawing.Size(151, 147);
            this.listBox_dane_firmy.TabIndex = 46;
            this.listBox_dane_firmy.SelectedIndexChanged += new System.EventHandler(this.listBox_dane_firmy_SelectedIndexChanged);
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
            this.label11.Location = new System.Drawing.Point(346, 710);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 7);
            this.label11.TabIndex = 51;
            this.label11.Text = "Osoba upoważniona do odbioru";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox4.Location = new System.Drawing.Point(291, 706);
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
            // KreatorFaktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox_dane_firmy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbox_pracownik);
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
            this.Controls.Add(this.Combo_wyb_zlec);
            this.Controls.Add(this.dataGridView_faktura);
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
        private System.Windows.Forms.ComboBox Combo_wyb_zlec;
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
        private System.Windows.Forms.TextBox txtbox_pracownik;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox_dane_firmy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
    }
}