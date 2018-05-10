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
            this.Zapisz = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panelMaszyny = new System.Windows.Forms.Panel();
            this.panelMaszyny.SuspendLayout();
            this.SuspendLayout();
            // 
            // WyczyscDane
            // 
            this.WyczyscDane.Location = new System.Drawing.Point(336, 306);
            this.WyczyscDane.Name = "WyczyscDane";
            this.WyczyscDane.Size = new System.Drawing.Size(143, 79);
            this.WyczyscDane.TabIndex = 12;
            this.WyczyscDane.Text = "Wyczyść dane";
            this.WyczyscDane.UseVisualStyleBackColor = true;
            this.WyczyscDane.Click += new System.EventHandler(this.WyczyscDane_Click);
            // 
            // Aktualizuj
            // 
            this.Aktualizuj.Location = new System.Drawing.Point(166, 306);
            this.Aktualizuj.Name = "Aktualizuj";
            this.Aktualizuj.Size = new System.Drawing.Size(147, 79);
            this.Aktualizuj.TabIndex = 13;
            this.Aktualizuj.Text = "Zapisz";
            this.Aktualizuj.UseVisualStyleBackColor = true;
            this.Aktualizuj.Click += new System.EventHandler(this.Aktualizuj_Click);
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(12, 306);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(134, 79);
            this.Zapisz.TabIndex = 14;
            this.Zapisz.Text = "Dodaj nową na podstawie istniejącej maszyny";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 251);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(337, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(337, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cena za godzinę";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Predkość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Typ maszyny";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(101, 128);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(337, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Posuw";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(101, 205);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(337, 20);
            this.textBox6.TabIndex = 8;
            // 
            // panelMaszyny
            // 
            this.panelMaszyny.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMaszyny.Controls.Add(this.label4);
            this.panelMaszyny.Controls.Add(this.label1);
            this.panelMaszyny.Controls.Add(this.WyczyscDane);
            this.panelMaszyny.Controls.Add(this.label5);
            this.panelMaszyny.Controls.Add(this.Aktualizuj);
            this.panelMaszyny.Controls.Add(this.label2);
            this.panelMaszyny.Controls.Add(this.Zapisz);
            this.panelMaszyny.Controls.Add(this.label3);
            this.panelMaszyny.Controls.Add(this.textBox6);
            this.panelMaszyny.Controls.Add(this.label6);
            this.panelMaszyny.Controls.Add(this.textBox4);
            this.panelMaszyny.Controls.Add(this.textBox5);
            this.panelMaszyny.Controls.Add(this.textBox1);
            this.panelMaszyny.Controls.Add(this.textBox3);
            this.panelMaszyny.Controls.Add(this.textBox2);
            this.panelMaszyny.Location = new System.Drawing.Point(0, 24);
            this.panelMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.panelMaszyny.Name = "panelMaszyny";
            this.panelMaszyny.Size = new System.Drawing.Size(601, 417);
            this.panelMaszyny.TabIndex = 15;
            // 
            // FormZmiana_Maszyny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1012, 596);
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
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panelMaszyny;
    }
}