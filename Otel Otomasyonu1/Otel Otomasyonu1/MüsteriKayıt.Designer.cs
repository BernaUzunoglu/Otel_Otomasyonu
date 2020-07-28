namespace Otel_Otomasyonu1
{
    partial class MüsteriKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüsteriKayıt));
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_odalar = new System.Windows.Forms.ComboBox();
            this.lbl_uyruk = new System.Windows.Forms.Label();
            this.cmb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_odaTürleri = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Mus_Kayıt = new System.Windows.Forms.Button();
            this.dtTimePck_Cıkıs = new System.Windows.Forms.DateTimePicker();
            this.dtTimePck_Giris = new System.Windows.Forms.DateTimePicker();
            this.mskdTxt_tel = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ucret = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdio_btn_Yabanci = new System.Windows.Forms.RadioButton();
            this.rdio_btn_Tc = new System.Windows.Forms.RadioButton();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Mus_sil = new System.Windows.Forms.Button();
            this.datagridMusteri = new System.Windows.Forms.DataGridView();
            this.musteriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyrukDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıSoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otel_OtomasyonuDataSetMusteriTablosu = new Otel_Otomasyonu1.Otel_OtomasyonuDataSetMusteriTablosu();
            this.btn_Mus_Lstl = new System.Windows.Forms.Button();
            this.lbl_MusteriId = new System.Windows.Forms.Label();
            this.musteriTableAdapter = new Otel_Otomasyonu1.Otel_OtomasyonuDataSetMusteriTablosuTableAdapters.MusteriTableAdapter();
            this.otel_OtomasyonuDataPerYon1 = new Otel_Otomasyonu1.Otel_OtomasyonuDataPerYon();
            this.btn_gncl = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otel_OtomasyonuDataSetMusteriTablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otel_OtomasyonuDataPerYon1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(329, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Müşteri Kayıt Formu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.combo_odalar);
            this.groupBox1.Controls.Add(this.lbl_uyruk);
            this.groupBox1.Controls.Add(this.cmb_Cinsiyet);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cmb_odaTürleri);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btn_Mus_Kayıt);
            this.groupBox1.Controls.Add(this.dtTimePck_Cıkıs);
            this.groupBox1.Controls.Add(this.dtTimePck_Giris);
            this.groupBox1.Controls.Add(this.mskdTxt_tel);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_ucret);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rdio_btn_Yabanci);
            this.groupBox1.Controls.Add(this.rdio_btn_Tc);
            this.groupBox1.Controls.Add(this.txt_adres);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.txt_AdSoyad);
            this.groupBox1.Controls.Add(this.txt_Tc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 479);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // combo_odalar
            // 
            this.combo_odalar.FormattingEnabled = true;
            this.combo_odalar.Location = new System.Drawing.Point(347, 301);
            this.combo_odalar.Name = "combo_odalar";
            this.combo_odalar.Size = new System.Drawing.Size(92, 21);
            this.combo_odalar.TabIndex = 17;
            // 
            // lbl_uyruk
            // 
            this.lbl_uyruk.AutoSize = true;
            this.lbl_uyruk.Location = new System.Drawing.Point(287, 44);
            this.lbl_uyruk.Name = "lbl_uyruk";
            this.lbl_uyruk.Size = new System.Drawing.Size(0, 13);
            this.lbl_uyruk.TabIndex = 49;
            // 
            // cmb_Cinsiyet
            // 
            this.cmb_Cinsiyet.FormattingEnabled = true;
            this.cmb_Cinsiyet.Items.AddRange(new object[] {
            "Bayan",
            "Bay"});
            this.cmb_Cinsiyet.Location = new System.Drawing.Point(120, 269);
            this.cmb_Cinsiyet.Name = "cmb_Cinsiyet";
            this.cmb_Cinsiyet.Size = new System.Drawing.Size(119, 21);
            this.cmb_Cinsiyet.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(351, 379);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "0";
            // 
            // cmb_odaTürleri
            // 
            this.cmb_odaTürleri.FormattingEnabled = true;
            this.cmb_odaTürleri.Items.AddRange(new object[] {
            "Standart Tek Kişilik",
            "Standart Çift Kişilik",
            "Birleşik Oda",
            "Suit Oda"});
            this.cmb_odaTürleri.Location = new System.Drawing.Point(120, 306);
            this.cmb_odaTürleri.Name = "cmb_odaTürleri";
            this.cmb_odaTürleri.Size = new System.Drawing.Size(119, 21);
            this.cmb_odaTürleri.TabIndex = 46;
            this.cmb_odaTürleri.TextChanged += new System.EventHandler(this.cmb_odaTürleri_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Oda Türü";
            // 
            // btn_Mus_Kayıt
            // 
            this.btn_Mus_Kayıt.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_Mus_Kayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Mus_Kayıt.Location = new System.Drawing.Point(138, 441);
            this.btn_Mus_Kayıt.Name = "btn_Mus_Kayıt";
            this.btn_Mus_Kayıt.Size = new System.Drawing.Size(149, 32);
            this.btn_Mus_Kayıt.TabIndex = 44;
            this.btn_Mus_Kayıt.Text = "Kayıt";
            this.btn_Mus_Kayıt.UseVisualStyleBackColor = false;
            this.btn_Mus_Kayıt.Click += new System.EventHandler(this.btn_Mus_Kayıt_Click);
            // 
            // dtTimePck_Cıkıs
            // 
            this.dtTimePck_Cıkıs.Location = new System.Drawing.Point(120, 398);
            this.dtTimePck_Cıkıs.Name = "dtTimePck_Cıkıs";
            this.dtTimePck_Cıkıs.Size = new System.Drawing.Size(200, 20);
            this.dtTimePck_Cıkıs.TabIndex = 43;
            this.dtTimePck_Cıkıs.ValueChanged += new System.EventHandler(this.dtTimePck_Cıkıs_ValueChanged);
            // 
            // dtTimePck_Giris
            // 
            this.dtTimePck_Giris.Location = new System.Drawing.Point(120, 365);
            this.dtTimePck_Giris.Name = "dtTimePck_Giris";
            this.dtTimePck_Giris.Size = new System.Drawing.Size(200, 20);
            this.dtTimePck_Giris.TabIndex = 42;
            // 
            // mskdTxt_tel
            // 
            this.mskdTxt_tel.Location = new System.Drawing.Point(120, 144);
            this.mskdTxt_tel.Mask = "(999) 000-0000";
            this.mskdTxt_tel.Name = "mskdTxt_tel";
            this.mskdTxt_tel.Size = new System.Drawing.Size(119, 20);
            this.mskdTxt_tel.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(33, 402);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "Çıkış Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(35, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Gİriş Tarihi";
            // 
            // txt_ucret
            // 
            this.txt_ucret.Location = new System.Drawing.Point(120, 333);
            this.txt_ucret.Name = "txt_ucret";
            this.txt_ucret.Size = new System.Drawing.Size(119, 20);
            this.txt_ucret.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(68, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Ücret";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(267, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Oda Numarası";
            // 
            // rdio_btn_Yabanci
            // 
            this.rdio_btn_Yabanci.AutoSize = true;
            this.rdio_btn_Yabanci.BackColor = System.Drawing.Color.Transparent;
            this.rdio_btn_Yabanci.Location = new System.Drawing.Point(165, 43);
            this.rdio_btn_Yabanci.Name = "rdio_btn_Yabanci";
            this.rdio_btn_Yabanci.Size = new System.Drawing.Size(95, 17);
            this.rdio_btn_Yabanci.TabIndex = 32;
            this.rdio_btn_Yabanci.TabStop = true;
            this.rdio_btn_Yabanci.Text = "Yabancı Uyruk";
            this.rdio_btn_Yabanci.UseVisualStyleBackColor = false;
            // 
            // rdio_btn_Tc
            // 
            this.rdio_btn_Tc.AutoSize = true;
            this.rdio_btn_Tc.BackColor = System.Drawing.Color.Transparent;
            this.rdio_btn_Tc.Location = new System.Drawing.Point(120, 42);
            this.rdio_btn_Tc.Name = "rdio_btn_Tc";
            this.rdio_btn_Tc.Size = new System.Drawing.Size(39, 17);
            this.rdio_btn_Tc.TabIndex = 31;
            this.rdio_btn_Tc.TabStop = true;
            this.rdio_btn_Tc.Text = "TC";
            this.rdio_btn_Tc.UseVisualStyleBackColor = false;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(120, 205);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(119, 58);
            this.txt_adres.TabIndex = 30;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(120, 179);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(119, 20);
            this.txt_mail.TabIndex = 29;
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(120, 118);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(119, 20);
            this.txt_AdSoyad.TabIndex = 27;
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(120, 80);
            this.txt_Tc.MaxLength = 11;
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(119, 20);
            this.txt_Tc.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(52, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(63, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(61, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(54, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "TC. Kimlik No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Uyruk";
            // 
            // btn_Mus_sil
            // 
            this.btn_Mus_sil.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_Mus_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Mus_sil.Location = new System.Drawing.Point(510, 107);
            this.btn_Mus_sil.Name = "btn_Mus_sil";
            this.btn_Mus_sil.Size = new System.Drawing.Size(96, 32);
            this.btn_Mus_sil.TabIndex = 50;
            this.btn_Mus_sil.Text = "Kayıt Sil";
            this.btn_Mus_sil.UseVisualStyleBackColor = false;
            this.btn_Mus_sil.Click += new System.EventHandler(this.btn_Mus_sil_Click);
            // 
            // datagridMusteri
            // 
            this.datagridMusteri.AutoGenerateColumns = false;
            this.datagridMusteri.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.datagridMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridMusteri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIdDataGridViewTextBoxColumn,
            this.odaNumarasiDataGridViewTextBoxColumn,
            this.uyrukDataGridViewCheckBoxColumn,
            this.tCNoDataGridViewTextBoxColumn,
            this.adıSoyadıDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.odaTürüDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.girisTarihiDataGridViewTextBoxColumn,
            this.cikisTarihiDataGridViewTextBoxColumn});
            this.datagridMusteri.DataSource = this.musteriBindingSource;
            this.datagridMusteri.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.datagridMusteri.Location = new System.Drawing.Point(489, 169);
            this.datagridMusteri.Name = "datagridMusteri";
            this.datagridMusteri.Size = new System.Drawing.Size(633, 357);
            this.datagridMusteri.TabIndex = 18;
            this.datagridMusteri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridMusteri_CellClick);
            // 
            // musteriIdDataGridViewTextBoxColumn
            // 
            this.musteriIdDataGridViewTextBoxColumn.DataPropertyName = "Musteri_Id";
            this.musteriIdDataGridViewTextBoxColumn.HeaderText = "Musteri_Id";
            this.musteriIdDataGridViewTextBoxColumn.Name = "musteriIdDataGridViewTextBoxColumn";
            this.musteriIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odaNumarasiDataGridViewTextBoxColumn
            // 
            this.odaNumarasiDataGridViewTextBoxColumn.DataPropertyName = "OdaNumarasi";
            this.odaNumarasiDataGridViewTextBoxColumn.HeaderText = "OdaNumarasi";
            this.odaNumarasiDataGridViewTextBoxColumn.Name = "odaNumarasiDataGridViewTextBoxColumn";
            // 
            // uyrukDataGridViewCheckBoxColumn
            // 
            this.uyrukDataGridViewCheckBoxColumn.DataPropertyName = "Uyruk";
            this.uyrukDataGridViewCheckBoxColumn.HeaderText = "Uyruk";
            this.uyrukDataGridViewCheckBoxColumn.Name = "uyrukDataGridViewCheckBoxColumn";
            // 
            // tCNoDataGridViewTextBoxColumn
            // 
            this.tCNoDataGridViewTextBoxColumn.DataPropertyName = "TC_No";
            this.tCNoDataGridViewTextBoxColumn.HeaderText = "TC_No";
            this.tCNoDataGridViewTextBoxColumn.Name = "tCNoDataGridViewTextBoxColumn";
            // 
            // adıSoyadıDataGridViewTextBoxColumn
            // 
            this.adıSoyadıDataGridViewTextBoxColumn.DataPropertyName = "AdıSoyadı";
            this.adıSoyadıDataGridViewTextBoxColumn.HeaderText = "AdıSoyadı";
            this.adıSoyadıDataGridViewTextBoxColumn.Name = "adıSoyadıDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "E_Mail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "E_Mail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // odaTürüDataGridViewTextBoxColumn
            // 
            this.odaTürüDataGridViewTextBoxColumn.DataPropertyName = "Oda_Türü";
            this.odaTürüDataGridViewTextBoxColumn.HeaderText = "Oda_Türü";
            this.odaTürüDataGridViewTextBoxColumn.Name = "odaTürüDataGridViewTextBoxColumn";
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "Ucret";
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            // 
            // girisTarihiDataGridViewTextBoxColumn
            // 
            this.girisTarihiDataGridViewTextBoxColumn.DataPropertyName = "Giris_Tarihi";
            this.girisTarihiDataGridViewTextBoxColumn.HeaderText = "Giris_Tarihi";
            this.girisTarihiDataGridViewTextBoxColumn.Name = "girisTarihiDataGridViewTextBoxColumn";
            // 
            // cikisTarihiDataGridViewTextBoxColumn
            // 
            this.cikisTarihiDataGridViewTextBoxColumn.DataPropertyName = "Cikis_Tarihi";
            this.cikisTarihiDataGridViewTextBoxColumn.HeaderText = "Cikis_Tarihi";
            this.cikisTarihiDataGridViewTextBoxColumn.Name = "cikisTarihiDataGridViewTextBoxColumn";
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.otel_OtomasyonuDataSetMusteriTablosu;
            // 
            // otel_OtomasyonuDataSetMusteriTablosu
            // 
            this.otel_OtomasyonuDataSetMusteriTablosu.DataSetName = "Otel_OtomasyonuDataSetMusteriTablosu";
            this.otel_OtomasyonuDataSetMusteriTablosu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Mus_Lstl
            // 
            this.btn_Mus_Lstl.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_Mus_Lstl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Mus_Lstl.Location = new System.Drawing.Point(999, 107);
            this.btn_Mus_Lstl.Name = "btn_Mus_Lstl";
            this.btn_Mus_Lstl.Size = new System.Drawing.Size(123, 32);
            this.btn_Mus_Lstl.TabIndex = 51;
            this.btn_Mus_Lstl.Text = "Müşteri Listele";
            this.btn_Mus_Lstl.UseVisualStyleBackColor = false;
            this.btn_Mus_Lstl.Click += new System.EventHandler(this.btn_Mus_Lstl_Click);
            // 
            // lbl_MusteriId
            // 
            this.lbl_MusteriId.AutoSize = true;
            this.lbl_MusteriId.Location = new System.Drawing.Point(458, 546);
            this.lbl_MusteriId.Name = "lbl_MusteriId";
            this.lbl_MusteriId.Size = new System.Drawing.Size(0, 13);
            this.lbl_MusteriId.TabIndex = 53;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // otel_OtomasyonuDataPerYon1
            // 
            this.otel_OtomasyonuDataPerYon1.DataSetName = "Otel_OtomasyonuDataPerYon";
            this.otel_OtomasyonuDataPerYon1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_gncl
            // 
            this.btn_gncl.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_gncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_gncl.Location = new System.Drawing.Point(642, 107);
            this.btn_gncl.Name = "btn_gncl";
            this.btn_gncl.Size = new System.Drawing.Size(96, 32);
            this.btn_gncl.TabIndex = 54;
            this.btn_gncl.Text = "Güncelle";
            this.btn_gncl.UseVisualStyleBackColor = false;
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_ara.Location = new System.Drawing.Point(787, 107);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(96, 32);
            this.btn_ara.TabIndex = 55;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(728, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Aranacak Öğe";
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(810, 62);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(100, 20);
            this.txt_ara.TabIndex = 57;
            // 
            // MüsteriKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 568);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_gncl);
            this.Controls.Add(this.lbl_MusteriId);
            this.Controls.Add(this.btn_Mus_Lstl);
            this.Controls.Add(this.btn_Mus_sil);
            this.Controls.Add(this.datagridMusteri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Name = "MüsteriKayıt";
            this.Text = " Kayıt";
            this.Load += new System.EventHandler(this.MüsteriKayıt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otel_OtomasyonuDataSetMusteriTablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otel_OtomasyonuDataPerYon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdio_btn_Yabanci;
        private System.Windows.Forms.RadioButton rdio_btn_Tc;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.TextBox txt_Tc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ucret;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Mus_Kayıt;
        private System.Windows.Forms.DateTimePicker dtTimePck_Cıkıs;
        private System.Windows.Forms.DateTimePicker dtTimePck_Giris;
        private System.Windows.Forms.MaskedTextBox mskdTxt_tel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combo_odalar;
        private System.Windows.Forms.DataGridView datagridMusteri;
        private System.Windows.Forms.ComboBox cmb_odaTürleri;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_Cinsiyet;
        private System.Windows.Forms.Label lbl_uyruk;
        private System.Windows.Forms.Button btn_Mus_sil;
        private System.Windows.Forms.Button btn_Mus_Lstl;
        private System.Windows.Forms.Label lbl_MusteriId;
        private Otel_OtomasyonuDataSetMusteriTablosu otel_OtomasyonuDataSetMusteriTablosu;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private Otel_OtomasyonuDataSetMusteriTablosuTableAdapters.MusteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uyrukDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıSoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihiDataGridViewTextBoxColumn;
        private Otel_OtomasyonuDataPerYon otel_OtomasyonuDataPerYon1;
        private System.Windows.Forms.Button btn_gncl;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_ara;


    }
}