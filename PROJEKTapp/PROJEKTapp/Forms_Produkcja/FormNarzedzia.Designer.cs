namespace PROJEKTapp.Forms_Produkcja
{
    partial class FormNarzedzia
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
            this.Nazwa = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.NrEwidencyjny = new System.Windows.Forms.Label();
            this.Cenazah = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Zapisz = new System.Windows.Forms.Button();
            this.Aktualizuj = new System.Windows.Forms.Button();
            this.WyczyscDane = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSize = true;
            this.Nazwa.Location = new System.Drawing.Point(38, 70);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(40, 13);
            this.Nazwa.TabIndex = 0;
            this.Nazwa.Text = "Nazwa";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(38, 120);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 0;
            this.Model.Text = "Model";
            // 
            // NrEwidencyjny
            // 
            this.NrEwidencyjny.AutoSize = true;
            this.NrEwidencyjny.Location = new System.Drawing.Point(38, 176);
            this.NrEwidencyjny.Name = "NrEwidencyjny";
            this.NrEwidencyjny.Size = new System.Drawing.Size(82, 13);
            this.NrEwidencyjny.TabIndex = 0;
            this.NrEwidencyjny.Text = "Nr_ewidencyjny";
            // 
            // Cenazah
            // 
            this.Cenazah.AutoSize = true;
            this.Cenazah.Location = new System.Drawing.Point(38, 236);
            this.Cenazah.Name = "Cenazah";
            this.Cenazah.Size = new System.Drawing.Size(92, 13);
            this.Cenazah.TabIndex = 0;
            this.Cenazah.Text = "Cena_za_godzine";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(323, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 236);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(323, 20);
            this.textBox4.TabIndex = 1;
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(41, 377);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(79, 62);
            this.Zapisz.TabIndex = 2;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // Aktualizuj
            // 
            this.Aktualizuj.Location = new System.Drawing.Point(155, 377);
            this.Aktualizuj.Name = "Aktualizuj";
            this.Aktualizuj.Size = new System.Drawing.Size(87, 62);
            this.Aktualizuj.TabIndex = 2;
            this.Aktualizuj.Text = "Aktualizuj";
            this.Aktualizuj.UseVisualStyleBackColor = true;
            // 
            // WyczyscDane
            // 
            this.WyczyscDane.Location = new System.Drawing.Point(272, 377);
            this.WyczyscDane.Name = "WyczyscDane";
            this.WyczyscDane.Size = new System.Drawing.Size(81, 62);
            this.WyczyscDane.TabIndex = 2;
            this.WyczyscDane.Text = "Wyczyść dane";
            this.WyczyscDane.UseVisualStyleBackColor = true;
            // 
            // FormNarzedzia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.WyczyscDane);
            this.Controls.Add(this.Aktualizuj);
            this.Controls.Add(this.Zapisz);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cenazah);
            this.Controls.Add(this.NrEwidencyjny);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Nazwa);
            this.Name = "FormNarzedzia";
            this.Text = "FormNarzedzia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nazwa;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label NrEwidencyjny;
        private System.Windows.Forms.Label Cenazah;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.Button Aktualizuj;
        private System.Windows.Forms.Button WyczyscDane;
    }
}