namespace PROJEKTapp
{
    partial class FormKadry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKadry));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStatystyki = new System.Windows.Forms.Button();
            this.btnSzkolenia = new System.Windows.Forms.Button();
            this.btnUrlopy = new System.Windows.Forms.Button();
            this.btnWynagrodzenia = new System.Windows.Forms.Button();
            this.btnPracownicy = new System.Windows.Forms.Button();
            this.pnlUserControl = new System.Windows.Forms.Panel();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pnlUserSearch = new System.Windows.Forms.Panel();
            this.LWyszukaj = new System.Windows.Forms.Label();
            this.txtWyszukajNazwisko = new System.Windows.Forms.TextBox();
            this.ListaPracownikow = new System.Windows.Forms.DataGridView();
            this.lblNrbudynku = new System.Windows.Forms.Label();
            this.txtboxNrbudynku = new System.Windows.Forms.TextBox();
            this.txtboxUlica = new System.Windows.Forms.TextBox();
            this.lblNrlokalu = new System.Windows.Forms.Label();
            this.lblUlica = new System.Windows.Forms.Label();
            this.txtboxNrlokalu = new System.Windows.Forms.TextBox();
            this.txtboxPesel = new System.Windows.Forms.TextBox();
            this.lblKodpocztowy = new System.Windows.Forms.Label();
            this.lblPesel = new System.Windows.Forms.Label();
            this.txtboxKodpocztowy = new System.Windows.Forms.TextBox();
            this.txtboxTel = new System.Windows.Forms.TextBox();
            this.lblKraj = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtboxNazwisko = new System.Windows.Forms.TextBox();
            this.lblMiasto = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.txtboxImie = new System.Windows.Forms.TextBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.lblStanowisko = new System.Windows.Forms.Label();
            this.cbMiasto = new System.Windows.Forms.ComboBox();
            this.lblDataStart = new System.Windows.Forms.Label();
            this.txtboxKraj = new System.Windows.Forms.TextBox();
            this.txtDataRozpoczeciaPracy = new System.Windows.Forms.DateTimePicker();
            this.cbStanowisko = new System.Windows.Forms.ComboBox();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.btnZapiszDodaj = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.pnlUserField = new System.Windows.Forms.Panel();
            this.chbEdycjaStanoiwska = new System.Windows.Forms.CheckBox();
            this.chbDataKoniec = new System.Windows.Forms.CheckBox();
            this.cbOkres = new System.Windows.Forms.ComboBox();
            this.cbStawka = new System.Windows.Forms.ComboBox();
            this.txtDataKoniec = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlUserControl.SuspendLayout();
            this.pnlUserSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPracownikow)).BeginInit();
            this.pnlUserField.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 59);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1297, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kadry i Finanse";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.btnStatystyki);
            this.panel2.Controls.Add(this.btnSzkolenia);
            this.panel2.Controls.Add(this.btnUrlopy);
            this.panel2.Controls.Add(this.btnWynagrodzenia);
            this.panel2.Controls.Add(this.btnPracownicy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 633);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 135);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.btnStatystyki_Click);
            // 
            // btnStatystyki
            // 
            this.btnStatystyki.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStatystyki.FlatAppearance.BorderSize = 0;
            this.btnStatystyki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatystyki.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatystyki.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStatystyki.Image = ((System.Drawing.Image)(resources.GetObject("btnStatystyki.Image")));
            this.btnStatystyki.Location = new System.Drawing.Point(752, -3);
            this.btnStatystyki.Name = "btnStatystyki";
            this.btnStatystyki.Size = new System.Drawing.Size(188, 135);
            this.btnStatystyki.TabIndex = 2;
            this.btnStatystyki.Text = "Statystyki";
            this.btnStatystyki.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStatystyki.UseVisualStyleBackColor = false;
            // 
            // btnSzkolenia
            // 
            this.btnSzkolenia.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSzkolenia.FlatAppearance.BorderSize = 0;
            this.btnSzkolenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzkolenia.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzkolenia.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSzkolenia.Image = ((System.Drawing.Image)(resources.GetObject("btnSzkolenia.Image")));
            this.btnSzkolenia.Location = new System.Drawing.Point(564, -3);
            this.btnSzkolenia.Name = "btnSzkolenia";
            this.btnSzkolenia.Size = new System.Drawing.Size(188, 138);
            this.btnSzkolenia.TabIndex = 2;
            this.btnSzkolenia.Text = "Szkolenia";
            this.btnSzkolenia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSzkolenia.UseVisualStyleBackColor = false;
            this.btnSzkolenia.Click += new System.EventHandler(this.btnSzkolenia_Click);
            // 
            // btnUrlopy
            // 
            this.btnUrlopy.FlatAppearance.BorderSize = 0;
            this.btnUrlopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrlopy.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrlopy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUrlopy.Image = ((System.Drawing.Image)(resources.GetObject("btnUrlopy.Image")));
            this.btnUrlopy.Location = new System.Drawing.Point(376, -3);
            this.btnUrlopy.Name = "btnUrlopy";
            this.btnUrlopy.Size = new System.Drawing.Size(188, 135);
            this.btnUrlopy.TabIndex = 2;
            this.btnUrlopy.Text = "Urlopy";
            this.btnUrlopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrlopy.UseVisualStyleBackColor = true;
            this.btnUrlopy.Click += new System.EventHandler(this.btnUrlopy_Click);
            // 
            // btnWynagrodzenia
            // 
            this.btnWynagrodzenia.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnWynagrodzenia.FlatAppearance.BorderSize = 0;
            this.btnWynagrodzenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWynagrodzenia.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWynagrodzenia.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWynagrodzenia.Image = ((System.Drawing.Image)(resources.GetObject("btnWynagrodzenia.Image")));
            this.btnWynagrodzenia.Location = new System.Drawing.Point(188, -3);
            this.btnWynagrodzenia.Name = "btnWynagrodzenia";
            this.btnWynagrodzenia.Size = new System.Drawing.Size(188, 138);
            this.btnWynagrodzenia.TabIndex = 2;
            this.btnWynagrodzenia.Text = "Wynagrodzenia";
            this.btnWynagrodzenia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWynagrodzenia.UseVisualStyleBackColor = false;
            this.btnWynagrodzenia.Click += new System.EventHandler(this.btnWynagrodzenia_Click);
            // 
            // btnPracownicy
            // 
            this.btnPracownicy.FlatAppearance.BorderSize = 0;
            this.btnPracownicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPracownicy.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPracownicy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPracownicy.Image = ((System.Drawing.Image)(resources.GetObject("btnPracownicy.Image")));
            this.btnPracownicy.Location = new System.Drawing.Point(0, 0);
            this.btnPracownicy.Name = "btnPracownicy";
            this.btnPracownicy.Size = new System.Drawing.Size(188, 135);
            this.btnPracownicy.TabIndex = 2;
            this.btnPracownicy.Text = "Pracownicy";
            this.btnPracownicy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPracownicy.UseVisualStyleBackColor = true;
            this.btnPracownicy.Click += new System.EventHandler(this.btnPracownicy_Click);
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.Controls.Add(this.btnUsun);
            this.pnlUserControl.Controls.Add(this.btnEdytuj);
            this.pnlUserControl.Controls.Add(this.btnDodaj);
            this.pnlUserControl.Location = new System.Drawing.Point(3, 397);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(160, 230);
            this.pnlUserControl.TabIndex = 2;
            // 
            // btnUsun
            // 
            this.btnUsun.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(29, 155);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(106, 61);
            this.btnUsun.TabIndex = 0;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdytuj.Location = new System.Drawing.Point(29, 88);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(106, 61);
            this.btnEdytuj.TabIndex = 0;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(29, 21);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(106, 61);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // pnlUserSearch
            // 
            this.pnlUserSearch.Controls.Add(this.LWyszukaj);
            this.pnlUserSearch.Controls.Add(this.txtWyszukajNazwisko);
            this.pnlUserSearch.Controls.Add(this.ListaPracownikow);
            this.pnlUserSearch.Location = new System.Drawing.Point(169, 65);
            this.pnlUserSearch.Name = "pnlUserSearch";
            this.pnlUserSearch.Size = new System.Drawing.Size(552, 562);
            this.pnlUserSearch.TabIndex = 3;
            // 
            // LWyszukaj
            // 
            this.LWyszukaj.AutoSize = true;
            this.LWyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LWyszukaj.Location = new System.Drawing.Point(16, 17);
            this.LWyszukaj.Name = "LWyszukaj";
            this.LWyszukaj.Size = new System.Drawing.Size(147, 20);
            this.LWyszukaj.TabIndex = 21;
            this.LWyszukaj.Text = "Wyszukaj Nazwisko";
            // 
            // txtWyszukajNazwisko
            // 
            this.txtWyszukajNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWyszukajNazwisko.Location = new System.Drawing.Point(169, 11);
            this.txtWyszukajNazwisko.Name = "txtWyszukajNazwisko";
            this.txtWyszukajNazwisko.Size = new System.Drawing.Size(253, 26);
            this.txtWyszukajNazwisko.TabIndex = 20;
            this.txtWyszukajNazwisko.TextChanged += new System.EventHandler(this.txtWyszukajNazwisko_TextChanged);
            // 
            // ListaPracownikow
            // 
            this.ListaPracownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPracownikow.Location = new System.Drawing.Point(6, 43);
            this.ListaPracownikow.Name = "ListaPracownikow";
            this.ListaPracownikow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaPracownikow.Size = new System.Drawing.Size(531, 505);
            this.ListaPracownikow.TabIndex = 19;
            // 
            // lblNrbudynku
            // 
            this.lblNrbudynku.AutoSize = true;
            this.lblNrbudynku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNrbudynku.Location = new System.Drawing.Point(19, 201);
            this.lblNrbudynku.Name = "lblNrbudynku";
            this.lblNrbudynku.Size = new System.Drawing.Size(93, 20);
            this.lblNrbudynku.TabIndex = 54;
            this.lblNrbudynku.Text = "Nr budynku:";
            // 
            // txtboxNrbudynku
            // 
            this.txtboxNrbudynku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxNrbudynku.Location = new System.Drawing.Point(130, 201);
            this.txtboxNrbudynku.Name = "txtboxNrbudynku";
            this.txtboxNrbudynku.Size = new System.Drawing.Size(183, 26);
            this.txtboxNrbudynku.TabIndex = 62;
            // 
            // txtboxUlica
            // 
            this.txtboxUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxUlica.Location = new System.Drawing.Point(130, 170);
            this.txtboxUlica.Name = "txtboxUlica";
            this.txtboxUlica.Size = new System.Drawing.Size(183, 26);
            this.txtboxUlica.TabIndex = 61;
            // 
            // lblNrlokalu
            // 
            this.lblNrlokalu.AutoSize = true;
            this.lblNrlokalu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNrlokalu.Location = new System.Drawing.Point(19, 232);
            this.lblNrlokalu.Name = "lblNrlokalu";
            this.lblNrlokalu.Size = new System.Drawing.Size(74, 20);
            this.lblNrlokalu.TabIndex = 52;
            this.lblNrlokalu.Text = "Nr lokalu:";
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUlica.Location = new System.Drawing.Point(19, 170);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(48, 20);
            this.lblUlica.TabIndex = 55;
            this.lblUlica.Text = "Ulica:";
            // 
            // txtboxNrlokalu
            // 
            this.txtboxNrlokalu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxNrlokalu.Location = new System.Drawing.Point(130, 232);
            this.txtboxNrlokalu.Name = "txtboxNrlokalu";
            this.txtboxNrlokalu.Size = new System.Drawing.Size(183, 26);
            this.txtboxNrlokalu.TabIndex = 63;
            // 
            // txtboxPesel
            // 
            this.txtboxPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxPesel.Location = new System.Drawing.Point(130, 106);
            this.txtboxPesel.Name = "txtboxPesel";
            this.txtboxPesel.Size = new System.Drawing.Size(183, 26);
            this.txtboxPesel.TabIndex = 59;
            // 
            // lblKodpocztowy
            // 
            this.lblKodpocztowy.AutoSize = true;
            this.lblKodpocztowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKodpocztowy.Location = new System.Drawing.Point(19, 266);
            this.lblKodpocztowy.Name = "lblKodpocztowy";
            this.lblKodpocztowy.Size = new System.Drawing.Size(111, 20);
            this.lblKodpocztowy.TabIndex = 50;
            this.lblKodpocztowy.Text = "Kod pocztowy:";
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPesel.Location = new System.Drawing.Point(19, 106);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(65, 20);
            this.lblPesel.TabIndex = 51;
            this.lblPesel.Text = "PESEL:";
            // 
            // txtboxKodpocztowy
            // 
            this.txtboxKodpocztowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxKodpocztowy.Location = new System.Drawing.Point(130, 263);
            this.txtboxKodpocztowy.Name = "txtboxKodpocztowy";
            this.txtboxKodpocztowy.Size = new System.Drawing.Size(183, 26);
            this.txtboxKodpocztowy.TabIndex = 64;
            // 
            // txtboxTel
            // 
            this.txtboxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxTel.Location = new System.Drawing.Point(130, 75);
            this.txtboxTel.Name = "txtboxTel";
            this.txtboxTel.Size = new System.Drawing.Size(183, 26);
            this.txtboxTel.TabIndex = 58;
            // 
            // lblKraj
            // 
            this.lblKraj.AutoSize = true;
            this.lblKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKraj.Location = new System.Drawing.Point(19, 329);
            this.lblKraj.Name = "lblKraj";
            this.lblKraj.Size = new System.Drawing.Size(40, 20);
            this.lblKraj.TabIndex = 49;
            this.lblKraj.Text = "Kraj:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTel.Location = new System.Drawing.Point(19, 75);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(34, 20);
            this.lblTel.TabIndex = 48;
            this.lblTel.Text = "Tel:";
            // 
            // txtboxNazwisko
            // 
            this.txtboxNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxNazwisko.Location = new System.Drawing.Point(130, 44);
            this.txtboxNazwisko.Name = "txtboxNazwisko";
            this.txtboxNazwisko.Size = new System.Drawing.Size(183, 26);
            this.txtboxNazwisko.TabIndex = 57;
            // 
            // lblMiasto
            // 
            this.lblMiasto.AutoSize = true;
            this.lblMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMiasto.Location = new System.Drawing.Point(19, 295);
            this.lblMiasto.Name = "lblMiasto";
            this.lblMiasto.Size = new System.Drawing.Size(60, 20);
            this.lblMiasto.TabIndex = 47;
            this.lblMiasto.Text = "Miasto:";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwisko.Location = new System.Drawing.Point(19, 44);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(80, 20);
            this.lblNazwisko.TabIndex = 45;
            this.lblNazwisko.Text = "Nazwisko:";
            // 
            // txtboxImie
            // 
            this.txtboxImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxImie.Location = new System.Drawing.Point(130, 13);
            this.txtboxImie.Name = "txtboxImie";
            this.txtboxImie.Size = new System.Drawing.Size(183, 26);
            this.txtboxImie.TabIndex = 53;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(19, 13);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(43, 20);
            this.lblImie.TabIndex = 44;
            this.lblImie.Text = "Imie:";
            // 
            // lblStanowisko
            // 
            this.lblStanowisko.AutoSize = true;
            this.lblStanowisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStanowisko.Location = new System.Drawing.Point(20, 380);
            this.lblStanowisko.Name = "lblStanowisko";
            this.lblStanowisko.Size = new System.Drawing.Size(95, 20);
            this.lblStanowisko.TabIndex = 56;
            this.lblStanowisko.Text = "Stanowisko:";
            // 
            // cbMiasto
            // 
            this.cbMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMiasto.FormattingEnabled = true;
            this.cbMiasto.Location = new System.Drawing.Point(130, 295);
            this.cbMiasto.Name = "cbMiasto";
            this.cbMiasto.Size = new System.Drawing.Size(183, 28);
            this.cbMiasto.TabIndex = 66;
            // 
            // lblDataStart
            // 
            this.lblDataStart.AutoSize = true;
            this.lblDataStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataStart.Location = new System.Drawing.Point(333, 17);
            this.lblDataStart.Name = "lblDataStart";
            this.lblDataStart.Size = new System.Drawing.Size(179, 20);
            this.lblDataStart.TabIndex = 46;
            this.lblDataStart.Text = "Data rozpoczecia pracy:";
            // 
            // txtboxKraj
            // 
            this.txtboxKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxKraj.Location = new System.Drawing.Point(130, 329);
            this.txtboxKraj.Name = "txtboxKraj";
            this.txtboxKraj.Size = new System.Drawing.Size(183, 26);
            this.txtboxKraj.TabIndex = 65;
            this.txtboxKraj.Text = "Polska";
            // 
            // txtDataRozpoczeciaPracy
            // 
            this.txtDataRozpoczeciaPracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDataRozpoczeciaPracy.Location = new System.Drawing.Point(337, 40);
            this.txtDataRozpoczeciaPracy.Name = "txtDataRozpoczeciaPracy";
            this.txtDataRozpoczeciaPracy.Size = new System.Drawing.Size(290, 26);
            this.txtDataRozpoczeciaPracy.TabIndex = 67;
            // 
            // cbStanowisko
            // 
            this.cbStanowisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbStanowisko.FormattingEnabled = true;
            this.cbStanowisko.Location = new System.Drawing.Point(22, 403);
            this.cbStanowisko.Name = "cbStanowisko";
            this.cbStanowisko.Size = new System.Drawing.Size(248, 28);
            this.cbStanowisko.TabIndex = 60;
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(122, 492);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(91, 49);
            this.btnWyczysc.TabIndex = 69;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // btnZapiszDodaj
            // 
            this.btnZapiszDodaj.Location = new System.Drawing.Point(25, 492);
            this.btnZapiszDodaj.Name = "btnZapiszDodaj";
            this.btnZapiszDodaj.Size = new System.Drawing.Size(91, 49);
            this.btnZapiszDodaj.TabIndex = 69;
            this.btnZapiszDodaj.Text = "Zapisz";
            this.btnZapiszDodaj.UseVisualStyleBackColor = true;
            this.btnZapiszDodaj.Click += new System.EventHandler(this.btnZapiszDodaj_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(219, 492);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(91, 49);
            this.btnAnuluj.TabIndex = 68;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // pnlUserField
            // 
            this.pnlUserField.Controls.Add(this.chbEdycjaStanoiwska);
            this.pnlUserField.Controls.Add(this.chbDataKoniec);
            this.pnlUserField.Controls.Add(this.cbOkres);
            this.pnlUserField.Controls.Add(this.cbStawka);
            this.pnlUserField.Controls.Add(this.btnAnuluj);
            this.pnlUserField.Controls.Add(this.btnZapiszDodaj);
            this.pnlUserField.Controls.Add(this.btnWyczysc);
            this.pnlUserField.Controls.Add(this.cbStanowisko);
            this.pnlUserField.Controls.Add(this.txtDataKoniec);
            this.pnlUserField.Controls.Add(this.txtDataRozpoczeciaPracy);
            this.pnlUserField.Controls.Add(this.txtboxKraj);
            this.pnlUserField.Controls.Add(this.lblDataStart);
            this.pnlUserField.Controls.Add(this.cbMiasto);
            this.pnlUserField.Controls.Add(this.lblStanowisko);
            this.pnlUserField.Controls.Add(this.lblImie);
            this.pnlUserField.Controls.Add(this.txtboxImie);
            this.pnlUserField.Controls.Add(this.lblNazwisko);
            this.pnlUserField.Controls.Add(this.lblMiasto);
            this.pnlUserField.Controls.Add(this.txtboxNazwisko);
            this.pnlUserField.Controls.Add(this.lblTel);
            this.pnlUserField.Controls.Add(this.lblKraj);
            this.pnlUserField.Controls.Add(this.txtboxTel);
            this.pnlUserField.Controls.Add(this.txtboxKodpocztowy);
            this.pnlUserField.Controls.Add(this.lblPesel);
            this.pnlUserField.Controls.Add(this.lblKodpocztowy);
            this.pnlUserField.Controls.Add(this.txtboxPesel);
            this.pnlUserField.Controls.Add(this.txtboxNrlokalu);
            this.pnlUserField.Controls.Add(this.lblUlica);
            this.pnlUserField.Controls.Add(this.lblNrlokalu);
            this.pnlUserField.Controls.Add(this.txtboxUlica);
            this.pnlUserField.Controls.Add(this.txtboxNrbudynku);
            this.pnlUserField.Controls.Add(this.lblNrbudynku);
            this.pnlUserField.Location = new System.Drawing.Point(727, 65);
            this.pnlUserField.Name = "pnlUserField";
            this.pnlUserField.Size = new System.Drawing.Size(639, 555);
            this.pnlUserField.TabIndex = 5;
            // 
            // chbEdycjaStanoiwska
            // 
            this.chbEdycjaStanoiwska.AutoSize = true;
            this.chbEdycjaStanoiwska.Location = new System.Drawing.Point(121, 381);
            this.chbEdycjaStanoiwska.Name = "chbEdycjaStanoiwska";
            this.chbEdycjaStanoiwska.Size = new System.Drawing.Size(159, 19);
            this.chbEdycjaStanoiwska.TabIndex = 72;
            this.chbEdycjaStanoiwska.Text = "Czy zmienić stanoiwsko?";
            this.chbEdycjaStanoiwska.UseVisualStyleBackColor = true;
            // 
            // chbDataKoniec
            // 
            this.chbDataKoniec.AutoSize = true;
            this.chbDataKoniec.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbDataKoniec.Location = new System.Drawing.Point(337, 73);
            this.chbDataKoniec.Name = "chbDataKoniec";
            this.chbDataKoniec.Size = new System.Drawing.Size(213, 24);
            this.chbDataKoniec.TabIndex = 71;
            this.chbDataKoniec.Text = "Znana data końca pracy";
            this.chbDataKoniec.UseVisualStyleBackColor = true;
            this.chbDataKoniec.CheckedChanged += new System.EventHandler(this.chbDataKoniec_CheckedChanged);
            // 
            // cbOkres
            // 
            this.cbOkres.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbOkres.FormattingEnabled = true;
            this.cbOkres.Location = new System.Drawing.Point(23, 437);
            this.cbOkres.Name = "cbOkres";
            this.cbOkres.Size = new System.Drawing.Size(121, 28);
            this.cbOkres.TabIndex = 70;
            this.cbOkres.SelectedIndexChanged += new System.EventHandler(this.cbOkres_SelectedValueChanged);
            // 
            // cbStawka
            // 
            this.cbStawka.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbStawka.FormattingEnabled = true;
            this.cbStawka.Location = new System.Drawing.Point(150, 437);
            this.cbStawka.Name = "cbStawka";
            this.cbStawka.Size = new System.Drawing.Size(121, 28);
            this.cbStawka.TabIndex = 70;
            // 
            // txtDataKoniec
            // 
            this.txtDataKoniec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDataKoniec.Location = new System.Drawing.Point(337, 106);
            this.txtDataKoniec.Name = "txtDataKoniec";
            this.txtDataKoniec.Size = new System.Drawing.Size(290, 26);
            this.txtDataKoniec.TabIndex = 67;
            this.txtDataKoniec.Visible = false;
            // 
            // FormKadry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlUserField);
            this.Controls.Add(this.pnlUserSearch);
            this.Controls.Add(this.pnlUserControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKadry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKadry";
            this.Load += new System.EventHandler(this.FormKadry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlUserControl.ResumeLayout(false);
            this.pnlUserSearch.ResumeLayout(false);
            this.pnlUserSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPracownikow)).EndInit();
            this.pnlUserField.ResumeLayout(false);
            this.pnlUserField.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPracownicy;
        private System.Windows.Forms.Button btnSzkolenia;
        private System.Windows.Forms.Button btnUrlopy;
        private System.Windows.Forms.Button btnWynagrodzenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStatystyki;
        private System.Windows.Forms.Panel pnlUserControl;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Panel pnlUserSearch;
        private System.Windows.Forms.Label LWyszukaj;
        private System.Windows.Forms.TextBox txtWyszukajNazwisko;
        private System.Windows.Forms.DataGridView ListaPracownikow;
        private System.Windows.Forms.Label lblNrbudynku;
        private System.Windows.Forms.TextBox txtboxNrbudynku;
        private System.Windows.Forms.TextBox txtboxUlica;
        private System.Windows.Forms.Label lblNrlokalu;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.TextBox txtboxNrlokalu;
        private System.Windows.Forms.TextBox txtboxPesel;
        private System.Windows.Forms.Label lblKodpocztowy;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.TextBox txtboxKodpocztowy;
        private System.Windows.Forms.TextBox txtboxTel;
        private System.Windows.Forms.Label lblKraj;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtboxNazwisko;
        private System.Windows.Forms.Label lblMiasto;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.TextBox txtboxImie;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblStanowisko;
        private System.Windows.Forms.ComboBox cbMiasto;
        private System.Windows.Forms.Label lblDataStart;
        private System.Windows.Forms.TextBox txtboxKraj;
        private System.Windows.Forms.DateTimePicker txtDataRozpoczeciaPracy;
        private System.Windows.Forms.ComboBox cbStanowisko;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.Button btnZapiszDodaj;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Panel pnlUserField;
        private System.Windows.Forms.ComboBox cbStawka;
        private System.Windows.Forms.ComboBox cbOkres;
        private System.Windows.Forms.CheckBox chbDataKoniec;
        private System.Windows.Forms.DateTimePicker txtDataKoniec;
        private System.Windows.Forms.CheckBox chbEdycjaStanoiwska;
    }
}