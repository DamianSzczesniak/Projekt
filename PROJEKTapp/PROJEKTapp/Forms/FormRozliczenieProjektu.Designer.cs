namespace PROJEKTapp
{
    partial class FormRozliczenieProjektu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRozliczenieProjektu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRozliczenie = new System.Windows.Forms.DataGridView();
            this.zestawienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDZLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wydatkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrotyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zarobekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRozliczenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zestawienieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 59);
            this.panel1.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1297, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kadry i Finanse";
            // 
            // dgvRozliczenie
            // 
            this.dgvRozliczenie.AllowUserToAddRows = false;
            this.dgvRozliczenie.AllowUserToDeleteRows = false;
            this.dgvRozliczenie.AutoGenerateColumns = false;
            this.dgvRozliczenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRozliczenie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDZLECENIADataGridViewTextBoxColumn,
            this.wydatkiDataGridViewTextBoxColumn,
            this.obrotyDataGridViewTextBoxColumn,
            this.zarobekDataGridViewTextBoxColumn});
            this.dgvRozliczenie.DataSource = this.zestawienieBindingSource;
            this.dgvRozliczenie.Location = new System.Drawing.Point(369, 105);
            this.dgvRozliczenie.Name = "dgvRozliczenie";
            this.dgvRozliczenie.ReadOnly = true;
            this.dgvRozliczenie.Size = new System.Drawing.Size(560, 468);
            this.dgvRozliczenie.TabIndex = 10;
            // 
            // zestawienieBindingSource
            // 
            this.zestawienieBindingSource.DataSource = typeof(PROJEKTapp.zestawienie);
            // 
            // iDZLECENIADataGridViewTextBoxColumn
            // 
            this.iDZLECENIADataGridViewTextBoxColumn.DataPropertyName = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.HeaderText = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.Name = "iDZLECENIADataGridViewTextBoxColumn";
            this.iDZLECENIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wydatkiDataGridViewTextBoxColumn
            // 
            this.wydatkiDataGridViewTextBoxColumn.DataPropertyName = "wydatki";
            this.wydatkiDataGridViewTextBoxColumn.HeaderText = "wydatki";
            this.wydatkiDataGridViewTextBoxColumn.Name = "wydatkiDataGridViewTextBoxColumn";
            this.wydatkiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obrotyDataGridViewTextBoxColumn
            // 
            this.obrotyDataGridViewTextBoxColumn.DataPropertyName = "obroty";
            this.obrotyDataGridViewTextBoxColumn.HeaderText = "obroty";
            this.obrotyDataGridViewTextBoxColumn.Name = "obrotyDataGridViewTextBoxColumn";
            this.obrotyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zarobekDataGridViewTextBoxColumn
            // 
            this.zarobekDataGridViewTextBoxColumn.DataPropertyName = "zarobek";
            this.zarobekDataGridViewTextBoxColumn.HeaderText = "zarobek";
            this.zarobekDataGridViewTextBoxColumn.Name = "zarobekDataGridViewTextBoxColumn";
            this.zarobekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormRozliczenieProjektu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 768);
            this.Controls.Add(this.dgvRozliczenie);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRozliczenieProjektu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRozliczenieProjektu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRozliczenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zestawienieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRozliczenie;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydatkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrotyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zarobekDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zestawienieBindingSource;
    }
}