namespace PROJEKTapp.Forms
{
    partial class PrzygotowanieTransportu
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Back_3 = new System.Windows.Forms.Button();
            this.TopBar_3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = ".../Logistyka/Przygotowanie transportu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Back_3
            // 
            this.Btn_Back_3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Back_3.FlatAppearance.BorderSize = 0;
            this.Btn_Back_3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back_3.Image = global::PROJEKTapp.Properties.Resources.return2;
            this.Btn_Back_3.Location = new System.Drawing.Point(0, 0);
            this.Btn_Back_3.Name = "Btn_Back_3";
            this.Btn_Back_3.Size = new System.Drawing.Size(80, 56);
            this.Btn_Back_3.TabIndex = 9;
            this.Btn_Back_3.UseVisualStyleBackColor = false;
            this.Btn_Back_3.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // TopBar_3
            // 
            this.TopBar_3.Image = global::PROJEKTapp.Properties.Resources.top_bar1;
            this.TopBar_3.Location = new System.Drawing.Point(0, 0);
            this.TopBar_3.Name = "TopBar_3";
            this.TopBar_3.Size = new System.Drawing.Size(960, 72);
            this.TopBar_3.TabIndex = 8;
            this.TopBar_3.TabStop = false;
            // 
            // Przygotowanie_Transportu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Back_3);
            this.Controls.Add(this.TopBar_3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Przygotowanie_Transportu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przygotowanie_Transportu";
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopBar_3;
        private System.Windows.Forms.Button Btn_Back_3;
        private System.Windows.Forms.Label label1;
    }
}