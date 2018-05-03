namespace PROJEKTapp
{
    partial class FormSzkolenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSzkolenie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStatystyki = new System.Windows.Forms.Button();
            this.btnSzkolenia = new System.Windows.Forms.Button();
            this.btnUrlopy = new System.Windows.Forms.Button();
            this.btnWynagrodzenia = new System.Windows.Forms.Button();
            this.btnPracownicy = new System.Windows.Forms.Button();
            this.pnlSzkoleniaControl = new System.Windows.Forms.Panel();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pnlUserSearch = new System.Windows.Forms.Panel();
            this.LWyszukaj = new System.Windows.Forms.Label();
            this.txtWyszukajNazwisko = new System.Windows.Forms.TextBox();
            this.ListaPracownikow = new System.Windows.Forms.DataGridView();
            this.btnNoweSzkolenie = new System.Windows.Forms.Button();
            this.pnlNoweSzkolenie = new System.Windows.Forms.Panel();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.txtboxNazwa = new System.Windows.Forms.TextBox();
            this.dtpKoniec = new System.Windows.Forms.DateTimePicker();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtboxOpis = new System.Windows.Forms.TextBox();
            this.lblDataKoniec = new System.Windows.Forms.Label();
            this.lblDataStart = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapiszDodaj = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.pnlDodajSzkolenie = new System.Windows.Forms.Panel();
            this.KalendarzSzkolenia = new System.Windows.Forms.MonthCalendar();
            this.cbSzkolenia = new System.Windows.Forms.ComboBox();
            this.cbRokSzkolenia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPracownik = new System.Windows.Forms.Label();
            this.btnZapiszSzkolenie = new System.Windows.Forms.Button();
            this.btnAnulujSzkolenie = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSzkoleniaControl.SuspendLayout();
            this.pnlUserSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPracownikow)).BeginInit();
            this.pnlNoweSzkolenie.SuspendLayout();
            this.pnlDodajSzkolenie.SuspendLayout();
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
            this.panel1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1281, 1);
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
            this.panel2.TabIndex = 5;
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
            this.btnStatystyki.Click += new System.EventHandler(this.btnStatystyki_Click);
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
            // pnlSzkoleniaControl
            // 
            this.pnlSzkoleniaControl.Controls.Add(this.btnUsun);
            this.pnlSzkoleniaControl.Controls.Add(this.btnEdytuj);
            this.pnlSzkoleniaControl.Controls.Add(this.btnNoweSzkolenie);
            this.pnlSzkoleniaControl.Controls.Add(this.btnDodaj);
            this.pnlSzkoleniaControl.Location = new System.Drawing.Point(0, 289);
            this.pnlSzkoleniaControl.Name = "pnlSzkoleniaControl";
            this.pnlSzkoleniaControl.Size = new System.Drawing.Size(160, 338);
            this.pnlSzkoleniaControl.TabIndex = 6;
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
            this.pnlUserSearch.Location = new System.Drawing.Point(166, 62);
            this.pnlUserSearch.Name = "pnlUserSearch";
            this.pnlUserSearch.Size = new System.Drawing.Size(552, 562);
            this.pnlUserSearch.TabIndex = 7;
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
            // btnNoweSzkolenie
            // 
            this.btnNoweSzkolenie.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNoweSzkolenie.Location = new System.Drawing.Point(29, 260);
            this.btnNoweSzkolenie.Name = "btnNoweSzkolenie";
            this.btnNoweSzkolenie.Size = new System.Drawing.Size(106, 61);
            this.btnNoweSzkolenie.TabIndex = 0;
            this.btnNoweSzkolenie.Text = "Nowe szkolenie";
            this.btnNoweSzkolenie.UseVisualStyleBackColor = true;
            this.btnNoweSzkolenie.Click += new System.EventHandler(this.btnNoweSzkolenie_Click);
            // 
            // pnlNoweSzkolenie
            // 
            this.pnlNoweSzkolenie.Controls.Add(this.btnAnuluj);
            this.pnlNoweSzkolenie.Controls.Add(this.dtpStart);
            this.pnlNoweSzkolenie.Controls.Add(this.dtpKoniec);
            this.pnlNoweSzkolenie.Controls.Add(this.lblDataStart);
            this.pnlNoweSzkolenie.Controls.Add(this.txtboxOpis);
            this.pnlNoweSzkolenie.Controls.Add(this.btnZapiszDodaj);
            this.pnlNoweSzkolenie.Controls.Add(this.lblDataKoniec);
            this.pnlNoweSzkolenie.Controls.Add(this.btnWyczysc);
            this.pnlNoweSzkolenie.Controls.Add(this.lblOpis);
            this.pnlNoweSzkolenie.Controls.Add(this.txtboxNazwa);
            this.pnlNoweSzkolenie.Controls.Add(this.lblNazwa);
            this.pnlNoweSzkolenie.Location = new System.Drawing.Point(733, 66);
            this.pnlNoweSzkolenie.Name = "pnlNoweSzkolenie";
            this.pnlNoweSzkolenie.Size = new System.Drawing.Size(561, 216);
            this.pnlNoweSzkolenie.TabIndex = 8;
            this.pnlNoweSzkolenie.Visible = false;
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwa.Location = new System.Drawing.Point(70, 15);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(57, 20);
            this.lblNazwa.TabIndex = 0;
            this.lblNazwa.Text = "Nazwa";
            // 
            // txtboxNazwa
            // 
            this.txtboxNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxNazwa.Location = new System.Drawing.Point(142, 9);
            this.txtboxNazwa.Name = "txtboxNazwa";
            this.txtboxNazwa.Size = new System.Drawing.Size(372, 26);
            this.txtboxNazwa.TabIndex = 1;
            // 
            // dtpKoniec
            // 
            this.dtpKoniec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpKoniec.Location = new System.Drawing.Point(218, 114);
            this.dtpKoniec.Name = "dtpKoniec";
            this.dtpKoniec.Size = new System.Drawing.Size(296, 26);
            this.dtpKoniec.TabIndex = 2;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(70, 41);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(41, 20);
            this.lblOpis.TabIndex = 0;
            this.lblOpis.Text = "Opis";
            // 
            // txtboxOpis
            // 
            this.txtboxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxOpis.Location = new System.Drawing.Point(142, 38);
            this.txtboxOpis.Name = "txtboxOpis";
            this.txtboxOpis.Size = new System.Drawing.Size(372, 26);
            this.txtboxOpis.TabIndex = 1;
            // 
            // lblDataKoniec
            // 
            this.lblDataKoniec.AutoSize = true;
            this.lblDataKoniec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataKoniec.Location = new System.Drawing.Point(99, 119);
            this.lblDataKoniec.Name = "lblDataKoniec";
            this.lblDataKoniec.Size = new System.Drawing.Size(93, 20);
            this.lblDataKoniec.TabIndex = 0;
            this.lblDataKoniec.Text = "Data Końca";
            // 
            // lblDataStart
            // 
            this.lblDataStart.AutoSize = true;
            this.lblDataStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataStart.Location = new System.Drawing.Point(99, 79);
            this.lblDataStart.Name = "lblDataStart";
            this.lblDataStart.Size = new System.Drawing.Size(113, 20);
            this.lblDataStart.TabIndex = 0;
            this.lblDataStart.Text = "Data początku";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpStart.Location = new System.Drawing.Point(218, 73);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(296, 26);
            this.dtpStart.TabIndex = 2;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(204, 159);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(91, 49);
            this.btnAnuluj.TabIndex = 70;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapiszDodaj
            // 
            this.btnZapiszDodaj.Location = new System.Drawing.Point(10, 159);
            this.btnZapiszDodaj.Name = "btnZapiszDodaj";
            this.btnZapiszDodaj.Size = new System.Drawing.Size(91, 49);
            this.btnZapiszDodaj.TabIndex = 71;
            this.btnZapiszDodaj.Text = "Zapisz";
            this.btnZapiszDodaj.UseVisualStyleBackColor = true;
            this.btnZapiszDodaj.Click += new System.EventHandler(this.btnZapiszDodaj_Click);
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(107, 159);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(91, 49);
            this.btnWyczysc.TabIndex = 72;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // pnlDodajSzkolenie
            // 
            this.pnlDodajSzkolenie.Controls.Add(this.btnAnulujSzkolenie);
            this.pnlDodajSzkolenie.Controls.Add(this.lblPracownik);
            this.pnlDodajSzkolenie.Controls.Add(this.label2);
            this.pnlDodajSzkolenie.Controls.Add(this.cbRokSzkolenia);
            this.pnlDodajSzkolenie.Controls.Add(this.cbSzkolenia);
            this.pnlDodajSzkolenie.Controls.Add(this.KalendarzSzkolenia);
            this.pnlDodajSzkolenie.Controls.Add(this.btnZapiszSzkolenie);
            this.pnlDodajSzkolenie.Location = new System.Drawing.Point(733, 296);
            this.pnlDodajSzkolenie.Name = "pnlDodajSzkolenie";
            this.pnlDodajSzkolenie.Size = new System.Drawing.Size(621, 328);
            this.pnlDodajSzkolenie.TabIndex = 9;
            this.pnlDodajSzkolenie.Visible = false;
            // 
            // KalendarzSzkolenia
            // 
            this.KalendarzSzkolenia.Location = new System.Drawing.Point(340, 5);
            this.KalendarzSzkolenia.Name = "KalendarzSzkolenia";
            this.KalendarzSzkolenia.TabIndex = 1;
            // 
            // cbSzkolenia
            // 
            this.cbSzkolenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSzkolenia.FormattingEnabled = true;
            this.cbSzkolenia.Location = new System.Drawing.Point(19, 81);
            this.cbSzkolenia.Name = "cbSzkolenia";
            this.cbSzkolenia.Size = new System.Drawing.Size(257, 28);
            this.cbSzkolenia.TabIndex = 2;
            // 
            // cbRokSzkolenia
            // 
            this.cbRokSzkolenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbRokSzkolenia.FormatString = "d";
            this.cbRokSzkolenia.FormattingEnabled = true;
            this.cbRokSzkolenia.Location = new System.Drawing.Point(142, 32);
            this.cbRokSzkolenia.Name = "cbRokSzkolenia";
            this.cbRokSzkolenia.Size = new System.Drawing.Size(134, 28);
            this.cbRokSzkolenia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rok Szkolenia";
            // 
            // lblPracownik
            // 
            this.lblPracownik.AutoSize = true;
            this.lblPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPracownik.Location = new System.Drawing.Point(15, 5);
            this.lblPracownik.Name = "lblPracownik";
            this.lblPracownik.Size = new System.Drawing.Size(0, 20);
            this.lblPracownik.TabIndex = 3;
            // 
            // btnZapiszSzkolenie
            // 
            this.btnZapiszSzkolenie.Location = new System.Drawing.Point(19, 265);
            this.btnZapiszSzkolenie.Name = "btnZapiszSzkolenie";
            this.btnZapiszSzkolenie.Size = new System.Drawing.Size(91, 49);
            this.btnZapiszSzkolenie.TabIndex = 71;
            this.btnZapiszSzkolenie.Text = "Zapisz";
            this.btnZapiszSzkolenie.UseVisualStyleBackColor = true;
            this.btnZapiszSzkolenie.Click += new System.EventHandler(this.btnZapiszSzkolenie_Click);
            // 
            // btnAnulujSzkolenie
            // 
            this.btnAnulujSzkolenie.Location = new System.Drawing.Point(121, 265);
            this.btnAnulujSzkolenie.Name = "btnAnulujSzkolenie";
            this.btnAnulujSzkolenie.Size = new System.Drawing.Size(91, 49);
            this.btnAnulujSzkolenie.TabIndex = 70;
            this.btnAnulujSzkolenie.Text = "Anuluj";
            this.btnAnulujSzkolenie.UseVisualStyleBackColor = true;
            this.btnAnulujSzkolenie.Click += new System.EventHandler(this.btnAnulujSzkolenie_Click);
            // 
            // FormSzkolenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlDodajSzkolenie);
            this.Controls.Add(this.pnlNoweSzkolenie);
            this.Controls.Add(this.pnlUserSearch);
            this.Controls.Add(this.pnlSzkoleniaControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSzkolenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSzkolenie";
            this.Load += new System.EventHandler(this.FormSzkolenie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlSzkoleniaControl.ResumeLayout(false);
            this.pnlUserSearch.ResumeLayout(false);
            this.pnlUserSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPracownikow)).EndInit();
            this.pnlNoweSzkolenie.ResumeLayout(false);
            this.pnlNoweSzkolenie.PerformLayout();
            this.pnlDodajSzkolenie.ResumeLayout(false);
            this.pnlDodajSzkolenie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStatystyki;
        private System.Windows.Forms.Button btnSzkolenia;
        private System.Windows.Forms.Button btnUrlopy;
        private System.Windows.Forms.Button btnWynagrodzenia;
        private System.Windows.Forms.Button btnPracownicy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlSzkoleniaControl;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Panel pnlUserSearch;
        private System.Windows.Forms.Label LWyszukaj;
        private System.Windows.Forms.TextBox txtWyszukajNazwisko;
        private System.Windows.Forms.DataGridView ListaPracownikow;
        private System.Windows.Forms.Button btnNoweSzkolenie;
        private System.Windows.Forms.Panel pnlNoweSzkolenie;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpKoniec;
        private System.Windows.Forms.Label lblDataStart;
        private System.Windows.Forms.TextBox txtboxOpis;
        private System.Windows.Forms.Label lblDataKoniec;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtboxNazwa;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapiszDodaj;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.Panel pnlDodajSzkolenie;
        private System.Windows.Forms.MonthCalendar KalendarzSzkolenia;
        private System.Windows.Forms.ComboBox cbSzkolenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRokSzkolenia;
        private System.Windows.Forms.Label lblPracownik;
        private System.Windows.Forms.Button btnAnulujSzkolenie;
        private System.Windows.Forms.Button btnZapiszSzkolenie;
    }
}