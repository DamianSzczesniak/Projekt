namespace PROJEKTapp
{
    partial class ZleceniaPosredniczacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZleceniaPosredniczacy));
            this.btnStatusyZlecen = new System.Windows.Forms.Button();
            this.btnNoweZlecenie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStatusyZlecen
            // 
            this.btnStatusyZlecen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStatusyZlecen.FlatAppearance.BorderSize = 0;
            this.btnStatusyZlecen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusyZlecen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusyZlecen.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStatusyZlecen.Image = ((System.Drawing.Image)(resources.GetObject("btnStatusyZlecen.Image")));
            this.btnStatusyZlecen.Location = new System.Drawing.Point(1, 75);
            this.btnStatusyZlecen.Name = "btnStatusyZlecen";
            this.btnStatusyZlecen.Size = new System.Drawing.Size(225, 69);
            this.btnStatusyZlecen.TabIndex = 6;
            this.btnStatusyZlecen.Text = "STATUSY ZLECEN";
            this.btnStatusyZlecen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatusyZlecen.UseVisualStyleBackColor = true;
            this.btnStatusyZlecen.Click += new System.EventHandler(this.btnStatusyZlecen_Click);
            // 
            // btnNoweZlecenie
            // 
            this.btnNoweZlecenie.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNoweZlecenie.FlatAppearance.BorderSize = 0;
            this.btnNoweZlecenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoweZlecenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoweZlecenie.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNoweZlecenie.Image = ((System.Drawing.Image)(resources.GetObject("btnNoweZlecenie.Image")));
            this.btnNoweZlecenie.Location = new System.Drawing.Point(1, 0);
            this.btnNoweZlecenie.Name = "btnNoweZlecenie";
            this.btnNoweZlecenie.Size = new System.Drawing.Size(225, 69);
            this.btnNoweZlecenie.TabIndex = 7;
            this.btnNoweZlecenie.Text = "NOWE ZLECENIE";
            this.btnNoweZlecenie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNoweZlecenie.UseVisualStyleBackColor = false;
            this.btnNoweZlecenie.Click += new System.EventHandler(this.btnNoweZlecenie_Click);
            // 
            // ZleceniaPosredniczacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(229, 146);
            this.Controls.Add(this.btnNoweZlecenie);
            this.Controls.Add(this.btnStatusyZlecen);
            this.Name = "ZleceniaPosredniczacy";
            this.Text = "ZleceniaPosredniczacy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStatusyZlecen;
        private System.Windows.Forms.Button btnNoweZlecenie;
    }
}