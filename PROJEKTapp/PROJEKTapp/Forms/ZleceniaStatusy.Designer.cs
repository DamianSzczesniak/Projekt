namespace PROJEKTapp
{
    partial class ZleceniaStatusy
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
            this.StatusZleceniaDGV = new System.Windows.Forms.DataGridView();
            this.zleceniaStatusyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StatusZleceniaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zleceniaStatusyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusZleceniaDGV
            // 
            this.StatusZleceniaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatusZleceniaDGV.Location = new System.Drawing.Point(82, 58);
            this.StatusZleceniaDGV.Name = "StatusZleceniaDGV";
            this.StatusZleceniaDGV.Size = new System.Drawing.Size(413, 299);
            this.StatusZleceniaDGV.TabIndex = 0;
            // 
            // zleceniaStatusyBindingSource
            // 
            this.zleceniaStatusyBindingSource.DataSource = typeof(PROJEKTapp.ZleceniaStatusy);
            // 
            // ZleceniaStatusy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 436);
            this.Controls.Add(this.StatusZleceniaDGV);
            this.Name = "ZleceniaStatusy";
            this.Text = "Statusy Zleceń";
            ((System.ComponentModel.ISupportInitialize)(this.StatusZleceniaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zleceniaStatusyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StatusZleceniaDGV;
        private System.Windows.Forms.BindingSource zleceniaStatusyBindingSource;
    }
}