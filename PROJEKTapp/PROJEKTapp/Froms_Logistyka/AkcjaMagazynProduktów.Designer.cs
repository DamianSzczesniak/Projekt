namespace PROJEKTapp.Froms_Logistyka
{
    partial class AkcjaMagazynProduktów
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
            this.lblItem = new System.Windows.Forms.Label();
            this.lblLokalizacja = new System.Windows.Forms.Label();
            this.lblIlosc = new System.Windows.Forms.Label();
            this.lblRodzajAkcji = new System.Windows.Forms.Label();
            this.lblPrzypisaneZlecenie = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.cBoxSurPro = new System.Windows.Forms.ComboBox();
            this.cBoxLokalizacja = new System.Windows.Forms.ComboBox();
            this.txtBoxIlosc = new System.Windows.Forms.TextBox();
            this.cBoxPrzypisaneZlecenie = new System.Windows.Forms.ComboBox();
            this.txtBoxRAkcji = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(27, 27);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(86, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "chcBoxDepends";
            // 
            // lblLokalizacja
            // 
            this.lblLokalizacja.AutoSize = true;
            this.lblLokalizacja.Location = new System.Drawing.Point(27, 195);
            this.lblLokalizacja.Name = "lblLokalizacja";
            this.lblLokalizacja.Size = new System.Drawing.Size(66, 13);
            this.lblLokalizacja.TabIndex = 1;
            this.lblLokalizacja.Text = "Lokalizacja :";
            // 
            // lblIlosc
            // 
            this.lblIlosc.AutoSize = true;
            this.lblIlosc.Location = new System.Drawing.Point(27, 139);
            this.lblIlosc.Name = "lblIlosc";
            this.lblIlosc.Size = new System.Drawing.Size(35, 13);
            this.lblIlosc.TabIndex = 2;
            this.lblIlosc.Text = "Ilośc :";
            // 
            // lblRodzajAkcji
            // 
            this.lblRodzajAkcji.AutoSize = true;
            this.lblRodzajAkcji.Location = new System.Drawing.Point(28, 83);
            this.lblRodzajAkcji.Name = "lblRodzajAkcji";
            this.lblRodzajAkcji.Size = new System.Drawing.Size(72, 13);
            this.lblRodzajAkcji.TabIndex = 3;
            this.lblRodzajAkcji.Text = "Rodzaj Akcji :";
            // 
            // lblPrzypisaneZlecenie
            // 
            this.lblPrzypisaneZlecenie.AutoSize = true;
            this.lblPrzypisaneZlecenie.Location = new System.Drawing.Point(27, 251);
            this.lblPrzypisaneZlecenie.Name = "lblPrzypisaneZlecenie";
            this.lblPrzypisaneZlecenie.Size = new System.Drawing.Size(108, 13);
            this.lblPrzypisaneZlecenie.TabIndex = 4;
            this.lblPrzypisaneZlecenie.Text = "Przypisane Zlecenie :";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(122, 297);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 5;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            // 
            // cBoxSurPro
            // 
            this.cBoxSurPro.FormattingEnabled = true;
            this.cBoxSurPro.Location = new System.Drawing.Point(146, 24);
            this.cBoxSurPro.Name = "cBoxSurPro";
            this.cBoxSurPro.Size = new System.Drawing.Size(152, 21);
            this.cBoxSurPro.TabIndex = 8;
            // 
            // cBoxLokalizacja
            // 
            this.cBoxLokalizacja.FormattingEnabled = true;
            this.cBoxLokalizacja.Location = new System.Drawing.Point(147, 191);
            this.cBoxLokalizacja.Name = "cBoxLokalizacja";
            this.cBoxLokalizacja.Size = new System.Drawing.Size(152, 21);
            this.cBoxLokalizacja.TabIndex = 9;
            // 
            // txtBoxIlosc
            // 
            this.txtBoxIlosc.Location = new System.Drawing.Point(146, 136);
            this.txtBoxIlosc.Name = "txtBoxIlosc";
            this.txtBoxIlosc.Size = new System.Drawing.Size(152, 20);
            this.txtBoxIlosc.TabIndex = 11;
            // 
            // cBoxPrzypisaneZlecenie
            // 
            this.cBoxPrzypisaneZlecenie.FormattingEnabled = true;
            this.cBoxPrzypisaneZlecenie.Location = new System.Drawing.Point(146, 247);
            this.cBoxPrzypisaneZlecenie.Name = "cBoxPrzypisaneZlecenie";
            this.cBoxPrzypisaneZlecenie.Size = new System.Drawing.Size(152, 21);
            this.cBoxPrzypisaneZlecenie.TabIndex = 12;
            // 
            // txtBoxRAkcji
            // 
            this.txtBoxRAkcji.Location = new System.Drawing.Point(147, 80);
            this.txtBoxRAkcji.Name = "txtBoxRAkcji";
            this.txtBoxRAkcji.ReadOnly = true;
            this.txtBoxRAkcji.Size = new System.Drawing.Size(151, 20);
            this.txtBoxRAkcji.TabIndex = 13;
            // 
            // AkcjaMagazynProduktów
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 332);
            this.Controls.Add(this.txtBoxRAkcji);
            this.Controls.Add(this.cBoxPrzypisaneZlecenie);
            this.Controls.Add(this.txtBoxIlosc);
            this.Controls.Add(this.cBoxLokalizacja);
            this.Controls.Add(this.cBoxSurPro);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.lblPrzypisaneZlecenie);
            this.Controls.Add(this.lblRodzajAkcji);
            this.Controls.Add(this.lblIlosc);
            this.Controls.Add(this.lblLokalizacja);
            this.Controls.Add(this.lblItem);
            this.Name = "AkcjaMagazynProduktów";
            this.Text = "AkcjaMagazynProduktów";
            this.Load += new System.EventHandler(this.AkcjaMagazynProduktów_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblLokalizacja;
        private System.Windows.Forms.Label lblIlosc;
        private System.Windows.Forms.Label lblRodzajAkcji;
        private System.Windows.Forms.Label lblPrzypisaneZlecenie;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.ComboBox cBoxSurPro;
        private System.Windows.Forms.ComboBox cBoxLokalizacja;
        private System.Windows.Forms.TextBox txtBoxIlosc;
        private System.Windows.Forms.ComboBox cBoxPrzypisaneZlecenie;
        private System.Windows.Forms.TextBox txtBoxRAkcji;
    }
}