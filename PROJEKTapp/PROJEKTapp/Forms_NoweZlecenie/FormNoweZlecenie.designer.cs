namespace PROJEKTapp
{
    partial class FormNoweZlecenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoweZlecenie));
            this.groupBoxOferta = new System.Windows.Forms.GroupBox();
            this.txtBoxCena = new System.Windows.Forms.TextBox();
            this.lblKOSZT = new System.Windows.Forms.Label();
            this.dataGridViewOferta = new System.Windows.Forms.DataGridView();
            this.txtBox_Ilosc_Oferta = new System.Windows.Forms.TextBox();
            this.btn_Dodaj_Oferta = new System.Windows.Forms.Button();
            this.cBox_Produkty_Oferta = new System.Windows.Forms.ComboBox();
            this.btnPrzedstaw_Oferte = new System.Windows.Forms.Button();
            this.lbl_Ilosc_Oferta = new System.Windows.Forms.Label();
            this.lblProdukt_Oferta = new System.Windows.Forms.Label();
            this.txtBox_Data_Realizacji = new System.Windows.Forms.TextBox();
            this.lbl_Data_Realizacji = new System.Windows.Forms.Label();
            this.groupBoxNowe_ZLecenie = new System.Windows.Forms.GroupBox();
            this.dGVOFERTA = new System.Windows.Forms.DataGridView();
            this.btnWybierzFirme = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl_Data_Zlecenia = new System.Windows.Forms.Label();
            this.cbBoxFirmy = new System.Windows.Forms.ComboBox();
            this.txtBox_Data_Zlecenia = new System.Windows.Forms.TextBox();
            this.btn_Dodaj_Zlecenie = new System.Windows.Forms.Button();
            this.lblFirma = new System.Windows.Forms.Label();
            this.btnOdrzuc = new System.Windows.Forms.Button();
            this.iDZLECENIADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOSZTCALKOWITYPRODUKCJIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cZASPRODUKCJIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFERTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDPRODUKTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDZLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iLOSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zLECENIAPRODUKTYNAZWYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fIRMYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.FirmyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxOferta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOferta)).BeginInit();
            this.groupBoxNowe_ZLecenie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOFERTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFERTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLECENIAPRODUKTYNAZWYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIRMYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirmyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOferta
            // 
            this.groupBoxOferta.Controls.Add(this.txtBoxCena);
            this.groupBoxOferta.Controls.Add(this.lblKOSZT);
            this.groupBoxOferta.Controls.Add(this.dataGridViewOferta);
            this.groupBoxOferta.Controls.Add(this.txtBox_Ilosc_Oferta);
            this.groupBoxOferta.Controls.Add(this.btn_Dodaj_Oferta);
            this.groupBoxOferta.Controls.Add(this.cBox_Produkty_Oferta);
            this.groupBoxOferta.Controls.Add(this.btnPrzedstaw_Oferte);
            this.groupBoxOferta.Controls.Add(this.lbl_Ilosc_Oferta);
            this.groupBoxOferta.Controls.Add(this.lblProdukt_Oferta);
            this.groupBoxOferta.Controls.Add(this.txtBox_Data_Realizacji);
            this.groupBoxOferta.Controls.Add(this.lbl_Data_Realizacji);
            this.groupBoxOferta.Location = new System.Drawing.Point(12, 2);
            this.groupBoxOferta.Name = "groupBoxOferta";
            this.groupBoxOferta.Size = new System.Drawing.Size(337, 431);
            this.groupBoxOferta.TabIndex = 9;
            this.groupBoxOferta.TabStop = false;
            this.groupBoxOferta.Text = "Oferta";
            // 
            // txtBoxCena
            // 
            this.txtBoxCena.Location = new System.Drawing.Point(47, 392);
            this.txtBoxCena.Name = "txtBoxCena";
            this.txtBoxCena.ReadOnly = true;
            this.txtBoxCena.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCena.TabIndex = 14;
            // 
            // lblKOSZT
            // 
            this.lblKOSZT.AutoSize = true;
            this.lblKOSZT.Location = new System.Drawing.Point(79, 375);
            this.lblKOSZT.Name = "lblKOSZT";
            this.lblKOSZT.Size = new System.Drawing.Size(42, 13);
            this.lblKOSZT.TabIndex = 13;
            this.lblKOSZT.Text = "CENA :";
            // 
            // dataGridViewOferta
            // 
            this.dataGridViewOferta.AllowUserToAddRows = false;
            this.dataGridViewOferta.AutoGenerateColumns = false;
            this.dataGridViewOferta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOferta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUKTUDataGridViewTextBoxColumn,
            this.iDZLECENIADataGridViewTextBoxColumn,
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn,
            this.iLOSCDataGridViewTextBoxColumn});
            this.dataGridViewOferta.DataSource = this.zLECENIAPRODUKTYNAZWYBindingSource;
            this.dataGridViewOferta.Location = new System.Drawing.Point(7, 155);
            this.dataGridViewOferta.Name = "dataGridViewOferta";
            this.dataGridViewOferta.Size = new System.Drawing.Size(324, 167);
            this.dataGridViewOferta.TabIndex = 12;
            this.dataGridViewOferta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOferta_CellContentClick);
            this.dataGridViewOferta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOferta_CellEndEdit);
            this.dataGridViewOferta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // txtBox_Ilosc_Oferta
            // 
            this.txtBox_Ilosc_Oferta.Location = new System.Drawing.Point(107, 72);
            this.txtBox_Ilosc_Oferta.Name = "txtBox_Ilosc_Oferta";
            this.txtBox_Ilosc_Oferta.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Ilosc_Oferta.TabIndex = 10;
            this.txtBox_Ilosc_Oferta.TextChanged += new System.EventHandler(this.txtBox_Ilosc_Oferta_TextChanged);
            // 
            // btn_Dodaj_Oferta
            // 
            this.btn_Dodaj_Oferta.Location = new System.Drawing.Point(107, 109);
            this.btn_Dodaj_Oferta.Name = "btn_Dodaj_Oferta";
            this.btn_Dodaj_Oferta.Size = new System.Drawing.Size(105, 23);
            this.btn_Dodaj_Oferta.TabIndex = 9;
            this.btn_Dodaj_Oferta.Text = "Dodaj do listy";
            this.btn_Dodaj_Oferta.UseVisualStyleBackColor = true;
            this.btn_Dodaj_Oferta.Click += new System.EventHandler(this.btn_Dodaj_Oferta_Click);
            // 
            // cBox_Produkty_Oferta
            // 
            this.cBox_Produkty_Oferta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Produkty_Oferta.FormattingEnabled = true;
            this.cBox_Produkty_Oferta.Location = new System.Drawing.Point(107, 31);
            this.cBox_Produkty_Oferta.Name = "cBox_Produkty_Oferta";
            this.cBox_Produkty_Oferta.Size = new System.Drawing.Size(205, 21);
            this.cBox_Produkty_Oferta.TabIndex = 8;
            // 
            // btnPrzedstaw_Oferte
            // 
            this.btnPrzedstaw_Oferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzedstaw_Oferte.Location = new System.Drawing.Point(97, 328);
            this.btnPrzedstaw_Oferte.Name = "btnPrzedstaw_Oferte";
            this.btnPrzedstaw_Oferte.Size = new System.Drawing.Size(135, 30);
            this.btnPrzedstaw_Oferte.TabIndex = 6;
            this.btnPrzedstaw_Oferte.Text = "Przedstaw Oferte";
            this.btnPrzedstaw_Oferte.UseVisualStyleBackColor = true;
            this.btnPrzedstaw_Oferte.Click += new System.EventHandler(this.btnPrzedstaw_Oferte_Click);
            // 
            // lbl_Ilosc_Oferta
            // 
            this.lbl_Ilosc_Oferta.AutoSize = true;
            this.lbl_Ilosc_Oferta.Location = new System.Drawing.Point(26, 79);
            this.lbl_Ilosc_Oferta.Name = "lbl_Ilosc_Oferta";
            this.lbl_Ilosc_Oferta.Size = new System.Drawing.Size(29, 13);
            this.lbl_Ilosc_Oferta.TabIndex = 7;
            this.lbl_Ilosc_Oferta.Text = "Ilość";
            // 
            // lblProdukt_Oferta
            // 
            this.lblProdukt_Oferta.AutoSize = true;
            this.lblProdukt_Oferta.Location = new System.Drawing.Point(26, 34);
            this.lblProdukt_Oferta.Name = "lblProdukt_Oferta";
            this.lblProdukt_Oferta.Size = new System.Drawing.Size(44, 13);
            this.lblProdukt_Oferta.TabIndex = 7;
            this.lblProdukt_Oferta.Text = "Produkt";
            // 
            // txtBox_Data_Realizacji
            // 
            this.txtBox_Data_Realizacji.Location = new System.Drawing.Point(170, 392);
            this.txtBox_Data_Realizacji.Name = "txtBox_Data_Realizacji";
            this.txtBox_Data_Realizacji.ReadOnly = true;
            this.txtBox_Data_Realizacji.Size = new System.Drawing.Size(142, 20);
            this.txtBox_Data_Realizacji.TabIndex = 3;
            // 
            // lbl_Data_Realizacji
            // 
            this.lbl_Data_Realizacji.AutoSize = true;
            this.lbl_Data_Realizacji.Location = new System.Drawing.Point(194, 376);
            this.lbl_Data_Realizacji.Name = "lbl_Data_Realizacji";
            this.lbl_Data_Realizacji.Size = new System.Drawing.Size(78, 13);
            this.lbl_Data_Realizacji.TabIndex = 1;
            this.lbl_Data_Realizacji.Text = "Data Realizacji";
            // 
            // groupBoxNowe_ZLecenie
            // 
            this.groupBoxNowe_ZLecenie.Controls.Add(this.btnOdrzuc);
            this.groupBoxNowe_ZLecenie.Controls.Add(this.dGVOFERTA);
            this.groupBoxNowe_ZLecenie.Controls.Add(this.btnWybierzFirme);
            this.groupBoxNowe_ZLecenie.Controls.Add(this.btnExit);
            this.groupBoxNowe_ZLecenie.Controls.Add(this.lbl_Data_Zlecenia);
            this.groupBoxNowe_ZLecenie.Controls.Add(this.cbBoxFirmy);
            this.groupBoxNowe_ZLecenie.Controls.Add(this.txtBox_Data_Zlecenia);
            this.groupBoxNowe_ZLecenie.Controls.Add(this.btn_Dodaj_Zlecenie);
            this.groupBoxNowe_ZLecenie.Controls.Add(this.lblFirma);
            this.groupBoxNowe_ZLecenie.Location = new System.Drawing.Point(355, 2);
            this.groupBoxNowe_ZLecenie.Name = "groupBoxNowe_ZLecenie";
            this.groupBoxNowe_ZLecenie.Size = new System.Drawing.Size(352, 431);
            this.groupBoxNowe_ZLecenie.TabIndex = 10;
            this.groupBoxNowe_ZLecenie.TabStop = false;
            this.groupBoxNowe_ZLecenie.Text = "Nowe Zlecenie";
            // 
            // dGVOFERTA
            // 
            this.dGVOFERTA.AutoGenerateColumns = false;
            this.dGVOFERTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOFERTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDZLECENIADataGridViewTextBoxColumn1,
            this.kOSZTCALKOWITYPRODUKCJIDataGridViewTextBoxColumn,
            this.cZASPRODUKCJIDataGridViewTextBoxColumn});
            this.dGVOFERTA.DataSource = this.oFERTABindingSource;
            this.dGVOFERTA.Location = new System.Drawing.Point(59, 392);
            this.dGVOFERTA.Name = "dGVOFERTA";
            this.dGVOFERTA.Size = new System.Drawing.Size(263, 20);
            this.dGVOFERTA.TabIndex = 9;
            this.dGVOFERTA.Visible = false;
            // 
            // btnWybierzFirme
            // 
            this.btnWybierzFirme.Location = new System.Drawing.Point(130, 218);
            this.btnWybierzFirme.Name = "btnWybierzFirme";
            this.btnWybierzFirme.Size = new System.Drawing.Size(116, 23);
            this.btnWybierzFirme.TabIndex = 6;
            this.btnWybierzFirme.Text = "Ewidencja Firm";
            this.btnWybierzFirme.UseVisualStyleBackColor = true;
            this.btnWybierzFirme.Click += new System.EventHandler(this.btnWybierzFirme_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(314, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbl_Data_Zlecenia
            // 
            this.lbl_Data_Zlecenia.AutoSize = true;
            this.lbl_Data_Zlecenia.Location = new System.Drawing.Point(149, 106);
            this.lbl_Data_Zlecenia.Name = "lbl_Data_Zlecenia";
            this.lbl_Data_Zlecenia.Size = new System.Drawing.Size(74, 13);
            this.lbl_Data_Zlecenia.TabIndex = 0;
            this.lbl_Data_Zlecenia.Text = "Data Zlecenia";
            // 
            // cbBoxFirmy
            // 
            this.cbBoxFirmy.FormattingEnabled = true;
            this.cbBoxFirmy.Location = new System.Drawing.Point(106, 191);
            this.cbBoxFirmy.Name = "cbBoxFirmy";
            this.cbBoxFirmy.Size = new System.Drawing.Size(166, 21);
            this.cbBoxFirmy.TabIndex = 8;
            // 
            // txtBox_Data_Zlecenia
            // 
            this.txtBox_Data_Zlecenia.Location = new System.Drawing.Point(130, 122);
            this.txtBox_Data_Zlecenia.Name = "txtBox_Data_Zlecenia";
            this.txtBox_Data_Zlecenia.ReadOnly = true;
            this.txtBox_Data_Zlecenia.Size = new System.Drawing.Size(116, 20);
            this.txtBox_Data_Zlecenia.TabIndex = 3;
            // 
            // btn_Dodaj_Zlecenie
            // 
            this.btn_Dodaj_Zlecenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Dodaj_Zlecenie.Location = new System.Drawing.Point(121, 292);
            this.btn_Dodaj_Zlecenie.Name = "btn_Dodaj_Zlecenie";
            this.btn_Dodaj_Zlecenie.Size = new System.Drawing.Size(134, 30);
            this.btn_Dodaj_Zlecenie.TabIndex = 4;
            this.btn_Dodaj_Zlecenie.Text = "Dodaj Zlecenie";
            this.btn_Dodaj_Zlecenie.UseVisualStyleBackColor = true;
            this.btn_Dodaj_Zlecenie.Click += new System.EventHandler(this.btn_Dodaj_Zlecenie_Click);
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(167, 175);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(32, 13);
            this.lblFirma.TabIndex = 7;
            this.lblFirma.Text = "Firma";
            // 
            // btnOdrzuc
            // 
            this.btnOdrzuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdrzuc.Location = new System.Drawing.Point(121, 334);
            this.btnOdrzuc.Name = "btnOdrzuc";
            this.btnOdrzuc.Size = new System.Drawing.Size(134, 23);
            this.btnOdrzuc.TabIndex = 10;
            this.btnOdrzuc.Text = "Odrzucono";
            this.btnOdrzuc.UseVisualStyleBackColor = true;
            this.btnOdrzuc.Click += new System.EventHandler(this.button1_Click);
            // 
            // iDZLECENIADataGridViewTextBoxColumn1
            // 
            this.iDZLECENIADataGridViewTextBoxColumn1.DataPropertyName = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn1.HeaderText = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn1.Name = "iDZLECENIADataGridViewTextBoxColumn1";
            // 
            // kOSZTCALKOWITYPRODUKCJIDataGridViewTextBoxColumn
            // 
            this.kOSZTCALKOWITYPRODUKCJIDataGridViewTextBoxColumn.DataPropertyName = "KOSZT_CALKOWITY_PRODUKCJI";
            this.kOSZTCALKOWITYPRODUKCJIDataGridViewTextBoxColumn.HeaderText = "KOSZT_CALKOWITY_PRODUKCJI";
            this.kOSZTCALKOWITYPRODUKCJIDataGridViewTextBoxColumn.Name = "kOSZTCALKOWITYPRODUKCJIDataGridViewTextBoxColumn";
            // 
            // cZASPRODUKCJIDataGridViewTextBoxColumn
            // 
            this.cZASPRODUKCJIDataGridViewTextBoxColumn.DataPropertyName = "CZAS_PRODUKCJI";
            this.cZASPRODUKCJIDataGridViewTextBoxColumn.HeaderText = "CZAS_PRODUKCJI";
            this.cZASPRODUKCJIDataGridViewTextBoxColumn.Name = "cZASPRODUKCJIDataGridViewTextBoxColumn";
            // 
            // oFERTABindingSource
            // 
            this.oFERTABindingSource.DataSource = typeof(PROJEKTapp.OFERTA);
            // 
            // iDPRODUKTUDataGridViewTextBoxColumn
            // 
            this.iDPRODUKTUDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUKTU";
            this.iDPRODUKTUDataGridViewTextBoxColumn.HeaderText = "ID_PRODUKTU";
            this.iDPRODUKTUDataGridViewTextBoxColumn.Name = "iDPRODUKTUDataGridViewTextBoxColumn";
            this.iDPRODUKTUDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDZLECENIADataGridViewTextBoxColumn
            // 
            this.iDZLECENIADataGridViewTextBoxColumn.DataPropertyName = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.HeaderText = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.Name = "iDZLECENIADataGridViewTextBoxColumn";
            this.iDZLECENIADataGridViewTextBoxColumn.Visible = false;
            // 
            // nAZWAPRODUKTUDataGridViewTextBoxColumn
            // 
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.DataPropertyName = "NAZWA_PRODUKTU";
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.HeaderText = "NAZWA PRODUKTU";
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.Name = "nAZWAPRODUKTUDataGridViewTextBoxColumn";
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iLOSCDataGridViewTextBoxColumn
            // 
            this.iLOSCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iLOSCDataGridViewTextBoxColumn.DataPropertyName = "ILOSC";
            this.iLOSCDataGridViewTextBoxColumn.HeaderText = "ILOSC";
            this.iLOSCDataGridViewTextBoxColumn.Name = "iLOSCDataGridViewTextBoxColumn";
            this.iLOSCDataGridViewTextBoxColumn.Width = 63;
            // 
            // zLECENIAPRODUKTYNAZWYBindingSource
            // 
            this.zLECENIAPRODUKTYNAZWYBindingSource.DataSource = typeof(PROJEKTapp.ZLECENIA_PRODUKTY_NAZWY);
            // 
            // fIRMYBindingSource1
            // 
            this.fIRMYBindingSource1.DataSource = typeof(PROJEKTapp.FIRMY);
            // 
            // FirmyBindingSource
            // 
            this.FirmyBindingSource.DataSource = typeof(PROJEKTapp.FIRMY);
            // 
            // FormNoweZlecenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(718, 442);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxNowe_ZLecenie);
            this.Controls.Add(this.groupBoxOferta);
            this.Name = "FormNoweZlecenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormNoweZlecenie_Load);
            this.groupBoxOferta.ResumeLayout(false);
            this.groupBoxOferta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOferta)).EndInit();
            this.groupBoxNowe_ZLecenie.ResumeLayout(false);
            this.groupBoxNowe_ZLecenie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOFERTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFERTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLECENIAPRODUKTYNAZWYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIRMYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirmyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOferta;
        private System.Windows.Forms.DataGridView dataGridViewOferta;
        private System.Windows.Forms.TextBox txtBox_Ilosc_Oferta;
        private System.Windows.Forms.Button btn_Dodaj_Oferta;
        private System.Windows.Forms.ComboBox cBox_Produkty_Oferta;
        private System.Windows.Forms.Button btnPrzedstaw_Oferte;
        private System.Windows.Forms.Label lbl_Ilosc_Oferta;
        private System.Windows.Forms.Label lblProdukt_Oferta;
        private System.Windows.Forms.GroupBox groupBoxNowe_ZLecenie;
        private System.Windows.Forms.Label lbl_Data_Zlecenia;
        private System.Windows.Forms.TextBox txtBox_Data_Zlecenia;
        private System.Windows.Forms.Button btn_Dodaj_Zlecenie;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWybierzFirme;
        private System.Windows.Forms.ComboBox cbBoxFirmy;
        private System.Windows.Forms.BindingSource FirmyBindingSource;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.BindingSource fIRMYBindingSource1;
        private System.Windows.Forms.BindingSource zLECENIAPRODUKTYNAZWYBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUKTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWAPRODUKTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iLOSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBoxCena;
        private System.Windows.Forms.Label lblKOSZT;
        private System.Windows.Forms.TextBox txtBox_Data_Realizacji;
        private System.Windows.Forms.Label lbl_Data_Realizacji;
        private System.Windows.Forms.DataGridView dGVOFERTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kOSZTCALKOWITYPRODUKCJIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cZASPRODUKCJIDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oFERTABindingSource;
        private System.Windows.Forms.Button btnOdrzuc;
    }
}