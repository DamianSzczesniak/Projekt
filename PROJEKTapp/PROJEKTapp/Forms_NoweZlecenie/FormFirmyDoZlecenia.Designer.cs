namespace PROJEKTapp.Forms_NoweZlecenie
{
    partial class FormFirmyDoZlecenia
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
            this.iDFIRMYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWAFIRMYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRTELEFONUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOSTAWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOJAZDYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zAMOWIENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNazwaTabeliFirmy = new System.Windows.Forms.Label();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirmyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFIRMYDataGridViewTextBoxColumn,
            this.nAZWAFIRMYDataGridViewTextBoxColumn,
            this.aDRESEMAILDataGridViewTextBoxColumn,
            this.nRTELEFONUDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn,
            this.dOSTAWADataGridViewTextBoxColumn,
            this.pOJAZDYDataGridViewTextBoxColumn,
            this.zAMOWIENIADataGridViewTextBoxColumn,
            this.zLECENIADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.FirmyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDFIRMYDataGridViewTextBoxColumn
            // 
            this.iDFIRMYDataGridViewTextBoxColumn.DataPropertyName = "ID_FIRMY";
            this.iDFIRMYDataGridViewTextBoxColumn.HeaderText = "ID_FIRMY";
            this.iDFIRMYDataGridViewTextBoxColumn.Name = "iDFIRMYDataGridViewTextBoxColumn";
            this.iDFIRMYDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAZWAFIRMYDataGridViewTextBoxColumn
            // 
            this.nAZWAFIRMYDataGridViewTextBoxColumn.DataPropertyName = "NAZWA_FIRMY";
            this.nAZWAFIRMYDataGridViewTextBoxColumn.HeaderText = "NAZWA_FIRMY";
            this.nAZWAFIRMYDataGridViewTextBoxColumn.Name = "nAZWAFIRMYDataGridViewTextBoxColumn";
            // 
            // aDRESEMAILDataGridViewTextBoxColumn
            // 
            this.aDRESEMAILDataGridViewTextBoxColumn.DataPropertyName = "ADRES_EMAIL";
            this.aDRESEMAILDataGridViewTextBoxColumn.HeaderText = "ADRES_EMAIL";
            this.aDRESEMAILDataGridViewTextBoxColumn.Name = "aDRESEMAILDataGridViewTextBoxColumn";
            // 
            // nRTELEFONUDataGridViewTextBoxColumn
            // 
            this.nRTELEFONUDataGridViewTextBoxColumn.DataPropertyName = "NR_TELEFONU";
            this.nRTELEFONUDataGridViewTextBoxColumn.HeaderText = "NR_TELEFONU";
            this.nRTELEFONUDataGridViewTextBoxColumn.Name = "nRTELEFONUDataGridViewTextBoxColumn";
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            // 
            // dOSTAWADataGridViewTextBoxColumn
            // 
            this.dOSTAWADataGridViewTextBoxColumn.DataPropertyName = "DOSTAWA";
            this.dOSTAWADataGridViewTextBoxColumn.HeaderText = "DOSTAWA";
            this.dOSTAWADataGridViewTextBoxColumn.Name = "dOSTAWADataGridViewTextBoxColumn";
            this.dOSTAWADataGridViewTextBoxColumn.Visible = false;
            // 
            // pOJAZDYDataGridViewTextBoxColumn
            // 
            this.pOJAZDYDataGridViewTextBoxColumn.DataPropertyName = "POJAZDY";
            this.pOJAZDYDataGridViewTextBoxColumn.HeaderText = "POJAZDY";
            this.pOJAZDYDataGridViewTextBoxColumn.Name = "pOJAZDYDataGridViewTextBoxColumn";
            this.pOJAZDYDataGridViewTextBoxColumn.Visible = false;
            // 
            // zAMOWIENIADataGridViewTextBoxColumn
            // 
            this.zAMOWIENIADataGridViewTextBoxColumn.DataPropertyName = "ZAMOWIENIA";
            this.zAMOWIENIADataGridViewTextBoxColumn.HeaderText = "ZAMOWIENIA";
            this.zAMOWIENIADataGridViewTextBoxColumn.Name = "zAMOWIENIADataGridViewTextBoxColumn";
            this.zAMOWIENIADataGridViewTextBoxColumn.Visible = false;
            // 
            // zLECENIADataGridViewTextBoxColumn
            // 
            this.zLECENIADataGridViewTextBoxColumn.DataPropertyName = "ZLECENIA";
            this.zLECENIADataGridViewTextBoxColumn.HeaderText = "ZLECENIA";
            this.zLECENIADataGridViewTextBoxColumn.Name = "zLECENIADataGridViewTextBoxColumn";
            this.zLECENIADataGridViewTextBoxColumn.Visible = false;
            // 
            // FirmyBindingSource
            // 
            this.FirmyBindingSource.DataSource = typeof(PROJEKTapp.FIRMY);
            // 
            // lblNazwaTabeliFirmy
            // 
            this.lblNazwaTabeliFirmy.AutoSize = true;
            this.lblNazwaTabeliFirmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaTabeliFirmy.Location = new System.Drawing.Point(187, 9);
            this.lblNazwaTabeliFirmy.Name = "lblNazwaTabeliFirmy";
            this.lblNazwaTabeliFirmy.Size = new System.Drawing.Size(100, 24);
            this.lblNazwaTabeliFirmy.TabIndex = 1;
            this.lblNazwaTabeliFirmy.Text = "Lista Firm";
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(392, 426);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(202, 426);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 2;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 426);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormFirmyDoZlecenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 461);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.lblNazwaTabeliFirmy);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormFirmyDoZlecenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ewidencja Firm";
            this.Load += new System.EventHandler(this.FormFirmyDoZlecenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirmyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNazwaTabeliFirmy;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFIRMYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWAFIRMYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRTELEFONUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOSTAWADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOJAZDYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zAMOWIENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource FirmyBindingSource;
    }
}