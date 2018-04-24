namespace PROJEKTapp
{
    partial class PracStan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracStan));
            this.dgwPracStan = new System.Windows.Forms.DataGridView();
            this.cbStanowisko = new System.Windows.Forms.ComboBox();
            this.txtWyszukaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPracStan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPracStan
            // 
            this.dgwPracStan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPracStan.Location = new System.Drawing.Point(94, 94);
            this.dgwPracStan.Name = "dgwPracStan";
            this.dgwPracStan.Size = new System.Drawing.Size(603, 325);
            this.dgwPracStan.TabIndex = 0;
            // 
            // cbStanowisko
            // 
            this.cbStanowisko.FormattingEnabled = true;
            this.cbStanowisko.Location = new System.Drawing.Point(94, 55);
            this.cbStanowisko.Name = "cbStanowisko";
            this.cbStanowisko.Size = new System.Drawing.Size(265, 21);
            this.cbStanowisko.TabIndex = 1;
            this.cbStanowisko.SelectedIndexChanged += new System.EventHandler(this.cbStanowisko_SelectedIndexChanged);
            // 
            // txtWyszukaj
            // 
            this.txtWyszukaj.Location = new System.Drawing.Point(365, 56);
            this.txtWyszukaj.Name = "txtWyszukaj";
            this.txtWyszukaj.Size = new System.Drawing.Size(215, 20);
            this.txtWyszukaj.TabIndex = 2;
            this.txtWyszukaj.TextChanged += new System.EventHandler(this.txtWyszukaj_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stanowisko:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(733, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PracStan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWyszukaj);
            this.Controls.Add(this.cbStanowisko);
            this.Controls.Add(this.dgwPracStan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PracStan";
            this.Text = "PracStan";
            this.Load += new System.EventHandler(this.PracStan_Load);
            this.TextChanged += new System.EventHandler(this.txtWyszukaj_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPracStan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPracStan;
        private System.Windows.Forms.ComboBox cbStanowisko;
        private System.Windows.Forms.TextBox txtWyszukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}