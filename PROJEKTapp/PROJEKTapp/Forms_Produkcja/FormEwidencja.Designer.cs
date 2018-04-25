namespace PROJEKTapp.Forms_Produkcja
{
    partial class FormEwidencja
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
            this.btnExitEwidencja = new System.Windows.Forms.Button();
            this.panelNarzedzia = new System.Windows.Forms.Panel();
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
            this.LabelN = new System.Windows.Forms.Label();
            this.panelMaszyny = new System.Windows.Forms.Panel();
            this.WyczyscDaneM = new System.Windows.Forms.Button();
            this.ZapiszM = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelNarzedzia.SuspendLayout();
            this.panelMaszyny.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitEwidencja
            // 
            this.btnExitEwidencja.FlatAppearance.BorderSize = 0;
            this.btnExitEwidencja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitEwidencja.Image = global::PROJEKTapp.Properties.Resources.btnExit_Image;
            this.btnExitEwidencja.Location = new System.Drawing.Point(1724, 15);
            this.btnExitEwidencja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExitEwidencja.Name = "btnExitEwidencja";
            this.btnExitEwidencja.Size = new System.Drawing.Size(81, 76);
            this.btnExitEwidencja.TabIndex = 1;
            this.btnExitEwidencja.UseVisualStyleBackColor = true;
            this.btnExitEwidencja.Click += new System.EventHandler(this.btnExitEwidencja_Click);
            // 
            // panelNarzedzia
            // 
            this.panelNarzedzia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelNarzedzia.Controls.Add(this.WyczyscDane);
            this.panelNarzedzia.Controls.Add(this.Aktualizuj);
            this.panelNarzedzia.Controls.Add(this.Zapisz);
            this.panelNarzedzia.Controls.Add(this.textBox4);
            this.panelNarzedzia.Controls.Add(this.textBox3);
            this.panelNarzedzia.Controls.Add(this.textBox2);
            this.panelNarzedzia.Controls.Add(this.textBox1);
            this.panelNarzedzia.Controls.Add(this.label4);
            this.panelNarzedzia.Controls.Add(this.label3);
            this.panelNarzedzia.Controls.Add(this.label2);
            this.panelNarzedzia.Controls.Add(this.label1);
            this.panelNarzedzia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelNarzedzia.Location = new System.Drawing.Point(35, 98);
            this.panelNarzedzia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelNarzedzia.Name = "panelNarzedzia";
            this.panelNarzedzia.Size = new System.Drawing.Size(800, 631);
            this.panelNarzedzia.TabIndex = 3;
            this.panelNarzedzia.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNarzedzia_Paint);
            // 
            // WyczyscDane
            // 
            this.WyczyscDane.Location = new System.Drawing.Point(504, 559);
            this.WyczyscDane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WyczyscDane.Name = "WyczyscDane";
            this.WyczyscDane.Size = new System.Drawing.Size(163, 71);
            this.WyczyscDane.TabIndex = 2;
            this.WyczyscDane.Text = "Wyczyść dane";
            this.WyczyscDane.UseVisualStyleBackColor = true;
            this.WyczyscDane.Click += new System.EventHandler(this.WyczyscDane_Click);
            // 
            // Aktualizuj
            // 
            this.Aktualizuj.Location = new System.Drawing.Point(303, 559);
            this.Aktualizuj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Aktualizuj.Name = "Aktualizuj";
            this.Aktualizuj.Size = new System.Drawing.Size(163, 71);
            this.Aktualizuj.TabIndex = 2;
            this.Aktualizuj.Text = "Aktualizuj";
            this.Aktualizuj.UseVisualStyleBackColor = true;
            this.Aktualizuj.Click += new System.EventHandler(this.Aktualizuj_Click);
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(91, 559);
            this.Zapisz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(163, 71);
            this.Zapisz.TabIndex = 2;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(217, 414);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(448, 22);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(217, 313);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(448, 22);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 196);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(448, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 105);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 414);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cena za godzinę";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numer ewidencyjny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa";
            // 
            // LabelN
            // 
            this.LabelN.AutoSize = true;
            this.LabelN.Location = new System.Drawing.Point(59, 66);
            this.LabelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(180, 17);
            this.LabelN.TabIndex = 0;
            this.LabelN.Text = "Dodanie nowego narzędzia";
            // 
            // panelMaszyny
            // 
            this.panelMaszyny.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMaszyny.Controls.Add(this.button1);
            this.panelMaszyny.Controls.Add(this.WyczyscDaneM);
            this.panelMaszyny.Controls.Add(this.ZapiszM);
            this.panelMaszyny.Controls.Add(this.label7);
            this.panelMaszyny.Controls.Add(this.label10);
            this.panelMaszyny.Controls.Add(this.label9);
            this.panelMaszyny.Controls.Add(this.textBox10);
            this.panelMaszyny.Controls.Add(this.textBox9);
            this.panelMaszyny.Controls.Add(this.textBox8);
            this.panelMaszyny.Controls.Add(this.textBox7);
            this.panelMaszyny.Controls.Add(this.textBox6);
            this.panelMaszyny.Controls.Add(this.textBox5);
            this.panelMaszyny.Controls.Add(this.label8);
            this.panelMaszyny.Controls.Add(this.label6);
            this.panelMaszyny.Controls.Add(this.label5);
            this.panelMaszyny.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMaszyny.Location = new System.Drawing.Point(843, 99);
            this.panelMaszyny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMaszyny.Name = "panelMaszyny";
            this.panelMaszyny.Size = new System.Drawing.Size(800, 630);
            this.panelMaszyny.TabIndex = 4;
            this.panelMaszyny.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMaszyny_Paint);
            // 
            // WyczyscDaneM
            // 
            this.WyczyscDaneM.Location = new System.Drawing.Point(545, 555);
            this.WyczyscDaneM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WyczyscDaneM.Name = "WyczyscDaneM";
            this.WyczyscDaneM.Size = new System.Drawing.Size(135, 71);
            this.WyczyscDaneM.TabIndex = 3;
            this.WyczyscDaneM.Text = "Wyczyść dane";
            this.WyczyscDaneM.UseVisualStyleBackColor = true;
            this.WyczyscDaneM.Click += new System.EventHandler(this.WyczyscDaneM_Click);
            // 
            // ZapiszM
            // 
            this.ZapiszM.Location = new System.Drawing.Point(87, 555);
            this.ZapiszM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ZapiszM.Name = "ZapiszM";
            this.ZapiszM.Size = new System.Drawing.Size(147, 71);
            this.ZapiszM.TabIndex = 2;
            this.ZapiszM.Text = "Zapisz";
            this.ZapiszM.UseVisualStyleBackColor = true;
            this.ZapiszM.Click += new System.EventHandler(this.ZapiszM_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Marka";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 443);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cena za godzinę";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 367);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Posuw";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(232, 434);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(448, 22);
            this.textBox10.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(232, 358);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(448, 22);
            this.textBox9.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(232, 290);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(448, 22);
            this.textBox8.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(232, 223);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(448, 22);
            this.textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(232, 160);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(448, 22);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(232, 101);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(448, 22);
            this.textBox5.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 294);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Prędkość";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Typ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Model";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(854, 74);
            this.labelM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(223, 17);
            this.labelM.TabIndex = 0;
            this.labelM.Text = "Dodanie nowego modelu maszyny";
            this.labelM.Click += new System.EventHandler(this.labelM_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aktualizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEwidencja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1821, 945);
            this.Controls.Add(this.LabelN);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.panelMaszyny);
            this.Controls.Add(this.panelNarzedzia);
            this.Controls.Add(this.btnExitEwidencja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEwidencja";
            this.Text = "FormEwidencja";
            this.panelNarzedzia.ResumeLayout(false);
            this.panelNarzedzia.PerformLayout();
            this.panelMaszyny.ResumeLayout(false);
            this.panelMaszyny.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitEwidencja;
        private System.Windows.Forms.Panel panelNarzedzia;
        private System.Windows.Forms.Panel panelMaszyny;
        private System.Windows.Forms.Label LabelN;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WyczyscDane;
        private System.Windows.Forms.Button Aktualizuj;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ZapiszM;
        private System.Windows.Forms.Button WyczyscDaneM;
        private System.Windows.Forms.Button button1;
    }
}