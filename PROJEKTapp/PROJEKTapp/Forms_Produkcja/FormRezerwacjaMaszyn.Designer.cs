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
            this.btnExitRezerwacjaMaszyn = new System.Windows.Forms.Button();
            this.lblWyborZlecenia = new System.Windows.Forms.Label();
            this.cboxWybierzZlecenie = new System.Windows.Forms.ComboBox();
            this.RezerwujMaszyny = new System.Windows.Forms.Button();
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
            this.RezerwujMaszyny.Location = new System.Drawing.Point(121, 224);
            this.RezerwujMaszyny.Name = "RezerwujMaszyny";
            this.RezerwujMaszyny.Size = new System.Drawing.Size(179, 95);
            this.RezerwujMaszyny.TabIndex = 5;
            this.RezerwujMaszyny.Text = "Rezerwuj maszyny";
            this.RezerwujMaszyny.UseVisualStyleBackColor = true;
            this.RezerwujMaszyny.Click += new System.EventHandler(this.RezerwujMaszyny_Click);
            // 
            // FormRezerwacjaMaszyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.RezerwujMaszyny);
            this.Controls.Add(this.cboxWybierzZlecenie);
            this.Controls.Add(this.lblWyborZlecenia);
            this.Controls.Add(this.btnExitRezerwacjaMaszyn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRezerwacjaMaszyn";
            this.Text = "FormRezerwacjaMaszyn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitRezerwacjaMaszyn;
        private System.Windows.Forms.Label lblWyborZlecenia;
        private System.Windows.Forms.ComboBox cboxWybierzZlecenie;
        private System.Windows.Forms.Button RezerwujMaszyny;
    }
}