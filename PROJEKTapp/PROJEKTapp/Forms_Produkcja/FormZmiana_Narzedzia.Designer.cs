namespace PROJEKTapp.Forms_Produkcja
{
    partial class FormZmiana_Narzedzia
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
            this.button1 = new System.Windows.Forms.Button();
            this.WyczyscDaneM = new System.Windows.Forms.Button();
            this.ZapiszM = new System.Windows.Forms.Button();
            this.labelM = new System.Windows.Forms.Label();
            this.panelNarzedzia = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelNarzedzia.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 558);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aktualizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(144, -50);
            this.labelM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(223, 17);
            this.labelM.TabIndex = 5;
            this.labelM.Text = "Dodanie nowego modelu maszyny";
            // 
            // panelNarzedzia
            // 
            this.panelNarzedzia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelNarzedzia.Controls.Add(this.button1);
            this.panelNarzedzia.Controls.Add(this.WyczyscDaneM);
            this.panelNarzedzia.Controls.Add(this.ZapiszM);
            this.panelNarzedzia.Controls.Add(this.label7);
            this.panelNarzedzia.Controls.Add(this.textBox8);
            this.panelNarzedzia.Controls.Add(this.textBox7);
            this.panelNarzedzia.Controls.Add(this.textBox6);
            this.panelNarzedzia.Controls.Add(this.textBox5);
            this.panelNarzedzia.Controls.Add(this.label8);
            this.panelNarzedzia.Controls.Add(this.label6);
            this.panelNarzedzia.Controls.Add(this.label5);
            this.panelNarzedzia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelNarzedzia.Location = new System.Drawing.Point(37, 15);
            this.panelNarzedzia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelNarzedzia.Name = "panelNarzedzia";
            this.panelNarzedzia.Size = new System.Drawing.Size(800, 630);
            this.panelNarzedzia.TabIndex = 6;
            this.panelNarzedzia.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMaszyny_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Model";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(232, 398);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(448, 22);
            this.textBox8.TabIndex = 1;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(232, 294);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(448, 22);
            this.textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(232, 202);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(448, 22);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(232, 107);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(448, 22);
            this.textBox5.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 401);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Koszt za godzinę";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nr Ewidencyjny";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nazwa";
            // 
            // FormZmiana_Narzedzia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.panelNarzedzia);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormZmiana_Narzedzia";
            this.Text = "FormZmiana_Narzedzia";
            this.panelNarzedzia.ResumeLayout(false);
            this.panelNarzedzia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button WyczyscDaneM;
        private System.Windows.Forms.Button ZapiszM;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Panel panelNarzedzia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}