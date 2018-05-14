namespace PROJEKTapp.Forms
{
    partial class PrzygotowanieTransportu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Back_3 = new System.Windows.Forms.Button();
            this.TopBar_3 = new System.Windows.Forms.PictureBox();
            this.dgvTransport = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cBoxFirma = new System.Windows.Forms.ComboBox();
            this.cBoxAdress = new System.Windows.Forms.ComboBox();
            this.cBoxPojazd = new System.Windows.Forms.ComboBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iDZLECENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRODUKTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUKTYGOTOWEDOTRANSPORTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUKTYPOZOSTALEDOTRANSPORTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnWydelegujTransport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUKTYPOZOSTALEDOTRANSPORTUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = ".../Logistyka/Przygotowanie transportu";
            // 
            // Btn_Back_3
            // 
            this.Btn_Back_3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Back_3.FlatAppearance.BorderSize = 0;
            this.Btn_Back_3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Back_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back_3.Image = global::PROJEKTapp.Properties.Resources.return2;
            this.Btn_Back_3.Location = new System.Drawing.Point(0, 0);
            this.Btn_Back_3.Name = "Btn_Back_3";
            this.Btn_Back_3.Size = new System.Drawing.Size(80, 56);
            this.Btn_Back_3.TabIndex = 9;
            this.Btn_Back_3.UseVisualStyleBackColor = false;
            this.Btn_Back_3.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // TopBar_3
            // 
            this.TopBar_3.Image = global::PROJEKTapp.Properties.Resources.top_bar1;
            this.TopBar_3.Location = new System.Drawing.Point(59, 0);
            this.TopBar_3.Name = "TopBar_3";
            this.TopBar_3.Size = new System.Drawing.Size(960, 72);
            this.TopBar_3.TabIndex = 8;
            this.TopBar_3.TabStop = false;
            // 
            // dgvTransport
            // 
            this.dgvTransport.AllowUserToAddRows = false;
            this.dgvTransport.AllowUserToDeleteRows = false;
            this.dgvTransport.AutoGenerateColumns = false;
            this.dgvTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDZLECENIADataGridViewTextBoxColumn,
            this.iDPRODUKTUDataGridViewTextBoxColumn,
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn,
            this.pRODUKTYGOTOWEDOTRANSPORTUDataGridViewTextBoxColumn});
            this.dgvTransport.DataSource = this.pRODUKTYPOZOSTALEDOTRANSPORTUBindingSource;
            this.dgvTransport.Location = new System.Drawing.Point(34, 179);
            this.dgvTransport.Name = "dgvTransport";
            this.dgvTransport.ReadOnly = true;
            this.dgvTransport.Size = new System.Drawing.Size(549, 387);
            this.dgvTransport.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(936, 2);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 56);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox3.Location = new System.Drawing.Point(1162, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 56);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // cBoxFirma
            // 
            this.cBoxFirma.FormattingEnabled = true;
            this.cBoxFirma.Location = new System.Drawing.Point(621, 179);
            this.cBoxFirma.Name = "cBoxFirma";
            this.cBoxFirma.Size = new System.Drawing.Size(369, 21);
            this.cBoxFirma.TabIndex = 21;
            // 
            // cBoxAdress
            // 
            this.cBoxAdress.FormattingEnabled = true;
            this.cBoxAdress.Location = new System.Drawing.Point(621, 256);
            this.cBoxAdress.Name = "cBoxAdress";
            this.cBoxAdress.Size = new System.Drawing.Size(369, 21);
            this.cBoxAdress.TabIndex = 22;
            // 
            // cBoxPojazd
            // 
            this.cBoxPojazd.FormattingEnabled = true;
            this.cBoxPojazd.Location = new System.Drawing.Point(621, 329);
            this.cBoxPojazd.Name = "cBoxPojazd";
            this.cBoxPojazd.Size = new System.Drawing.Size(369, 21);
            this.cBoxPojazd.TabIndex = 23;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLista.Location = new System.Drawing.Point(152, 155);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(264, 18);
            this.lblLista.TabIndex = 24;
            this.lblLista.Text = "Lista produktów do dostarczenia :";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirma.Location = new System.Drawing.Point(773, 155);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(61, 18);
            this.lblFirma.TabIndex = 25;
            this.lblFirma.Text = "Firma :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(773, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Adres :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(764, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pojazd :";
            // 
            // iDZLECENIADataGridViewTextBoxColumn
            // 
            this.iDZLECENIADataGridViewTextBoxColumn.DataPropertyName = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.HeaderText = "ID_ZLECENIA";
            this.iDZLECENIADataGridViewTextBoxColumn.Name = "iDZLECENIADataGridViewTextBoxColumn";
            this.iDZLECENIADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDZLECENIADataGridViewTextBoxColumn.Visible = false;
            // 
            // iDPRODUKTUDataGridViewTextBoxColumn
            // 
            this.iDPRODUKTUDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUKTU";
            this.iDPRODUKTUDataGridViewTextBoxColumn.HeaderText = "ID_PRODUKTU";
            this.iDPRODUKTUDataGridViewTextBoxColumn.Name = "iDPRODUKTUDataGridViewTextBoxColumn";
            this.iDPRODUKTUDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPRODUKTUDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAZWAPRODUKTUDataGridViewTextBoxColumn
            // 
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.DataPropertyName = "NAZWA_PRODUKTU";
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.HeaderText = "NAZWA PRODUKTU";
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.Name = "nAZWAPRODUKTUDataGridViewTextBoxColumn";
            this.nAZWAPRODUKTUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUKTYGOTOWEDOTRANSPORTUDataGridViewTextBoxColumn
            // 
            this.pRODUKTYGOTOWEDOTRANSPORTUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pRODUKTYGOTOWEDOTRANSPORTUDataGridViewTextBoxColumn.DataPropertyName = "PRODUKTY_GOTOWE_DO_TRANSPORTU";
            this.pRODUKTYGOTOWEDOTRANSPORTUDataGridViewTextBoxColumn.HeaderText = "ILOSC";
            this.pRODUKTYGOTOWEDOTRANSPORTUDataGridViewTextBoxColumn.Name = "pRODUKTYGOTOWEDOTRANSPORTUDataGridViewTextBoxColumn";
            this.pRODUKTYGOTOWEDOTRANSPORTUDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUKTYGOTOWEDOTRANSPORTUDataGridViewTextBoxColumn.Width = 63;
            // 
            // pRODUKTYPOZOSTALEDOTRANSPORTUBindingSource
            // 
            this.pRODUKTYPOZOSTALEDOTRANSPORTUBindingSource.DataSource = typeof(PROJEKTapp.PRODUKTY_POZOSTALE_DO_TRANSPORTU);
            // 
            // btnWydelegujTransport
            // 
            this.btnWydelegujTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWydelegujTransport.Location = new System.Drawing.Point(702, 449);
            this.btnWydelegujTransport.Name = "btnWydelegujTransport";
            this.btnWydelegujTransport.Size = new System.Drawing.Size(230, 61);
            this.btnWydelegujTransport.TabIndex = 28;
            this.btnWydelegujTransport.Text = "Wyślij transport";
            this.btnWydelegujTransport.UseVisualStyleBackColor = true;
            this.btnWydelegujTransport.Click += new System.EventHandler(this.btnWydelegujTransport_Click);
            // 
            // PrzygotowanieTransportu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 768);
            this.Controls.Add(this.btnWydelegujTransport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.cBoxPojazd);
            this.Controls.Add(this.cBoxAdress);
            this.Controls.Add(this.cBoxFirma);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvTransport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Back_3);
            this.Controls.Add(this.TopBar_3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrzygotowanieTransportu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przygotowanie_Transportu";
            ((System.ComponentModel.ISupportInitialize)(this.TopBar_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUKTYPOZOSTALEDOTRANSPORTUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopBar_3;
        private System.Windows.Forms.Button Btn_Back_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTransport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cBoxFirma;
        private System.Windows.Forms.ComboBox cBoxAdress;
        private System.Windows.Forms.ComboBox cBoxPojazd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZLECENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUKTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWAPRODUKTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUKTYGOTOWEDOTRANSPORTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pRODUKTYPOZOSTALEDOTRANSPORTUBindingSource;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWydelegujTransport;
    }
}