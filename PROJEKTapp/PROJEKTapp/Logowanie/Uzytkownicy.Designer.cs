namespace PROJEKTapp.Logowanie
{
    partial class Uzytkownicy
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
            this.DGW_KOnta_Uzytkownikow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_KOnta_Uzytkownikow)).BeginInit();
            this.SuspendLayout();
            // 
            // DGW_KOnta_Uzytkownikow
            // 
            this.DGW_KOnta_Uzytkownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_KOnta_Uzytkownikow.Location = new System.Drawing.Point(32, 23);
            this.DGW_KOnta_Uzytkownikow.Name = "DGW_KOnta_Uzytkownikow";
            this.DGW_KOnta_Uzytkownikow.Size = new System.Drawing.Size(463, 232);
            this.DGW_KOnta_Uzytkownikow.TabIndex = 0;
            // 
            // Uzytkownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 360);
            this.Controls.Add(this.DGW_KOnta_Uzytkownikow);
            this.Name = "Uzytkownicy";
            this.Text = "Ewidencja Kont";
            this.Load += new System.EventHandler(this.Uzytkownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_KOnta_Uzytkownikow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGW_KOnta_Uzytkownikow;
    }
}