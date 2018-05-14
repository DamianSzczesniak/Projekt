namespace PROJEKTapp
{
    partial class FormLogistyka
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
            this.Btn_kreat_fak = new System.Windows.Forms.Button();
            this.Btn_zam_mat = new System.Windows.Forms.Button();
            this.TopBar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_kreat_fak
            // 
            this.Btn_kreat_fak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_kreat_fak.FlatAppearance.BorderSize = 0;
            this.Btn_kreat_fak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_kreat_fak.Image = global::PROJEKTapp.Properties.Resources.Kreator_faktur;
            this.Btn_kreat_fak.Location = new System.Drawing.Point(195, 362);
            this.Btn_kreat_fak.Name = "Btn_kreat_fak";
            this.Btn_kreat_fak.Size = new System.Drawing.Size(437, 63);
            this.Btn_kreat_fak.TabIndex = 6;
            this.Btn_kreat_fak.UseVisualStyleBackColor = true;
            this.Btn_kreat_fak.Click += new System.EventHandler(this.Btn_kreat_fak_Click);
            // 
            // Btn_zam_mat
            // 
            this.Btn_zam_mat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_zam_mat.FlatAppearance.BorderSize = 0;
            this.Btn_zam_mat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_zam_mat.Image = global::PROJEKTapp.Properties.Resources.zamowienie_materialu;
            this.Btn_zam_mat.Location = new System.Drawing.Point(195, 270);
            this.Btn_zam_mat.Name = "Btn_zam_mat";
            this.Btn_zam_mat.Size = new System.Drawing.Size(437, 63);
            this.Btn_zam_mat.TabIndex = 5;
            this.Btn_zam_mat.UseVisualStyleBackColor = true;
            this.Btn_zam_mat.Click += new System.EventHandler(this.Btn_zam_mat_Click);
            // 
            // TopBar
            // 
            this.TopBar.Image = global::PROJEKTapp.Properties.Resources.top_bar1;
            this.TopBar.Location = new System.Drawing.Point(-68, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(960, 72);
            this.TopBar.TabIndex = 2;
            this.TopBar.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Location = new System.Drawing.Point(1164, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 56);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
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
            this.Btn_Back.Location = new System.Drawing.Point(722, 0);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(80, 44);
            this.Btn_Back.TabIndex = 10;
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // FormLogistyka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 768);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_kreat_fak);
            this.Controls.Add(this.Btn_zam_mat);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogistyka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogistyka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox TopBar;
        private System.Windows.Forms.Button Btn_zam_mat;
        private System.Windows.Forms.Button Btn_kreat_fak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_Back;
    }
}