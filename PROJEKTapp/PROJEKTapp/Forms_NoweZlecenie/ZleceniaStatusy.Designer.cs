namespace PROJEKTapp
{
    partial class ZleceniaStatusy
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
            this.StatusZleceniaDGV = new System.Windows.Forms.DataGridView();
            this.iDZLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWAFIRMYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAZLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAREALIZACJIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFIRMYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusdetalezlecenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNastepnyStatus = new System.Windows.Forms.Button();
            this.btnHZlecen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StatusZleceniaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusdetalezlecenieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusZleceniaDGV
            // 
            this.StatusZleceniaDGV.AllowUserToAddRows = false;
            this.StatusZleceniaDGV.AllowUserToDeleteRows = false;
            this.StatusZleceniaDGV.AutoGenerateColumns = false;
            this.StatusZleceniaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatusZleceniaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDZLECENIADataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.nAZWAFIRMYDataGridViewTextBoxColumn,
            this.dATAZLECENIADataGridViewTextBoxColumn,
            this.dATAREALIZACJIDataGridViewTextBoxColumn,
            this.iDFIRMYDataGridViewTextBoxColumn,
            this.eTAPDataGridViewTextBoxColumn});
            this.StatusZleceniaDGV.DataSource = this.statusdetalezlecenieBindingSource;
            this.StatusZleceniaDGV.Location = new System.Drawing.Point(12, 12);
            this.StatusZleceniaDGV.Name = "StatusZleceniaDGV";
            this.StatusZleceniaDGV.ReadOnly = true;
            this.StatusZleceniaDGV.Size = new System.Drawing.Size(672, 258);
            this.StatusZleceniaDGV.TabIndex = 0;
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
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 62;
            // 
            // nAZWAFIRMYDataGridViewTextBoxColumn
            // 
            this.nAZWAFIRMYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nAZWAFIRMYDataGridViewTextBoxColumn.DataPropertyName = "NAZWA_FIRMY";
            this.nAZWAFIRMYDataGridViewTextBoxColumn.HeaderText = "NAZWA_FIRMY";
            this.nAZWAFIRMYDataGridViewTextBoxColumn.Name = "nAZWAFIRMYDataGridViewTextBoxColumn";
            this.nAZWAFIRMYDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAZWAFIRMYDataGridViewTextBoxColumn.Width = 111;
            // 
            // dATAZLECENIADataGridViewTextBoxColumn
            // 
            this.dATAZLECENIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dATAZLECENIADataGridViewTextBoxColumn.DataPropertyName = "DATA_ZLECENIA";
            this.dATAZLECENIADataGridViewTextBoxColumn.HeaderText = "DATA_ZLECENIA";
            this.dATAZLECENIADataGridViewTextBoxColumn.Name = "dATAZLECENIADataGridViewTextBoxColumn";
            this.dATAZLECENIADataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAZLECENIADataGridViewTextBoxColumn.Width = 119;
            // 
            // dATAREALIZACJIDataGridViewTextBoxColumn
            // 
            this.dATAREALIZACJIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dATAREALIZACJIDataGridViewTextBoxColumn.DataPropertyName = "DATA_REALIZACJI";
            this.dATAREALIZACJIDataGridViewTextBoxColumn.HeaderText = "DATA_REALIZACJI";
            this.dATAREALIZACJIDataGridViewTextBoxColumn.Name = "dATAREALIZACJIDataGridViewTextBoxColumn";
            this.dATAREALIZACJIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAREALIZACJIDataGridViewTextBoxColumn.Width = 127;
            // 
            // iDFIRMYDataGridViewTextBoxColumn
            // 
            this.iDFIRMYDataGridViewTextBoxColumn.DataPropertyName = "ID_FIRMY";
            this.iDFIRMYDataGridViewTextBoxColumn.HeaderText = "ID_FIRMY";
            this.iDFIRMYDataGridViewTextBoxColumn.Name = "iDFIRMYDataGridViewTextBoxColumn";
            this.iDFIRMYDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFIRMYDataGridViewTextBoxColumn.Visible = false;
            // 
            // eTAPDataGridViewTextBoxColumn
            // 
            this.eTAPDataGridViewTextBoxColumn.DataPropertyName = "ETAP";
            this.eTAPDataGridViewTextBoxColumn.HeaderText = "ETAP";
            this.eTAPDataGridViewTextBoxColumn.Name = "eTAPDataGridViewTextBoxColumn";
            this.eTAPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusdetalezlecenieBindingSource
            // 
            this.statusdetalezlecenieBindingSource.DataSource = typeof(PROJEKTapp.Status_detale_zlecenie);
            // 
            // btnNastepnyStatus
            // 
            this.btnNastepnyStatus.Location = new System.Drawing.Point(242, 296);
            this.btnNastepnyStatus.Name = "btnNastepnyStatus";
            this.btnNastepnyStatus.Size = new System.Drawing.Size(202, 23);
            this.btnNastepnyStatus.TabIndex = 1;
            this.btnNastepnyStatus.Text = "Przekaż zlecenie do nastepnego etapu";
            this.btnNastepnyStatus.UseVisualStyleBackColor = true;
            this.btnNastepnyStatus.Click += new System.EventHandler(this.btnNastepnyStatus_Click);
            // 
            // btnHZlecen
            // 
            this.btnHZlecen.Location = new System.Drawing.Point(242, 325);
            this.btnHZlecen.Name = "btnHZlecen";
            this.btnHZlecen.Size = new System.Drawing.Size(202, 23);
            this.btnHZlecen.TabIndex = 2;
            this.btnHZlecen.Text = "Historia zmiany statusu zlecenia";
            this.btnHZlecen.UseVisualStyleBackColor = true;
            this.btnHZlecen.Click += new System.EventHandler(this.btnHZlecen_Click);
            // 
            // ZleceniaStatusy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 360);
            this.Controls.Add(this.btnHZlecen);
            this.Controls.Add(this.btnNastepnyStatus);
            this.Controls.Add(this.StatusZleceniaDGV);
            this.Name = "ZleceniaStatusy";
            this.Text = "Statusy Zleceń";
            this.Load += new System.EventHandler(this.ZleceniaStatusy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatusZleceniaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusdetalezlecenieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StatusZleceniaDGV;
        private System.Windows.Forms.Button btnNastepnyStatus;
        private System.Windows.Forms.Button btnHZlecen;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWAFIRMYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAZLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAREALIZACJIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFIRMYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource statusdetalezlecenieBindingSource;
    }
}