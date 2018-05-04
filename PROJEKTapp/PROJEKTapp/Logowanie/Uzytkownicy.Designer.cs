namespace PROJEKTapp.Logowanie
{
    partial class Uzytkownicy
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
            this.DGW_KOnta_Uzytkownikow = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_KOnta_Uzytkownikow)).BeginInit();
            this.SuspendLayout();
            // 
            // DGW_KOnta_Uzytkownikow
            // 
            this.DGW_KOnta_Uzytkownikow.AllowUserToAddRows = false;
            this.DGW_KOnta_Uzytkownikow.AllowUserToDeleteRows = false;
            this.DGW_KOnta_Uzytkownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_KOnta_Uzytkownikow.Location = new System.Drawing.Point(12, 23);
            this.DGW_KOnta_Uzytkownikow.Name = "DGW_KOnta_Uzytkownikow";
            this.DGW_KOnta_Uzytkownikow.ReadOnly = true;
            this.DGW_KOnta_Uzytkownikow.Size = new System.Drawing.Size(563, 209);
            this.DGW_KOnta_Uzytkownikow.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(163, 263);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(353, 263);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 2;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            // 
            // Uzytkownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 326);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.DGW_KOnta_Uzytkownikow);
            this.Name = "Uzytkownicy";
            this.Text = "Ewidencja Kont";
            this.Load += new System.EventHandler(this.Uzytkownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_KOnta_Uzytkownikow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGW_KOnta_Uzytkownikow;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
    }
}