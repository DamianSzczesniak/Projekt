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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Back_4 = new System.Windows.Forms.Button();
            this.TopBar_4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_faktura = new System.Windows.Forms.DataGridView();
            this.nr_zlec = new System.Windows.Forms.Label();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_faktura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = ".../Logistyka/Kreator faktur";
            // 
            // Btn_Back_4
            // 
            this.Btn_Back_4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Back_4.FlatAppearance.BorderSize = 0;
            this.Btn_Back_4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back_4.Image = global::PROJEKTapp.Properties.Resources.return2;
            this.Btn_Back_4.Location = new System.Drawing.Point(0, 0);
            this.Btn_Back_4.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Back_4.Name = "Btn_Back_4";
            this.Btn_Back_4.Size = new System.Drawing.Size(107, 69);
            this.Btn_Back_4.TabIndex = 11;
            this.Btn_Back_4.UseVisualStyleBackColor = false;
            this.Btn_Back_4.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // TopBar_4
            // 
            this.TopBar_4.Image = global::PROJEKTapp.Properties.Resources.top_bar1;
            this.TopBar_4.Location = new System.Drawing.Point(0, 0);
            this.TopBar_4.Margin = new System.Windows.Forms.Padding(4);
            this.TopBar_4.Name = "TopBar_4";
            this.TopBar_4.Size = new System.Drawing.Size(1280, 89);
            this.TopBar_4.TabIndex = 10;
            this.TopBar_4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(16, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1248, 2);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView_faktura
            // 
            this.dataGridView_faktura.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_faktura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_faktura.Location = new System.Drawing.Point(37, 167);
            this.dataGridView_faktura.Name = "dataGridView_faktura";
            this.dataGridView_faktura.RowTemplate.Height = 24;
            this.dataGridView_faktura.Size = new System.Drawing.Size(878, 482);
            this.dataGridView_faktura.TabIndex = 19;
            // 
            // nr_zlec
            // 
            this.nr_zlec.AutoSize = true;
            this.nr_zlec.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr_zlec.ForeColor = System.Drawing.SystemColors.Highlight;
            this.nr_zlec.Location = new System.Drawing.Point(31, 129);
            this.nr_zlec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nr_zlec.Name = "nr_zlec";
            this.nr_zlec.Size = new System.Drawing.Size(210, 32);
            this.nr_zlec.TabIndex = 20;
            this.nr_zlec.Text = "Numer zlecenia:";
            // 
            // Combo_wyb_zlec
            // 
            this.Combo_wyb_zlec.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_wyb_zlec.FormattingEnabled = true;
            this.Combo_wyb_zlec.Location = new System.Drawing.Point(238, 126);
            this.Combo_wyb_zlec.Margin = new System.Windows.Forms.Padding(4);
            this.Combo_wyb_zlec.Name = "Combo_wyb_zlec";
            this.Combo_wyb_zlec.Size = new System.Drawing.Size(160, 39);
            this.Combo_wyb_zlec.TabIndex = 21;
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.Location = new System.Drawing.Point(406, 133);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(88, 28);
            this.btnGeneruj.TabIndex = 22;
            this.btnGeneruj.Text = "Generuj";
            this.btnGeneruj.UseVisualStyleBackColor = true;
            this.btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // txtbox_nr_faktury
            // 
            this.txtbox_nr_faktury.Location = new System.Drawing.Point(483, 195);
            this.txtbox_nr_faktury.Name = "txtbox_nr_faktury";
            this.txtbox_nr_faktury.Size = new System.Drawing.Size(87, 22);
            this.txtbox_nr_faktury.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(375, 197);
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
            this.txtbox_nr_zlec.Location = new System.Drawing.Point(240, 256);
            this.txtbox_nr_zlec.Name = "txtbox_nr_zlec";
            this.txtbox_nr_zlec.Size = new System.Drawing.Size(87, 22);
            this.txtbox_nr_zlec.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(584, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Data wystawienia:";
            // 
            // txtbox_data_wyst
            // 
            this.txtbox_data_wyst.Location = new System.Drawing.Point(789, 256);
            this.txtbox_data_wyst.Name = "txtbox_data_wyst";
            this.txtbox_data_wyst.Size = new System.Drawing.Size(87, 22);
            this.txtbox_data_wyst.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(584, 440);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Data płatności:";
            // 
            // txtbox_data_plat
            // 
            this.txtbox_data_plat.Location = new System.Drawing.Point(763, 440);
            this.txtbox_data_plat.Name = "txtbox_data_plat";
            this.txtbox_data_plat.Size = new System.Drawing.Size(87, 22);
            this.txtbox_data_plat.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(584, 480);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Kwota:";
            // 
            // txtbox_kwota
            // 
            this.txtbox_kwota.Location = new System.Drawing.Point(763, 480);
            this.txtbox_kwota.Name = "txtbox_kwota";
            this.txtbox_kwota.Size = new System.Drawing.Size(87, 22);
            this.txtbox_kwota.TabIndex = 37;
            // 
            // txtbox_wal
            // 
            this.txtbox_wal.Location = new System.Drawing.Point(872, 480);
            this.txtbox_wal.Name = "txtbox_wal";
            this.txtbox_wal.Size = new System.Drawing.Size(35, 22);
            this.txtbox_wal.TabIndex = 39;
            // 
            // txtbox_wal_zl
            // 
            this.txtbox_wal_zl.Location = new System.Drawing.Point(872, 508);
            this.txtbox_wal_zl.Name = "txtbox_wal_zl";
            this.txtbox_wal_zl.Size = new System.Drawing.Size(35, 22);
            this.txtbox_wal_zl.TabIndex = 40;
            // 
            // txtbox_kwota_zl
            // 
            this.txtbox_kwota_zl.Location = new System.Drawing.Point(763, 508);
            this.txtbox_kwota_zl.Name = "txtbox_kwota_zl";
            this.txtbox_kwota_zl.Size = new System.Drawing.Size(87, 22);
            this.txtbox_kwota_zl.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(59, 550);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Pracownik:";
            // 
            // txtbox_pracownik
            // 
            this.txtbox_pracownik.Location = new System.Drawing.Point(238, 550);
            this.txtbox_pracownik.Name = "txtbox_pracownik";
            this.txtbox_pracownik.Size = new System.Drawing.Size(160, 22);
            this.txtbox_pracownik.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(584, 289);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Miejsce wystawienia:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(789, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 22);
            this.textBox1.TabIndex = 45;
            this.textBox1.Text = "Warszawa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(62, 288);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Dane firmy:";
            // 
            // listBox_dane_firmy
            // 
            this.listBox_dane_firmy.FormattingEnabled = true;
            this.listBox_dane_firmy.ItemHeight = 16;
            this.listBox_dane_firmy.Location = new System.Drawing.Point(240, 289);
            this.listBox_dane_firmy.Name = "listBox_dane_firmy";
            this.listBox_dane_firmy.Size = new System.Drawing.Size(251, 212);
            this.listBox_dane_firmy.TabIndex = 46;
            this.listBox_dane_firmy.SelectedIndexChanged += new System.EventHandler(this.listBox_dane_firmy_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Location = new System.Drawing.Point(37, 246);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(878, 2);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox3.Location = new System.Drawing.Point(238, 605);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(265, 1);
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox4.Location = new System.Drawing.Point(611, 605);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(265, 1);
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(281, 610);
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
            this.label11.Location = new System.Drawing.Point(684, 610);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 12);
            this.label11.TabIndex = 51;
            this.label11.Text = "Osoba upoważniona do odbioru";
            // 
            // KreatorFaktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 665);
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
            this.Controls.Add(this.nr_zlec);
            this.Controls.Add(this.dataGridView_faktura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Back_4);
            this.Controls.Add(this.TopBar_4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KreatorFaktur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreator_Faktur";
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_faktura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back_4;
        private System.Windows.Forms.PictureBox TopBar_4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_faktura;
        private System.Windows.Forms.Label nr_zlec;
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