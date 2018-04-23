namespace PROJEKTapp.Forms
{
    partial class FormFirmyNoweZlecenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirmyNoweZlecenie));
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridFirmy = new System.Windows.Forms.DataGridView();
            this.lblFirmy = new System.Windows.Forms.Label();
            this.lblWyszukaj = new System.Windows.Forms.Label();
            this.txtBoxWyszukajFirme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFirmy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(639, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridFirmy
            // 
            this.dataGridFirmy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFirmy.Location = new System.Drawing.Point(20, 83);
            this.dataGridFirmy.Name = "dataGridFirmy";
            this.dataGridFirmy.Size = new System.Drawing.Size(645, 309);
            this.dataGridFirmy.TabIndex = 7;
            // 
            // lblFirmy
            // 
            this.lblFirmy.AutoSize = true;
            this.lblFirmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirmy.Location = new System.Drawing.Point(16, 56);
            this.lblFirmy.Name = "lblFirmy";
            this.lblFirmy.Size = new System.Drawing.Size(117, 24);
            this.lblFirmy.TabIndex = 8;
            this.lblFirmy.Text = "Dane Firmy";
            // 
            // lblWyszukaj
            // 
            this.lblWyszukaj.AutoSize = true;
            this.lblWyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWyszukaj.Location = new System.Drawing.Point(184, 20);
            this.lblWyszukaj.Name = "lblWyszukaj";
            this.lblWyszukaj.Size = new System.Drawing.Size(142, 20);
            this.lblWyszukaj.TabIndex = 9;
            this.lblWyszukaj.Text = "Wyszukaj Nazwe";
            // 
            // txtBoxWyszukajFirme
            // 
            this.txtBoxWyszukajFirme.Location = new System.Drawing.Point(332, 20);
            this.txtBoxWyszukajFirme.Name = "txtBoxWyszukajFirme";
            this.txtBoxWyszukajFirme.Size = new System.Drawing.Size(144, 20);
            this.txtBoxWyszukajFirme.TabIndex = 10;
            // 
            // FormFirmyNoweZlecenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 452);
            this.ControlBox = false;
            this.Controls.Add(this.txtBoxWyszukajFirme);
            this.Controls.Add(this.lblWyszukaj);
            this.Controls.Add(this.lblFirmy);
            this.Controls.Add(this.dataGridFirmy);
            this.Controls.Add(this.btnExit);
            this.Name = "FormFirmyNoweZlecenie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFirmy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridFirmy;
        private System.Windows.Forms.Label lblFirmy;
        private System.Windows.Forms.Label lblWyszukaj;
        private System.Windows.Forms.TextBox txtBoxWyszukajFirme;
    }
}