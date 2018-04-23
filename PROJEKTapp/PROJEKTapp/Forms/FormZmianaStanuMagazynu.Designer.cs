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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GridRekordyMagazyn = new System.Windows.Forms.DataGridView();
            this.ComboWyborMagazynu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonDodajRekord = new System.Windows.Forms.Button();
            this.ButtonUsunRekord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRekordyMagazyn)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = ".../Logistyka/Zmiana stanu magazynu";
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
            // GridRekordyMagazyn
            // 
            this.GridRekordyMagazyn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRekordyMagazyn.Location = new System.Drawing.Point(16, 148);
            this.GridRekordyMagazyn.Name = "GridRekordyMagazyn";
            this.GridRekordyMagazyn.Size = new System.Drawing.Size(932, 341);
            this.GridRekordyMagazyn.TabIndex = 19;
            // 
            // ComboWyborMagazynu
            // 
            this.ComboWyborMagazynu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboWyborMagazynu.FormattingEnabled = true;
            this.ComboWyborMagazynu.Location = new System.Drawing.Point(187, 107);
            this.ComboWyborMagazynu.Name = "ComboWyborMagazynu";
            this.ComboWyborMagazynu.Size = new System.Drawing.Size(121, 32);
            this.ComboWyborMagazynu.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Wybór magazynu:";
            // 
            // ButtonDodajRekord
            // 
            this.ButtonDodajRekord.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonDodajRekord.FlatAppearance.BorderSize = 0;
            this.ButtonDodajRekord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDodajRekord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonDodajRekord.Location = new System.Drawing.Point(752, 498);
            this.ButtonDodajRekord.Name = "ButtonDodajRekord";
            this.ButtonDodajRekord.Size = new System.Drawing.Size(98, 33);
            this.ButtonDodajRekord.TabIndex = 22;
            this.ButtonDodajRekord.Text = "DODAJ";
            this.ButtonDodajRekord.UseVisualStyleBackColor = false;
            // 
            // ButtonUsunRekord
            // 
            this.ButtonUsunRekord.BackColor = System.Drawing.Color.OrangeRed;
            this.ButtonUsunRekord.FlatAppearance.BorderSize = 0;
            this.ButtonUsunRekord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUsunRekord.Location = new System.Drawing.Point(856, 498);
            this.ButtonUsunRekord.Name = "ButtonUsunRekord";
            this.ButtonUsunRekord.Size = new System.Drawing.Size(92, 33);
            this.ButtonUsunRekord.TabIndex = 23;
            this.ButtonUsunRekord.Text = "USUŃ";
            this.ButtonUsunRekord.UseVisualStyleBackColor = false;
            // 
            // FormZmianaStanuMagazynu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.ButtonUsunRekord);
            this.Controls.Add(this.ButtonDodajRekord);
            this.Controls.Add(this.ComboWyborMagazynu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridRekordyMagazyn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.TopBar_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormZmianaStanuMagazynu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormZmianaStanuMagazynu";
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRekordyMagazyn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox TopBar_2;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView GridRekordyMagazyn;
        private System.Windows.Forms.ComboBox ComboWyborMagazynu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonDodajRekord;
        private System.Windows.Forms.Button ButtonUsunRekord;
    }
}