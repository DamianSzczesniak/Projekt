namespace PROJEKTapp
{
    partial class Produkcja_glowny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produkcja_glowny));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitProd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Label();
            this.lblDol = new System.Windows.Forms.Label();
            this.btnEwidencja = new System.Windows.Forms.Button();
            this.btnWykorzystaneMaszyny = new System.Windows.Forms.Button();
            this.btnGabaryty = new System.Windows.Forms.Button();
            this.btnEwidencjaMaszyn = new System.Windows.Forms.Button();
            this.btnRezerwacjaMaszyn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnExitProd);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.Panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 59);
            this.panel1.TabIndex = 1;
            // 
            // btnExitProd
            // 
            this.btnExitProd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExitProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExitProd.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnExitProd.FlatAppearance.BorderSize = 0;
            this.btnExitProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitProd.Image = global::PROJEKTapp.Properties.Resources.btnExit_Image;
            this.btnExitProd.Location = new System.Drawing.Point(517, 9);
            this.btnExitProd.Name = "btnExitProd";
            this.btnExitProd.Size = new System.Drawing.Size(71, 42);
            this.btnExitProd.TabIndex = 3;
            this.btnExitProd.UseVisualStyleBackColor = true;
            this.btnExitProd.Click += new System.EventHandler(this.btnExitProd_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(863, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Panel
            // 
            this.Panel.AutoSize = true;
            this.Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel.Location = new System.Drawing.Point(12, 9);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(144, 31);
            this.Panel.TabIndex = 2;
            this.Panel.Text = "Produkcja";
            // 
            // lblDol
            // 
            this.lblDol.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblDol.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblDol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDol.Location = new System.Drawing.Point(0, 266);
            this.lblDol.Name = "lblDol";
            this.lblDol.Size = new System.Drawing.Size(600, 100);
            this.lblDol.TabIndex = 3;
            // 
            // btnEwidencja
            // 
            this.btnEwidencja.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEwidencja.FlatAppearance.BorderSize = 0;
            this.btnEwidencja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEwidencja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEwidencja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEwidencja.Image = global::PROJEKTapp.Properties.Resources.btnObciazenie;
            this.btnEwidencja.Location = new System.Drawing.Point(157, 266);
            this.btnEwidencja.Margin = new System.Windows.Forms.Padding(2);
            this.btnEwidencja.Name = "btnEwidencja";
            this.btnEwidencja.Size = new System.Drawing.Size(145, 100);
            this.btnEwidencja.TabIndex = 2;
            this.btnEwidencja.Text = "Obciążenie";
            this.btnEwidencja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEwidencja.UseVisualStyleBackColor = false;
            this.btnEwidencja.Click += new System.EventHandler(this.btnEwidencja_Click);
            // 
            // btnWykorzystaneMaszyny
            // 
            this.btnWykorzystaneMaszyny.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnWykorzystaneMaszyny.FlatAppearance.BorderSize = 0;
            this.btnWykorzystaneMaszyny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWykorzystaneMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWykorzystaneMaszyny.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWykorzystaneMaszyny.Image = global::PROJEKTapp.Properties.Resources.btnMachine1;
            this.btnWykorzystaneMaszyny.Location = new System.Drawing.Point(8, 266);
            this.btnWykorzystaneMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.btnWykorzystaneMaszyny.Name = "btnWykorzystaneMaszyny";
            this.btnWykorzystaneMaszyny.Size = new System.Drawing.Size(145, 100);
            this.btnWykorzystaneMaszyny.TabIndex = 0;
            this.btnWykorzystaneMaszyny.Text = "Wykorzystane Zasoby";
            this.btnWykorzystaneMaszyny.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWykorzystaneMaszyny.UseVisualStyleBackColor = true;
            this.btnWykorzystaneMaszyny.Click += new System.EventHandler(this.btnWykorzystaneMaszyny_Click);
            // 
            // btnGabaryty
            // 
            this.btnGabaryty.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGabaryty.FlatAppearance.BorderSize = 0;
            this.btnGabaryty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGabaryty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGabaryty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGabaryty.Image = global::PROJEKTapp.Properties.Resources.btnObciazenie;
            this.btnGabaryty.Location = new System.Drawing.Point(306, 266);
            this.btnGabaryty.Margin = new System.Windows.Forms.Padding(2);
            this.btnGabaryty.Name = "btnGabaryty";
            this.btnGabaryty.Size = new System.Drawing.Size(145, 100);
            this.btnGabaryty.TabIndex = 4;
            this.btnGabaryty.Text = "Gabaryty";
            this.btnGabaryty.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGabaryty.UseVisualStyleBackColor = false;
            this.btnGabaryty.Click += new System.EventHandler(this.btnGabaryty_Click);
            // 
            // btnEwidencjaMaszyn
            // 
            this.btnEwidencjaMaszyn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEwidencjaMaszyn.FlatAppearance.BorderSize = 0;
            this.btnEwidencjaMaszyn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEwidencjaMaszyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEwidencjaMaszyn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEwidencjaMaszyn.Image = global::PROJEKTapp.Properties.Resources.btnObciazenie;
            this.btnEwidencjaMaszyn.Location = new System.Drawing.Point(455, 266);
            this.btnEwidencjaMaszyn.Margin = new System.Windows.Forms.Padding(2);
            this.btnEwidencjaMaszyn.Name = "btnEwidencjaMaszyn";
            this.btnEwidencjaMaszyn.Size = new System.Drawing.Size(145, 100);
            this.btnEwidencjaMaszyn.TabIndex = 5;
            this.btnEwidencjaMaszyn.Text = "Ewidencja";
            this.btnEwidencjaMaszyn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEwidencjaMaszyn.UseVisualStyleBackColor = false;
            this.btnEwidencjaMaszyn.Click += new System.EventHandler(this.btnEwidencjaMaszyn_Click);
            // 
            // btnRezerwacjaMaszyn
            // 
            this.btnRezerwacjaMaszyn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRezerwacjaMaszyn.FlatAppearance.BorderSize = 0;
            this.btnRezerwacjaMaszyn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezerwacjaMaszyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRezerwacjaMaszyn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRezerwacjaMaszyn.Image = global::PROJEKTapp.Properties.Resources.btnMachine1;
            this.btnRezerwacjaMaszyn.Location = new System.Drawing.Point(228, 133);
            this.btnRezerwacjaMaszyn.Margin = new System.Windows.Forms.Padding(2);
            this.btnRezerwacjaMaszyn.Name = "btnRezerwacjaMaszyn";
            this.btnRezerwacjaMaszyn.Size = new System.Drawing.Size(145, 100);
            this.btnRezerwacjaMaszyn.TabIndex = 6;
            this.btnRezerwacjaMaszyn.Text = "Rezerwacja Maszyn";
            this.btnRezerwacjaMaszyn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRezerwacjaMaszyn.UseVisualStyleBackColor = true;
            this.btnRezerwacjaMaszyn.Click += new System.EventHandler(this.btnRezerwacjaMaszyn_Click);
            // 
            // Produkcja_glowny
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnRezerwacjaMaszyn);
            this.Controls.Add(this.btnEwidencjaMaszyn);
            this.Controls.Add(this.btnGabaryty);
            this.Controls.Add(this.btnEwidencja);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnWykorzystaneMaszyny);
            this.Controls.Add(this.lblDol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Produkcja_glowny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkcja_glowny";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWykorzystaneMaszyny;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Panel;
        private System.Windows.Forms.Button btnExitProd;
        private System.Windows.Forms.Button btnEwidencja;
        private System.Windows.Forms.Label lblDol;
        private System.Windows.Forms.Button btnGabaryty;
        private System.Windows.Forms.Button btnEwidencjaMaszyn;
        private System.Windows.Forms.Button btnRezerwacjaMaszyn;
    }
}