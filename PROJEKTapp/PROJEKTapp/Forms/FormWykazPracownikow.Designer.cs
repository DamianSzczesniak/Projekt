namespace PROJEKTapp
{
    partial class FormWykazPracownikow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWykazPracownikow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.ListaPracownikow = new System.Windows.Forms.DataGridView();
            this.txtWyszukajNazwisko = new System.Windows.Forms.TextBox();
            this.btnZaktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPracownikow)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(733, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 507);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 36);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj Pracownika";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ListaPracownikow
            // 
            this.ListaPracownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPracownikow.Location = new System.Drawing.Point(12, 109);
            this.ListaPracownikow.Name = "ListaPracownikow";
            this.ListaPracownikow.Size = new System.Drawing.Size(776, 392);
            this.ListaPracownikow.TabIndex = 14;
            // 
            // txtWyszukajNazwisko
            // 
            this.txtWyszukajNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWyszukajNazwisko.Location = new System.Drawing.Point(148, 77);
            this.txtWyszukajNazwisko.Name = "txtWyszukajNazwisko";
            this.txtWyszukajNazwisko.Size = new System.Drawing.Size(240, 26);
            this.txtWyszukajNazwisko.TabIndex = 15;
            this.txtWyszukajNazwisko.TextChanged += new System.EventHandler(this.txtWyszukajNazwisko_TextChanged);
            // 
            // btnZaktualizuj
            // 
            this.btnZaktualizuj.Location = new System.Drawing.Point(96, 507);
            this.btnZaktualizuj.Name = "btnZaktualizuj";
            this.btnZaktualizuj.Size = new System.Drawing.Size(75, 36);
            this.btnZaktualizuj.TabIndex = 16;
            this.btnZaktualizuj.Text = "Edytuj Dane";
            this.btnZaktualizuj.UseVisualStyleBackColor = true;
            this.btnZaktualizuj.Click += new System.EventHandler(this.btnZaktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(177, 507);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 36);
            this.btnUsun.TabIndex = 17;
            this.btnUsun.Text = "Usuń Pracownika";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Wyszukaj Nazwisko";
            // 
            // FormWykazPracownikow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnZaktualizuj);
            this.Controls.Add(this.txtWyszukajNazwisko);
            this.Controls.Add(this.ListaPracownikow);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWykazPracownikow";
            this.Text = "Wykaz Pracownikow";
            this.Load += new System.EventHandler(this.FormWykazPracownikow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPracownikow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView ListaPracownikow;
        private System.Windows.Forms.TextBox txtWyszukajNazwisko;
        private System.Windows.Forms.Button btnZaktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Label label1;
    }
}