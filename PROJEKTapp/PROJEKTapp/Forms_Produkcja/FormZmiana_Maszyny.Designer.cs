namespace PROJEKTapp.Forms_Produkcja
{
    partial class FormZmiana_Maszyny
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
            this.WyczyscDane = new System.Windows.Forms.Button();
            this.Aktualizuj = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.textBoxCenaZaH = new System.Windows.Forms.TextBox();
            this.textBoxPredkosc = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTypMaszyny = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPosuw = new System.Windows.Forms.TextBox();
            this.panelMaszyny = new System.Windows.Forms.Panel();
            this.panelMaszyny.SuspendLayout();
            this.SuspendLayout();
            // 
            // WyczyscDane
            // 
            this.WyczyscDane.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.WyczyscDane.Location = new System.Drawing.Point(381, 336);
            this.WyczyscDane.Name = "WyczyscDane";
            this.WyczyscDane.Size = new System.Drawing.Size(171, 112);
            this.WyczyscDane.TabIndex = 12;
            this.WyczyscDane.Text = "Wyczyść dane";
            this.WyczyscDane.UseVisualStyleBackColor = true;
            this.WyczyscDane.Click += new System.EventHandler(this.WyczyscDane_Click);
            // 
            // Aktualizuj
            // 
            this.Aktualizuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Aktualizuj.Location = new System.Drawing.Point(191, 336);
            this.Aktualizuj.Name = "Aktualizuj";
            this.Aktualizuj.Size = new System.Drawing.Size(175, 112);
            this.Aktualizuj.TabIndex = 13;
            this.Aktualizuj.Text = "Zapisz";
            this.Aktualizuj.UseVisualStyleBackColor = true;
            this.Aktualizuj.Click += new System.EventHandler(this.Aktualizuj_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Dodaj.Location = new System.Drawing.Point(14, 336);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(162, 112);
            this.Dodaj.TabIndex = 14;
            this.Dodaj.Text = "Dodaj nową na podstawie istniejącej maszyny";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // textBoxCenaZaH
            // 
            this.textBoxCenaZaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCenaZaH.Location = new System.Drawing.Point(155, 275);
            this.textBoxCenaZaH.Name = "textBoxCenaZaH";
            this.textBoxCenaZaH.Size = new System.Drawing.Size(367, 26);
            this.textBoxCenaZaH.TabIndex = 8;
            // 
            // textBoxPredkosc
            // 
            this.textBoxPredkosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPredkosc.Location = new System.Drawing.Point(155, 178);
            this.textBoxPredkosc.Name = "textBoxPredkosc";
            this.textBoxPredkosc.Size = new System.Drawing.Size(367, 26);
            this.textBoxPredkosc.TabIndex = 9;
            this.textBoxPredkosc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxMarka.Location = new System.Drawing.Point(155, 74);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(367, 26);
            this.textBoxMarka.TabIndex = 10;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxModel.Location = new System.Drawing.Point(155, 16);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(367, 26);
            this.textBoxModel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(10, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cena za godzinę";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(10, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Predkość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Typ maszyny";
            // 
            // textBoxTypMaszyny
            // 
            this.textBoxTypMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTypMaszyny.Location = new System.Drawing.Point(155, 128);
            this.textBoxTypMaszyny.Name = "textBoxTypMaszyny";
            this.textBoxTypMaszyny.Size = new System.Drawing.Size(367, 26);
            this.textBoxTypMaszyny.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(10, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Posuw";
            // 
            // textBoxPosuw
            // 
            this.textBoxPosuw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPosuw.Location = new System.Drawing.Point(155, 228);
            this.textBoxPosuw.Name = "textBoxPosuw";
            this.textBoxPosuw.Size = new System.Drawing.Size(367, 26);
            this.textBoxPosuw.TabIndex = 8;
            // 
            // panelMaszyny
            // 
            this.panelMaszyny.BackColor = System.Drawing.SystemColors.Control;
            this.panelMaszyny.Controls.Add(this.label4);
            this.panelMaszyny.Controls.Add(this.label1);
            this.panelMaszyny.Controls.Add(this.WyczyscDane);
            this.panelMaszyny.Controls.Add(this.label5);
            this.panelMaszyny.Controls.Add(this.Aktualizuj);
            this.panelMaszyny.Controls.Add(this.label2);
            this.panelMaszyny.Controls.Add(this.Dodaj);
            this.panelMaszyny.Controls.Add(this.label3);
            this.panelMaszyny.Controls.Add(this.textBoxPosuw);
            this.panelMaszyny.Controls.Add(this.label6);
            this.panelMaszyny.Controls.Add(this.textBoxCenaZaH);
            this.panelMaszyny.Controls.Add(this.textBoxTypMaszyny);
            this.panelMaszyny.Controls.Add(this.textBoxModel);
            this.panelMaszyny.Controls.Add(this.textBoxPredkosc);
            this.panelMaszyny.Controls.Add(this.textBoxMarka);
            this.panelMaszyny.Location = new System.Drawing.Point(0, 24);
            this.panelMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.panelMaszyny.Name = "panelMaszyny";
            this.panelMaszyny.Size = new System.Drawing.Size(800, 600);
            this.panelMaszyny.TabIndex = 15;
            // 
            // FormZmiana_Maszyny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelMaszyny);
            this.Name = "FormZmiana_Maszyny";
            this.Text = "FormZmiana_Maszyny";
            this.panelMaszyny.ResumeLayout(false);
            this.panelMaszyny.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button WyczyscDane;
        private System.Windows.Forms.Button Aktualizuj;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.TextBox textBoxCenaZaH;
        private System.Windows.Forms.TextBox textBoxPredkosc;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTypMaszyny;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPosuw;
        private System.Windows.Forms.Panel panelMaszyny;
    }
}