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
            ((System.ComponentModel.ISupportInitialize)(this.GridWykorzystaneMaszyny)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitWykorzystaneMaszyny
            // 
            this.btnExitWykorzystaneMaszyny.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExitWykorzystaneMaszyny.Image = global::PROJEKTapp.Properties.Resources.btnExit_Image;
            this.btnExitWykorzystaneMaszyny.Location = new System.Drawing.Point(721, 12);
            this.btnExitWykorzystaneMaszyny.Name = "btnExitWykorzystaneMaszyny";
            this.btnExitWykorzystaneMaszyny.Size = new System.Drawing.Size(67, 52);
            this.btnExitWykorzystaneMaszyny.TabIndex = 0;
            this.btnExitWykorzystaneMaszyny.UseVisualStyleBackColor = false;
            this.btnExitWykorzystaneMaszyny.Click += new System.EventHandler(this.btnExitWykorzystaneMaszyny_Click);
            // 
            // GridWykorzystaneMaszyny
            // 
            this.GridWykorzystaneMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridWykorzystaneMaszyny.Location = new System.Drawing.Point(111, 65);
            this.GridWykorzystaneMaszyny.Name = "GridWykorzystaneMaszyny";
            this.GridWykorzystaneMaszyny.Size = new System.Drawing.Size(596, 286);
            this.GridWykorzystaneMaszyny.TabIndex = 1;
            // 
            // lblNazwaProduktu
            // 
            this.lblNazwaProduktu.AutoSize = true;
            this.lblNazwaProduktu.Location = new System.Drawing.Point(108, 27);
            this.lblNazwaProduktu.Name = "lblNazwaProduktu";
            this.lblNazwaProduktu.Size = new System.Drawing.Size(115, 13);
            this.lblNazwaProduktu.TabIndex = 2;
            this.lblNazwaProduktu.Text = "Wpisz nazwę produktu";
            this.lblNazwaProduktu.Click += new System.EventHandler(this.lblNazwaProduktu_Click);
            // 
            // txtNazwaProduktu
            // 
            this.txtNazwaProduktu.Location = new System.Drawing.Point(229, 23);
            this.txtNazwaProduktu.Name = "txtNazwaProduktu";
            this.txtNazwaProduktu.Size = new System.Drawing.Size(100, 20);
            this.txtNazwaProduktu.TabIndex = 3;
            this.txtNazwaProduktu.TextChanged += new System.EventHandler(this.txtNazwaProduktu_TextChanged);
            // 
            // cboxWybierzTryb
            // 
            this.cboxWybierzTryb.FormattingEnabled = true;
            this.cboxWybierzTryb.Items.AddRange(new object[] {
            "Wykorzystane Maszyny",
            "Wykorzystane Narzędzia",
            "Wykorzystane Procesy"});
            this.cboxWybierzTryb.Location = new System.Drawing.Point(537, 23);
            this.cboxWybierzTryb.Name = "cboxWybierzTryb";
            this.cboxWybierzTryb.Size = new System.Drawing.Size(147, 21);
            this.cboxWybierzTryb.TabIndex = 4;
            this.cboxWybierzTryb.Text = "Wykorzystane Maszyny";
            this.cboxWybierzTryb.SelectedIndexChanged += new System.EventHandler(this.cboxWybierzTryb_SelectedIndexChanged);
            // 
            // lblTrybFiltracji
            // 
            this.lblTrybFiltracji.AutoSize = true;
            this.lblTrybFiltracji.Location = new System.Drawing.Point(434, 27);
            this.lblTrybFiltracji.Name = "lblTrybFiltracji";
            this.lblTrybFiltracji.Size = new System.Drawing.Size(97, 13);
            this.lblTrybFiltracji.TabIndex = 5;
            this.lblTrybFiltracji.Text = "Wybierz tryb filtracji";
            // 
            // FormWykorzystaneMaszyny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTrybFiltracji);
            this.Controls.Add(this.cboxWybierzTryb);
            this.Controls.Add(this.txtNazwaProduktu);
            this.Controls.Add(this.lblNazwaProduktu);
            this.Controls.Add(this.GridWykorzystaneMaszyny);
            this.Controls.Add(this.btnExitWykorzystaneMaszyny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWykorzystaneMaszyny";
            this.Text = "Form1";
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
    }
}