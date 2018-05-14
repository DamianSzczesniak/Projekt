namespace PROJEKTapp.Forms_NoweZlecenie
{
    partial class SzczegolyZlecenia
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewOferta = new System.Windows.Forms.DataGridView();
            this.iDPRODUKTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDZLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iLOSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zLECENIAPRODUKTYNAZWYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Data_Zlecenia = new System.Windows.Forms.Label();
            this.txtBox_Data_Zlecenia = new System.Windows.Forms.TextBox();
            this.txtBoxCena = new System.Windows.Forms.TextBox();
            this.lblKOSZT = new System.Windows.Forms.Label();
            this.txtBox_Data_Realizacji = new System.Windows.Forms.TextBox();
            this.lbl_Data_Realizacji = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RezerwujMaszyny = new System.Windows.Forms.Button();
            this.btnZam = new System.Windows.Forms.Button();
            this.btnDostarczonoMaterialy = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtBAktualnyStatus = new System.Windows.Forms.TextBox();
            this.btnMagazynuj = new System.Windows.Forms.Button();
            this.btn_Pobierz_Materialy_produkcja = new System.Windows.Forms.Button();
            this.btn_składuj_produkty_w_Magazynie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOferta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLECENIAPRODUKTYNAZWYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOferta
            // 
            this.dataGridViewOferta.AllowUserToAddRows = false;
            this.dataGridViewOferta.AllowUserToDeleteRows = false;
            this.dataGridViewOferta.AutoGenerateColumns = false;
            this.dataGridViewOferta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOferta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUKTUDataGridViewTextBoxColumn,
            this.iDZLECENIADataGridViewTextBoxColumn,
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn,
            this.iLOSCDataGridViewTextBoxColumn});
            this.dataGridViewOferta.DataSource = this.zLECENIAPRODUKTYNAZWYBindingSource;
            this.dataGridViewOferta.Location = new System.Drawing.Point(21, 16);
            this.dataGridViewOferta.Name = "dataGridViewOferta";
            this.dataGridViewOferta.ReadOnly = true;
            this.dataGridViewOferta.Size = new System.Drawing.Size(324, 181);
            this.dataGridViewOferta.TabIndex = 13;
            // 
            // iDPRODUKTUDataGridViewTextBoxColumn
            // 
            this.iDPRODUKTUDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUKTU";
            this.iDPRODUKTUDataGridViewTextBoxColumn.HeaderText = "ID_PRODUKTU";
            this.iDPRODUKTUDataGridViewTextBoxColumn.Name = "iDPRODUKTUDataGridViewTextBoxColumn";
            this.iDPRODUKTUDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPRODUKTUDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDZLECENIADataGridViewTextBoxColumn
            // 
            this.iDZLECENIADataGridViewTextBoxColumn.DataPropertyName = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.HeaderText = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.Name = "iDZLECENIADataGridViewTextBoxColumn";
            this.iDZLECENIADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDZLECENIADataGridViewTextBoxColumn.Visible = false;
            // 
            // nAZWAPRODUKTUDataGridViewTextBoxColumn
            // 
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.DataPropertyName = "NAZWA_PRODUKTU";
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.HeaderText = "NAZWA_PRODUKTU";
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.Name = "nAZWAPRODUKTUDataGridViewTextBoxColumn";
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iLOSCDataGridViewTextBoxColumn
            // 
            this.iLOSCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iLOSCDataGridViewTextBoxColumn.DataPropertyName = "ILOSC";
            this.iLOSCDataGridViewTextBoxColumn.HeaderText = "ILOSC";
            this.iLOSCDataGridViewTextBoxColumn.Name = "iLOSCDataGridViewTextBoxColumn";
            this.iLOSCDataGridViewTextBoxColumn.ReadOnly = true;
            this.iLOSCDataGridViewTextBoxColumn.Width = 63;
            // 
            // zLECENIAPRODUKTYNAZWYBindingSource
            // 
            this.zLECENIAPRODUKTYNAZWYBindingSource.DataSource = typeof(PROJEKTapp.ZLECENIA_PRODUKTY_NAZWY);
            // 
            // lbl_Data_Zlecenia
            // 
            this.lbl_Data_Zlecenia.AutoSize = true;
            this.lbl_Data_Zlecenia.Location = new System.Drawing.Point(57, 245);
            this.lbl_Data_Zlecenia.Name = "lbl_Data_Zlecenia";
            this.lbl_Data_Zlecenia.Size = new System.Drawing.Size(80, 13);
            this.lbl_Data_Zlecenia.TabIndex = 14;
            this.lbl_Data_Zlecenia.Text = "Data Zlecenia :";
            // 
            // txtBox_Data_Zlecenia
            // 
            this.txtBox_Data_Zlecenia.Location = new System.Drawing.Point(23, 262);
            this.txtBox_Data_Zlecenia.Name = "txtBox_Data_Zlecenia";
            this.txtBox_Data_Zlecenia.ReadOnly = true;
            this.txtBox_Data_Zlecenia.Size = new System.Drawing.Size(140, 20);
            this.txtBox_Data_Zlecenia.TabIndex = 15;
            this.txtBox_Data_Zlecenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxCena
            // 
            this.txtBoxCena.Location = new System.Drawing.Point(23, 311);
            this.txtBoxCena.Name = "txtBoxCena";
            this.txtBoxCena.ReadOnly = true;
            this.txtBoxCena.Size = new System.Drawing.Size(140, 20);
            this.txtBoxCena.TabIndex = 19;
            this.txtBoxCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKOSZT
            // 
            this.lblKOSZT.AutoSize = true;
            this.lblKOSZT.Location = new System.Drawing.Point(70, 294);
            this.lblKOSZT.Name = "lblKOSZT";
            this.lblKOSZT.Size = new System.Drawing.Size(38, 13);
            this.lblKOSZT.TabIndex = 18;
            this.lblKOSZT.Text = "Cena :";
            // 
            // txtBox_Data_Realizacji
            // 
            this.txtBox_Data_Realizacji.Location = new System.Drawing.Point(204, 262);
            this.txtBox_Data_Realizacji.Name = "txtBox_Data_Realizacji";
            this.txtBox_Data_Realizacji.ReadOnly = true;
            this.txtBox_Data_Realizacji.Size = new System.Drawing.Size(142, 20);
            this.txtBox_Data_Realizacji.TabIndex = 17;
            this.txtBox_Data_Realizacji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Data_Realizacji
            // 
            this.lbl_Data_Realizacji.AutoSize = true;
            this.lbl_Data_Realizacji.Location = new System.Drawing.Point(238, 245);
            this.lbl_Data_Realizacji.Name = "lbl_Data_Realizacji";
            this.lbl_Data_Realizacji.Size = new System.Drawing.Size(84, 13);
            this.lbl_Data_Realizacji.TabIndex = 16;
            this.lbl_Data_Realizacji.Text = "Data Realizacji :";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(261, 294);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(38, 13);
            this.lblFirma.TabIndex = 20;
            this.lblFirma.Text = "Firma :";
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(204, 310);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.ReadOnly = true;
            this.txtFirma.Size = new System.Drawing.Size(142, 20);
            this.txtFirma.TabIndex = 21;
            this.txtFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(374, 33);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(435, 299);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // RezerwujMaszyny
            // 
            this.RezerwujMaszyny.Location = new System.Drawing.Point(204, 350);
            this.RezerwujMaszyny.Name = "RezerwujMaszyny";
            this.RezerwujMaszyny.Size = new System.Drawing.Size(142, 35);
            this.RezerwujMaszyny.TabIndex = 1;
            this.RezerwujMaszyny.Text = "Rezerwuj maszyny";
            this.RezerwujMaszyny.UseVisualStyleBackColor = true;
            this.RezerwujMaszyny.Visible = false;
            this.RezerwujMaszyny.Click += new System.EventHandler(this.RezerwujMaszyny_Click);
            // 
            // btnZam
            // 
            this.btnZam.Location = new System.Drawing.Point(23, 350);
            this.btnZam.Name = "btnZam";
            this.btnZam.Size = new System.Drawing.Size(140, 35);
            this.btnZam.TabIndex = 0;
            this.btnZam.Text = "Złóż zamówienia na materiały";
            this.btnZam.UseVisualStyleBackColor = true;
            this.btnZam.Visible = false;
            this.btnZam.Click += new System.EventHandler(this.btnZam_Click);
            // 
            // btnDostarczonoMaterialy
            // 
            this.btnDostarczonoMaterialy.Location = new System.Drawing.Point(23, 350);
            this.btnDostarczonoMaterialy.Name = "btnDostarczonoMaterialy";
            this.btnDostarczonoMaterialy.Size = new System.Drawing.Size(140, 35);
            this.btnDostarczonoMaterialy.TabIndex = 23;
            this.btnDostarczonoMaterialy.Text = "Odnotuj dostarczenie materiałów";
            this.btnDostarczonoMaterialy.UseVisualStyleBackColor = true;
            this.btnDostarczonoMaterialy.Visible = false;
            this.btnDostarczonoMaterialy.Click += new System.EventHandler(this.btnDostarczonoMaterialy_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(120, 200);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(131, 13);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Aktualny Status Zlecenia :";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBAktualnyStatus
            // 
            this.txtBAktualnyStatus.Location = new System.Drawing.Point(95, 216);
            this.txtBAktualnyStatus.Name = "txtBAktualnyStatus";
            this.txtBAktualnyStatus.ReadOnly = true;
            this.txtBAktualnyStatus.Size = new System.Drawing.Size(186, 20);
            this.txtBAktualnyStatus.TabIndex = 25;
            this.txtBAktualnyStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMagazynuj
            // 
            this.btnMagazynuj.Location = new System.Drawing.Point(23, 350);
            this.btnMagazynuj.Name = "btnMagazynuj";
            this.btnMagazynuj.Size = new System.Drawing.Size(140, 35);
            this.btnMagazynuj.TabIndex = 26;
            this.btnMagazynuj.Text = "Zmagazynuj dostarczone materiały";
            this.btnMagazynuj.UseVisualStyleBackColor = true;
            this.btnMagazynuj.Visible = false;
            this.btnMagazynuj.Click += new System.EventHandler(this.btnMagazynuj_Click);
            // 
            // btn_Pobierz_Materialy_produkcja
            // 
            this.btn_Pobierz_Materialy_produkcja.Location = new System.Drawing.Point(23, 350);
            this.btn_Pobierz_Materialy_produkcja.Name = "btn_Pobierz_Materialy_produkcja";
            this.btn_Pobierz_Materialy_produkcja.Size = new System.Drawing.Size(140, 35);
            this.btn_Pobierz_Materialy_produkcja.TabIndex = 27;
            this.btn_Pobierz_Materialy_produkcja.Text = "Pobierz materiały z magazynu";
            this.btn_Pobierz_Materialy_produkcja.UseVisualStyleBackColor = true;
            this.btn_Pobierz_Materialy_produkcja.Visible = false;
            this.btn_Pobierz_Materialy_produkcja.Click += new System.EventHandler(this.btn_Pobierz_Materialy_produkcja_Click);
            // 
            // btn_składuj_produkty_w_Magazynie
            // 
            this.btn_składuj_produkty_w_Magazynie.Location = new System.Drawing.Point(204, 350);
            this.btn_składuj_produkty_w_Magazynie.Name = "btn_składuj_produkty_w_Magazynie";
            this.btn_składuj_produkty_w_Magazynie.Size = new System.Drawing.Size(142, 35);
            this.btn_składuj_produkty_w_Magazynie.TabIndex = 28;
            this.btn_składuj_produkty_w_Magazynie.Text = "Składuj produkty w magazynie";
            this.btn_składuj_produkty_w_Magazynie.UseVisualStyleBackColor = true;
            this.btn_składuj_produkty_w_Magazynie.Visible = false;
            this.btn_składuj_produkty_w_Magazynie.Click += new System.EventHandler(this.btn_składuj_produkty_w_Magazynie_Click);
            // 
            // SzczegolyZlecenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 402);
            this.Controls.Add(this.btn_składuj_produkty_w_Magazynie);
            this.Controls.Add(this.btn_Pobierz_Materialy_produkcja);
            this.Controls.Add(this.btnMagazynuj);
            this.Controls.Add(this.txtBAktualnyStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDostarczonoMaterialy);
            this.Controls.Add(this.btnZam);
            this.Controls.Add(this.RezerwujMaszyny);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.txtBoxCena);
            this.Controls.Add(this.lblKOSZT);
            this.Controls.Add(this.txtBox_Data_Realizacji);
            this.Controls.Add(this.lbl_Data_Realizacji);
            this.Controls.Add(this.lbl_Data_Zlecenia);
            this.Controls.Add(this.txtBox_Data_Zlecenia);
            this.Controls.Add(this.dataGridViewOferta);
            this.Name = "SzczegolyZlecenia";
            this.Text = "Szczegoly Zlecenia";
            this.Activated += new System.EventHandler(this.SzczegolyZlecenia_Enter);
            this.Load += new System.EventHandler(this.SzczegolyZlecenia_Load);
            this.Enter += new System.EventHandler(this.SzczegolyZlecenia_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOferta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLECENIAPRODUKTYNAZWYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOferta;
        private System.Windows.Forms.Label lbl_Data_Zlecenia;
        private System.Windows.Forms.TextBox txtBox_Data_Zlecenia;
        private System.Windows.Forms.TextBox txtBoxCena;
        private System.Windows.Forms.Label lblKOSZT;
        private System.Windows.Forms.TextBox txtBox_Data_Realizacji;
        private System.Windows.Forms.Label lbl_Data_Realizacji;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUKTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWAPRODUKTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iLOSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zLECENIAPRODUKTYNAZWYBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button RezerwujMaszyny;
        private System.Windows.Forms.Button btnZam;
        private System.Windows.Forms.Button btnDostarczonoMaterialy;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtBAktualnyStatus;
        private System.Windows.Forms.Button btnMagazynuj;
        private System.Windows.Forms.Button btn_Pobierz_Materialy_produkcja;
        private System.Windows.Forms.Button btn_składuj_produkty_w_Magazynie;
    }
}