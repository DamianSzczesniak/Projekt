namespace PROJEKTapp.Forms
{
    partial class FormZmianaStanuMagazynu
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
            this.Btn_Back = new System.Windows.Forms.Button();
            this.TopBar_2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Back.FlatAppearance.BorderSize = 0;
            this.Btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Image = global::PROJEKTapp.Properties.Resources.return2;
            this.Btn_Back.Location = new System.Drawing.Point(0, 0);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(80, 56);
            this.Btn_Back.TabIndex = 8;
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // TopBar_2
            // 
            this.TopBar_2.Image = global::PROJEKTapp.Properties.Resources.top_bar1;
            this.TopBar_2.Location = new System.Drawing.Point(0, 0);
            this.TopBar_2.Name = "TopBar_2";
            this.TopBar_2.Size = new System.Drawing.Size(960, 72);
            this.TopBar_2.TabIndex = 7;
            this.TopBar_2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = ".../Logistyka/Zmiana stanu magazynu";
            // 
            // FormZmianaStanuMagazynu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.TopBar_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormZmianaStanuMagazynu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormZmianaStanuMagazynu";
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox TopBar_2;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label label1;
    }
}