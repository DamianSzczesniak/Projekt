namespace PROJEKTapp.Forms_Produkcja
{
    partial class FormNoweNarzedzie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCenaZaH = new System.Windows.Forms.TextBox();
            this.textBoxNrEwidencyjny = new System.Windows.Forms.TextBox();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxCenaZaH);
            this.panel1.Controls.Add(this.textBoxNrEwidencyjny);
            this.panel1.Controls.Add(this.textBoxNazwa);
            this.panel1.Controls.Add(this.textBoxModel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(445, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 87);
            this.button3.TabIndex = 11;
            this.button3.Text = "Wyczyść dane";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(198, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 87);
            this.button2.TabIndex = 10;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(56, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Koszt za godzinę";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(56, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(56, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nr Ewidencyjny";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(56, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Model";
            // 
            // textBoxCenaZaH
            // 
            this.textBoxCenaZaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCenaZaH.Location = new System.Drawing.Point(198, 296);
            this.textBoxCenaZaH.Name = "textBoxCenaZaH";
            this.textBoxCenaZaH.Size = new System.Drawing.Size(441, 26);
            this.textBoxCenaZaH.TabIndex = 6;
            this.textBoxCenaZaH.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxNrEwidencyjny
            // 
            this.textBoxNrEwidencyjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNrEwidencyjny.Location = new System.Drawing.Point(198, 216);
            this.textBoxNrEwidencyjny.Name = "textBoxNrEwidencyjny";
            this.textBoxNrEwidencyjny.Size = new System.Drawing.Size(441, 26);
            this.textBoxNrEwidencyjny.TabIndex = 7;
            this.textBoxNrEwidencyjny.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNazwa.Location = new System.Drawing.Point(198, 60);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(441, 26);
            this.textBoxNazwa.TabIndex = 8;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxModel.Location = new System.Drawing.Point(198, 135);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(441, 26);
            this.textBoxModel.TabIndex = 9;
            // 
            // FormNoweNarzedzie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Name = "FormNoweNarzedzie";
            this.Text = "FormNoweNarzedzie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCenaZaH;
        private System.Windows.Forms.TextBox textBoxNrEwidencyjny;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}