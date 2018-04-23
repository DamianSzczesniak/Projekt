namespace PROJEKTapp.Forms
{
    partial class ZamowienieMaterialu
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
            this.Btn_Back_5 = new System.Windows.Forms.Button();
            this.TopBar_5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Back_5
            // 
            this.Btn_Back_5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Back_5.FlatAppearance.BorderSize = 0;
            this.Btn_Back_5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back_5.Image = global::PROJEKTapp.Properties.Resources.return2;
            this.Btn_Back_5.Location = new System.Drawing.Point(0, 0);
            this.Btn_Back_5.Name = "Btn_Back_5";
            this.Btn_Back_5.Size = new System.Drawing.Size(80, 56);
            this.Btn_Back_5.TabIndex = 13;
            this.Btn_Back_5.UseVisualStyleBackColor = false;
            this.Btn_Back_5.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // TopBar_5
            // 
            this.TopBar_5.Image = global::PROJEKTapp.Properties.Resources.top_bar1;
            this.TopBar_5.Location = new System.Drawing.Point(0, 0);
            this.TopBar_5.Name = "TopBar_5";
            this.TopBar_5.Size = new System.Drawing.Size(960, 72);
            this.TopBar_5.TabIndex = 12;
            this.TopBar_5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = ".../Logistyka/Zamówienie materiału";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(936, 2);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ZamowienieMaterialu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Back_5);
            this.Controls.Add(this.TopBar_5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZamowienieMaterialu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZamówienieMaterialu";
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back_5;
        private System.Windows.Forms.PictureBox TopBar_5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}