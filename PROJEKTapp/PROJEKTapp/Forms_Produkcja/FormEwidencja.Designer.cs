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
            this.SuspendLayout();
            // 
            // btnExitEwidencja
            // 
            this.btnExitEwidencja.FlatAppearance.BorderSize = 0;
            this.btnExitEwidencja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitEwidencja.Image = global::PROJEKTapp.Properties.Resources.btnExit_Image;
            this.btnExitEwidencja.Location = new System.Drawing.Point(727, 12);
            this.btnExitEwidencja.Name = "btnExitEwidencja";
            this.btnExitEwidencja.Size = new System.Drawing.Size(61, 62);
            this.btnExitEwidencja.TabIndex = 1;
            this.btnExitEwidencja.UseVisualStyleBackColor = true;
            this.btnExitEwidencja.Click += new System.EventHandler(this.btnExitEwidencja_Click);
            // 
            // FormEwidencja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitEwidencja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEwidencja";
            this.Text = "FormEwidencja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitEwidencja;
    }
}