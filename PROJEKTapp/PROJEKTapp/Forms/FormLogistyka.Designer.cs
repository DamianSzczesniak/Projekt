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
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_kreat_fak = new System.Windows.Forms.Button();
            this.Btn_zam_mat = new System.Windows.Forms.Button();
            this.Btn_przyg_trans = new System.Windows.Forms.Button();
            this.Btn_zmiana_stat = new System.Windows.Forms.Button();
            this.TopBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(903, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_kreat_fak
            // 
            this.Btn_kreat_fak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_kreat_fak.FlatAppearance.BorderSize = 0;
            this.Btn_kreat_fak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_kreat_fak.Image = global::PROJEKTapp.Properties.Resources.Kreator_faktur;
            this.Btn_kreat_fak.Location = new System.Drawing.Point(259, 390);
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
            this.Btn_zam_mat.Location = new System.Drawing.Point(259, 303);
            this.Btn_zam_mat.Name = "Btn_zam_mat";
            this.Btn_zam_mat.Size = new System.Drawing.Size(437, 63);
            this.Btn_zam_mat.TabIndex = 5;
            this.Btn_zam_mat.UseVisualStyleBackColor = true;
            this.Btn_zam_mat.Click += new System.EventHandler(this.Btn_zam_mat_Click);
            // 
            // Btn_przyg_trans
            // 
            this.Btn_przyg_trans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_przyg_trans.FlatAppearance.BorderSize = 0;
            this.Btn_przyg_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_przyg_trans.Image = global::PROJEKTapp.Properties.Resources.Przygotowanie_transportu;
            this.Btn_przyg_trans.Location = new System.Drawing.Point(259, 213);
            this.Btn_przyg_trans.Name = "Btn_przyg_trans";
            this.Btn_przyg_trans.Size = new System.Drawing.Size(437, 63);
            this.Btn_przyg_trans.TabIndex = 4;
            this.Btn_przyg_trans.UseVisualStyleBackColor = true;
            this.Btn_przyg_trans.Click += new System.EventHandler(this.Btn_przyg_trans_Click);
            // 
            // Btn_zmiana_stat
            // 
            this.Btn_zmiana_stat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_zmiana_stat.FlatAppearance.BorderSize = 0;
            this.Btn_zmiana_stat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_zmiana_stat.Image = global::PROJEKTapp.Properties.Resources.Zmiana_stanu_magazynu;
            this.Btn_zmiana_stat.Location = new System.Drawing.Point(259, 122);
            this.Btn_zmiana_stat.Name = "Btn_zmiana_stat";
            this.Btn_zmiana_stat.Size = new System.Drawing.Size(437, 63);
            this.Btn_zmiana_stat.TabIndex = 3;
            this.Btn_zmiana_stat.UseVisualStyleBackColor = true;
            this.Btn_zmiana_stat.Click += new System.EventHandler(this.Btn_zmiana_stat_Click);
            // 
            // TopBar
            // 
            this.TopBar.Image = global::PROJEKTapp.Properties.Resources.top_bar1;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(960, 72);
            this.TopBar.TabIndex = 2;
            this.TopBar.TabStop = false;
            // 
            // FormLogistyka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_kreat_fak);
            this.Controls.Add(this.Btn_zam_mat);
            this.Controls.Add(this.Btn_przyg_trans);
            this.Controls.Add(this.Btn_zmiana_stat);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogistyka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogistyka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox TopBar;
        private System.Windows.Forms.Button Btn_zmiana_stat;
        private System.Windows.Forms.Button Btn_przyg_trans;
        private System.Windows.Forms.Button Btn_zam_mat;
        private System.Windows.Forms.Button Btn_kreat_fak;
        private System.Windows.Forms.Button button1;
    }
}