namespace PROJEKTapp.Forms.Forms_Logistyka
{
    partial class FormListaFaktur
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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopBar_4 = new System.Windows.Forms.PictureBox();
            this.dataGridView_lista_faktur = new System.Windows.Forms.DataGridView();
            this.Btn_Back_5 = new System.Windows.Forms.Button();
            this.ckcBZaplacono = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lista_faktur)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox6.Location = new System.Drawing.Point(1162, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(204, 56);
            this.pictureBox6.TabIndex = 58;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(204, 56);
            this.pictureBox5.TabIndex = 57;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1340, 2);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = ".../Logistyka/Kreator faktur";
            // 
            // TopBar_4
            // 
            this.TopBar_4.Image = global::PROJEKTapp.Properties.Resources.top_bar1;
            this.TopBar_4.Location = new System.Drawing.Point(204, 0);
            this.TopBar_4.Name = "TopBar_4";
            this.TopBar_4.Size = new System.Drawing.Size(960, 72);
            this.TopBar_4.TabIndex = 54;
            this.TopBar_4.TabStop = false;
            // 
            // dataGridView_lista_faktur
            // 
            this.dataGridView_lista_faktur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lista_faktur.Location = new System.Drawing.Point(16, 117);
            this.dataGridView_lista_faktur.Name = "dataGridView_lista_faktur";
            this.dataGridView_lista_faktur.Size = new System.Drawing.Size(1338, 573);
            this.dataGridView_lista_faktur.TabIndex = 59;
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
            this.Btn_Back_5.TabIndex = 63;
            this.Btn_Back_5.UseVisualStyleBackColor = false;
            this.Btn_Back_5.Click += new System.EventHandler(this.Btn_Back_5_Click);
            // 
            // ckcBZaplacono
            // 
            this.ckcBZaplacono.AutoSize = true;
            this.ckcBZaplacono.Location = new System.Drawing.Point(600, 79);
            this.ckcBZaplacono.Name = "ckcBZaplacono";
            this.ckcBZaplacono.Size = new System.Drawing.Size(123, 17);
            this.ckcBZaplacono.TabIndex = 64;
            this.ckcBZaplacono.Text = "Tylko nie zapłacone";
            this.ckcBZaplacono.UseVisualStyleBackColor = true;
            this.ckcBZaplacono.CheckedChanged += new System.EventHandler(this.ckcBZaplacono_CheckedChanged);
            // 
            // FormListaFaktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 768);
            this.Controls.Add(this.ckcBZaplacono);
            this.Controls.Add(this.Btn_Back_5);
            this.Controls.Add(this.dataGridView_lista_faktur);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopBar_4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListaFaktur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListaFaktur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lista_faktur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox TopBar_4;
        private System.Windows.Forms.DataGridView dataGridView_lista_faktur;
        private System.Windows.Forms.Button Btn_Back_5;
        private System.Windows.Forms.CheckBox ckcBZaplacono;
    }
}