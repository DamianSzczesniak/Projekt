namespace PROJEKTapp
{
    partial class FormWynagordzenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWynagordzenie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStatystyki = new System.Windows.Forms.Button();
            this.btnSzkolenia = new System.Windows.Forms.Button();
            this.btnUrlopy = new System.Windows.Forms.Button();
            this.btnWynagrodzenia = new System.Windows.Forms.Button();
            this.btnPracownicy = new System.Windows.Forms.Button();
            this.dgvWyplaty = new System.Windows.Forms.DataGridView();
            this.pnlWynagordzenia = new System.Windows.Forms.Panel();
            this.LWyszukaj = new System.Windows.Forms.Label();
            this.txtWyszukajNazwisko = new System.Windows.Forms.TextBox();
            this.dtpMiesiac = new System.Windows.Forms.DateTimePicker();
            this.lblSumaPensji = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyplaty)).BeginInit();
            this.pnlWynagordzenia.SuspendLayout();
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
            this.panel1.TabIndex = 6;
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
            this.panel2.TabIndex = 7;
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
            // dgvWyplaty
            // 
            this.dgvWyplaty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWyplaty.Location = new System.Drawing.Point(3, 69);
            this.dgvWyplaty.Name = "dgvWyplaty";
            this.dgvWyplaty.Size = new System.Drawing.Size(436, 487);
            this.dgvWyplaty.TabIndex = 8;
            // 
            // pnlWynagordzenia
            // 
            this.pnlWynagordzenia.Controls.Add(this.lblSumaPensji);
            this.pnlWynagordzenia.Controls.Add(this.LWyszukaj);
            this.pnlWynagordzenia.Controls.Add(this.txtWyszukajNazwisko);
            this.pnlWynagordzenia.Controls.Add(this.dtpMiesiac);
            this.pnlWynagordzenia.Controls.Add(this.dgvWyplaty);
            this.pnlWynagordzenia.Location = new System.Drawing.Point(34, 65);
            this.pnlWynagordzenia.Name = "pnlWynagordzenia";
            this.pnlWynagordzenia.Size = new System.Drawing.Size(895, 559);
            this.pnlWynagordzenia.TabIndex = 9;
            // 
            // LWyszukaj
            // 
            this.LWyszukaj.AutoSize = true;
            this.LWyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LWyszukaj.Location = new System.Drawing.Point(242, 14);
            this.LWyszukaj.Name = "LWyszukaj";
            this.LWyszukaj.Size = new System.Drawing.Size(147, 20);
            this.LWyszukaj.TabIndex = 23;
            this.LWyszukaj.Text = "Wyszukaj Nazwisko";
            // 
            // txtWyszukajNazwisko
            // 
            this.txtWyszukajNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWyszukajNazwisko.Location = new System.Drawing.Point(186, 37);
            this.txtWyszukajNazwisko.Name = "txtWyszukajNazwisko";
            this.txtWyszukajNazwisko.Size = new System.Drawing.Size(253, 26);
            this.txtWyszukajNazwisko.TabIndex = 22;
            this.txtWyszukajNazwisko.TextChanged += new System.EventHandler(this.txtWyszukajNazwisko_TextChanged);
            // 
            // dtpMiesiac
            // 
            this.dtpMiesiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpMiesiac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMiesiac.Location = new System.Drawing.Point(3, 37);
            this.dtpMiesiac.Name = "dtpMiesiac";
            this.dtpMiesiac.Size = new System.Drawing.Size(127, 26);
            this.dtpMiesiac.TabIndex = 9;
            this.dtpMiesiac.ValueChanged += new System.EventHandler(this.dtpMiesiac_ValueChanged);
            // 
            // lblSumaPensji
            // 
            this.lblSumaPensji.AutoSize = true;
            this.lblSumaPensji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSumaPensji.Location = new System.Drawing.Point(456, 69);
            this.lblSumaPensji.Name = "lblSumaPensji";
            this.lblSumaPensji.Size = new System.Drawing.Size(48, 20);
            this.lblSumaPensji.TabIndex = 24;
            this.lblSumaPensji.Text = "suma";
            // 
            // FormWynagordzenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlWynagordzenia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWynagordzenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWynagordzenie";
            this.Load += new System.EventHandler(this.FormWynagordzenie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyplaty)).EndInit();
            this.pnlWynagordzenia.ResumeLayout(false);
            this.pnlWynagordzenia.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvWyplaty;
        private System.Windows.Forms.Panel pnlWynagordzenia;
        private System.Windows.Forms.DateTimePicker dtpMiesiac;
        private System.Windows.Forms.Label LWyszukaj;
        private System.Windows.Forms.TextBox txtWyszukajNazwisko;
        private System.Windows.Forms.Label lblSumaPensji;
    }
}