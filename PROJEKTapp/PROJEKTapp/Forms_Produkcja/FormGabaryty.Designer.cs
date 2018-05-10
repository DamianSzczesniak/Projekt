namespace PROJEKTapp.Forms_Produkcja
{
    partial class FormGabaryty
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
            this.btnExitGabaryty = new System.Windows.Forms.Button();
            this.GridMasaWymiar = new System.Windows.Forms.DataGridView();
            this.lblTryb = new System.Windows.Forms.Label();
            this.cboxTryb = new System.Windows.Forms.ComboBox();
            this.txtNazwaProduktu = new System.Windows.Forms.TextBox();
            this.lblNazwaProduktu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridMasaWymiar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitGabaryty
            // 
            this.btnExitGabaryty.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExitGabaryty.FlatAppearance.BorderSize = 0;
            this.btnExitGabaryty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGabaryty.Image = global::PROJEKTapp.Properties.Resources.btnExit_Image;
            this.btnExitGabaryty.Location = new System.Drawing.Point(1293, 12);
            this.btnExitGabaryty.Name = "btnExitGabaryty";
            this.btnExitGabaryty.Size = new System.Drawing.Size(67, 52);
            this.btnExitGabaryty.TabIndex = 1;
            this.btnExitGabaryty.UseVisualStyleBackColor = false;
            this.btnExitGabaryty.Click += new System.EventHandler(this.btnExitGabaryty_Click);
            // 
            // GridMasaWymiar
            // 
            this.GridMasaWymiar.AllowUserToAddRows = false;
            this.GridMasaWymiar.AllowUserToDeleteRows = false;
            this.GridMasaWymiar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMasaWymiar.Location = new System.Drawing.Point(130, 152);
            this.GridMasaWymiar.Name = "GridMasaWymiar";
            this.GridMasaWymiar.ReadOnly = true;
            this.GridMasaWymiar.Size = new System.Drawing.Size(1098, 582);
            this.GridMasaWymiar.TabIndex = 2;
            // 
            // lblTryb
            // 
            this.lblTryb.AutoSize = true;
            this.lblTryb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTryb.Location = new System.Drawing.Point(125, 74);
            this.lblTryb.Name = "lblTryb";
            this.lblTryb.Size = new System.Drawing.Size(156, 29);
            this.lblTryb.TabIndex = 7;
            this.lblTryb.Text = "Wybierz tryb";
            // 
            // cboxTryb
            // 
            this.cboxTryb.AutoCompleteCustomSource.AddRange(new string[] {
            "Masa",
            "Wymiar"});
            this.cboxTryb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxTryb.FormattingEnabled = true;
            this.cboxTryb.Items.AddRange(new object[] {
            "Masa",
            "Wymiar"});
            this.cboxTryb.Location = new System.Drawing.Point(338, 74);
            this.cboxTryb.Name = "cboxTryb";
            this.cboxTryb.Size = new System.Drawing.Size(150, 33);
            this.cboxTryb.TabIndex = 8;
            this.cboxTryb.Text = "Masa";
            this.cboxTryb.SelectedIndexChanged += new System.EventHandler(this.cboxTryb_SelectedIndexChanged);
            // 
            // txtNazwaProduktu
            // 
            this.txtNazwaProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaProduktu.Location = new System.Drawing.Point(1050, 72);
            this.txtNazwaProduktu.Name = "txtNazwaProduktu";
            this.txtNazwaProduktu.Size = new System.Drawing.Size(178, 31);
            this.txtNazwaProduktu.TabIndex = 10;
            this.txtNazwaProduktu.TextChanged += new System.EventHandler(this.txtNazwaProduktu_TextChanged);
            // 
            // lblNazwaProduktu
            // 
            this.lblNazwaProduktu.AutoSize = true;
            this.lblNazwaProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaProduktu.Location = new System.Drawing.Point(702, 74);
            this.lblNazwaProduktu.Name = "lblNazwaProduktu";
            this.lblNazwaProduktu.Size = new System.Drawing.Size(273, 29);
            this.lblNazwaProduktu.TabIndex = 11;
            this.lblNazwaProduktu.Text = "Wpisz nazwe produktu";
            // 
            // FormGabaryty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblNazwaProduktu);
            this.Controls.Add(this.txtNazwaProduktu);
            this.Controls.Add(this.cboxTryb);
            this.Controls.Add(this.lblTryb);
            this.Controls.Add(this.GridMasaWymiar);
            this.Controls.Add(this.btnExitGabaryty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGabaryty";
            this.Text = "FormGabaryty";
            this.Load += new System.EventHandler(this.FormGabaryty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMasaWymiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitGabaryty;
        private System.Windows.Forms.DataGridView GridMasaWymiar;
        private System.Windows.Forms.Label lblTryb;
        private System.Windows.Forms.ComboBox cboxTryb;
        private System.Windows.Forms.TextBox txtNazwaProduktu;
        private System.Windows.Forms.Label lblNazwaProduktu;
    }
}