namespace PROJEKTapp.Forms
{
    partial class FormZmianaStanuMagazynu
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
            this.Btn_Back = new System.Windows.Forms.Button();
            this.DGV_MATERIALY = new System.Windows.Forms.DataGridView();
            this.PELNA_NAZWA_MATERIALU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDZLECENIADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEKTORDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLEJKADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTANDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMATERIALUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLOKALIZACJIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTANMATERIALYNAZWYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonDodajRekord = new System.Windows.Forms.Button();
            this.TopBar_2 = new System.Windows.Forms.PictureBox();
            this.checkBProdukty = new System.Windows.Forms.CheckBox();
            this.checkBMaterialy = new System.Windows.Forms.CheckBox();
            this.checkBWszystkie = new System.Windows.Forms.CheckBox();
            this.cBoxFlitracja = new System.Windows.Forms.ComboBox();
            this.DGV_PRODUKTY = new System.Windows.Forms.DataGridView();
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDZLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEKTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLEJKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRODUKTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLOKALIZACJIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTANPRODUKTYNAZWYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_ID_ZLECENIA = new System.Windows.Forms.Label();
            this.btnZdejmij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MATERIALY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTANMATERIALYNAZWYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUKTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTANPRODUKTYNAZWYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Back.FlatAppearance.BorderSize = 0;
            this.Btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Image = global::PROJEKTapp.Properties.Resources.return2;
            this.Btn_Back.Location = new System.Drawing.Point(0, 0);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(80, 56);
            this.Btn_Back.TabIndex = 8;
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // DGV_MATERIALY
            // 
            this.DGV_MATERIALY.AllowUserToAddRows = false;
            this.DGV_MATERIALY.AllowUserToDeleteRows = false;
            this.DGV_MATERIALY.AutoGenerateColumns = false;
            this.DGV_MATERIALY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_MATERIALY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PELNA_NAZWA_MATERIALU,
            this.iDZLECENIADataGridViewTextBoxColumn1,
            this.sEKTORDataGridViewTextBoxColumn1,
            this.aLEJKADataGridViewTextBoxColumn1,
            this.sTANDataGridViewTextBoxColumn1,
            this.iDMATERIALUDataGridViewTextBoxColumn,
            this.iDLOKALIZACJIDataGridViewTextBoxColumn1});
            this.DGV_MATERIALY.DataSource = this.sTANMATERIALYNAZWYBindingSource;
            this.DGV_MATERIALY.Location = new System.Drawing.Point(16, 154);
            this.DGV_MATERIALY.Name = "DGV_MATERIALY";
            this.DGV_MATERIALY.ReadOnly = true;
            this.DGV_MATERIALY.Size = new System.Drawing.Size(706, 318);
            this.DGV_MATERIALY.TabIndex = 19;
            // 
            // PELNA_NAZWA_MATERIALU
            // 
            this.PELNA_NAZWA_MATERIALU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PELNA_NAZWA_MATERIALU.DataPropertyName = "PELNA_NAZWA_MATERIALU";
            this.PELNA_NAZWA_MATERIALU.HeaderText = "NAZWA MATERIALU";
            this.PELNA_NAZWA_MATERIALU.Name = "PELNA_NAZWA_MATERIALU";
            this.PELNA_NAZWA_MATERIALU.ReadOnly = true;
            // 
            // iDZLECENIADataGridViewTextBoxColumn1
            // 
            this.iDZLECENIADataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDZLECENIADataGridViewTextBoxColumn1.DataPropertyName = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn1.HeaderText = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn1.Name = "iDZLECENIADataGridViewTextBoxColumn1";
            this.iDZLECENIADataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDZLECENIADataGridViewTextBoxColumn1.Width = 101;
            // 
            // sEKTORDataGridViewTextBoxColumn1
            // 
            this.sEKTORDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sEKTORDataGridViewTextBoxColumn1.DataPropertyName = "SEKTOR";
            this.sEKTORDataGridViewTextBoxColumn1.HeaderText = "SEKTOR";
            this.sEKTORDataGridViewTextBoxColumn1.Name = "sEKTORDataGridViewTextBoxColumn1";
            this.sEKTORDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sEKTORDataGridViewTextBoxColumn1.Width = 76;
            // 
            // aLEJKADataGridViewTextBoxColumn1
            // 
            this.aLEJKADataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aLEJKADataGridViewTextBoxColumn1.DataPropertyName = "ALEJKA";
            this.aLEJKADataGridViewTextBoxColumn1.HeaderText = "ALEJKA";
            this.aLEJKADataGridViewTextBoxColumn1.Name = "aLEJKADataGridViewTextBoxColumn1";
            this.aLEJKADataGridViewTextBoxColumn1.ReadOnly = true;
            this.aLEJKADataGridViewTextBoxColumn1.Width = 71;
            // 
            // sTANDataGridViewTextBoxColumn1
            // 
            this.sTANDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTANDataGridViewTextBoxColumn1.DataPropertyName = "STAN";
            this.sTANDataGridViewTextBoxColumn1.HeaderText = "STAN";
            this.sTANDataGridViewTextBoxColumn1.Name = "sTANDataGridViewTextBoxColumn1";
            this.sTANDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sTANDataGridViewTextBoxColumn1.Width = 61;
            // 
            // iDMATERIALUDataGridViewTextBoxColumn
            // 
            this.iDMATERIALUDataGridViewTextBoxColumn.DataPropertyName = "ID_MATERIALU";
            this.iDMATERIALUDataGridViewTextBoxColumn.HeaderText = "ID_MATERIALU";
            this.iDMATERIALUDataGridViewTextBoxColumn.Name = "iDMATERIALUDataGridViewTextBoxColumn";
            this.iDMATERIALUDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDMATERIALUDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDLOKALIZACJIDataGridViewTextBoxColumn1
            // 
            this.iDLOKALIZACJIDataGridViewTextBoxColumn1.DataPropertyName = "ID_LOKALIZACJI";
            this.iDLOKALIZACJIDataGridViewTextBoxColumn1.HeaderText = "ID_LOKALIZACJI";
            this.iDLOKALIZACJIDataGridViewTextBoxColumn1.Name = "iDLOKALIZACJIDataGridViewTextBoxColumn1";
            this.iDLOKALIZACJIDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDLOKALIZACJIDataGridViewTextBoxColumn1.Visible = false;
            // 
            // sTANMATERIALYNAZWYBindingSource
            // 
            this.sTANMATERIALYNAZWYBindingSource.DataSource = typeof(PROJEKTapp.STAN_MATERIALY_NAZWY);
            // 
            // ButtonDodajRekord
            // 
            this.ButtonDodajRekord.BackColor = System.Drawing.Color.Lime;
            this.ButtonDodajRekord.FlatAppearance.BorderSize = 0;
            this.ButtonDodajRekord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDodajRekord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonDodajRekord.Location = new System.Drawing.Point(137, 478);
            this.ButtonDodajRekord.Name = "ButtonDodajRekord";
            this.ButtonDodajRekord.Size = new System.Drawing.Size(164, 54);
            this.ButtonDodajRekord.TabIndex = 22;
            this.ButtonDodajRekord.Text = "Dodaj do magazynu";
            this.ButtonDodajRekord.UseVisualStyleBackColor = false;
            this.ButtonDodajRekord.Click += new System.EventHandler(this.ButtonDodajRekord_Click);
            // 
            // TopBar_2
            // 
            this.TopBar_2.Image = global::PROJEKTapp.Properties.Resources.top_bar1;
            this.TopBar_2.Location = new System.Drawing.Point(-135, 0);
            this.TopBar_2.Name = "TopBar_2";
            this.TopBar_2.Size = new System.Drawing.Size(1070, 83);
            this.TopBar_2.TabIndex = 7;
            this.TopBar_2.TabStop = false;
            // 
            // checkBSurowce
            // 
            this.checkBProdukty.AutoSize = true;
            this.checkBProdukty.Location = new System.Drawing.Point(209, 94);
            this.checkBProdukty.Name = "checkBSurowce";
            this.checkBProdukty.Size = new System.Drawing.Size(68, 17);
            this.checkBProdukty.TabIndex = 23;
            this.checkBProdukty.Text = "Produkty";
            this.checkBProdukty.UseVisualStyleBackColor = true;
            this.checkBProdukty.CheckedChanged += new System.EventHandler(this.checkBSurowce_CheckedChanged);
            // 
            // checkBMaterialy
            // 
            this.checkBMaterialy.AutoSize = true;
            this.checkBMaterialy.Location = new System.Drawing.Point(209, 118);
            this.checkBMaterialy.Name = "checkBMaterialy";
            this.checkBMaterialy.Size = new System.Drawing.Size(70, 17);
            this.checkBMaterialy.TabIndex = 24;
            this.checkBMaterialy.Text = "Materiały";
            this.checkBMaterialy.UseVisualStyleBackColor = true;
            this.checkBMaterialy.CheckedChanged += new System.EventHandler(this.checkBMaterialy_CheckedChanged);
            // 
            // checkBWszystkie
            // 
            this.checkBWszystkie.AutoSize = true;
            this.checkBWszystkie.Location = new System.Drawing.Point(419, 94);
            this.checkBWszystkie.Name = "checkBWszystkie";
            this.checkBWszystkie.Size = new System.Drawing.Size(74, 17);
            this.checkBWszystkie.TabIndex = 25;
            this.checkBWszystkie.Text = "Wszystkie";
            this.checkBWszystkie.UseVisualStyleBackColor = true;
            this.checkBWszystkie.CheckedChanged += new System.EventHandler(this.checkBWszystkie_CheckedChanged);
            // 
            // cBoxFlitracja
            // 
            this.cBoxFlitracja.FormattingEnabled = true;
            this.cBoxFlitracja.Location = new System.Drawing.Point(419, 116);
            this.cBoxFlitracja.Name = "cBoxFlitracja";
            this.cBoxFlitracja.Size = new System.Drawing.Size(121, 21);
            this.cBoxFlitracja.TabIndex = 27;
            this.cBoxFlitracja.SelectedIndexChanged += new System.EventHandler(this.cBoxFlitracja_SelectedIndexChanged);
            // 
            // DGV_PRODUKTY
            // 
            this.DGV_PRODUKTY.AllowUserToAddRows = false;
            this.DGV_PRODUKTY.AllowUserToDeleteRows = false;
            this.DGV_PRODUKTY.AutoGenerateColumns = false;
            this.DGV_PRODUKTY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUKTY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn,
            this.iDZLECENIADataGridViewTextBoxColumn,
            this.sEKTORDataGridViewTextBoxColumn,
            this.aLEJKADataGridViewTextBoxColumn,
            this.sTANDataGridViewTextBoxColumn,
            this.iDPRODUKTUDataGridViewTextBoxColumn,
            this.iDLOKALIZACJIDataGridViewTextBoxColumn});
            this.DGV_PRODUKTY.DataSource = this.sTANPRODUKTYNAZWYBindingSource;
            this.DGV_PRODUKTY.Location = new System.Drawing.Point(16, 154);
            this.DGV_PRODUKTY.Name = "DGV_PRODUKTY";
            this.DGV_PRODUKTY.ReadOnly = true;
            this.DGV_PRODUKTY.Size = new System.Drawing.Size(706, 318);
            this.DGV_PRODUKTY.TabIndex = 28;
            // 
            // nAZWAPRODUKTUDataGridViewTextBoxColumn
            // 
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.DataPropertyName = "NAZWA_PRODUKTU";
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.HeaderText = "NAZWA PRODUKTU";
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.Name = "nAZWAPRODUKTUDataGridViewTextBoxColumn";
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDZLECENIADataGridViewTextBoxColumn
            // 
            this.iDZLECENIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDZLECENIADataGridViewTextBoxColumn.DataPropertyName = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.HeaderText = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.Name = "iDZLECENIADataGridViewTextBoxColumn";
            this.iDZLECENIADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDZLECENIADataGridViewTextBoxColumn.Width = 101;
            // 
            // sEKTORDataGridViewTextBoxColumn
            // 
            this.sEKTORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sEKTORDataGridViewTextBoxColumn.DataPropertyName = "SEKTOR";
            this.sEKTORDataGridViewTextBoxColumn.HeaderText = "SEKTOR";
            this.sEKTORDataGridViewTextBoxColumn.Name = "sEKTORDataGridViewTextBoxColumn";
            this.sEKTORDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEKTORDataGridViewTextBoxColumn.Width = 76;
            // 
            // aLEJKADataGridViewTextBoxColumn
            // 
            this.aLEJKADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aLEJKADataGridViewTextBoxColumn.DataPropertyName = "ALEJKA";
            this.aLEJKADataGridViewTextBoxColumn.HeaderText = "ALEJKA";
            this.aLEJKADataGridViewTextBoxColumn.Name = "aLEJKADataGridViewTextBoxColumn";
            this.aLEJKADataGridViewTextBoxColumn.ReadOnly = true;
            this.aLEJKADataGridViewTextBoxColumn.Width = 71;
            // 
            // sTANDataGridViewTextBoxColumn
            // 
            this.sTANDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTANDataGridViewTextBoxColumn.DataPropertyName = "STAN";
            this.sTANDataGridViewTextBoxColumn.HeaderText = "STAN";
            this.sTANDataGridViewTextBoxColumn.Name = "sTANDataGridViewTextBoxColumn";
            this.sTANDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTANDataGridViewTextBoxColumn.Width = 61;
            // 
            // iDPRODUKTUDataGridViewTextBoxColumn
            // 
            this.iDPRODUKTUDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUKTU";
            this.iDPRODUKTUDataGridViewTextBoxColumn.HeaderText = "ID_PRODUKTU";
            this.iDPRODUKTUDataGridViewTextBoxColumn.Name = "iDPRODUKTUDataGridViewTextBoxColumn";
            this.iDPRODUKTUDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPRODUKTUDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDLOKALIZACJIDataGridViewTextBoxColumn
            // 
            this.iDLOKALIZACJIDataGridViewTextBoxColumn.DataPropertyName = "ID_LOKALIZACJI";
            this.iDLOKALIZACJIDataGridViewTextBoxColumn.HeaderText = "ID_LOKALIZACJI";
            this.iDLOKALIZACJIDataGridViewTextBoxColumn.Name = "iDLOKALIZACJIDataGridViewTextBoxColumn";
            this.iDLOKALIZACJIDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDLOKALIZACJIDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTANPRODUKTYNAZWYBindingSource
            // 
            this.sTANPRODUKTYNAZWYBindingSource.DataSource = typeof(PROJEKTapp.STAN_PRODUKTY_NAZWY);
            // 
            // lbl_ID_ZLECENIA
            // 
            this.lbl_ID_ZLECENIA.AutoSize = true;
            this.lbl_ID_ZLECENIA.Location = new System.Drawing.Point(337, 119);
            this.lbl_ID_ZLECENIA.Name = "lbl_ID_ZLECENIA";
            this.lbl_ID_ZLECENIA.Size = new System.Drawing.Size(76, 13);
            this.lbl_ID_ZLECENIA.TabIndex = 29;
            this.lbl_ID_ZLECENIA.Text = "ID ZLECENIA:";
            // 
            // btnZdejmij
            // 
            this.btnZdejmij.BackColor = System.Drawing.Color.Red;
            this.btnZdejmij.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZdejmij.Location = new System.Drawing.Point(402, 478);
            this.btnZdejmij.Name = "btnZdejmij";
            this.btnZdejmij.Size = new System.Drawing.Size(164, 55);
            this.btnZdejmij.TabIndex = 30;
            this.btnZdejmij.Text = "Zdejmij z magazynu";
            this.btnZdejmij.UseVisualStyleBackColor = false;
            this.btnZdejmij.Click += new System.EventHandler(this.btnZdejmij_Click);
            // 
            // FormZmianaStanuMagazynu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 544);
            this.Controls.Add(this.btnZdejmij);
            this.Controls.Add(this.lbl_ID_ZLECENIA);
            this.Controls.Add(this.DGV_PRODUKTY);
            this.Controls.Add(this.cBoxFlitracja);
            this.Controls.Add(this.checkBWszystkie);
            this.Controls.Add(this.checkBMaterialy);
            this.Controls.Add(this.checkBProdukty);
            this.Controls.Add(this.ButtonDodajRekord);
            this.Controls.Add(this.DGV_MATERIALY);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.TopBar_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormZmianaStanuMagazynu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormZmianaStanuMagazynu";
            this.Load += new System.EventHandler(this.FormZmianaStanuMagazynu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MATERIALY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTANMATERIALYNAZWYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUKTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTANPRODUKTYNAZWYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.DataGridView DGV_MATERIALY;
        private System.Windows.Forms.Button ButtonDodajRekord;
        private System.Windows.Forms.PictureBox TopBar_2;
        private System.Windows.Forms.CheckBox checkBProdukty;
        private System.Windows.Forms.CheckBox checkBMaterialy;
        private System.Windows.Forms.CheckBox checkBWszystkie;
        private System.Windows.Forms.ComboBox cBoxFlitracja;
        private System.Windows.Forms.DataGridView DGV_PRODUKTY;
        private System.Windows.Forms.BindingSource sTANPRODUKTYNAZWYBindingSource;
        private System.Windows.Forms.Label lbl_ID_ZLECENIA;
        private System.Windows.Forms.BindingSource sTANMATERIALYNAZWYBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn PELNA_NAZWA_MATERIALU;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEKTORDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLEJKADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTANDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMATERIALUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLOKALIZACJIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWAPRODUKTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEKTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLEJKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUKTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLOKALIZACJIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnZdejmij;
    }
}