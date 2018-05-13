namespace PROJEKTapp.Forms
{
    partial class ZamowienieMaterialu
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
            this.Btn_Back_5 = new System.Windows.Forms.Button();
            this.TopBar_5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnNoweZam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNrZlecenia = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GridVwZapMat = new System.Windows.Forms.DataGridView();
            this.iDZLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PELNA_NAZWA_MATERIALU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMATERIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUMAMATERIALUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUMAZAPOTRZEBOWANIAMATERIALZLECENIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.BtnShow = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.comboBoxFirmy = new System.Windows.Forms.ComboBox();
            this.lblDZ = new System.Windows.Forms.Label();
            this.lblReal = new System.Windows.Forms.Label();
            this.txtzlozenia = new System.Windows.Forms.TextBox();
            this.txtZamowienia = new System.Windows.Forms.TextBox();
            this.lvlFirmy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVwZapMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUMAZAPOTRZEBOWANIAMATERIALZLECENIEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Back_5
            // 
            this.Btn_Back_5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Back_5.FlatAppearance.BorderSize = 0;
            this.Btn_Back_5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back_5.Image = global::PROJEKTapp.Properties.Resources.return2;
            this.Btn_Back_5.Location = new System.Drawing.Point(0, 0);
            this.Btn_Back_5.Name = "Btn_Back_5";
            this.Btn_Back_5.Size = new System.Drawing.Size(80, 56);
            this.Btn_Back_5.TabIndex = 13;
            this.Btn_Back_5.UseVisualStyleBackColor = false;
            this.Btn_Back_5.Click += new System.EventHandler(this.Btn_Back_5_Click);
            // 
            // TopBar_5
            // 
            this.TopBar_5.Image = global::PROJEKTapp.Properties.Resources.top_bar1;
            this.TopBar_5.Location = new System.Drawing.Point(-167, 0);
            this.TopBar_5.Name = "TopBar_5";
            this.TopBar_5.Size = new System.Drawing.Size(960, 72);
            this.TopBar_5.TabIndex = 12;
            this.TopBar_5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = ".../Logistyka/Zamówienie materiału";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1340, 2);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // BtnNoweZam
            // 
            this.BtnNoweZam.Location = new System.Drawing.Point(79, 359);
            this.BtnNoweZam.Name = "BtnNoweZam";
            this.BtnNoweZam.Size = new System.Drawing.Size(446, 26);
            this.BtnNoweZam.TabIndex = 19;
            this.BtnNoweZam.Text = "Generuj nowe zamówienie";
            this.BtnNoweZam.UseVisualStyleBackColor = true;
            this.BtnNoweZam.Click += new System.EventHandler(this.BtnNoweZam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Numer zlecenia";
            // 
            // comboBoxNrZlecenia
            // 
            this.comboBoxNrZlecenia.FormattingEnabled = true;
            this.comboBoxNrZlecenia.Location = new System.Drawing.Point(130, 123);
            this.comboBoxNrZlecenia.Name = "comboBoxNrZlecenia";
            this.comboBoxNrZlecenia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNrZlecenia.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 56);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox3.Location = new System.Drawing.Point(1164, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 56);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // GridVwZapMat
            // 
            this.GridVwZapMat.AllowUserToAddRows = false;
            this.GridVwZapMat.AllowUserToDeleteRows = false;
            this.GridVwZapMat.AutoGenerateColumns = false;
            this.GridVwZapMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVwZapMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDZLECENIADataGridViewTextBoxColumn,
            this.PELNA_NAZWA_MATERIALU,
            this.iDMATERIALDataGridViewTextBoxColumn,
            this.sUMAMATERIALUDataGridViewTextBoxColumn});
            this.GridVwZapMat.DataSource = this.sUMAZAPOTRZEBOWANIAMATERIALZLECENIEBindingSource;
            this.GridVwZapMat.Location = new System.Drawing.Point(79, 178);
            this.GridVwZapMat.Name = "GridVwZapMat";
            this.GridVwZapMat.ReadOnly = true;
            this.GridVwZapMat.Size = new System.Drawing.Size(446, 161);
            this.GridVwZapMat.TabIndex = 26;
            // 
            // iDZLECENIADataGridViewTextBoxColumn
            // 
            this.iDZLECENIADataGridViewTextBoxColumn.DataPropertyName = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.HeaderText = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.Name = "iDZLECENIADataGridViewTextBoxColumn";
            this.iDZLECENIADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDZLECENIADataGridViewTextBoxColumn.Visible = false;
            // 
            // PELNA_NAZWA_MATERIALU
            // 
            this.PELNA_NAZWA_MATERIALU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PELNA_NAZWA_MATERIALU.DataPropertyName = "PELNA_NAZWA_MATERIALU";
            this.PELNA_NAZWA_MATERIALU.HeaderText = "NAZWA MATERIALU";
            this.PELNA_NAZWA_MATERIALU.Name = "PELNA_NAZWA_MATERIALU";
            this.PELNA_NAZWA_MATERIALU.ReadOnly = true;
            // 
            // iDMATERIALDataGridViewTextBoxColumn
            // 
            this.iDMATERIALDataGridViewTextBoxColumn.DataPropertyName = "ID_MATERIAL";
            this.iDMATERIALDataGridViewTextBoxColumn.HeaderText = "ID_MATERIAL";
            this.iDMATERIALDataGridViewTextBoxColumn.Name = "iDMATERIALDataGridViewTextBoxColumn";
            this.iDMATERIALDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDMATERIALDataGridViewTextBoxColumn.Visible = false;
            // 
            // sUMAMATERIALUDataGridViewTextBoxColumn
            // 
            this.sUMAMATERIALUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sUMAMATERIALUDataGridViewTextBoxColumn.DataPropertyName = "SUMA_MATERIALU";
            this.sUMAMATERIALUDataGridViewTextBoxColumn.HeaderText = "LICZBA SZTUK";
            this.sUMAMATERIALUDataGridViewTextBoxColumn.Name = "sUMAMATERIALUDataGridViewTextBoxColumn";
            this.sUMAMATERIALUDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUMAMATERIALUDataGridViewTextBoxColumn.Width = 99;
            // 
            // sUMAZAPOTRZEBOWANIAMATERIALZLECENIEBindingSource
            // 
            this.sUMAZAPOTRZEBOWANIAMATERIALZLECENIEBindingSource.DataSource = typeof(PROJEKTapp.SUMA_ZAPOTRZEBOWANIA_MATERIAL_ZLECENIE);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Zapotrzebowanie na materiały do danego zlecenia:";
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(271, 123);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 29;
            this.BtnShow.Text = "Pokaż";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnZapisz.Location = new System.Drawing.Point(417, 435);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 30;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // comboBoxFirmy
            // 
            this.comboBoxFirmy.FormattingEnabled = true;
            this.comboBoxFirmy.Location = new System.Drawing.Point(194, 401);
            this.comboBoxFirmy.Name = "comboBoxFirmy";
            this.comboBoxFirmy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFirmy.TabIndex = 31;
            // 
            // lblDZ
            // 
            this.lblDZ.AutoSize = true;
            this.lblDZ.Location = new System.Drawing.Point(45, 435);
            this.lblDZ.Name = "lblDZ";
            this.lblDZ.Size = new System.Drawing.Size(131, 13);
            this.lblDZ.TabIndex = 32;
            this.lblDZ.Text = "Data złożenia zamówienia";
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Location = new System.Drawing.Point(45, 463);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(131, 13);
            this.lblReal.TabIndex = 33;
            this.lblReal.Text = "Data realizacji zamówienia";
            // 
            // txtzlozenia
            // 
            this.txtzlozenia.Location = new System.Drawing.Point(206, 427);
            this.txtzlozenia.Name = "txtzlozenia";
            this.txtzlozenia.ReadOnly = true;
            this.txtzlozenia.Size = new System.Drawing.Size(100, 20);
            this.txtzlozenia.TabIndex = 34;
            // 
            // txtZamowienia
            // 
            this.txtZamowienia.Location = new System.Drawing.Point(206, 455);
            this.txtZamowienia.Name = "txtZamowienia";
            this.txtZamowienia.ReadOnly = true;
            this.txtZamowienia.Size = new System.Drawing.Size(100, 20);
            this.txtZamowienia.TabIndex = 35;
            // 
            // lvlFirmy
            // 
            this.lvlFirmy.AutoSize = true;
            this.lvlFirmy.Location = new System.Drawing.Point(48, 401);
            this.lvlFirmy.Name = "lvlFirmy";
            this.lvlFirmy.Size = new System.Drawing.Size(37, 13);
            this.lvlFirmy.TabIndex = 36;
            this.lvlFirmy.Text = "Firmy :";
            // 
            // ZamowienieMaterialu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 499);
            this.Controls.Add(this.lvlFirmy);
            this.Controls.Add(this.txtZamowienia);
            this.Controls.Add(this.txtzlozenia);
            this.Controls.Add(this.lblReal);
            this.Controls.Add(this.lblDZ);
            this.Controls.Add(this.comboBoxFirmy);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridVwZapMat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.comboBoxNrZlecenia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnNoweZam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Back_5);
            this.Controls.Add(this.TopBar_5);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZamowienieMaterialu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZamówienieMaterialu";
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVwZapMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUMAZAPOTRZEBOWANIAMATERIALZLECENIEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back_5;
        private System.Windows.Forms.PictureBox TopBar_5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnNoweZam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNrZlecenia;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView GridVwZapMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.BindingSource sUMAZAPOTRZEBOWANIAMATERIALZLECENIEBindingSource;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.ComboBox comboBoxFirmy;
        private System.Windows.Forms.Label lblDZ;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.TextBox txtzlozenia;
        private System.Windows.Forms.TextBox txtZamowienia;
        private System.Windows.Forms.Label lvlFirmy;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PELNA_NAZWA_MATERIALU;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMATERIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUMAMATERIALUDataGridViewTextBoxColumn;
    }
}