namespace PROJEKTapp.Forms_NoweZlecenie
{
    partial class HistoriaStatusyZlecenia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDZLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAZMIANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hISTORIASTATUSZLECENIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIASTATUSZLECENIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDZLECENIADataGridViewTextBoxColumn,
            this.eTAPDataGridViewTextBoxColumn,
            this.dATAZMIANYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hISTORIASTATUSZLECENIABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(449, 309);
            this.dataGridView1.TabIndex = 0;
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
            // eTAPDataGridViewTextBoxColumn
            // 
            this.eTAPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eTAPDataGridViewTextBoxColumn.DataPropertyName = "ETAP";
            this.eTAPDataGridViewTextBoxColumn.HeaderText = "ETAP";
            this.eTAPDataGridViewTextBoxColumn.Name = "eTAPDataGridViewTextBoxColumn";
            this.eTAPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAZMIANYDataGridViewTextBoxColumn
            // 
            this.dATAZMIANYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dATAZMIANYDataGridViewTextBoxColumn.DataPropertyName = "DATA_ZMIANY";
            this.dATAZMIANYDataGridViewTextBoxColumn.HeaderText = "DATA_ZMIANY";
            this.dATAZMIANYDataGridViewTextBoxColumn.Name = "dATAZMIANYDataGridViewTextBoxColumn";
            this.dATAZMIANYDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAZMIANYDataGridViewTextBoxColumn.Width = 108;
            // 
            // hISTORIASTATUSZLECENIABindingSource
            // 
            this.hISTORIASTATUSZLECENIABindingSource.DataSource = typeof(PROJEKTapp.HISTORIA_STATUS_ZLECENIA);
            // 
            // HistoriaStatusyZlecenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 340);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HistoriaStatusyZlecenia";
            this.Text = "HistoriaStatusyZlecenia";
            this.Load += new System.EventHandler(this.HistoriaStatusyZlecenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIASTATUSZLECENIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAZMIANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hISTORIASTATUSZLECENIABindingSource;
    }
}