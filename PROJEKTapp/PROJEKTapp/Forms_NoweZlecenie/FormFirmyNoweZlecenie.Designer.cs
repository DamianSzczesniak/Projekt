namespace PROJEKTapp.Forms
{
    partial class FormFirmyNoweZlecenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirmyNoweZlecenie));
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridFirmy = new System.Windows.Forms.DataGridView();
            this.lblFirmy = new System.Windows.Forms.Label();
            this.lblWyszukaj = new System.Windows.Forms.Label();
            this.txtBoxWyszukajFirme = new System.Windows.Forms.TextBox();
            this.btnWybierz = new System.Windows.Forms.Button();
            this.lblAdresEmail = new System.Windows.Forms.Label();
            this.lbNrTelefonu = new System.Windows.Forms.Label();
            this.lblNIP = new System.Windows.Forms.Label();
            this.btnDodajFirme = new System.Windows.Forms.Button();
            this.lblNowaFirma = new System.Windows.Forms.Label();
            this.txtB_NazwaFirmy = new System.Windows.Forms.TextBox();
            this.txtBAdresEmail = new System.Windows.Forms.TextBox();
            this.txtB_NrTelefonu = new System.Windows.Forms.TextBox();
            this.txtB_Nip = new System.Windows.Forms.TextBox();
            this.lblNazwaFirmy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFirmy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(639, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridFirmy
            // 
            this.dataGridFirmy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridFirmy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridFirmy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFirmy.Location = new System.Drawing.Point(54, 83);
            this.dataGridFirmy.Name = "dataGridFirmy";
            this.dataGridFirmy.Size = new System.Drawing.Size(259, 303);
            this.dataGridFirmy.TabIndex = 7;
            // 
            // lblFirmy
            // 
            this.lblFirmy.AutoSize = true;
            this.lblFirmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirmy.Location = new System.Drawing.Point(124, 44);
            this.lblFirmy.Name = "lblFirmy";
            this.lblFirmy.Size = new System.Drawing.Size(117, 24);
            this.lblFirmy.TabIndex = 8;
            this.lblFirmy.Text = "Dane Firmy";
            // 
            // lblWyszukaj
            // 
            this.lblWyszukaj.AutoSize = true;
            this.lblWyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWyszukaj.Location = new System.Drawing.Point(16, 17);
            this.lblWyszukaj.Name = "lblWyszukaj";
            this.lblWyszukaj.Size = new System.Drawing.Size(142, 20);
            this.lblWyszukaj.TabIndex = 9;
            this.lblWyszukaj.Text = "Wyszukaj Nazwe";
            // 
            // txtBoxWyszukajFirme
            // 
            this.txtBoxWyszukajFirme.Location = new System.Drawing.Point(186, 17);
            this.txtBoxWyszukajFirme.Name = "txtBoxWyszukajFirme";
            this.txtBoxWyszukajFirme.Size = new System.Drawing.Size(144, 20);
            this.txtBoxWyszukajFirme.TabIndex = 10;
            // 
            // btnWybierz
            // 
            this.btnWybierz.Location = new System.Drawing.Point(137, 405);
            this.btnWybierz.Name = "btnWybierz";
            this.btnWybierz.Size = new System.Drawing.Size(75, 23);
            this.btnWybierz.TabIndex = 11;
            this.btnWybierz.Text = "Wybierz";
            this.btnWybierz.UseVisualStyleBackColor = true;
            this.btnWybierz.Click += new System.EventHandler(this.btnWybierz_Click);
            // 
            // lblAdresEmail
            // 
            this.lblAdresEmail.AutoSize = true;
            this.lblAdresEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresEmail.Location = new System.Drawing.Point(369, 175);
            this.lblAdresEmail.Name = "lblAdresEmail";
            this.lblAdresEmail.Size = new System.Drawing.Size(94, 20);
            this.lblAdresEmail.TabIndex = 13;
            this.lblAdresEmail.Text = "Adres Email";
            // 
            // lbNrTelefonu
            // 
            this.lbNrTelefonu.AutoSize = true;
            this.lbNrTelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNrTelefonu.Location = new System.Drawing.Point(372, 271);
            this.lbNrTelefonu.Name = "lbNrTelefonu";
            this.lbNrTelefonu.Size = new System.Drawing.Size(91, 20);
            this.lbNrTelefonu.TabIndex = 14;
            this.lbNrTelefonu.Text = "Nr Telefonu";
            // 
            // lblNIP
            // 
            this.lblNIP.AutoSize = true;
            this.lblNIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNIP.Location = new System.Drawing.Point(372, 366);
            this.lblNIP.Name = "lblNIP";
            this.lblNIP.Size = new System.Drawing.Size(35, 20);
            this.lblNIP.TabIndex = 15;
            this.lblNIP.Text = "NIP";
            // 
            // btnDodajFirme
            // 
            this.btnDodajFirme.Location = new System.Drawing.Point(486, 405);
            this.btnDodajFirme.Name = "btnDodajFirme";
            this.btnDodajFirme.Size = new System.Drawing.Size(75, 23);
            this.btnDodajFirme.TabIndex = 17;
            this.btnDodajFirme.Text = "Dodaj";
            this.btnDodajFirme.UseVisualStyleBackColor = true;
            this.btnDodajFirme.Click += new System.EventHandler(this.btnDodajFirme_Click);
            // 
            // lblNowaFirma
            // 
            this.lblNowaFirma.AutoSize = true;
            this.lblNowaFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNowaFirma.Location = new System.Drawing.Point(459, 44);
            this.lblNowaFirma.Name = "lblNowaFirma";
            this.lblNowaFirma.Size = new System.Drawing.Size(117, 24);
            this.lblNowaFirma.TabIndex = 8;
            this.lblNowaFirma.Text = "Dane Firmy";
            // 
            // txtB_NazwaFirmy
            // 
            this.txtB_NazwaFirmy.Location = new System.Drawing.Point(486, 83);
            this.txtB_NazwaFirmy.Name = "txtB_NazwaFirmy";
            this.txtB_NazwaFirmy.Size = new System.Drawing.Size(169, 20);
            this.txtB_NazwaFirmy.TabIndex = 18;
            // 
            // txtBAdresEmail
            // 
            this.txtBAdresEmail.Location = new System.Drawing.Point(486, 177);
            this.txtBAdresEmail.Name = "txtBAdresEmail";
            this.txtBAdresEmail.Size = new System.Drawing.Size(169, 20);
            this.txtBAdresEmail.TabIndex = 18;
            // 
            // txtB_NrTelefonu
            // 
            this.txtB_NrTelefonu.Location = new System.Drawing.Point(486, 271);
            this.txtB_NrTelefonu.Name = "txtB_NrTelefonu";
            this.txtB_NrTelefonu.Size = new System.Drawing.Size(169, 20);
            this.txtB_NrTelefonu.TabIndex = 18;
            // 
            // txtB_Nip
            // 
            this.txtB_Nip.Location = new System.Drawing.Point(486, 365);
            this.txtB_Nip.Name = "txtB_Nip";
            this.txtB_Nip.Size = new System.Drawing.Size(169, 20);
            this.txtB_Nip.TabIndex = 18;
            // 
            // lblNazwaFirmy
            // 
            this.lblNazwaFirmy.AutoSize = true;
            this.lblNazwaFirmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaFirmy.Location = new System.Drawing.Point(364, 83);
            this.lblNazwaFirmy.Name = "lblNazwaFirmy";
            this.lblNazwaFirmy.Size = new System.Drawing.Size(99, 20);
            this.lblNazwaFirmy.TabIndex = 12;
            this.lblNazwaFirmy.Text = "Nazwa Firmy";
            // 
            // FormFirmyNoweZlecenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 452);
            this.ControlBox = false;
            this.Controls.Add(this.txtB_Nip);
            this.Controls.Add(this.txtB_NrTelefonu);
            this.Controls.Add(this.txtBAdresEmail);
            this.Controls.Add(this.txtB_NazwaFirmy);
            this.Controls.Add(this.btnDodajFirme);
            this.Controls.Add(this.lblNIP);
            this.Controls.Add(this.lbNrTelefonu);
            this.Controls.Add(this.lblAdresEmail);
            this.Controls.Add(this.lblNazwaFirmy);
            this.Controls.Add(this.btnWybierz);
            this.Controls.Add(this.txtBoxWyszukajFirme);
            this.Controls.Add(this.lblWyszukaj);
            this.Controls.Add(this.lblNowaFirma);
            this.Controls.Add(this.lblFirmy);
            this.Controls.Add(this.dataGridFirmy);
            this.Controls.Add(this.btnExit);
            this.Name = "FormFirmyNoweZlecenie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFirmy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridFirmy;
        private System.Windows.Forms.Label lblFirmy;
        private System.Windows.Forms.Label lblWyszukaj;
        private System.Windows.Forms.TextBox txtBoxWyszukajFirme;
        private System.Windows.Forms.Button btnWybierz;
        private System.Windows.Forms.Label lblAdresEmail;
        private System.Windows.Forms.Label lbNrTelefonu;
        private System.Windows.Forms.Label lblNIP;
        private System.Windows.Forms.Button btnDodajFirme;
        private System.Windows.Forms.Label lblNowaFirma;
        private System.Windows.Forms.TextBox txtB_NazwaFirmy;
        private System.Windows.Forms.TextBox txtBAdresEmail;
        private System.Windows.Forms.TextBox txtB_NrTelefonu;
        private System.Windows.Forms.TextBox txtB_Nip;
        private System.Windows.Forms.Label lblNazwaFirmy;
    }
}