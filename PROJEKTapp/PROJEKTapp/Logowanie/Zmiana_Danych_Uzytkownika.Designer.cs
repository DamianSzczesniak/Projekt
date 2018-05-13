namespace PROJEKTapp.Logowanie
{
    partial class Zmiana_Danych_Uzytkownika
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
            this.cBPracownik = new System.Windows.Forms.ComboBox();
            this.cBPoziom = new System.Windows.Forms.ComboBox();
            this.txtBLogin = new System.Windows.Forms.TextBox();
            this.txtBHaslo = new System.Windows.Forms.TextBox();
            this.lblPracownik = new System.Windows.Forms.Label();
            this.lblPoziom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.txtBoxPESEL = new System.Windows.Forms.TextBox();
            this.uPRAWNIENIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRACOWNICYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uPRAWNIENIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACOWNICYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cBPracownik
            // 
            this.cBPracownik.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRACOWNICYBindingSource, "ID_PRACOWNIK", true));
            this.cBPracownik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBPracownik.FormattingEnabled = true;
            this.cBPracownik.Location = new System.Drawing.Point(143, 19);
            this.cBPracownik.Name = "cBPracownik";
            this.cBPracownik.Size = new System.Drawing.Size(278, 21);
            this.cBPracownik.TabIndex = 0;
            this.cBPracownik.ValueMember = "ID_PRACOWNIK";
            // 
            // cBPoziom
            // 
            this.cBPoziom.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uPRAWNIENIABindingSource, "ID_UPRAWNIENIA", true));
            this.cBPoziom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBPoziom.FormattingEnabled = true;
            this.cBPoziom.Location = new System.Drawing.Point(143, 224);
            this.cBPoziom.Name = "cBPoziom";
            this.cBPoziom.Size = new System.Drawing.Size(95, 21);
            this.cBPoziom.TabIndex = 3;
            // 
            // txtBLogin
            // 
            this.txtBLogin.Location = new System.Drawing.Point(143, 155);
            this.txtBLogin.Name = "txtBLogin";
            this.txtBLogin.Size = new System.Drawing.Size(163, 20);
            this.txtBLogin.TabIndex = 2;
            this.txtBLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBHaslo
            // 
            this.txtBHaslo.Location = new System.Drawing.Point(143, 87);
            this.txtBHaslo.Name = "txtBHaslo";
            this.txtBHaslo.Size = new System.Drawing.Size(163, 20);
            this.txtBHaslo.TabIndex = 1;
            this.txtBHaslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPracownik
            // 
            this.lblPracownik.AutoSize = true;
            this.lblPracownik.Location = new System.Drawing.Point(25, 22);
            this.lblPracownik.Name = "lblPracownik";
            this.lblPracownik.Size = new System.Drawing.Size(63, 13);
            this.lblPracownik.TabIndex = 4;
            this.lblPracownik.Text = "Pracownik :";
            // 
            // lblPoziom
            // 
            this.lblPoziom.AutoSize = true;
            this.lblPoziom.Location = new System.Drawing.Point(25, 226);
            this.lblPoziom.Name = "lblPoziom";
            this.lblPoziom.Size = new System.Drawing.Size(101, 13);
            this.lblPoziom.TabIndex = 5;
            this.lblPoziom.Text = "Poziom Uprawnień :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Haslo :";
            // 
            // btnZapisz
            // 
            this.btnZapisz.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnZapisz.Location = new System.Drawing.Point(163, 267);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 4;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // txtBoxPESEL
            // 
            this.txtBoxPESEL.Location = new System.Drawing.Point(143, 19);
            this.txtBoxPESEL.Name = "txtBoxPESEL";
            this.txtBoxPESEL.ReadOnly = true;
            this.txtBoxPESEL.Size = new System.Drawing.Size(278, 20);
            this.txtBoxPESEL.TabIndex = 0;
            this.txtBoxPESEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxPESEL.TextChanged += new System.EventHandler(this.txtBoxPESEL_TextChanged);
            // 
            // uPRAWNIENIABindingSource
            // 
            this.uPRAWNIENIABindingSource.DataSource = typeof(PROJEKTapp.UPRAWNIENIA);
            // 
            // pRACOWNICYBindingSource
            // 
            this.pRACOWNICYBindingSource.DataSource = typeof(PROJEKTapp.PRACOWNICY);
            // 
            // Zmiana_Danych_Uzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 302);
            this.Controls.Add(this.txtBoxPESEL);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPoziom);
            this.Controls.Add(this.lblPracownik);
            this.Controls.Add(this.txtBHaslo);
            this.Controls.Add(this.txtBLogin);
            this.Controls.Add(this.cBPoziom);
            this.Controls.Add(this.cBPracownik);
            this.Name = "Zmiana_Danych_Uzytkownika";
            this.Text = "Zmiana_Danych_Uzytkownika";
            this.Load += new System.EventHandler(this.Zmiana_Danych_Uzytkownika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uPRAWNIENIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACOWNICYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBPracownik;
        private System.Windows.Forms.ComboBox cBPoziom;
        private System.Windows.Forms.TextBox txtBLogin;
        private System.Windows.Forms.TextBox txtBHaslo;
        private System.Windows.Forms.Label lblPracownik;
        private System.Windows.Forms.Label lblPoziom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.BindingSource pRACOWNICYBindingSource;
        private System.Windows.Forms.BindingSource uPRAWNIENIABindingSource;
        private System.Windows.Forms.TextBox txtBoxPESEL;
    }
}