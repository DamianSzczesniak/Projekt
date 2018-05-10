namespace PROJEKTapp.Forms_Produkcja
{
    partial class FormWykorzystaneMaszyny
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
            this.btnExitWykorzystaneMaszyny = new System.Windows.Forms.Button();
            this.GridWykorzystaneMaszyny = new System.Windows.Forms.DataGridView();
            this.lblNazwaProduktu = new System.Windows.Forms.Label();
            this.txtNazwaProduktu = new System.Windows.Forms.TextBox();
            this.cboxWybierzTryb = new System.Windows.Forms.ComboBox();
            this.lblTrybFiltracji = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridWykorzystaneMaszyny)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitWykorzystaneMaszyny
            // 
            this.btnExitWykorzystaneMaszyny.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExitWykorzystaneMaszyny.FlatAppearance.BorderSize = 0;
            this.btnExitWykorzystaneMaszyny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitWykorzystaneMaszyny.Image = global::PROJEKTapp.Properties.Resources.btnExit_Image;
            this.btnExitWykorzystaneMaszyny.Location = new System.Drawing.Point(1287, 12);
            this.btnExitWykorzystaneMaszyny.Name = "btnExitWykorzystaneMaszyny";
            this.btnExitWykorzystaneMaszyny.Size = new System.Drawing.Size(67, 52);
            this.btnExitWykorzystaneMaszyny.TabIndex = 0;
            this.btnExitWykorzystaneMaszyny.UseVisualStyleBackColor = false;
            this.btnExitWykorzystaneMaszyny.Click += new System.EventHandler(this.btnExitWykorzystaneMaszyny_Click);
            // 
            // GridWykorzystaneMaszyny
            // 
            this.GridWykorzystaneMaszyny.AllowUserToAddRows = false;
            this.GridWykorzystaneMaszyny.AllowUserToDeleteRows = false;
            this.GridWykorzystaneMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridWykorzystaneMaszyny.Location = new System.Drawing.Point(130, 152);
            this.GridWykorzystaneMaszyny.Name = "GridWykorzystaneMaszyny";
            this.GridWykorzystaneMaszyny.ReadOnly = true;
            this.GridWykorzystaneMaszyny.Size = new System.Drawing.Size(1098, 582);
            this.GridWykorzystaneMaszyny.TabIndex = 1;
            // 
            // lblNazwaProduktu
            // 
            this.lblNazwaProduktu.AutoSize = true;
            this.lblNazwaProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaProduktu.Location = new System.Drawing.Point(125, 72);
            this.lblNazwaProduktu.Name = "lblNazwaProduktu";
            this.lblNazwaProduktu.Size = new System.Drawing.Size(273, 29);
            this.lblNazwaProduktu.TabIndex = 2;
            this.lblNazwaProduktu.Text = "Wpisz nazwę produktu";
            // 
            // txtNazwaProduktu
            // 
            this.txtNazwaProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaProduktu.Location = new System.Drawing.Point(417, 72);
            this.txtNazwaProduktu.Name = "txtNazwaProduktu";
            this.txtNazwaProduktu.Size = new System.Drawing.Size(168, 31);
            this.txtNazwaProduktu.TabIndex = 3;
            this.txtNazwaProduktu.TextChanged += new System.EventHandler(this.txtNazwaProduktu_TextChanged);
            // 
            // cboxWybierzTryb
            // 
            this.cboxWybierzTryb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxWybierzTryb.FormattingEnabled = true;
            this.cboxWybierzTryb.Items.AddRange(new object[] {
            "Wykorzystane Maszyny",
            "Wykorzystane Narzędzia",
            "Wykorzystane Procesy"});
            this.cboxWybierzTryb.Location = new System.Drawing.Point(973, 72);
            this.cboxWybierzTryb.Name = "cboxWybierzTryb";
            this.cboxWybierzTryb.Size = new System.Drawing.Size(255, 33);
            this.cboxWybierzTryb.TabIndex = 4;
            this.cboxWybierzTryb.Text = "Wykorzystane Maszyny";
            this.cboxWybierzTryb.SelectedIndexChanged += new System.EventHandler(this.cboxWybierzTryb_SelectedIndexChanged);
            // 
            // lblTrybFiltracji
            // 
            this.lblTrybFiltracji.AutoSize = true;
            this.lblTrybFiltracji.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrybFiltracji.Location = new System.Drawing.Point(709, 72);
            this.lblTrybFiltracji.Name = "lblTrybFiltracji";
            this.lblTrybFiltracji.Size = new System.Drawing.Size(241, 29);
            this.lblTrybFiltracji.TabIndex = 5;
            this.lblTrybFiltracji.Text = "Wybierz tryb filtracji";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PROJEKTapp.Properties.Resources.btnExit_Image;
            this.button1.Location = new System.Drawing.Point(1214, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 52);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormWykorzystaneMaszyny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTrybFiltracji);
            this.Controls.Add(this.cboxWybierzTryb);
            this.Controls.Add(this.txtNazwaProduktu);
            this.Controls.Add(this.lblNazwaProduktu);
            this.Controls.Add(this.GridWykorzystaneMaszyny);
            this.Controls.Add(this.btnExitWykorzystaneMaszyny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWykorzystaneMaszyny";
            this.Text = "WYKORZYSTANE MASZYNY";
            this.Load += new System.EventHandler(this.FormWykorzystaneMaszyny_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridWykorzystaneMaszyny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitWykorzystaneMaszyny;
        private System.Windows.Forms.DataGridView GridWykorzystaneMaszyny;
        private System.Windows.Forms.Label lblNazwaProduktu;
        private System.Windows.Forms.TextBox txtNazwaProduktu;
        private System.Windows.Forms.ComboBox cboxWybierzTryb;
        private System.Windows.Forms.Label lblTrybFiltracji;
        private System.Windows.Forms.Button button1;
    }
}