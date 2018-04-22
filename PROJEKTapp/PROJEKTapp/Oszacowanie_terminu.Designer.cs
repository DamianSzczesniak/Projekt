namespace PROJEKTapp
{
    partial class Oszacowanie_terminu
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
            this.Maszyny = new System.Windows.Forms.Button();
            this.Narzedzia = new System.Windows.Forms.Button();
            this.Pracownicy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Maszyny
            // 
            this.Maszyny.Location = new System.Drawing.Point(47, 108);
            this.Maszyny.Name = "Maszyny";
            this.Maszyny.Size = new System.Drawing.Size(97, 31);
            this.Maszyny.TabIndex = 0;
            this.Maszyny.Text = "Maszyny";
            this.Maszyny.UseVisualStyleBackColor = true;
            // 
            // Narzedzia
            // 
            this.Narzedzia.Location = new System.Drawing.Point(47, 158);
            this.Narzedzia.Name = "Narzedzia";
            this.Narzedzia.Size = new System.Drawing.Size(97, 31);
            this.Narzedzia.TabIndex = 0;
            this.Narzedzia.Text = "Narzedzia";
            this.Narzedzia.UseVisualStyleBackColor = true;
            // 
            // Pracownicy
            // 
            this.Pracownicy.Location = new System.Drawing.Point(47, 51);
            this.Pracownicy.Name = "Pracownicy";
            this.Pracownicy.Size = new System.Drawing.Size(97, 31);
            this.Pracownicy.TabIndex = 0;
            this.Pracownicy.Text = "Pracownicy";
            this.Pracownicy.UseVisualStyleBackColor = true;
            // 
            // Oszacowanie_terminu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pracownicy);
            this.Controls.Add(this.Narzedzia);
            this.Controls.Add(this.Maszyny);
            this.Name = "Oszacowanie_terminu";
            this.Text = "Oszacowanie_terminu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Maszyny;
        private System.Windows.Forms.Button Narzedzia;
        private System.Windows.Forms.Button Pracownicy;
    }
}