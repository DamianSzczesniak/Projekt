namespace PROJEKTapp
{
    partial class FormStatystyki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatystyki));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStatystyki = new System.Windows.Forms.Button();
            this.btnSzkolenia = new System.Windows.Forms.Button();
            this.btnUrlopy = new System.Windows.Forms.Button();
            this.btnWynagrodzenia = new System.Windows.Forms.Button();
            this.btnPracownicy = new System.Windows.Forms.Button();
            this.btnRozliczenieProjektow = new System.Windows.Forms.Button();
            this.pnlRozliczenie = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerKoniec = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPoczatek = new System.Windows.Forms.DateTimePicker();
            this.txtBoxSKoszty = new System.Windows.Forms.TextBox();
            this.txtBoxSPrzychod = new System.Windows.Forms.TextBox();
            this.txtBoxSDochod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRozliczenie = new System.Windows.Forms.DataGridView();
            this.Kwota_pobrana_za_zlecenie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kosz_wykonania_zlecenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_REALIZACJI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDZLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zestawienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlRozliczenie.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1366, 59);
            this.panel1.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1281, 1);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.btnStatystyki);
            this.panel2.Controls.Add(this.btnSzkolenia);
            this.panel2.Controls.Add(this.btnUrlopy);
            this.panel2.Controls.Add(this.btnWynagrodzenia);
            this.panel2.Controls.Add(this.btnPracownicy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 633);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 135);
            this.panel2.TabIndex = 9;
            // 
            // btnStatystyki
            // 
            this.btnStatystyki.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStatystyki.FlatAppearance.BorderSize = 0;
            this.btnStatystyki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatystyki.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatystyki.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStatystyki.Image = ((System.Drawing.Image)(resources.GetObject("btnStatystyki.Image")));
            this.btnStatystyki.Location = new System.Drawing.Point(752, -3);
            this.btnStatystyki.Name = "btnStatystyki";
            this.btnStatystyki.Size = new System.Drawing.Size(188, 135);
            this.btnStatystyki.TabIndex = 2;
            this.btnStatystyki.Text = "Statystyki";
            this.btnStatystyki.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStatystyki.UseVisualStyleBackColor = false;
            this.btnStatystyki.Click += new System.EventHandler(this.btnStatystyki_Click);
            // 
            // btnSzkolenia
            // 
            this.btnSzkolenia.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSzkolenia.FlatAppearance.BorderSize = 0;
            this.btnSzkolenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzkolenia.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzkolenia.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSzkolenia.Image = ((System.Drawing.Image)(resources.GetObject("btnSzkolenia.Image")));
            this.btnSzkolenia.Location = new System.Drawing.Point(564, -3);
            this.btnSzkolenia.Name = "btnSzkolenia";
            this.btnSzkolenia.Size = new System.Drawing.Size(188, 138);
            this.btnSzkolenia.TabIndex = 2;
            this.btnSzkolenia.Text = "Szkolenia";
            this.btnSzkolenia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSzkolenia.UseVisualStyleBackColor = false;
            this.btnSzkolenia.Click += new System.EventHandler(this.btnSzkolenia_Click);
            // 
            // btnUrlopy
            // 
            this.btnUrlopy.FlatAppearance.BorderSize = 0;
            this.btnUrlopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrlopy.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrlopy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUrlopy.Image = ((System.Drawing.Image)(resources.GetObject("btnUrlopy.Image")));
            this.btnUrlopy.Location = new System.Drawing.Point(376, -3);
            this.btnUrlopy.Name = "btnUrlopy";
            this.btnUrlopy.Size = new System.Drawing.Size(188, 135);
            this.btnUrlopy.TabIndex = 2;
            this.btnUrlopy.Text = "Urlopy";
            this.btnUrlopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrlopy.UseVisualStyleBackColor = true;
            this.btnUrlopy.Click += new System.EventHandler(this.btnUrlopy_Click);
            // 
            // btnWynagrodzenia
            // 
            this.btnWynagrodzenia.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnWynagrodzenia.FlatAppearance.BorderSize = 0;
            this.btnWynagrodzenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWynagrodzenia.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWynagrodzenia.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWynagrodzenia.Image = ((System.Drawing.Image)(resources.GetObject("btnWynagrodzenia.Image")));
            this.btnWynagrodzenia.Location = new System.Drawing.Point(188, -3);
            this.btnWynagrodzenia.Name = "btnWynagrodzenia";
            this.btnWynagrodzenia.Size = new System.Drawing.Size(188, 138);
            this.btnWynagrodzenia.TabIndex = 2;
            this.btnWynagrodzenia.Text = "Wynagrodzenia";
            this.btnWynagrodzenia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWynagrodzenia.UseVisualStyleBackColor = false;
            this.btnWynagrodzenia.Click += new System.EventHandler(this.btnWynagrodzenia_Click);
            // 
            // btnPracownicy
            // 
            this.btnPracownicy.FlatAppearance.BorderSize = 0;
            this.btnPracownicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPracownicy.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPracownicy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPracownicy.Image = ((System.Drawing.Image)(resources.GetObject("btnPracownicy.Image")));
            this.btnPracownicy.Location = new System.Drawing.Point(0, 0);
            this.btnPracownicy.Name = "btnPracownicy";
            this.btnPracownicy.Size = new System.Drawing.Size(188, 135);
            this.btnPracownicy.TabIndex = 2;
            this.btnPracownicy.Text = "Pracownicy";
            this.btnPracownicy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPracownicy.UseVisualStyleBackColor = true;
            this.btnPracownicy.Click += new System.EventHandler(this.btnPracownicy_Click);
            // 
            // btnRozliczenieProjektow
            // 
            this.btnRozliczenieProjektow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRozliczenieProjektow.Location = new System.Drawing.Point(12, 65);
            this.btnRozliczenieProjektow.Name = "btnRozliczenieProjektow";
            this.btnRozliczenieProjektow.Size = new System.Drawing.Size(231, 103);
            this.btnRozliczenieProjektow.TabIndex = 10;
            this.btnRozliczenieProjektow.Text = "Pokaż podsumowanie projektów";
            this.btnRozliczenieProjektow.UseVisualStyleBackColor = true;
            this.btnRozliczenieProjektow.Visible = false;
            this.btnRozliczenieProjektow.Click += new System.EventHandler(this.btnRozliczenieProjektow_Click);
            // 
            // pnlRozliczenie
            // 
            this.pnlRozliczenie.Controls.Add(this.dgvRozliczenie);
            this.pnlRozliczenie.Controls.Add(this.label7);
            this.pnlRozliczenie.Controls.Add(this.label6);
            this.pnlRozliczenie.Controls.Add(this.label5);
            this.pnlRozliczenie.Controls.Add(this.dateTimePickerKoniec);
            this.pnlRozliczenie.Controls.Add(this.dateTimePickerPoczatek);
            this.pnlRozliczenie.Controls.Add(this.txtBoxSKoszty);
            this.pnlRozliczenie.Controls.Add(this.txtBoxSPrzychod);
            this.pnlRozliczenie.Controls.Add(this.txtBoxSDochod);
            this.pnlRozliczenie.Controls.Add(this.label4);
            this.pnlRozliczenie.Controls.Add(this.label3);
            this.pnlRozliczenie.Controls.Add(this.label2);
            this.pnlRozliczenie.Location = new System.Drawing.Point(530, 65);
            this.pnlRozliczenie.Name = "pnlRozliczenie";
            this.pnlRozliczenie.Size = new System.Drawing.Size(824, 562);
            this.pnlRozliczenie.TabIndex = 11;
            this.pnlRozliczenie.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "DO :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "OD :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(187, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "ZESTAWIENIE FINANSOWE DLA OKRESU :";
            // 
            // dateTimePickerKoniec
            // 
            this.dateTimePickerKoniec.Location = new System.Drawing.Point(268, 86);
            this.dateTimePickerKoniec.Name = "dateTimePickerKoniec";
            this.dateTimePickerKoniec.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKoniec.TabIndex = 30;
            // 
            // dateTimePickerPoczatek
            // 
            this.dateTimePickerPoczatek.Location = new System.Drawing.Point(268, 50);
            this.dateTimePickerPoczatek.Name = "dateTimePickerPoczatek";
            this.dateTimePickerPoczatek.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPoczatek.TabIndex = 29;
            // 
            // txtBoxSKoszty
            // 
            this.txtBoxSKoszty.Location = new System.Drawing.Point(321, 522);
            this.txtBoxSKoszty.Name = "txtBoxSKoszty";
            this.txtBoxSKoszty.Size = new System.Drawing.Size(157, 20);
            this.txtBoxSKoszty.TabIndex = 28;
            this.txtBoxSKoszty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxSPrzychod
            // 
            this.txtBoxSPrzychod.Location = new System.Drawing.Point(174, 522);
            this.txtBoxSPrzychod.Name = "txtBoxSPrzychod";
            this.txtBoxSPrzychod.Size = new System.Drawing.Size(141, 20);
            this.txtBoxSPrzychod.TabIndex = 27;
            this.txtBoxSPrzychod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxSDochod
            // 
            this.txtBoxSDochod.Location = new System.Drawing.Point(484, 522);
            this.txtBoxSDochod.Name = "txtBoxSDochod";
            this.txtBoxSDochod.Size = new System.Drawing.Size(161, 20);
            this.txtBoxSDochod.TabIndex = 26;
            this.txtBoxSDochod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "SUMA DOCHODOW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "SUMA PRZYCHODOW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "SUMA KOSZTOW";
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
            this.dgvRozliczenie.Location = new System.Drawing.Point(33, 112);
            this.dgvRozliczenie.Name = "dgvRozliczenie";
            this.dgvRozliczenie.ReadOnly = true;
            this.dgvRozliczenie.Size = new System.Drawing.Size(612, 380);
            this.dgvRozliczenie.TabIndex = 34;
            // 
            // Kwota_pobrana_za_zlecenie
            // 
            this.Kwota_pobrana_za_zlecenie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Kwota_pobrana_za_zlecenie.DataPropertyName = "Kwota_pobrana_za_zlecenie";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Kwota_pobrana_za_zlecenie.DefaultCellStyle = dataGridViewCellStyle2;
            this.Kwota_pobrana_za_zlecenie.HeaderText = "PRZYCHÓD";
            this.Kwota_pobrana_za_zlecenie.Name = "Kwota_pobrana_za_zlecenie";
            this.Kwota_pobrana_za_zlecenie.ReadOnly = true;
            this.Kwota_pobrana_za_zlecenie.Width = 150;
            // 
            // Kosz_wykonania_zlecenia
            // 
            this.Kosz_wykonania_zlecenia.DataPropertyName = "Kosz_wykonania_zlecenia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Kosz_wykonania_zlecenia.DefaultCellStyle = dataGridViewCellStyle3;
            this.Kosz_wykonania_zlecenia.HeaderText = "KOSZT";
            this.Kosz_wykonania_zlecenia.Name = "Kosz_wykonania_zlecenia";
            this.Kosz_wykonania_zlecenia.ReadOnly = true;
            this.Kosz_wykonania_zlecenia.Width = 150;
            // 
            // Saldo
            // 
            this.Saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle4;
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
            // iDZLECENIADataGridViewTextBoxColumn
            // 
            this.iDZLECENIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDZLECENIADataGridViewTextBoxColumn.DataPropertyName = "ID_ZLECENIA";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iDZLECENIADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.iDZLECENIADataGridViewTextBoxColumn.HeaderText = "ID ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.Name = "iDZLECENIADataGridViewTextBoxColumn";
            this.iDZLECENIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zestawienieBindingSource
            // 
            this.zestawienieBindingSource.DataSource = typeof(PROJEKTapp.zestawienie);
            // 
            // FormStatystyki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlRozliczenie);
            this.Controls.Add(this.btnRozliczenieProjektow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStatystyki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStatystyki";
            this.Load += new System.EventHandler(this.FormStatystyki_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlRozliczenie.ResumeLayout(false);
            this.pnlRozliczenie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRozliczenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zestawienieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStatystyki;
        private System.Windows.Forms.Button btnSzkolenia;
        private System.Windows.Forms.Button btnUrlopy;
        private System.Windows.Forms.Button btnWynagrodzenia;
        private System.Windows.Forms.Button btnPracownicy;
        private System.Windows.Forms.Button btnRozliczenieProjektow;
        private System.Windows.Forms.Panel pnlRozliczenie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerKoniec;
        private System.Windows.Forms.DateTimePicker dateTimePickerPoczatek;
        private System.Windows.Forms.TextBox txtBoxSKoszty;
        private System.Windows.Forms.TextBox txtBoxSPrzychod;
        private System.Windows.Forms.TextBox txtBoxSDochod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource zestawienieBindingSource;
        private System.Windows.Forms.DataGridView dgvRozliczenie;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kwota_pobrana_za_zlecenie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kosz_wykonania_zlecenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_REALIZACJI;
    }
}