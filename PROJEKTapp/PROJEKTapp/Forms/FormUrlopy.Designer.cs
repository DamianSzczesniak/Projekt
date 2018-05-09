namespace PROJEKTapp
{
    partial class FormUrlopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrlopy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStatystyki = new System.Windows.Forms.Button();
            this.btnSzkolenia = new System.Windows.Forms.Button();
            this.btnUrlopy = new System.Windows.Forms.Button();
            this.btnWynagrodzenia = new System.Windows.Forms.Button();
            this.btnPracownicy = new System.Windows.Forms.Button();
            this.pnlUrlopyControl = new System.Windows.Forms.Panel();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pnlUserSearch = new System.Windows.Forms.Panel();
            this.LWyszukaj = new System.Windows.Forms.Label();
            this.txtWyszukajNazwisko = new System.Windows.Forms.TextBox();
            this.dgvUrlopyPraconik = new System.Windows.Forms.DataGridView();
            this.ListaPracownikow = new System.Windows.Forms.DataGridView();
            this.pnlWolne = new System.Windows.Forms.Panel();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapiszDodaj = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.txtDataStart = new System.Windows.Forms.DateTimePicker();
            this.KalendarzUrlop = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWnioskowany = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPozostalo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxWykorzystany = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataKoniec = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTypUrlopu = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlUrlopyControl.SuspendLayout();
            this.pnlUserSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlopyPraconik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPracownikow)).BeginInit();
            this.pnlWolne.SuspendLayout();
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
            this.panel1.TabIndex = 2;
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
            this.panel2.TabIndex = 3;
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
            // pnlUrlopyControl
            // 
            this.pnlUrlopyControl.Controls.Add(this.btnUsun);
            this.pnlUrlopyControl.Controls.Add(this.btnEdytuj);
            this.pnlUrlopyControl.Controls.Add(this.btnDodaj);
            this.pnlUrlopyControl.Location = new System.Drawing.Point(0, 394);
            this.pnlUrlopyControl.Name = "pnlUrlopyControl";
            this.pnlUrlopyControl.Size = new System.Drawing.Size(160, 230);
            this.pnlUrlopyControl.TabIndex = 4;
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
            this.pnlUserSearch.Controls.Add(this.dgvUrlopyPraconik);
            this.pnlUserSearch.Controls.Add(this.ListaPracownikow);
            this.pnlUserSearch.Location = new System.Drawing.Point(166, 62);
            this.pnlUserSearch.Name = "pnlUserSearch";
            this.pnlUserSearch.Size = new System.Drawing.Size(552, 562);
            this.pnlUserSearch.TabIndex = 5;
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
            // dgvUrlopyPraconik
            // 
            this.dgvUrlopyPraconik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrlopyPraconik.Location = new System.Drawing.Point(6, 345);
            this.dgvUrlopyPraconik.Name = "dgvUrlopyPraconik";
            this.dgvUrlopyPraconik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrlopyPraconik.Size = new System.Drawing.Size(531, 203);
            this.dgvUrlopyPraconik.TabIndex = 19;
            // 
            // ListaPracownikow
            // 
            this.ListaPracownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPracownikow.Location = new System.Drawing.Point(6, 43);
            this.ListaPracownikow.Name = "ListaPracownikow";
            this.ListaPracownikow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaPracownikow.Size = new System.Drawing.Size(531, 291);
            this.ListaPracownikow.TabIndex = 19;
            this.ListaPracownikow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListaPracownikow_MouseClick);
            // 
            // pnlWolne
            // 
            this.pnlWolne.Controls.Add(this.btnAnuluj);
            this.pnlWolne.Controls.Add(this.btnZapiszDodaj);
            this.pnlWolne.Controls.Add(this.btnWyczysc);
            this.pnlWolne.Controls.Add(this.txtDataStart);
            this.pnlWolne.Controls.Add(this.KalendarzUrlop);
            this.pnlWolne.Controls.Add(this.label2);
            this.pnlWolne.Controls.Add(this.label12);
            this.pnlWolne.Controls.Add(this.label11);
            this.pnlWolne.Controls.Add(this.label6);
            this.pnlWolne.Controls.Add(this.textBoxWnioskowany);
            this.pnlWolne.Controls.Add(this.label3);
            this.pnlWolne.Controls.Add(this.textBoxPozostalo);
            this.pnlWolne.Controls.Add(this.label13);
            this.pnlWolne.Controls.Add(this.label7);
            this.pnlWolne.Controls.Add(this.textBoxWykorzystany);
            this.pnlWolne.Controls.Add(this.label8);
            this.pnlWolne.Controls.Add(this.label9);
            this.pnlWolne.Controls.Add(this.label10);
            this.pnlWolne.Controls.Add(this.txtDataKoniec);
            this.pnlWolne.Controls.Add(this.label4);
            this.pnlWolne.Controls.Add(this.label5);
            this.pnlWolne.Controls.Add(this.cbTypUrlopu);
            this.pnlWolne.Location = new System.Drawing.Point(730, 61);
            this.pnlWolne.Name = "pnlWolne";
            this.pnlWolne.Size = new System.Drawing.Size(636, 563);
            this.pnlWolne.TabIndex = 15;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(211, 500);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(91, 49);
            this.btnAnuluj.TabIndex = 70;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapiszDodaj
            // 
            this.btnZapiszDodaj.Location = new System.Drawing.Point(17, 500);
            this.btnZapiszDodaj.Name = "btnZapiszDodaj";
            this.btnZapiszDodaj.Size = new System.Drawing.Size(91, 49);
            this.btnZapiszDodaj.TabIndex = 71;
            this.btnZapiszDodaj.Text = "Zapisz";
            this.btnZapiszDodaj.UseVisualStyleBackColor = true;
            this.btnZapiszDodaj.Click += new System.EventHandler(this.btnZapiszDodaj_Click);
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(114, 500);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(91, 49);
            this.btnWyczysc.TabIndex = 72;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // txtDataStart
            // 
            this.txtDataStart.Location = new System.Drawing.Point(188, 183);
            this.txtDataStart.Name = "txtDataStart";
            this.txtDataStart.Size = new System.Drawing.Size(225, 20);
            this.txtDataStart.TabIndex = 3;
            // 
            // KalendarzUrlop
            // 
            this.KalendarzUrlop.Location = new System.Drawing.Point(361, 6);
            this.KalendarzUrlop.Name = "KalendarzUrlop";
            this.KalendarzUrlop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Typ urlopu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(181, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "-planowany urlop";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(181, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "-zaplanowane szkolenie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Weryfikacja urlopu przysługującego:";
            // 
            // textBoxWnioskowany
            // 
            this.textBoxWnioskowany.Location = new System.Drawing.Point(262, 365);
            this.textBoxWnioskowany.Name = "textBoxWnioskowany";
            this.textBoxWnioskowany.Size = new System.Drawing.Size(151, 20);
            this.textBoxWnioskowany.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Okres urlopu:";
            // 
            // textBoxPozostalo
            // 
            this.textBoxPozostalo.Location = new System.Drawing.Point(262, 340);
            this.textBoxPozostalo.Name = "textBoxPozostalo";
            this.textBoxPozostalo.Size = new System.Drawing.Size(151, 20);
            this.textBoxPozostalo.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(261, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "26";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(146, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Przysługujący:";
            // 
            // textBoxWykorzystany
            // 
            this.textBoxWykorzystany.Location = new System.Drawing.Point(262, 315);
            this.textBoxWykorzystany.Name = "textBoxWykorzystany";
            this.textBoxWykorzystany.Size = new System.Drawing.Size(151, 20);
            this.textBoxWykorzystany.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(146, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Wykorzystany:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(146, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Pozostało:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(146, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Wnioskowany:";
            // 
            // txtDataKoniec
            // 
            this.txtDataKoniec.Location = new System.Drawing.Point(188, 213);
            this.txtDataKoniec.Name = "txtDataKoniec";
            this.txtDataKoniec.Size = new System.Drawing.Size(225, 20);
            this.txtDataKoniec.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(41, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data rozpoczęcia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(41, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Data zakonczenia:";
            // 
            // cbTypUrlopu
            // 
            this.cbTypUrlopu.FormattingEnabled = true;
            this.cbTypUrlopu.Location = new System.Drawing.Point(44, 105);
            this.cbTypUrlopu.Name = "cbTypUrlopu";
            this.cbTypUrlopu.Size = new System.Drawing.Size(185, 21);
            this.cbTypUrlopu.TabIndex = 2;
            // 
            // FormUrlopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlWolne);
            this.Controls.Add(this.pnlUserSearch);
            this.Controls.Add(this.pnlUrlopyControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUrlopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUrlopy";
            this.Load += new System.EventHandler(this.FormUrlopy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlUrlopyControl.ResumeLayout(false);
            this.pnlUserSearch.ResumeLayout(false);
            this.pnlUserSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlopyPraconik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPracownikow)).EndInit();
            this.pnlWolne.ResumeLayout(false);
            this.pnlWolne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStatystyki;
        private System.Windows.Forms.Button btnSzkolenia;
        private System.Windows.Forms.Button btnUrlopy;
        private System.Windows.Forms.Button btnWynagrodzenia;
        private System.Windows.Forms.Button btnPracownicy;
        private System.Windows.Forms.Panel pnlUrlopyControl;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Panel pnlUserSearch;
        private System.Windows.Forms.Label LWyszukaj;
        private System.Windows.Forms.TextBox txtWyszukajNazwisko;
        private System.Windows.Forms.DataGridView ListaPracownikow;
        private System.Windows.Forms.Panel pnlWolne;
        private System.Windows.Forms.DateTimePicker txtDataStart;
        private System.Windows.Forms.MonthCalendar KalendarzUrlop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxWnioskowany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPozostalo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxWykorzystany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtDataKoniec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTypUrlopu;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapiszDodaj;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvUrlopyPraconik;
    }
}