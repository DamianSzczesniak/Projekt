namespace PROJEKTapp.Forms_NoweZlecenie
{
    partial class FormDodajEdytujFirme
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
            this.lblNazwa = new System.Windows.Forms.Label();
            this.lblAdresEmail = new System.Windows.Forms.Label();
            this.lblNrTel = new System.Windows.Forms.Label();
            this.lblNip = new System.Windows.Forms.Label();
            this.txtBoxNazwa = new System.Windows.Forms.TextBox();
            this.FirmyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBoxAdresEmail = new System.Windows.Forms.TextBox();
            this.txtBoxNrTelefonu = new System.Windows.Forms.TextBox();
            this.txtBoxNIP = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FirmyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Location = new System.Drawing.Point(13, 15);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(43, 13);
            this.lblNazwa.TabIndex = 0;
            this.lblNazwa.Text = "Nazwa:";
            // 
            // lblAdresEmail
            // 
            this.lblAdresEmail.AutoSize = true;
            this.lblAdresEmail.Location = new System.Drawing.Point(13, 76);
            this.lblAdresEmail.Name = "lblAdresEmail";
            this.lblAdresEmail.Size = new System.Drawing.Size(65, 13);
            this.lblAdresEmail.TabIndex = 0;
            this.lblAdresEmail.Text = "Adres Email:";
            // 
            // lblNrTel
            // 
            this.lblNrTel.AutoSize = true;
            this.lblNrTel.Location = new System.Drawing.Point(13, 134);
            this.lblNrTel.Name = "lblNrTel";
            this.lblNrTel.Size = new System.Drawing.Size(66, 13);
            this.lblNrTel.TabIndex = 0;
            this.lblNrTel.Text = "Nr Telefonu:";
            // 
            // lblNip
            // 
            this.lblNip.AutoSize = true;
            this.lblNip.Location = new System.Drawing.Point(13, 204);
            this.lblNip.Name = "lblNip";
            this.lblNip.Size = new System.Drawing.Size(28, 13);
            this.lblNip.TabIndex = 0;
            this.lblNip.Text = "NIP:";
            // 
            // txtBoxNazwa
            // 
            this.txtBoxNazwa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FirmyBindingSource, "NAZWA_FIRMY", true));
            this.txtBoxNazwa.Location = new System.Drawing.Point(94, 12);
            this.txtBoxNazwa.Name = "txtBoxNazwa";
            this.txtBoxNazwa.Size = new System.Drawing.Size(146, 20);
            this.txtBoxNazwa.TabIndex = 0;
            // 
            // FirmyBindingSource
            // 
            this.FirmyBindingSource.DataSource = typeof(PROJEKTapp.FIRMY);
            // 
            // txtBoxAdresEmail
            // 
            this.txtBoxAdresEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FirmyBindingSource, "ADRES_EMAIL", true));
            this.txtBoxAdresEmail.Location = new System.Drawing.Point(94, 73);
            this.txtBoxAdresEmail.Name = "txtBoxAdresEmail";
            this.txtBoxAdresEmail.Size = new System.Drawing.Size(146, 20);
            this.txtBoxAdresEmail.TabIndex = 1;
            // 
            // txtBoxNrTelefonu
            // 
            this.txtBoxNrTelefonu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FirmyBindingSource, "NR_TELEFONU", true));
            this.txtBoxNrTelefonu.Location = new System.Drawing.Point(94, 131);
            this.txtBoxNrTelefonu.Name = "txtBoxNrTelefonu";
            this.txtBoxNrTelefonu.Size = new System.Drawing.Size(146, 20);
            this.txtBoxNrTelefonu.TabIndex = 2;
            // 
            // txtBoxNIP
            // 
            this.txtBoxNIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FirmyBindingSource, "NIP", true));
            this.txtBoxNIP.Location = new System.Drawing.Point(94, 201);
            this.txtBoxNIP.Name = "txtBoxNIP";
            this.txtBoxNIP.Size = new System.Drawing.Size(146, 20);
            this.txtBoxNIP.TabIndex = 3;
            // 
            // btnZapisz
            // 
            this.btnZapisz.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnZapisz.Location = new System.Drawing.Point(94, 237);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 4;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
          
            // 
            // FormDodajEdytujFirme
            // 
            this.AcceptButton = this.btnZapisz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 272);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.txtBoxNIP);
            this.Controls.Add(this.txtBoxNrTelefonu);
            this.Controls.Add(this.txtBoxAdresEmail);
            this.Controls.Add(this.txtBoxNazwa);
            this.Controls.Add(this.lblNip);
            this.Controls.Add(this.lblNrTel);
            this.Controls.Add(this.lblAdresEmail);
            this.Controls.Add(this.lblNazwa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDodajEdytujFirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie/Edycja Firmy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDodajEdytujFirme_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.FirmyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Label lblAdresEmail;
        private System.Windows.Forms.Label lblNrTel;
        private System.Windows.Forms.Label lblNip;
        private System.Windows.Forms.TextBox txtBoxNazwa;
        private System.Windows.Forms.TextBox txtBoxAdresEmail;
        private System.Windows.Forms.TextBox txtBoxNrTelefonu;
        private System.Windows.Forms.TextBox txtBoxNIP;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.BindingSource FirmyBindingSource;
    }
}