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
            this.Aktualizuj = new System.Windows.Forms.Button();
            this.WyczyscDane = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.labelM = new System.Windows.Forms.Label();
            this.panelNarzedzia = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKosztZaH = new System.Windows.Forms.TextBox();
            this.textBoxNrEwidencyjny = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelNarzedzia.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aktualizuj
            // 
            this.Aktualizuj.Location = new System.Drawing.Point(213, 409);
            this.Aktualizuj.Margin = new System.Windows.Forms.Padding(2);
            this.Aktualizuj.Name = "Aktualizuj";
            this.Aktualizuj.Size = new System.Drawing.Size(111, 87);
            this.Aktualizuj.TabIndex = 4;
            this.Aktualizuj.Text = "Zapisz";
            this.Aktualizuj.UseVisualStyleBackColor = true;
            this.Aktualizuj.Click += new System.EventHandler(this.button1_Click);
            // 
            // WyczyscDane
            // 
            this.WyczyscDane.Location = new System.Drawing.Point(356, 409);
            this.WyczyscDane.Name = "WyczyscDane";
            this.WyczyscDane.Size = new System.Drawing.Size(123, 87);
            this.WyczyscDane.TabIndex = 3;
            this.WyczyscDane.Text = "Wyczyść dane";
            this.WyczyscDane.UseVisualStyleBackColor = true;
            this.WyczyscDane.Click += new System.EventHandler(this.WyczyscDaneM_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(62, 409);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(119, 87);
            this.Dodaj.TabIndex = 2;
            this.Dodaj.Text = "Dodaj nowe na podstawie istniejącego narzędzia";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.ZapiszM_Click);
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(108, -41);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(168, 13);
            this.labelM.TabIndex = 5;
            this.labelM.Text = "Dodanie nowego modelu maszyny";
            // 
            // panelNarzedzia
            // 
            this.panelNarzedzia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelNarzedzia.Controls.Add(this.Aktualizuj);
            this.panelNarzedzia.Controls.Add(this.WyczyscDane);
            this.panelNarzedzia.Controls.Add(this.Dodaj);
            this.panelNarzedzia.Controls.Add(this.label7);
            this.panelNarzedzia.Controls.Add(this.textBoxKosztZaH);
            this.panelNarzedzia.Controls.Add(this.textBoxNrEwidencyjny);
            this.panelNarzedzia.Controls.Add(this.textBoxModel);
            this.panelNarzedzia.Controls.Add(this.textBoxNazwa);
            this.panelNarzedzia.Controls.Add(this.label8);
            this.panelNarzedzia.Controls.Add(this.label6);
            this.panelNarzedzia.Controls.Add(this.label5);
            this.panelNarzedzia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelNarzedzia.Location = new System.Drawing.Point(28, 12);
            this.panelNarzedzia.Name = "panelNarzedzia";
            this.panelNarzedzia.Size = new System.Drawing.Size(600, 512);
            this.panelNarzedzia.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Model";
            // 
            // textBoxKosztZaH
            // 
            this.textBoxKosztZaH.Location = new System.Drawing.Point(174, 323);
            this.textBoxKosztZaH.Name = "textBoxKosztZaH";
            this.textBoxKosztZaH.Size = new System.Drawing.Size(337, 20);
            this.textBoxKosztZaH.TabIndex = 1;
            // 
            // textBoxNrEwidencyjny
            // 
            this.textBoxNrEwidencyjny.Location = new System.Drawing.Point(174, 239);
            this.textBoxNrEwidencyjny.Name = "textBoxNrEwidencyjny";
            this.textBoxNrEwidencyjny.Size = new System.Drawing.Size(337, 20);
            this.textBoxNrEwidencyjny.TabIndex = 1;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(174, 164);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(337, 20);
            this.textBoxModel.TabIndex = 1;
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(174, 87);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(337, 20);
            this.textBoxNazwa.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Koszt za godzinę";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nr Ewidencyjny";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nazwa";
            // 
            // FormZmiana_Narzedzia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 729);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.panelNarzedzia);
            this.Name = "FormZmiana_Narzedzia";
            this.Text = "FormZmiana_Narzedzia";
            this.panelNarzedzia.ResumeLayout(false);
            this.panelNarzedzia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aktualizuj;
        private System.Windows.Forms.Button WyczyscDane;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Panel panelNarzedzia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKosztZaH;
        private System.Windows.Forms.TextBox textBoxNrEwidencyjny;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}