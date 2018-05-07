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
            this.components = new System.ComponentModel.Container();
            this.DGW_KOnta_Uzytkownikow = new System.Windows.Forms.DataGridView();
            this.iMIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWISKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWALOGOWANIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hASLODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOZIOMUPRAWNIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRACOWNIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPRAWNIENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPISUZYTKOWNIKOWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_KOnta_Uzytkownikow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPISUZYTKOWNIKOWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGW_KOnta_Uzytkownikow
            // 
            this.DGW_KOnta_Uzytkownikow.AllowUserToAddRows = false;
            this.DGW_KOnta_Uzytkownikow.AllowUserToDeleteRows = false;
            this.DGW_KOnta_Uzytkownikow.AutoGenerateColumns = false;
            this.DGW_KOnta_Uzytkownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_KOnta_Uzytkownikow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iMIEDataGridViewTextBoxColumn,
            this.nAZWISKODataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.nAZWALOGOWANIEDataGridViewTextBoxColumn,
            this.hASLODataGridViewTextBoxColumn,
            this.pOZIOMUPRAWNIENDataGridViewTextBoxColumn,
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn,
            this.iDPRACOWNIKDataGridViewTextBoxColumn,
            this.uPRAWNIENIADataGridViewTextBoxColumn});
            this.DGW_KOnta_Uzytkownikow.DataSource = this.sPISUZYTKOWNIKOWBindingSource;
            this.DGW_KOnta_Uzytkownikow.Location = new System.Drawing.Point(12, 23);
            this.DGW_KOnta_Uzytkownikow.Name = "DGW_KOnta_Uzytkownikow";
            this.DGW_KOnta_Uzytkownikow.ReadOnly = true;
            this.DGW_KOnta_Uzytkownikow.Size = new System.Drawing.Size(628, 209);
            this.DGW_KOnta_Uzytkownikow.TabIndex = 0;
            // 
            // iMIEDataGridViewTextBoxColumn
            // 
            this.iMIEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iMIEDataGridViewTextBoxColumn.DataPropertyName = "IMIE";
            this.iMIEDataGridViewTextBoxColumn.HeaderText = "IMIE";
            this.iMIEDataGridViewTextBoxColumn.Name = "iMIEDataGridViewTextBoxColumn";
            this.iMIEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iMIEDataGridViewTextBoxColumn.Width = 54;
            // 
            // nAZWISKODataGridViewTextBoxColumn
            // 
            this.nAZWISKODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nAZWISKODataGridViewTextBoxColumn.DataPropertyName = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn.HeaderText = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn.Name = "nAZWISKODataGridViewTextBoxColumn";
            this.nAZWISKODataGridViewTextBoxColumn.ReadOnly = true;
            this.nAZWISKODataGridViewTextBoxColumn.Width = 90;
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            this.pESELDataGridViewTextBoxColumn.ReadOnly = true;
            this.pESELDataGridViewTextBoxColumn.Width = 66;
            // 
            // nAZWALOGOWANIEDataGridViewTextBoxColumn
            // 
            this.nAZWALOGOWANIEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nAZWALOGOWANIEDataGridViewTextBoxColumn.DataPropertyName = "NAZWA_LOGOWANIE";
            this.nAZWALOGOWANIEDataGridViewTextBoxColumn.HeaderText = "LOGIN";
            this.nAZWALOGOWANIEDataGridViewTextBoxColumn.Name = "nAZWALOGOWANIEDataGridViewTextBoxColumn";
            this.nAZWALOGOWANIEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAZWALOGOWANIEDataGridViewTextBoxColumn.Width = 65;
            // 
            // hASLODataGridViewTextBoxColumn
            // 
            this.hASLODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hASLODataGridViewTextBoxColumn.DataPropertyName = "HASLO";
            this.hASLODataGridViewTextBoxColumn.HeaderText = "HASLO";
            this.hASLODataGridViewTextBoxColumn.Name = "hASLODataGridViewTextBoxColumn";
            this.hASLODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pOZIOMUPRAWNIENDataGridViewTextBoxColumn
            // 
            this.pOZIOMUPRAWNIENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pOZIOMUPRAWNIENDataGridViewTextBoxColumn.DataPropertyName = "POZIOM_UPRAWNIEN";
            this.pOZIOMUPRAWNIENDataGridViewTextBoxColumn.HeaderText = "POZIOM_UPRAWNIEN";
            this.pOZIOMUPRAWNIENDataGridViewTextBoxColumn.Name = "pOZIOMUPRAWNIENDataGridViewTextBoxColumn";
            this.pOZIOMUPRAWNIENDataGridViewTextBoxColumn.ReadOnly = true;
            this.pOZIOMUPRAWNIENDataGridViewTextBoxColumn.Width = 147;
            // 
            // iDUZYTKOWNIKADataGridViewTextBoxColumn
            // 
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.DataPropertyName = "ID_UZYTKOWNIKA";
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.HeaderText = "ID_UZYTKOWNIKA";
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.Name = "iDUZYTKOWNIKADataGridViewTextBoxColumn";
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.Visible = false;
            // 
            // iDPRACOWNIKDataGridViewTextBoxColumn
            // 
            this.iDPRACOWNIKDataGridViewTextBoxColumn.DataPropertyName = "ID_PRACOWNIK";
            this.iDPRACOWNIKDataGridViewTextBoxColumn.HeaderText = "ID_PRACOWNIK";
            this.iDPRACOWNIKDataGridViewTextBoxColumn.Name = "iDPRACOWNIKDataGridViewTextBoxColumn";
            this.iDPRACOWNIKDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPRACOWNIKDataGridViewTextBoxColumn.Visible = false;
            // 
            // uPRAWNIENIADataGridViewTextBoxColumn
            // 
            this.uPRAWNIENIADataGridViewTextBoxColumn.DataPropertyName = "UPRAWNIENIA";
            this.uPRAWNIENIADataGridViewTextBoxColumn.HeaderText = "UPRAWNIENIA";
            this.uPRAWNIENIADataGridViewTextBoxColumn.Name = "uPRAWNIENIADataGridViewTextBoxColumn";
            this.uPRAWNIENIADataGridViewTextBoxColumn.ReadOnly = true;
            this.uPRAWNIENIADataGridViewTextBoxColumn.Visible = false;
            // 
            // sPISUZYTKOWNIKOWBindingSource
            // 
            this.sPISUZYTKOWNIKOWBindingSource.DataSource = typeof(PROJEKTapp.SPIS_UZYTKOWNIKOW);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(130, 263);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(288, 263);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 2;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(452, 263);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 3;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // Uzytkownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 326);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.DGW_KOnta_Uzytkownikow);
            this.Name = "Uzytkownicy";
            this.Text = "Ewidencja Kont";
            this.Load += new System.EventHandler(this.Uzytkownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_KOnta_Uzytkownikow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPISUZYTKOWNIKOWBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGW_KOnta_Uzytkownikow;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.BindingSource sPISUZYTKOWNIKOWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWALOGOWANIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASLODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOZIOMUPRAWNIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUZYTKOWNIKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRACOWNIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPRAWNIENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUsun;
    }
}