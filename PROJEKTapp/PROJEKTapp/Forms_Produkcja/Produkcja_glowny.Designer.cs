namespace PROJEKTapp
{
    partial class Produkcja_glowny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produkcja_glowny));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitProd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Label();
            this.lblDol = new System.Windows.Forms.Label();
            this.GridPracownicyWPracy = new System.Windows.Forms.DataGridView();
            this.btnEwidencjaMaszyn = new System.Windows.Forms.Button();
            this.btnGabaryty = new System.Windows.Forms.Button();
            this.btnEwidencja = new System.Windows.Forms.Button();
            this.btnWykorzystaneMaszyny = new System.Windows.Forms.Button();
            this.GridPracownicyWybor = new System.Windows.Forms.DataGridView();
            this.btnDodajPracownika = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.iDPRACOWNIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWISKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTANOWISKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACOWNICYSTANOWISKABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRACOWNICYWPRACYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_PRACOWNIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMIEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWISKODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTANOWISKODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADZIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPracownicyWPracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPracownicyWybor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACOWNICYSTANOWISKABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACOWNICYWPRACYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnExitProd);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.Panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 59);
            this.panel1.TabIndex = 1;
            // 
            // btnExitProd
            // 
            this.btnExitProd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExitProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExitProd.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnExitProd.FlatAppearance.BorderSize = 0;
            this.btnExitProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitProd.Image = global::PROJEKTapp.Properties.Resources.btnExit_Image;
            this.btnExitProd.Location = new System.Drawing.Point(1292, 12);
            this.btnExitProd.Name = "btnExitProd";
            this.btnExitProd.Size = new System.Drawing.Size(71, 42);
            this.btnExitProd.TabIndex = 3;
            this.btnExitProd.UseVisualStyleBackColor = true;
            this.btnExitProd.Click += new System.EventHandler(this.btnExitProd_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1297, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Panel
            // 
            this.Panel.AutoSize = true;
            this.Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel.Location = new System.Drawing.Point(12, 9);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(144, 31);
            this.Panel.TabIndex = 2;
            this.Panel.Text = "Produkcja";
            // 
            // lblDol
            // 
            this.lblDol.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblDol.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblDol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDol.Location = new System.Drawing.Point(0, 668);
            this.lblDol.Name = "lblDol";
            this.lblDol.Size = new System.Drawing.Size(1366, 100);
            this.lblDol.TabIndex = 3;
            // 
            // GridPracownicyWPracy
            // 
            this.GridPracownicyWPracy.AllowUserToAddRows = false;
            this.GridPracownicyWPracy.AutoGenerateColumns = false;
            this.GridPracownicyWPracy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPracownicyWPracy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRACOWNIK,
            this.iMIEDataGridViewTextBoxColumn1,
            this.nAZWISKODataGridViewTextBoxColumn1,
            this.sTANOWISKODataGridViewTextBoxColumn1,
            this.dATADZIENDataGridViewTextBoxColumn});
            this.GridPracownicyWPracy.DataSource = this.pRACOWNICYWPRACYBindingSource;
            this.GridPracownicyWPracy.Location = new System.Drawing.Point(691, 65);
            this.GridPracownicyWPracy.Name = "GridPracownicyWPracy";
            this.GridPracownicyWPracy.ReadOnly = true;
            this.GridPracownicyWPracy.Size = new System.Drawing.Size(663, 482);
            this.GridPracownicyWPracy.TabIndex = 7;
            // 
            // btnEwidencjaMaszyn
            // 
            this.btnEwidencjaMaszyn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEwidencjaMaszyn.FlatAppearance.BorderSize = 0;
            this.btnEwidencjaMaszyn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEwidencjaMaszyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEwidencjaMaszyn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEwidencjaMaszyn.Image = global::PROJEKTapp.Properties.Resources.Book_designed_by_Benny_Forsberg_from_the_Noun_Project___with_lines2;
            this.btnEwidencjaMaszyn.Location = new System.Drawing.Point(1035, 668);
            this.btnEwidencjaMaszyn.Margin = new System.Windows.Forms.Padding(2);
            this.btnEwidencjaMaszyn.Name = "btnEwidencjaMaszyn";
            this.btnEwidencjaMaszyn.Size = new System.Drawing.Size(331, 100);
            this.btnEwidencjaMaszyn.TabIndex = 5;
            this.btnEwidencjaMaszyn.Text = "Ewidencja";
            this.btnEwidencjaMaszyn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEwidencjaMaszyn.UseVisualStyleBackColor = false;
            this.btnEwidencjaMaszyn.Click += new System.EventHandler(this.btnEwidencjaMaszyn_Click);
            // 
            // btnGabaryty
            // 
            this.btnGabaryty.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGabaryty.FlatAppearance.BorderSize = 0;
            this.btnGabaryty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGabaryty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGabaryty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGabaryty.Image = global::PROJEKTapp.Properties.Resources._18073;
            this.btnGabaryty.Location = new System.Drawing.Point(691, 668);
            this.btnGabaryty.Margin = new System.Windows.Forms.Padding(2);
            this.btnGabaryty.Name = "btnGabaryty";
            this.btnGabaryty.Size = new System.Drawing.Size(340, 100);
            this.btnGabaryty.TabIndex = 4;
            this.btnGabaryty.Text = "Gabaryty";
            this.btnGabaryty.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGabaryty.UseVisualStyleBackColor = false;
            this.btnGabaryty.Click += new System.EventHandler(this.btnGabaryty_Click);
            // 
            // btnEwidencja
            // 
            this.btnEwidencja.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEwidencja.FlatAppearance.BorderSize = 0;
            this.btnEwidencja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEwidencja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEwidencja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEwidencja.Image = global::PROJEKTapp.Properties.Resources.Sports_Weightlift_icon;
            this.btnEwidencja.Location = new System.Drawing.Point(347, 668);
            this.btnEwidencja.Margin = new System.Windows.Forms.Padding(2);
            this.btnEwidencja.Name = "btnEwidencja";
            this.btnEwidencja.Size = new System.Drawing.Size(340, 100);
            this.btnEwidencja.TabIndex = 2;
            this.btnEwidencja.Text = "Obciążenie";
            this.btnEwidencja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEwidencja.UseVisualStyleBackColor = false;
            this.btnEwidencja.Click += new System.EventHandler(this.btnEwidencja_Click);
            // 
            // btnWykorzystaneMaszyny
            // 
            this.btnWykorzystaneMaszyny.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnWykorzystaneMaszyny.FlatAppearance.BorderSize = 0;
            this.btnWykorzystaneMaszyny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWykorzystaneMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWykorzystaneMaszyny.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWykorzystaneMaszyny.Image = global::PROJEKTapp.Properties.Resources.btnMachine1;
            this.btnWykorzystaneMaszyny.Location = new System.Drawing.Point(0, 668);
            this.btnWykorzystaneMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.btnWykorzystaneMaszyny.Name = "btnWykorzystaneMaszyny";
            this.btnWykorzystaneMaszyny.Size = new System.Drawing.Size(332, 100);
            this.btnWykorzystaneMaszyny.TabIndex = 0;
            this.btnWykorzystaneMaszyny.Text = "Wykorzystane Zasoby";
            this.btnWykorzystaneMaszyny.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWykorzystaneMaszyny.UseVisualStyleBackColor = true;
            this.btnWykorzystaneMaszyny.Click += new System.EventHandler(this.btnWykorzystaneMaszyny_Click);
            // 
            // GridPracownicyWybor
            // 
            this.GridPracownicyWybor.AllowUserToAddRows = false;
            this.GridPracownicyWybor.AllowUserToDeleteRows = false;
            this.GridPracownicyWybor.AutoGenerateColumns = false;
            this.GridPracownicyWybor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPracownicyWybor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRACOWNIKDataGridViewTextBoxColumn,
            this.nAZWISKODataGridViewTextBoxColumn,
            this.iMIEDataGridViewTextBoxColumn,
            this.sTANOWISKODataGridViewTextBoxColumn});
            this.GridPracownicyWybor.DataSource = this.pRACOWNICYSTANOWISKABindingSource;
            this.GridPracownicyWybor.Location = new System.Drawing.Point(12, 65);
            this.GridPracownicyWybor.Name = "GridPracownicyWybor";
            this.GridPracownicyWybor.ReadOnly = true;
            this.GridPracownicyWybor.Size = new System.Drawing.Size(661, 482);
            this.GridPracownicyWybor.TabIndex = 8;
            // 
            // btnDodajPracownika
            // 
            this.btnDodajPracownika.Location = new System.Drawing.Point(265, 581);
            this.btnDodajPracownika.Name = "btnDodajPracownika";
            this.btnDodajPracownika.Size = new System.Drawing.Size(167, 49);
            this.btnDodajPracownika.TabIndex = 9;
            this.btnDodajPracownika.Text = "Dodaj Wybranego Pracownika";
            this.btnDodajPracownika.UseVisualStyleBackColor = true;
            this.btnDodajPracownika.Click += new System.EventHandler(this.btnDodajPracownika_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(952, 581);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(160, 50);
            this.btnOdswiez.TabIndex = 10;
            this.btnOdswiez.Text = "Usuń Pracownika";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // iDPRACOWNIKDataGridViewTextBoxColumn
            // 
            this.iDPRACOWNIKDataGridViewTextBoxColumn.DataPropertyName = "ID_PRACOWNIK";
            this.iDPRACOWNIKDataGridViewTextBoxColumn.HeaderText = "ID_PRACOWNIK";
            this.iDPRACOWNIKDataGridViewTextBoxColumn.Name = "iDPRACOWNIKDataGridViewTextBoxColumn";
            this.iDPRACOWNIKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAZWISKODataGridViewTextBoxColumn
            // 
            this.nAZWISKODataGridViewTextBoxColumn.DataPropertyName = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn.HeaderText = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn.Name = "nAZWISKODataGridViewTextBoxColumn";
            this.nAZWISKODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMIEDataGridViewTextBoxColumn
            // 
            this.iMIEDataGridViewTextBoxColumn.DataPropertyName = "IMIE";
            this.iMIEDataGridViewTextBoxColumn.HeaderText = "IMIE";
            this.iMIEDataGridViewTextBoxColumn.Name = "iMIEDataGridViewTextBoxColumn";
            this.iMIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTANOWISKODataGridViewTextBoxColumn
            // 
            this.sTANOWISKODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTANOWISKODataGridViewTextBoxColumn.DataPropertyName = "STANOWISKO";
            this.sTANOWISKODataGridViewTextBoxColumn.HeaderText = "STANOWISKO";
            this.sTANOWISKODataGridViewTextBoxColumn.Name = "sTANOWISKODataGridViewTextBoxColumn";
            this.sTANOWISKODataGridViewTextBoxColumn.ReadOnly = true;
            this.sTANOWISKODataGridViewTextBoxColumn.Width = 105;
            // 
            // pRACOWNICYSTANOWISKABindingSource
            // 
            this.pRACOWNICYSTANOWISKABindingSource.DataSource = typeof(PROJEKTapp.PRACOWNICY_STANOWISKA);
            // 
            // pRACOWNICYWPRACYBindingSource
            // 
            this.pRACOWNICYWPRACYBindingSource.DataSource = typeof(PROJEKTapp.PRACOWNICY_W_PRACY);
            // 
            // ID_PRACOWNIK
            // 
            this.ID_PRACOWNIK.DataPropertyName = "ID_PRACOWNIK";
            this.ID_PRACOWNIK.HeaderText = "ID_PRACOWNIK";
            this.ID_PRACOWNIK.Name = "ID_PRACOWNIK";
            this.ID_PRACOWNIK.ReadOnly = true;
            // 
            // iMIEDataGridViewTextBoxColumn1
            // 
            this.iMIEDataGridViewTextBoxColumn1.DataPropertyName = "IMIE";
            this.iMIEDataGridViewTextBoxColumn1.HeaderText = "IMIE";
            this.iMIEDataGridViewTextBoxColumn1.Name = "iMIEDataGridViewTextBoxColumn1";
            this.iMIEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nAZWISKODataGridViewTextBoxColumn1
            // 
            this.nAZWISKODataGridViewTextBoxColumn1.DataPropertyName = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn1.HeaderText = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn1.Name = "nAZWISKODataGridViewTextBoxColumn1";
            this.nAZWISKODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sTANOWISKODataGridViewTextBoxColumn1
            // 
            this.sTANOWISKODataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTANOWISKODataGridViewTextBoxColumn1.DataPropertyName = "STANOWISKO";
            this.sTANOWISKODataGridViewTextBoxColumn1.HeaderText = "STANOWISKO";
            this.sTANOWISKODataGridViewTextBoxColumn1.Name = "sTANOWISKODataGridViewTextBoxColumn1";
            this.sTANOWISKODataGridViewTextBoxColumn1.ReadOnly = true;
            this.sTANOWISKODataGridViewTextBoxColumn1.Width = 105;
            // 
            // dATADZIENDataGridViewTextBoxColumn
            // 
            this.dATADZIENDataGridViewTextBoxColumn.DataPropertyName = "DATA_DZIEN";
            this.dATADZIENDataGridViewTextBoxColumn.HeaderText = "DATA_DZIEN";
            this.dATADZIENDataGridViewTextBoxColumn.Name = "dATADZIENDataGridViewTextBoxColumn";
            this.dATADZIENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Produkcja_glowny
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodajPracownika);
            this.Controls.Add(this.GridPracownicyWybor);
            this.Controls.Add(this.GridPracownicyWPracy);
            this.Controls.Add(this.btnEwidencjaMaszyn);
            this.Controls.Add(this.btnGabaryty);
            this.Controls.Add(this.btnEwidencja);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnWykorzystaneMaszyny);
            this.Controls.Add(this.lblDol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Produkcja_glowny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkcja_glowny";
            this.Load += new System.EventHandler(this.Produkcja_glowny_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPracownicyWPracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPracownicyWybor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACOWNICYSTANOWISKABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACOWNICYWPRACYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWykorzystaneMaszyny;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Panel;
        private System.Windows.Forms.Button btnExitProd;
        private System.Windows.Forms.Button btnEwidencja;
        private System.Windows.Forms.Label lblDol;
        private System.Windows.Forms.Button btnGabaryty;
        private System.Windows.Forms.Button btnEwidencjaMaszyn;
        private System.Windows.Forms.DataGridView GridPracownicyWPracy;
        private System.Windows.Forms.DataGridView GridPracownicyWybor;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTANOWISKOPRACOWNICYDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodajPracownika;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRACOWNIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTANOWISKODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pRACOWNICYSTANOWISKABindingSource;
        private System.Windows.Forms.BindingSource pRACOWNICYWPRACYBindingSource;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRACOWNIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTANOWISKODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATADZIENDataGridViewTextBoxColumn;
    }
}