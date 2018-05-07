namespace PROJEKTapp.Logowanie
{
    partial class ZmianaHasla
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
            this.btnZapisz = new System.Windows.Forms.Button();
            this.lblAHaslo = new System.Windows.Forms.Label();
            this.lblNHaslo = new System.Windows.Forms.Label();
            this.txtBoxAHaslo = new System.Windows.Forms.TextBox();
            this.txtBoxNHaslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(95, 145);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 0;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // lblAHaslo
            // 
            this.lblAHaslo.AutoSize = true;
            this.lblAHaslo.Location = new System.Drawing.Point(18, 27);
            this.lblAHaslo.Name = "lblAHaslo";
            this.lblAHaslo.Size = new System.Drawing.Size(85, 13);
            this.lblAHaslo.TabIndex = 1;
            this.lblAHaslo.Text = "Aktualne hasło :";
            // 
            // lblNHaslo
            // 
            this.lblNHaslo.AutoSize = true;
            this.lblNHaslo.Location = new System.Drawing.Point(18, 88);
            this.lblNHaslo.Name = "lblNHaslo";
            this.lblNHaslo.Size = new System.Drawing.Size(71, 13);
            this.lblNHaslo.TabIndex = 2;
            this.lblNHaslo.Text = "Nowe hasło :";
            // 
            // txtBoxAHaslo
            // 
            this.txtBoxAHaslo.Location = new System.Drawing.Point(111, 24);
            this.txtBoxAHaslo.Name = "txtBoxAHaslo";
            this.txtBoxAHaslo.Size = new System.Drawing.Size(131, 20);
            this.txtBoxAHaslo.TabIndex = 3;
            // 
            // txtBoxNHaslo
            // 
            this.txtBoxNHaslo.Location = new System.Drawing.Point(111, 85);
            this.txtBoxNHaslo.Name = "txtBoxNHaslo";
            this.txtBoxNHaslo.Size = new System.Drawing.Size(131, 20);
            this.txtBoxNHaslo.TabIndex = 4;
            // 
            // ZmianaHasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 180);
            this.Controls.Add(this.txtBoxNHaslo);
            this.Controls.Add(this.txtBoxAHaslo);
            this.Controls.Add(this.lblNHaslo);
            this.Controls.Add(this.lblAHaslo);
            this.Controls.Add(this.btnZapisz);
            this.Name = "ZmianaHasla";
            this.Text = "ZmianaHasla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Label lblAHaslo;
        private System.Windows.Forms.Label lblNHaslo;
        private System.Windows.Forms.TextBox txtBoxAHaslo;
        private System.Windows.Forms.TextBox txtBoxNHaslo;
    }
}