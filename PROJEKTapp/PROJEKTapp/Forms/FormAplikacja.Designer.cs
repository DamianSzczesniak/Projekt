namespace PROJEKTapp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FormAplikacja = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZlecenia = new System.Windows.Forms.Button();
            this.btnStatusyZlecen = new System.Windows.Forms.Button();
            this.btnProdukcja = new System.Windows.Forms.Button();
            this.btnKadry = new System.Windows.Forms.Button();
            this.btnNoweZlecenie = new System.Windows.Forms.Button();
            this.btnLogistyka = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.FormAplikacja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FormAplikacja
            // 
            this.FormAplikacja.BackColor = System.Drawing.SystemColors.HotTrack;
            this.FormAplikacja.Controls.Add(this.Btn_Back);
            this.FormAplikacja.Controls.Add(this.label2);
            this.FormAplikacja.Controls.Add(this.pictureBox1);
            this.FormAplikacja.Controls.Add(this.button1);
            this.FormAplikacja.Controls.Add(this.label1);
            this.FormAplikacja.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormAplikacja.Location = new System.Drawing.Point(0, 0);
            this.FormAplikacja.Name = "FormAplikacja";
            this.FormAplikacja.Size = new System.Drawing.Size(872, 152);
            this.FormAplikacja.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Management System Version 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(741, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 94);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(242, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "STAL TECH";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.btnZlecenia);
            this.panel2.Controls.Add(this.btnStatusyZlecen);
            this.panel2.Controls.Add(this.btnProdukcja);
            this.panel2.Controls.Add(this.btnKadry);
            this.panel2.Controls.Add(this.btnNoweZlecenie);
            this.panel2.Controls.Add(this.btnLogistyka);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 298);
            this.panel2.TabIndex = 1;
            // 
            // btnZlecenia
            // 
            this.btnZlecenia.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnZlecenia.FlatAppearance.BorderSize = 0;
            this.btnZlecenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZlecenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZlecenia.ForeColor = System.Drawing.SystemColors.Control;
            this.btnZlecenia.Image = ((System.Drawing.Image)(resources.GetObject("btnZlecenia.Image")));
            this.btnZlecenia.Location = new System.Drawing.Point(-1, 0);
            this.btnZlecenia.Name = "btnZlecenia";
            this.btnZlecenia.Size = new System.Drawing.Size(225, 69);
            this.btnZlecenia.TabIndex = 6;
            this.btnZlecenia.Text = "ZLECENIA";
            this.btnZlecenia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZlecenia.UseVisualStyleBackColor = true;
            this.btnZlecenia.Click += new System.EventHandler(this.btnZlecenia_Click);
            // 
            // btnStatusyZlecen
            // 
            this.btnStatusyZlecen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStatusyZlecen.FlatAppearance.BorderSize = 0;
            this.btnStatusyZlecen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusyZlecen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusyZlecen.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStatusyZlecen.Image = ((System.Drawing.Image)(resources.GetObject("btnStatusyZlecen.Image")));
            this.btnStatusyZlecen.Location = new System.Drawing.Point(0, 0);
            this.btnStatusyZlecen.Name = "btnStatusyZlecen";
            this.btnStatusyZlecen.Size = new System.Drawing.Size(225, 69);
            this.btnStatusyZlecen.TabIndex = 5;
            this.btnStatusyZlecen.Text = "STATUSY ZLECEN";
            this.btnStatusyZlecen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatusyZlecen.UseVisualStyleBackColor = true;
            this.btnStatusyZlecen.Click += new System.EventHandler(this.btnStatusyZlecen_Click);
            // 
            // btnProdukcja
            // 
            this.btnProdukcja.FlatAppearance.BorderSize = 0;
            this.btnProdukcja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdukcja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdukcja.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProdukcja.Image = ((System.Drawing.Image)(resources.GetObject("btnProdukcja.Image")));
            this.btnProdukcja.Location = new System.Drawing.Point(0, 222);
            this.btnProdukcja.Name = "btnProdukcja";
            this.btnProdukcja.Size = new System.Drawing.Size(224, 76);
            this.btnProdukcja.TabIndex = 4;
            this.btnProdukcja.Text = "  PRODUKCJA";
            this.btnProdukcja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdukcja.UseVisualStyleBackColor = true;
            this.btnProdukcja.Click += new System.EventHandler(this.btnProdukcja_Click);
            // 
            // btnKadry
            // 
            this.btnKadry.FlatAppearance.BorderSize = 0;
            this.btnKadry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKadry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKadry.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKadry.Image = ((System.Drawing.Image)(resources.GetObject("btnKadry.Image")));
            this.btnKadry.Location = new System.Drawing.Point(0, 151);
            this.btnKadry.Name = "btnKadry";
            this.btnKadry.Size = new System.Drawing.Size(227, 65);
            this.btnKadry.TabIndex = 3;
            this.btnKadry.Text = "  KADRY";
            this.btnKadry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKadry.UseVisualStyleBackColor = true;
            this.btnKadry.Click += new System.EventHandler(this.btnKadry_Click);
            // 
            // btnNoweZlecenie
            // 
            this.btnNoweZlecenie.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNoweZlecenie.FlatAppearance.BorderSize = 0;
            this.btnNoweZlecenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoweZlecenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoweZlecenie.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNoweZlecenie.Image = ((System.Drawing.Image)(resources.GetObject("btnNoweZlecenie.Image")));
            this.btnNoweZlecenie.Location = new System.Drawing.Point(3, 0);
            this.btnNoweZlecenie.Name = "btnNoweZlecenie";
            this.btnNoweZlecenie.Size = new System.Drawing.Size(225, 69);
            this.btnNoweZlecenie.TabIndex = 2;
            this.btnNoweZlecenie.Text = "NOWE ZLECENIE";
            this.btnNoweZlecenie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNoweZlecenie.UseVisualStyleBackColor = false;
            this.btnNoweZlecenie.Click += new System.EventHandler(this.btnNoweZlecenie_Click);
            // 
            // btnLogistyka
            // 
            this.btnLogistyka.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogistyka.FlatAppearance.BorderSize = 0;
            this.btnLogistyka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogistyka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogistyka.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogistyka.Image = ((System.Drawing.Image)(resources.GetObject("btnLogistyka.Image")));
            this.btnLogistyka.Location = new System.Drawing.Point(2, 76);
            this.btnLogistyka.Name = "btnLogistyka";
            this.btnLogistyka.Size = new System.Drawing.Size(225, 69);
            this.btnLogistyka.TabIndex = 2;
            this.btnLogistyka.Text = "  LOGISTYKA";
            this.btnLogistyka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogistyka.UseVisualStyleBackColor = false;
            this.btnLogistyka.Click += new System.EventHandler(this.btnLogistyka_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(701, 352);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(171, 98);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(701, 257);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(171, 98);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(701, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(171, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(224, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(479, 298);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
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
            this.Btn_Back.Location = new System.Drawing.Point(792, 0);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(80, 44);
            this.Btn_Back.TabIndex = 9;
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.btnWyloguj_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FormAplikacja);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormAplikacja.ResumeLayout(false);
            this.FormAplikacja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormAplikacja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProdukcja;
        private System.Windows.Forms.Button btnKadry;
        private System.Windows.Forms.Button btnLogistyka;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNoweZlecenie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStatusyZlecen;
        private System.Windows.Forms.Button btnZlecenia;
        private System.Windows.Forms.Button Btn_Back;
    }
}

