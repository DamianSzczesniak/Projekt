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
            this.components = new System.ComponentModel.Container();
            this.Btn_Back_5 = new System.Windows.Forms.Button();
            this.TopBar_5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSprDost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNrZlecenia = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GridVwZapMat = new System.Windows.Forms.DataGridView();
            this.sTANMATERIALYNAZWYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.BtnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVwZapMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTANMATERIALYNAZWYBindingSource)).BeginInit();
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
            // 
            // TopBar_5
            // 
            this.TopBar_5.Image = global::PROJEKTapp.Properties.Resources.top_bar1;
            this.TopBar_5.Location = new System.Drawing.Point(204, 0);
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
            this.pictureBox1.Size = new System.Drawing.Size(1340, 2);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSprDost
            // 
            this.BtnSprDost.Location = new System.Drawing.Point(31, 345);
            this.BtnSprDost.Name = "BtnSprDost";
            this.BtnSprDost.Size = new System.Drawing.Size(966, 26);
            this.BtnSprDost.TabIndex = 19;
            this.BtnSprDost.Text = "Sprawdź dostępność materiałów";
            this.BtnSprDost.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Numer zlecenia";
            // 
            // comboBoxNrZlecenia
            // 
            this.comboBoxNrZlecenia.FormattingEnabled = true;
            this.comboBoxNrZlecenia.Location = new System.Drawing.Point(130, 123);
            this.comboBoxNrZlecenia.Name = "comboBoxNrZlecenia";
            this.comboBoxNrZlecenia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNrZlecenia.TabIndex = 21;
            this.comboBoxNrZlecenia.SelectedIndexChanged += new System.EventHandler(this.comboBoxNrZlecenia_SelectedIndexChanged_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 56);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox3.Location = new System.Drawing.Point(1164, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 56);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // GridVwZapMat
            // 
            this.GridVwZapMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVwZapMat.Location = new System.Drawing.Point(31, 178);
            this.GridVwZapMat.Name = "GridVwZapMat";
            this.GridVwZapMat.Size = new System.Drawing.Size(966, 161);
            this.GridVwZapMat.TabIndex = 26;
            // 
            // sTANMATERIALYNAZWYBindingSource
            // 
            this.sTANMATERIALYNAZWYBindingSource.DataSource = typeof(PROJEKTapp.STAN_MATERIALY_NAZWY);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Zapotrzebowanie na materiały do danego zlecenia:";
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(271, 123);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 29;
            this.BtnShow.Text = "Pokaż";
            this.BtnShow.UseVisualStyleBackColor = true;
            // 
            // ZamowienieMaterialu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridVwZapMat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.comboBoxNrZlecenia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSprDost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Back_5);
            this.Controls.Add(this.TopBar_5);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZamowienieMaterialu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZamówienieMaterialu";
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVwZapMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTANMATERIALYNAZWYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back_5;
        private System.Windows.Forms.PictureBox TopBar_5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSprDost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNrZlecenia;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView GridVwZapMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.BindingSource sTANMATERIALYNAZWYBindingSource;
    }
}