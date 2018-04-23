namespace PROJEKTapp
{
    partial class FormWykazPracownikow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWykazPracownikow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.ListaPracownikow = new System.Windows.Forms.DataGridView();
            this.txtWyszukajNazwisko = new System.Windows.Forms.TextBox();
            this.btnZaktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.LWyszukaj = new System.Windows.Forms.Label();
            this.btnZaktualizaujZapisz = new System.Windows.Forms.Button();
            this.cbStanowisko = new System.Windows.Forms.ComboBox();
            this.cbMiasto = new System.Windows.Forms.ComboBox();
            this.txtDataRozpoczeciaPracy = new System.Windows.Forms.DateTimePicker();
            this.lblDataStart = new System.Windows.Forms.Label();
            this.lblMiasto = new System.Windows.Forms.Label();
            this.txtboxKraj = new System.Windows.Forms.TextBox();
            this.lblKraj = new System.Windows.Forms.Label();
            this.txtboxKodpocztowy = new System.Windows.Forms.TextBox();
            this.lblKodpocztowy = new System.Windows.Forms.Label();
            this.txtboxNrlokalu = new System.Windows.Forms.TextBox();
            this.lblNrlokalu = new System.Windows.Forms.Label();
            this.txtNrbudynku = new System.Windows.Forms.TextBox();
            this.lblNrbudynku = new System.Windows.Forms.Label();
            this.txtboxUlica = new System.Windows.Forms.TextBox();
            this.lblUlica = new System.Windows.Forms.Label();
            this.lblStanowisko = new System.Windows.Forms.Label();
            this.txtboxPesel = new System.Windows.Forms.TextBox();
            this.lblPesel = new System.Windows.Forms.Label();
            this.txtboxTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtboxNazwisko = new System.Windows.Forms.TextBox();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.txtboxImie = new System.Windows.Forms.TextBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.btnDodajZapisz = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPracownikow)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(733, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 507);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 36);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj Pracownika";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ListaPracownikow
            // 
            this.ListaPracownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPracownikow.Location = new System.Drawing.Point(12, 109);
            this.ListaPracownikow.Name = "ListaPracownikow";
            this.ListaPracownikow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaPracownikow.Size = new System.Drawing.Size(776, 392);
            this.ListaPracownikow.TabIndex = 14;
            // 
            // txtWyszukajNazwisko
            // 
            this.txtWyszukajNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWyszukajNazwisko.Location = new System.Drawing.Point(148, 77);
            this.txtWyszukajNazwisko.Name = "txtWyszukajNazwisko";
            this.txtWyszukajNazwisko.Size = new System.Drawing.Size(240, 26);
            this.txtWyszukajNazwisko.TabIndex = 15;
            this.txtWyszukajNazwisko.TextChanged += new System.EventHandler(this.txtWyszukajNazwisko_TextChanged);
            // 
            // btnZaktualizuj
            // 
            this.btnZaktualizuj.Location = new System.Drawing.Point(96, 507);
            this.btnZaktualizuj.Name = "btnZaktualizuj";
            this.btnZaktualizuj.Size = new System.Drawing.Size(75, 36);
            this.btnZaktualizuj.TabIndex = 16;
            this.btnZaktualizuj.Text = "Edytuj Dane";
            this.btnZaktualizuj.UseVisualStyleBackColor = true;
            this.btnZaktualizuj.Click += new System.EventHandler(this.btnZaktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(177, 507);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 36);
            this.btnUsun.TabIndex = 17;
            this.btnUsun.Text = "Usuń Pracownika";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // LWyszukaj
            // 
            this.LWyszukaj.AutoSize = true;
            this.LWyszukaj.Location = new System.Drawing.Point(27, 85);
            this.LWyszukaj.Name = "LWyszukaj";
            this.LWyszukaj.Size = new System.Drawing.Size(102, 13);
            this.LWyszukaj.TabIndex = 18;
            this.LWyszukaj.Text = "Wyszukaj Nazwisko";
            // 
            // btnZaktualizaujZapisz
            // 
            this.btnZaktualizaujZapisz.Location = new System.Drawing.Point(529, 507);
            this.btnZaktualizaujZapisz.Name = "btnZaktualizaujZapisz";
            this.btnZaktualizaujZapisz.Size = new System.Drawing.Size(75, 36);
            this.btnZaktualizaujZapisz.TabIndex = 19;
            this.btnZaktualizaujZapisz.Text = "Zapisz";
            this.btnZaktualizaujZapisz.UseVisualStyleBackColor = true;
            this.btnZaktualizaujZapisz.Visible = false;
            this.btnZaktualizaujZapisz.Click += new System.EventHandler(this.btnZaktualizaujZapisz_Click);
            // 
            // cbStanowisko
            // 
            this.cbStanowisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbStanowisko.FormattingEnabled = true;
            this.cbStanowisko.Location = new System.Drawing.Point(518, 200);
            this.cbStanowisko.Name = "cbStanowisko";
            this.cbStanowisko.Size = new System.Drawing.Size(170, 28);
            this.cbStanowisko.TabIndex = 36;
            this.cbStanowisko.Visible = false;
            // 
            // cbMiasto
            // 
            this.cbMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMiasto.FormattingEnabled = true;
            this.cbMiasto.Location = new System.Drawing.Point(148, 420);
            this.cbMiasto.Name = "cbMiasto";
            this.cbMiasto.Size = new System.Drawing.Size(170, 28);
            this.cbMiasto.TabIndex = 42;
            this.cbMiasto.Visible = false;
            // 
            // txtDataRozpoczeciaPracy
            // 
            this.txtDataRozpoczeciaPracy.Location = new System.Drawing.Point(541, 237);
            this.txtDataRozpoczeciaPracy.Name = "txtDataRozpoczeciaPracy";
            this.txtDataRozpoczeciaPracy.Size = new System.Drawing.Size(200, 20);
            this.txtDataRozpoczeciaPracy.TabIndex = 43;
            this.txtDataRozpoczeciaPracy.Visible = false;
            // 
            // lblDataStart
            // 
            this.lblDataStart.AutoSize = true;
            this.lblDataStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataStart.Location = new System.Drawing.Point(356, 237);
            this.lblDataStart.Name = "lblDataStart";
            this.lblDataStart.Size = new System.Drawing.Size(179, 20);
            this.lblDataStart.TabIndex = 22;
            this.lblDataStart.Text = "Data rozpoczecia pracy:";
            this.lblDataStart.Visible = false;
            // 
            // lblMiasto
            // 
            this.lblMiasto.AutoSize = true;
            this.lblMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMiasto.Location = new System.Drawing.Point(37, 420);
            this.lblMiasto.Name = "lblMiasto";
            this.lblMiasto.Size = new System.Drawing.Size(60, 20);
            this.lblMiasto.TabIndex = 23;
            this.lblMiasto.Text = "Miasto:";
            this.lblMiasto.Visible = false;
            // 
            // txtboxKraj
            // 
            this.txtboxKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxKraj.Location = new System.Drawing.Point(148, 454);
            this.txtboxKraj.Name = "txtboxKraj";
            this.txtboxKraj.Size = new System.Drawing.Size(170, 26);
            this.txtboxKraj.TabIndex = 41;
            this.txtboxKraj.Text = "Polska";
            this.txtboxKraj.Visible = false;
            // 
            // lblKraj
            // 
            this.lblKraj.AutoSize = true;
            this.lblKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKraj.Location = new System.Drawing.Point(37, 454);
            this.lblKraj.Name = "lblKraj";
            this.lblKraj.Size = new System.Drawing.Size(40, 20);
            this.lblKraj.TabIndex = 25;
            this.lblKraj.Text = "Kraj:";
            this.lblKraj.Visible = false;
            // 
            // txtboxKodpocztowy
            // 
            this.txtboxKodpocztowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxKodpocztowy.Location = new System.Drawing.Point(148, 388);
            this.txtboxKodpocztowy.Name = "txtboxKodpocztowy";
            this.txtboxKodpocztowy.Size = new System.Drawing.Size(170, 26);
            this.txtboxKodpocztowy.TabIndex = 40;
            this.txtboxKodpocztowy.Visible = false;
            // 
            // lblKodpocztowy
            // 
            this.lblKodpocztowy.AutoSize = true;
            this.lblKodpocztowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKodpocztowy.Location = new System.Drawing.Point(37, 391);
            this.lblKodpocztowy.Name = "lblKodpocztowy";
            this.lblKodpocztowy.Size = new System.Drawing.Size(111, 20);
            this.lblKodpocztowy.TabIndex = 26;
            this.lblKodpocztowy.Text = "Kod pocztowy:";
            this.lblKodpocztowy.Visible = false;
            // 
            // txtboxNrlokalu
            // 
            this.txtboxNrlokalu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxNrlokalu.Location = new System.Drawing.Point(148, 357);
            this.txtboxNrlokalu.Name = "txtboxNrlokalu";
            this.txtboxNrlokalu.Size = new System.Drawing.Size(170, 26);
            this.txtboxNrlokalu.TabIndex = 39;
            this.txtboxNrlokalu.Visible = false;
            // 
            // lblNrlokalu
            // 
            this.lblNrlokalu.AutoSize = true;
            this.lblNrlokalu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNrlokalu.Location = new System.Drawing.Point(37, 357);
            this.lblNrlokalu.Name = "lblNrlokalu";
            this.lblNrlokalu.Size = new System.Drawing.Size(74, 20);
            this.lblNrlokalu.TabIndex = 28;
            this.lblNrlokalu.Text = "Nr lokalu:";
            this.lblNrlokalu.Visible = false;
            // 
            // txtNrbudynku
            // 
            this.txtNrbudynku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNrbudynku.Location = new System.Drawing.Point(148, 326);
            this.txtNrbudynku.Name = "txtNrbudynku";
            this.txtNrbudynku.Size = new System.Drawing.Size(170, 26);
            this.txtNrbudynku.TabIndex = 38;
            this.txtNrbudynku.Visible = false;
            // 
            // lblNrbudynku
            // 
            this.lblNrbudynku.AutoSize = true;
            this.lblNrbudynku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNrbudynku.Location = new System.Drawing.Point(37, 326);
            this.lblNrbudynku.Name = "lblNrbudynku";
            this.lblNrbudynku.Size = new System.Drawing.Size(93, 20);
            this.lblNrbudynku.TabIndex = 30;
            this.lblNrbudynku.Text = "Nr budynku:";
            this.lblNrbudynku.Visible = false;
            // 
            // txtboxUlica
            // 
            this.txtboxUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxUlica.Location = new System.Drawing.Point(148, 295);
            this.txtboxUlica.Name = "txtboxUlica";
            this.txtboxUlica.Size = new System.Drawing.Size(170, 26);
            this.txtboxUlica.TabIndex = 37;
            this.txtboxUlica.Visible = false;
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUlica.Location = new System.Drawing.Point(37, 295);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(48, 20);
            this.lblUlica.TabIndex = 31;
            this.lblUlica.Text = "Ulica:";
            this.lblUlica.Visible = false;
            // 
            // lblStanowisko
            // 
            this.lblStanowisko.AutoSize = true;
            this.lblStanowisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStanowisko.Location = new System.Drawing.Point(407, 200);
            this.lblStanowisko.Name = "lblStanowisko";
            this.lblStanowisko.Size = new System.Drawing.Size(95, 20);
            this.lblStanowisko.TabIndex = 32;
            this.lblStanowisko.Text = "Stanowisko:";
            this.lblStanowisko.Visible = false;
            // 
            // txtboxPesel
            // 
            this.txtboxPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxPesel.Location = new System.Drawing.Point(148, 231);
            this.txtboxPesel.Name = "txtboxPesel";
            this.txtboxPesel.Size = new System.Drawing.Size(170, 26);
            this.txtboxPesel.TabIndex = 35;
            this.txtboxPesel.Visible = false;
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPesel.Location = new System.Drawing.Point(37, 231);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(65, 20);
            this.lblPesel.TabIndex = 27;
            this.lblPesel.Text = "PESEL:";
            this.lblPesel.Visible = false;
            // 
            // txtboxTel
            // 
            this.txtboxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxTel.Location = new System.Drawing.Point(148, 200);
            this.txtboxTel.Name = "txtboxTel";
            this.txtboxTel.Size = new System.Drawing.Size(170, 26);
            this.txtboxTel.TabIndex = 34;
            this.txtboxTel.Visible = false;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTel.Location = new System.Drawing.Point(37, 200);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(34, 20);
            this.lblTel.TabIndex = 24;
            this.lblTel.Text = "Tel:";
            this.lblTel.Visible = false;
            // 
            // txtboxNazwisko
            // 
            this.txtboxNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxNazwisko.Location = new System.Drawing.Point(148, 169);
            this.txtboxNazwisko.Name = "txtboxNazwisko";
            this.txtboxNazwisko.Size = new System.Drawing.Size(170, 26);
            this.txtboxNazwisko.TabIndex = 33;
            this.txtboxNazwisko.Visible = false;
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwisko.Location = new System.Drawing.Point(37, 169);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(80, 20);
            this.lblNazwisko.TabIndex = 21;
            this.lblNazwisko.Text = "Nazwisko:";
            this.lblNazwisko.Visible = false;
            // 
            // txtboxImie
            // 
            this.txtboxImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxImie.Location = new System.Drawing.Point(148, 138);
            this.txtboxImie.Name = "txtboxImie";
            this.txtboxImie.Size = new System.Drawing.Size(170, 26);
            this.txtboxImie.TabIndex = 29;
            this.txtboxImie.Visible = false;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(37, 138);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(43, 20);
            this.lblImie.TabIndex = 20;
            this.lblImie.Text = "Imie:";
            this.lblImie.Visible = false;
            // 
            // btnDodajZapisz
            // 
            this.btnDodajZapisz.Location = new System.Drawing.Point(448, 507);
            this.btnDodajZapisz.Name = "btnDodajZapisz";
            this.btnDodajZapisz.Size = new System.Drawing.Size(75, 36);
            this.btnDodajZapisz.TabIndex = 19;
            this.btnDodajZapisz.Text = "Zapisz";
            this.btnDodajZapisz.UseVisualStyleBackColor = true;
            this.btnDodajZapisz.Visible = false;
            this.btnDodajZapisz.Click += new System.EventHandler(this.btnDodajZapisz_Click);
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(613, 507);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(75, 36);
            this.btnWyczysc.TabIndex = 19;
            this.btnWyczysc.Text = "Wyczyść formularz";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Visible = false;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(694, 507);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 36);
            this.btnAnuluj.TabIndex = 19;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Visible = false;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // FormWykazPracownikow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.cbStanowisko);
            this.Controls.Add(this.cbMiasto);
            this.Controls.Add(this.txtDataRozpoczeciaPracy);
            this.Controls.Add(this.lblDataStart);
            this.Controls.Add(this.lblMiasto);
            this.Controls.Add(this.txtboxKraj);
            this.Controls.Add(this.lblKraj);
            this.Controls.Add(this.txtboxKodpocztowy);
            this.Controls.Add(this.lblKodpocztowy);
            this.Controls.Add(this.txtboxNrlokalu);
            this.Controls.Add(this.lblNrlokalu);
            this.Controls.Add(this.txtNrbudynku);
            this.Controls.Add(this.lblNrbudynku);
            this.Controls.Add(this.txtboxUlica);
            this.Controls.Add(this.lblUlica);
            this.Controls.Add(this.lblStanowisko);
            this.Controls.Add(this.txtboxPesel);
            this.Controls.Add(this.lblPesel);
            this.Controls.Add(this.txtboxTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtboxNazwisko);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.txtboxImie);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnWyczysc);
            this.Controls.Add(this.btnDodajZapisz);
            this.Controls.Add(this.btnZaktualizaujZapisz);
            this.Controls.Add(this.LWyszukaj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnZaktualizuj);
            this.Controls.Add(this.txtWyszukajNazwisko);
            this.Controls.Add(this.ListaPracownikow);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWykazPracownikow";
            this.Text = "a";
            this.Load += new System.EventHandler(this.FormWykazPracownikow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPracownikow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView ListaPracownikow;
        private System.Windows.Forms.TextBox txtWyszukajNazwisko;
        private System.Windows.Forms.Button btnZaktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Label LWyszukaj;
        private System.Windows.Forms.Button btnZaktualizaujZapisz;
        private System.Windows.Forms.ComboBox cbStanowisko;
        private System.Windows.Forms.ComboBox cbMiasto;
        private System.Windows.Forms.DateTimePicker txtDataRozpoczeciaPracy;
        private System.Windows.Forms.Label lblDataStart;
        private System.Windows.Forms.Label lblMiasto;
        private System.Windows.Forms.TextBox txtboxKraj;
        private System.Windows.Forms.Label lblKraj;
        private System.Windows.Forms.TextBox txtboxKodpocztowy;
        private System.Windows.Forms.Label lblKodpocztowy;
        private System.Windows.Forms.TextBox txtboxNrlokalu;
        private System.Windows.Forms.Label lblNrlokalu;
        private System.Windows.Forms.TextBox txtNrbudynku;
        private System.Windows.Forms.Label lblNrbudynku;
        private System.Windows.Forms.TextBox txtboxUlica;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.Label lblStanowisko;
        private System.Windows.Forms.TextBox txtboxPesel;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.TextBox txtboxTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtboxNazwisko;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.TextBox txtboxImie;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Button btnDodajZapisz;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.Button btnAnuluj;
    }
}