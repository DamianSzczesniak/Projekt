namespace PROJEKTapp
{
    partial class Produkcja_glowny
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
            this.Wycena = new System.Windows.Forms.Button();
            this.Oszacowanie_terminu = new System.Windows.Forms.Button();
            this.Ewidencja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Wycena
            // 
            this.Wycena.Location = new System.Drawing.Point(47, 233);
            this.Wycena.Name = "Wycena";
            this.Wycena.Size = new System.Drawing.Size(178, 37);
            this.Wycena.TabIndex = 0;
            this.Wycena.Text = "Wycena";
            this.Wycena.UseVisualStyleBackColor = true;
            // 
            // Oszacowanie_terminu
            // 
            this.Oszacowanie_terminu.Location = new System.Drawing.Point(47, 86);
            this.Oszacowanie_terminu.Name = "Oszacowanie_terminu";
            this.Oszacowanie_terminu.Size = new System.Drawing.Size(178, 37);
            this.Oszacowanie_terminu.TabIndex = 0;
            this.Oszacowanie_terminu.Text = "Oszacowanie_terminu";
            this.Oszacowanie_terminu.UseVisualStyleBackColor = true;
            // 
            // Ewidencja
            // 
            this.Ewidencja.Location = new System.Drawing.Point(47, 157);
            this.Ewidencja.Name = "Ewidencja";
            this.Ewidencja.Size = new System.Drawing.Size(178, 37);
            this.Ewidencja.TabIndex = 0;
            this.Ewidencja.Text = "Ewidencja";
            this.Ewidencja.UseVisualStyleBackColor = true;
            // 
            // Produkcja_glowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ewidencja);
            this.Controls.Add(this.Oszacowanie_terminu);
            this.Controls.Add(this.Wycena);
            this.Name = "Produkcja_glowny";
            this.Text = "Produkcja_glowny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Wycena;
        private System.Windows.Forms.Button Oszacowanie_terminu;
        private System.Windows.Forms.Button Ewidencja;
    }
}