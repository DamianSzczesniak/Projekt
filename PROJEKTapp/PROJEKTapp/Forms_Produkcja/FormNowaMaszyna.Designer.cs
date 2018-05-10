namespace PROJEKTapp.Forms_Produkcja
{
    partial class FormNowaMaszyna
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WyczyscDane = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DodajMaszyne = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPosuw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCenazaH = new System.Windows.Forms.TextBox();
            this.textBoxTypMaszyny = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxPredkosc = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(51, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cena za godzinę";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(52, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Marka";
            // 
            // WyczyscDane
            // 
            this.WyczyscDane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WyczyscDane.Location = new System.Drawing.Point(448, 385);
            this.WyczyscDane.Name = "WyczyscDane";
            this.WyczyscDane.Size = new System.Drawing.Size(196, 98);
            this.WyczyscDane.TabIndex = 27;
            this.WyczyscDane.Text = "Wyczyść dane";
            this.WyczyscDane.UseVisualStyleBackColor = true;
            this.WyczyscDane.Click += new System.EventHandler(this.WyczyscDane_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(51, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Typ maszyny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(52, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Model";
            // 
            // DodajMaszyne
            // 
            this.DodajMaszyne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DodajMaszyne.Location = new System.Drawing.Point(185, 385);
            this.DodajMaszyne.Name = "DodajMaszyne";
            this.DodajMaszyne.Size = new System.Drawing.Size(196, 98);
            this.DodajMaszyne.TabIndex = 28;
            this.DodajMaszyne.Text = "Zapisz";
            this.DodajMaszyne.UseVisualStyleBackColor = true;
            this.DodajMaszyne.Click += new System.EventHandler(this.DodajMaszyne_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(52, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Predkość";
            // 
            // textBoxPosuw
            // 
            this.textBoxPosuw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPosuw.Location = new System.Drawing.Point(185, 266);
            this.textBoxPosuw.Name = "textBoxPosuw";
            this.textBoxPosuw.Size = new System.Drawing.Size(459, 26);
            this.textBoxPosuw.TabIndex = 21;
            this.textBoxPosuw.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(52, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Posuw";
            // 
            // textBoxCenazaH
            // 
            this.textBoxCenazaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCenazaH.Location = new System.Drawing.Point(185, 315);
            this.textBoxCenazaH.Name = "textBoxCenazaH";
            this.textBoxCenazaH.Size = new System.Drawing.Size(458, 26);
            this.textBoxCenazaH.TabIndex = 22;
            this.textBoxCenazaH.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxTypMaszyny
            // 
            this.textBoxTypMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTypMaszyny.Location = new System.Drawing.Point(185, 157);
            this.textBoxTypMaszyny.Name = "textBoxTypMaszyny";
            this.textBoxTypMaszyny.Size = new System.Drawing.Size(459, 26);
            this.textBoxTypMaszyny.TabIndex = 23;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxModel.Location = new System.Drawing.Point(185, 63);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(459, 26);
            this.textBoxModel.TabIndex = 26;
            // 
            // textBoxPredkosc
            // 
            this.textBoxPredkosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPredkosc.Location = new System.Drawing.Point(185, 210);
            this.textBoxPredkosc.Name = "textBoxPredkosc";
            this.textBoxPredkosc.Size = new System.Drawing.Size(459, 26);
            this.textBoxPredkosc.TabIndex = 24;
            this.textBoxPredkosc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxMarka.Location = new System.Drawing.Point(185, 108);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(459, 26);
            this.textBoxMarka.TabIndex = 25;
            // 
            // FormNowaMaszyna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WyczyscDane);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DodajMaszyne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPosuw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCenazaH);
            this.Controls.Add(this.textBoxTypMaszyny);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxPredkosc);
            this.Controls.Add(this.textBoxMarka);
            this.Name = "FormNowaMaszyna";
            this.Text = "FormNowaMaszyna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WyczyscDane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DodajMaszyne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPosuw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCenazaH;
        private System.Windows.Forms.TextBox textBoxTypMaszyny;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxPredkosc;
        private System.Windows.Forms.TextBox textBoxMarka;
    }
}