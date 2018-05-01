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
            this.aKTUALNYSTATUSZLECENNAZWYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDZLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StatusZleceniaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKTUALNYSTATUSZLECENNAZWYBindingSource)).BeginInit();
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
            this.eTAPDataGridViewTextBoxColumn});
            this.StatusZleceniaDGV.DataSource = this.aKTUALNYSTATUSZLECENNAZWYBindingSource;
            this.StatusZleceniaDGV.Location = new System.Drawing.Point(12, 12);
            this.StatusZleceniaDGV.Name = "StatusZleceniaDGV";
            this.StatusZleceniaDGV.ReadOnly = true;
            this.StatusZleceniaDGV.Size = new System.Drawing.Size(449, 258);
            this.StatusZleceniaDGV.TabIndex = 0;
            // 
            // aKTUALNYSTATUSZLECENNAZWYBindingSource
            // 
            this.aKTUALNYSTATUSZLECENNAZWYBindingSource.DataSource = typeof(PROJEKTapp.AKTUALNY_STATUS_ZLECEN_NAZWY);
            // 
            // iDZLECENIADataGridViewTextBoxColumn
            // 
            this.iDZLECENIADataGridViewTextBoxColumn.DataPropertyName = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.HeaderText = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.Name = "iDZLECENIADataGridViewTextBoxColumn";
            this.iDZLECENIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // eTAPDataGridViewTextBoxColumn
            // 
            this.eTAPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eTAPDataGridViewTextBoxColumn.DataPropertyName = "ETAP";
            this.eTAPDataGridViewTextBoxColumn.HeaderText = "ETAP";
            this.eTAPDataGridViewTextBoxColumn.Name = "eTAPDataGridViewTextBoxColumn";
            this.eTAPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ZleceniaStatusy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 341);
            this.Controls.Add(this.StatusZleceniaDGV);
            this.Name = "ZleceniaStatusy";
            this.Text = "Statusy Zleceń";
            this.Load += new System.EventHandler(this.ZleceniaStatusy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatusZleceniaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKTUALNYSTATUSZLECENNAZWYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StatusZleceniaDGV;
        private System.Windows.Forms.BindingSource aKTUALNYSTATUSZLECENNAZWYBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTAPDataGridViewTextBoxColumn;
    }
}