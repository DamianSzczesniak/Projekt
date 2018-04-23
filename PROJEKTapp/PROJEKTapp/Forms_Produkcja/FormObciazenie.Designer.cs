namespace PROJEKTapp.Forms_Produkcja
{
    partial class FormObciazenie
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
            this.btnExitObciazenie = new System.Windows.Forms.Button();
            this.dateWybierzDate = new System.Windows.Forms.DateTimePicker();
            this.lblWybierzDate = new System.Windows.Forms.Label();
            this.GridObciazenie = new System.Windows.Forms.DataGridView();
            this.cboxTryb = new System.Windows.Forms.ComboBox();
            this.lblTryb = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridObciazenie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitObciazenie
            // 
            this.btnExitObciazenie.FlatAppearance.BorderSize = 0;
            this.btnExitObciazenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitObciazenie.Image = global::PROJEKTapp.Properties.Resources.btnExit_Image;
            this.btnExitObciazenie.Location = new System.Drawing.Point(727, 12);
            this.btnExitObciazenie.Name = "btnExitObciazenie";
            this.btnExitObciazenie.Size = new System.Drawing.Size(61, 62);
            this.btnExitObciazenie.TabIndex = 0;
            this.btnExitObciazenie.UseVisualStyleBackColor = true;
            this.btnExitObciazenie.Click += new System.EventHandler(this.btnExitObciazenie_Click);
            // 
            // dateWybierzDate
            // 
            this.dateWybierzDate.Location = new System.Drawing.Point(232, 29);
            this.dateWybierzDate.Name = "dateWybierzDate";
            this.dateWybierzDate.Size = new System.Drawing.Size(144, 20);
            this.dateWybierzDate.TabIndex = 1;
            this.dateWybierzDate.Value = new System.DateTime(2018, 4, 23, 0, 0, 0, 0);
            this.dateWybierzDate.ValueChanged += new System.EventHandler(this.dateWybierzDate_ValueChanged);
            // 
            // lblWybierzDate
            // 
            this.lblWybierzDate.AutoSize = true;
            this.lblWybierzDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWybierzDate.Location = new System.Drawing.Point(107, 31);
            this.lblWybierzDate.Name = "lblWybierzDate";
            this.lblWybierzDate.Size = new System.Drawing.Size(103, 17);
            this.lblWybierzDate.TabIndex = 2;
            this.lblWybierzDate.Text = "Wybierz date";
            // 
            // GridObciazenie
            // 
            this.GridObciazenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridObciazenie.Location = new System.Drawing.Point(110, 80);
            this.GridObciazenie.Name = "GridObciazenie";
            this.GridObciazenie.Size = new System.Drawing.Size(636, 374);
            this.GridObciazenie.TabIndex = 3;
            // 
            // cboxTryb
            // 
            this.cboxTryb.FormattingEnabled = true;
            this.cboxTryb.Items.AddRange(new object[] {
            "Obciążenie Maszyn",
            "Obciążenie Narzędzi"});
            this.cboxTryb.Location = new System.Drawing.Point(600, 29);
            this.cboxTryb.Name = "cboxTryb";
            this.cboxTryb.Size = new System.Drawing.Size(121, 21);
            this.cboxTryb.TabIndex = 4;
            this.cboxTryb.Text = "Obciążenie Maszyn";
            this.cboxTryb.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lblTryb
            // 
            this.lblTryb.AutoSize = true;
            this.lblTryb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTryb.Location = new System.Drawing.Point(469, 31);
            this.lblTryb.Name = "lblTryb";
            this.lblTryb.Size = new System.Drawing.Size(99, 17);
            this.lblTryb.TabIndex = 5;
            this.lblTryb.Text = "Wybierz tryb";
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(13, 60);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(24, 13);
            this.test.TabIndex = 6;
            this.test.Text = "test";
            // 
            // FormObciazenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test);
            this.Controls.Add(this.lblTryb);
            this.Controls.Add(this.cboxTryb);
            this.Controls.Add(this.GridObciazenie);
            this.Controls.Add(this.lblWybierzDate);
            this.Controls.Add(this.dateWybierzDate);
            this.Controls.Add(this.btnExitObciazenie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormObciazenie";
            this.Text = "FormObciazenie";
            this.Load += new System.EventHandler(this.FormObciazenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridObciazenie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitObciazenie;
        private System.Windows.Forms.DateTimePicker dateWybierzDate;
        private System.Windows.Forms.Label lblWybierzDate;
        private System.Windows.Forms.DataGridView GridObciazenie;
        private System.Windows.Forms.ComboBox cboxTryb;
        private System.Windows.Forms.Label lblTryb;
        private System.Windows.Forms.Label test;
    }
}