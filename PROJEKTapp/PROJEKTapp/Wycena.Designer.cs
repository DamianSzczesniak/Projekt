namespace PROJEKTapp
{
    partial class Wycena
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
            this.Produkt = new System.Windows.Forms.Button();
            this.Material = new System.Windows.Forms.Button();
            this.Maszyny = new System.Windows.Forms.Button();
            this.Narzedzia = new System.Windows.Forms.Button();
            this.Kwota_do_zaplaty = new System.Windows.Forms.Button();
            this.Koszty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Produkt
            // 
            this.Produkt.Location = new System.Drawing.Point(49, 47);
            this.Produkt.Name = "Produkt";
            this.Produkt.Size = new System.Drawing.Size(88, 35);
            this.Produkt.TabIndex = 0;
            this.Produkt.Text = "Produkt";
            this.Produkt.UseVisualStyleBackColor = true;
            // 
            // Material
            // 
            this.Material.Location = new System.Drawing.Point(143, 47);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(92, 35);
            this.Material.TabIndex = 0;
            this.Material.Text = "Material";
            this.Material.UseVisualStyleBackColor = true;
            // 
            // Maszyny
            // 
            this.Maszyny.Location = new System.Drawing.Point(344, 47);
            this.Maszyny.Name = "Maszyny";
            this.Maszyny.Size = new System.Drawing.Size(88, 35);
            this.Maszyny.TabIndex = 0;
            this.Maszyny.Text = "Maszyny";
            this.Maszyny.UseVisualStyleBackColor = true;
            // 
            // Narzedzia
            // 
            this.Narzedzia.Location = new System.Drawing.Point(453, 47);
            this.Narzedzia.Name = "Narzedzia";
            this.Narzedzia.Size = new System.Drawing.Size(88, 35);
            this.Narzedzia.TabIndex = 0;
            this.Narzedzia.Text = "Narzedzia";
            this.Narzedzia.UseVisualStyleBackColor = true;
            // 
            // Kwota_do_zaplaty
            // 
            this.Kwota_do_zaplaty.Location = new System.Drawing.Point(559, 47);
            this.Kwota_do_zaplaty.Name = "Kwota_do_zaplaty";
            this.Kwota_do_zaplaty.Size = new System.Drawing.Size(147, 35);
            this.Kwota_do_zaplaty.TabIndex = 0;
            this.Kwota_do_zaplaty.Text = "Kwota_do_zaplaty";
            this.Kwota_do_zaplaty.UseVisualStyleBackColor = true;
            // 
            // Koszty
            // 
            this.Koszty.Location = new System.Drawing.Point(250, 47);
            this.Koszty.Name = "Koszty";
            this.Koszty.Size = new System.Drawing.Size(88, 35);
            this.Koszty.TabIndex = 0;
            this.Koszty.Text = "Koszty";
            this.Koszty.UseVisualStyleBackColor = true;
            // 
            // Wycena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Koszty);
            this.Controls.Add(this.Kwota_do_zaplaty);
            this.Controls.Add(this.Narzedzia);
            this.Controls.Add(this.Maszyny);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.Produkt);
            this.Name = "Wycena";
            this.Text = "Wycena";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Produkt;
        private System.Windows.Forms.Button Material;
        private System.Windows.Forms.Button Maszyny;
        private System.Windows.Forms.Button Narzedzia;
        private System.Windows.Forms.Button Kwota_do_zaplaty;
        private System.Windows.Forms.Button Koszty;
    }
}