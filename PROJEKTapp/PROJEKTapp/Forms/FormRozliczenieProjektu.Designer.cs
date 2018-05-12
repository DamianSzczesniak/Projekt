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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRozliczenie = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxSDochod = new System.Windows.Forms.TextBox();
            this.txtBoxSPrzychod = new System.Windows.Forms.TextBox();
            this.txtBoxSKoszty = new System.Windows.Forms.TextBox();
            this.dateTimePickerPoczatek = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerKoniec = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.zestawienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDZLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kwota_pobrana_za_zlecenie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kosz_wykonania_zlecenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_REALIZACJI = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnExit.Location = new System.Drawing.Point(1297, 3);
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
            this.Kwota_pobrana_za_zlecenie,
            this.Kosz_wykonania_zlecenia,
            this.Saldo,
            this.DATA_REALIZACJI});
            this.dgvRozliczenie.DataSource = this.zestawienieBindingSource;
            this.dgvRozliczenie.Location = new System.Drawing.Point(362, 168);
            this.dgvRozliczenie.Name = "dgvRozliczenie";
            this.dgvRozliczenie.ReadOnly = true;
            this.dgvRozliczenie.Size = new System.Drawing.Size(612, 380);
            this.dgvRozliczenie.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "SUMA KOSZTOW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "SUMA PRZYCHODOW";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(841, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "SUMA DOCHODOW";
            // 
            // txtBoxSDochod
            // 
            this.txtBoxSDochod.Location = new System.Drawing.Point(813, 578);
            this.txtBoxSDochod.Name = "txtBoxSDochod";
            this.txtBoxSDochod.Size = new System.Drawing.Size(161, 20);
            this.txtBoxSDochod.TabIndex = 14;
            // 
            // txtBoxSPrzychod
            // 
            this.txtBoxSPrzychod.Location = new System.Drawing.Point(503, 578);
            this.txtBoxSPrzychod.Name = "txtBoxSPrzychod";
            this.txtBoxSPrzychod.Size = new System.Drawing.Size(141, 20);
            this.txtBoxSPrzychod.TabIndex = 15;
            // 
            // txtBoxSKoszty
            // 
            this.txtBoxSKoszty.Location = new System.Drawing.Point(650, 578);
            this.txtBoxSKoszty.Name = "txtBoxSKoszty";
            this.txtBoxSKoszty.Size = new System.Drawing.Size(157, 20);
            this.txtBoxSKoszty.TabIndex = 16;
            // 
            // dateTimePickerPoczatek
            // 
            this.dateTimePickerPoczatek.Location = new System.Drawing.Point(597, 106);
            this.dateTimePickerPoczatek.Name = "dateTimePickerPoczatek";
            this.dateTimePickerPoczatek.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPoczatek.TabIndex = 17;
            this.dateTimePickerPoczatek.ValueChanged += new System.EventHandler(this.dateTimePickerPoczatek_ValueChanged);
            // 
            // dateTimePickerKoniec
            // 
            this.dateTimePickerKoniec.Location = new System.Drawing.Point(597, 142);
            this.dateTimePickerKoniec.Name = "dateTimePickerKoniec";
            this.dateTimePickerKoniec.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKoniec.TabIndex = 18;
            this.dateTimePickerKoniec.ValueChanged += new System.EventHandler(this.dateTimePickerKoniec_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(516, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "ZESTAWIENIE FINANSOWE DLA OKRESU :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "OD :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(562, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "DO :";
            // 
            // zestawienieBindingSource
            // 
            this.zestawienieBindingSource.DataSource = typeof(PROJEKTapp.zestawienie);
            // 
            // iDZLECENIADataGridViewTextBoxColumn
            // 
            this.iDZLECENIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDZLECENIADataGridViewTextBoxColumn.DataPropertyName = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.HeaderText = "ID ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.Name = "iDZLECENIADataGridViewTextBoxColumn";
            this.iDZLECENIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Kwota_pobrana_za_zlecenie
            // 
            this.Kwota_pobrana_za_zlecenie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Kwota_pobrana_za_zlecenie.DataPropertyName = "Kwota_pobrana_za_zlecenie";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Kwota_pobrana_za_zlecenie.DefaultCellStyle = dataGridViewCellStyle1;
            this.Kwota_pobrana_za_zlecenie.HeaderText = "PRZYCHÓD";
            this.Kwota_pobrana_za_zlecenie.Name = "Kwota_pobrana_za_zlecenie";
            this.Kwota_pobrana_za_zlecenie.ReadOnly = true;
            this.Kwota_pobrana_za_zlecenie.Width = 150;
            // 
            // Kosz_wykonania_zlecenia
            // 
            this.Kosz_wykonania_zlecenia.DataPropertyName = "Kosz_wykonania_zlecenia";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Kosz_wykonania_zlecenia.DefaultCellStyle = dataGridViewCellStyle2;
            this.Kosz_wykonania_zlecenia.HeaderText = "KOSZT";
            this.Kosz_wykonania_zlecenia.Name = "Kosz_wykonania_zlecenia";
            this.Kosz_wykonania_zlecenia.ReadOnly = true;
            this.Kosz_wykonania_zlecenia.Width = 150;
            // 
            // Saldo
            // 
            this.Saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Saldo.HeaderText = "DOCHÓD";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // DATA_REALIZACJI
            // 
            this.DATA_REALIZACJI.DataPropertyName = "DATA_REALIZACJI";
            this.DATA_REALIZACJI.HeaderText = "DATA_REALIZACJI";
            this.DATA_REALIZACJI.Name = "DATA_REALIZACJI";
            this.DATA_REALIZACJI.ReadOnly = true;
            this.DATA_REALIZACJI.Visible = false;
            // 
            // FormRozliczenieProjektu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 768);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerKoniec);
            this.Controls.Add(this.dateTimePickerPoczatek);
            this.Controls.Add(this.txtBoxSKoszty);
            this.Controls.Add(this.txtBoxSPrzychod);
            this.Controls.Add(this.txtBoxSDochod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRozliczenie);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRozliczenieProjektu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRozliczenieProjektu";
            this.Load += new System.EventHandler(this.FormRozliczenieProjektu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRozliczenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zestawienieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRozliczenie;
        private System.Windows.Forms.BindingSource zestawienieBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxSDochod;
        private System.Windows.Forms.TextBox txtBoxSPrzychod;
        private System.Windows.Forms.TextBox txtBoxSKoszty;
        private System.Windows.Forms.DateTimePicker dateTimePickerPoczatek;
        private System.Windows.Forms.DateTimePicker dateTimePickerKoniec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kwota_pobrana_za_zlecenie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kosz_wykonania_zlecenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_REALIZACJI;
    }
}