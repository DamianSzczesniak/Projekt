namespace PROJEKTapp.Forms_Produkcja
{
    partial class FormSpis
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
            this.lblTrybFiltracji = new System.Windows.Forms.Label();
            this.cboxWybierzTryb = new System.Windows.Forms.ComboBox();
            this.txtNazwaProduktu = new System.Windows.Forms.TextBox();
            this.lblNazwaProduktu = new System.Windows.Forms.Label();
            this.GridWykorzystaneMaszyny = new System.Windows.Forms.DataGridView();
            this.btnExitWykorzystaneMaszyny = new System.Windows.Forms.Button();
            this.EwidencjaMaszynyNarzedzia = new System.Windows.Forms.DataGridView();
            this.ZapiszEdytuj = new System.Windows.Forms.Button();
            this.Usun = new System.Windows.Forms.Button();
            this.buttonUtworz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridWykorzystaneMaszyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EwidencjaMaszynyNarzedzia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrybFiltracji
            // 
            this.lblTrybFiltracji.AutoSize = true;
            this.lblTrybFiltracji.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrybFiltracji.Location = new System.Drawing.Point(557, 59);
            this.lblTrybFiltracji.Name = "lblTrybFiltracji";
            this.lblTrybFiltracji.Size = new System.Drawing.Size(241, 29);
            this.lblTrybFiltracji.TabIndex = 11;
            this.lblTrybFiltracji.Text = "Wybierz tryb filtracji";
            // 
            // cboxWybierzTryb
            // 
            this.cboxWybierzTryb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxWybierzTryb.FormattingEnabled = true;
            this.cboxWybierzTryb.Items.AddRange(new object[] {
            "Ewidencja Maszyn",
            "Ewidencja Narzędzia"});
            this.cboxWybierzTryb.Location = new System.Drawing.Point(813, 59);
            this.cboxWybierzTryb.Name = "cboxWybierzTryb";
            this.cboxWybierzTryb.Size = new System.Drawing.Size(255, 33);
            this.cboxWybierzTryb.TabIndex = 10;
            this.cboxWybierzTryb.Text = "Ewidencja maszyn";
            this.cboxWybierzTryb.SelectedIndexChanged += new System.EventHandler(this.cboxWybierzTryb_SelectedIndexChanged);
            // 
            // txtNazwaProduktu
            // 
            this.txtNazwaProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaProduktu.Location = new System.Drawing.Point(325, 57);
            this.txtNazwaProduktu.Name = "txtNazwaProduktu";
            this.txtNazwaProduktu.Size = new System.Drawing.Size(168, 31);
            this.txtNazwaProduktu.TabIndex = 9;
            this.txtNazwaProduktu.TextChanged += new System.EventHandler(this.txtNazwaProduktu_TextChanged);
            // 
            // lblNazwaProduktu
            // 
            this.lblNazwaProduktu.AutoSize = true;
            this.lblNazwaProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaProduktu.Location = new System.Drawing.Point(61, 59);
            this.lblNazwaProduktu.Name = "lblNazwaProduktu";
            this.lblNazwaProduktu.Size = new System.Drawing.Size(258, 29);
            this.lblNazwaProduktu.TabIndex = 8;
            this.lblNazwaProduktu.Text = "Wpisz nazwę modelu";
            // 
            // GridWykorzystaneMaszyny
            // 
            this.GridWykorzystaneMaszyny.AllowUserToAddRows = false;
            this.GridWykorzystaneMaszyny.AllowUserToDeleteRows = false;
            this.GridWykorzystaneMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridWykorzystaneMaszyny.Location = new System.Drawing.Point(66, 127);
            this.GridWykorzystaneMaszyny.Name = "GridWykorzystaneMaszyny";
            this.GridWykorzystaneMaszyny.ReadOnly = true;
            this.GridWykorzystaneMaszyny.Size = new System.Drawing.Size(820, 547);
            this.GridWykorzystaneMaszyny.TabIndex = 7;
            // 
            // btnExitWykorzystaneMaszyny
            // 
            this.btnExitWykorzystaneMaszyny.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExitWykorzystaneMaszyny.FlatAppearance.BorderSize = 0;
            this.btnExitWykorzystaneMaszyny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitWykorzystaneMaszyny.Image = global::PROJEKTapp.Properties.Resources.btnExit_Image;
            this.btnExitWykorzystaneMaszyny.Location = new System.Drawing.Point(1223, -1);
            this.btnExitWykorzystaneMaszyny.Name = "btnExitWykorzystaneMaszyny";
            this.btnExitWykorzystaneMaszyny.Size = new System.Drawing.Size(67, 52);
            this.btnExitWykorzystaneMaszyny.TabIndex = 6;
            this.btnExitWykorzystaneMaszyny.UseVisualStyleBackColor = false;
            this.btnExitWykorzystaneMaszyny.Click += new System.EventHandler(this.btnExitWykorzystaneMaszyny_Click);
            // 
            // EwidencjaMaszynyNarzedzia
            // 
            this.EwidencjaMaszynyNarzedzia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EwidencjaMaszynyNarzedzia.Location = new System.Drawing.Point(66, 127);
            this.EwidencjaMaszynyNarzedzia.Name = "EwidencjaMaszynyNarzedzia";
            this.EwidencjaMaszynyNarzedzia.Size = new System.Drawing.Size(990, 547);
            this.EwidencjaMaszynyNarzedzia.TabIndex = 12;
            // 
            // ZapiszEdytuj
            // 
            this.ZapiszEdytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ZapiszEdytuj.Location = new System.Drawing.Point(1141, 337);
            this.ZapiszEdytuj.Name = "ZapiszEdytuj";
            this.ZapiszEdytuj.Size = new System.Drawing.Size(134, 83);
            this.ZapiszEdytuj.TabIndex = 13;
            this.ZapiszEdytuj.Text = "Edytuj";
            this.ZapiszEdytuj.UseVisualStyleBackColor = true;
            this.ZapiszEdytuj.Click += new System.EventHandler(this.ZapiszEdytuj_Click);
            // 
            // Usun
            // 
            this.Usun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Usun.Location = new System.Drawing.Point(1141, 453);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(134, 83);
            this.Usun.TabIndex = 13;
            this.Usun.Text = "Usuń";
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // buttonUtworz
            // 
            this.buttonUtworz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonUtworz.Location = new System.Drawing.Point(1141, 223);
            this.buttonUtworz.Name = "buttonUtworz";
            this.buttonUtworz.Size = new System.Drawing.Size(134, 89);
            this.buttonUtworz.TabIndex = 14;
            this.buttonUtworz.Text = "Utwórz";
            this.buttonUtworz.UseVisualStyleBackColor = true;
            this.buttonUtworz.Click += new System.EventHandler(this.buttonUtworz_Click);
            // 
            // FormSpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 721);
            this.Controls.Add(this.buttonUtworz);
            this.Controls.Add(this.Usun);
            this.Controls.Add(this.ZapiszEdytuj);
            this.Controls.Add(this.EwidencjaMaszynyNarzedzia);
            this.Controls.Add(this.lblTrybFiltracji);
            this.Controls.Add(this.cboxWybierzTryb);
            this.Controls.Add(this.txtNazwaProduktu);
            this.Controls.Add(this.lblNazwaProduktu);
            this.Controls.Add(this.GridWykorzystaneMaszyny);
            this.Controls.Add(this.btnExitWykorzystaneMaszyny);
            this.Name = "FormSpis";
            this.Text = "FormSpis";
            this.Load += new System.EventHandler(this.FormSpis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridWykorzystaneMaszyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EwidencjaMaszynyNarzedzia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrybFiltracji;
        private System.Windows.Forms.ComboBox cboxWybierzTryb;
        private System.Windows.Forms.TextBox txtNazwaProduktu;
        private System.Windows.Forms.Label lblNazwaProduktu;
        private System.Windows.Forms.DataGridView GridWykorzystaneMaszyny;
        private System.Windows.Forms.Button btnExitWykorzystaneMaszyny;
        private System.Windows.Forms.DataGridView EwidencjaMaszynyNarzedzia;
        private System.Windows.Forms.Button ZapiszEdytuj;
        private System.Windows.Forms.Button Usun;
        private System.Windows.Forms.Button buttonUtworz;
    }
}