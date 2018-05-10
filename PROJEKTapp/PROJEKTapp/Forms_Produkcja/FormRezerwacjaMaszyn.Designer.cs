namespace PROJEKTapp.Forms_Produkcja
{
    partial class FormRezerwacjaMaszyn
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnExitRezerwacjaMaszyn = new System.Windows.Forms.Button();
            this.lblWyborZlecenia = new System.Windows.Forms.Label();
            this.cboxWybierzZlecenie = new System.Windows.Forms.ComboBox();
            this.RezerwujMaszyny = new System.Windows.Forms.Button();
            this.GridSprawdzenie = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GridSprawdzenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitRezerwacjaMaszyn
            // 
            this.btnExitRezerwacjaMaszyn.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExitRezerwacjaMaszyn.FlatAppearance.BorderSize = 0;
            this.btnExitRezerwacjaMaszyn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitRezerwacjaMaszyn.Image = global::PROJEKTapp.Properties.Resources.btnExit_Image;
            this.btnExitRezerwacjaMaszyn.Location = new System.Drawing.Point(1271, 12);
            this.btnExitRezerwacjaMaszyn.Name = "btnExitRezerwacjaMaszyn";
            this.btnExitRezerwacjaMaszyn.Size = new System.Drawing.Size(67, 52);
            this.btnExitRezerwacjaMaszyn.TabIndex = 2;
            this.btnExitRezerwacjaMaszyn.UseVisualStyleBackColor = false;
            this.btnExitRezerwacjaMaszyn.Click += new System.EventHandler(this.btnExitRezerwacjaMaszyn_Click);
            // 
            // lblWyborZlecenia
            // 
            this.lblWyborZlecenia.AutoSize = true;
            this.lblWyborZlecenia.Location = new System.Drawing.Point(55, 28);
            this.lblWyborZlecenia.Name = "lblWyborZlecenia";
            this.lblWyborZlecenia.Size = new System.Drawing.Size(145, 13);
            this.lblWyborZlecenia.TabIndex = 3;
            this.lblWyborZlecenia.Text = "Wybierz zlecenie do realizacji";
            // 
            // cboxWybierzZlecenie
            // 
            this.cboxWybierzZlecenie.FormattingEnabled = true;
            this.cboxWybierzZlecenie.Location = new System.Drawing.Point(242, 25);
            this.cboxWybierzZlecenie.Name = "cboxWybierzZlecenie";
            this.cboxWybierzZlecenie.Size = new System.Drawing.Size(121, 21);
            this.cboxWybierzZlecenie.TabIndex = 4;
            this.cboxWybierzZlecenie.SelectedIndexChanged += new System.EventHandler(this.cboxWybierzZlecenie_SelectedIndexChanged);
            // 
            // RezerwujMaszyny
            // 
            this.RezerwujMaszyny.Location = new System.Drawing.Point(58, 235);
            this.RezerwujMaszyny.Name = "RezerwujMaszyny";
            this.RezerwujMaszyny.Size = new System.Drawing.Size(179, 95);
            this.RezerwujMaszyny.TabIndex = 5;
            this.RezerwujMaszyny.Text = "Rezerwuj maszyny";
            this.RezerwujMaszyny.UseVisualStyleBackColor = true;
            this.RezerwujMaszyny.Click += new System.EventHandler(this.RezerwujMaszyny_Click);
            // 
            // GridSprawdzenie
            // 
            this.GridSprawdzenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSprawdzenie.Location = new System.Drawing.Point(58, 68);
            this.GridSprawdzenie.Name = "GridSprawdzenie";
            this.GridSprawdzenie.Size = new System.Drawing.Size(240, 150);
            this.GridSprawdzenie.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(355, 68);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(533, 300);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // FormRezerwacjaMaszyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.GridSprawdzenie);
            this.Controls.Add(this.RezerwujMaszyny);
            this.Controls.Add(this.cboxWybierzZlecenie);
            this.Controls.Add(this.lblWyborZlecenia);
            this.Controls.Add(this.btnExitRezerwacjaMaszyn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRezerwacjaMaszyn";
            this.Text = "FormRezerwacjaMaszyn";
            ((System.ComponentModel.ISupportInitialize)(this.GridSprawdzenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitRezerwacjaMaszyn;
        private System.Windows.Forms.Label lblWyborZlecenia;
        private System.Windows.Forms.ComboBox cboxWybierzZlecenie;
        private System.Windows.Forms.Button RezerwujMaszyny;
        private System.Windows.Forms.DataGridView GridSprawdzenie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}