namespace KaliteKontrolOtomasyonu.Forms
{
    partial class NumuneKontrolPaneli
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
            this.urunKoduTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urunMPSTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.urunAdiTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.urunFirmasiTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.urunAciklamaTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.exceleAktarButonu = new System.Windows.Forms.Button();
            this.urunTarihiDateTime = new System.Windows.Forms.DateTimePicker();
            this.raporStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.numuneDataGrid = new System.Windows.Forms.DataGridView();
            this.raporEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.urunMPSAramaTXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.geriDonButonu = new System.Windows.Forms.Button();
            this.numuneKaydetmeButonu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.hepsiniListeleCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.verileriTemizle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tariheGoreAzalanRadio = new System.Windows.Forms.RadioButton();
            this.tariheGoreArtanRadio = new System.Windows.Forms.RadioButton();
            this.onayDurumuCombo = new System.Windows.Forms.ComboBox();
            this.baslangicDate = new System.Windows.Forms.DateTimePicker();
            this.BitisDate = new System.Windows.Forms.DateTimePicker();
            this.zamanAraliginiListele = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.numuneGuncelleButonu = new System.Windows.Forms.Button();
            this.numuneKaldir = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numuneDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // urunKoduTXT
            // 
            this.urunKoduTXT.Location = new System.Drawing.Point(323, 74);
            this.urunKoduTXT.Name = "urunKoduTXT";
            this.urunKoduTXT.Size = new System.Drawing.Size(174, 20);
            this.urunKoduTXT.TabIndex = 2;
            this.urunKoduTXT.TextChanged += new System.EventHandler(this.urunKoduTXT_TextChanged);
            this.urunKoduTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urunKoduTXT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(222, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Kodu :";
            // 
            // urunMPSTXT
            // 
            this.urunMPSTXT.Location = new System.Drawing.Point(323, 149);
            this.urunMPSTXT.Name = "urunMPSTXT";
            this.urunMPSTXT.Size = new System.Drawing.Size(175, 20);
            this.urunMPSTXT.TabIndex = 4;
            this.urunMPSTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urunMPSTXT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(256, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MPS :";
            // 
            // urunAdiTXT
            // 
            this.urunAdiTXT.Location = new System.Drawing.Point(323, 111);
            this.urunAdiTXT.Name = "urunAdiTXT";
            this.urunAdiTXT.Size = new System.Drawing.Size(174, 20);
            this.urunAdiTXT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(228, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Adı :";
            // 
            // urunFirmasiTXT
            // 
            this.urunFirmasiTXT.Location = new System.Drawing.Point(324, 183);
            this.urunFirmasiTXT.Name = "urunFirmasiTXT";
            this.urunFirmasiTXT.Size = new System.Drawing.Size(174, 20);
            this.urunFirmasiTXT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(193, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürünün Firması :";
            // 
            // urunAciklamaTXT
            // 
            this.urunAciklamaTXT.Location = new System.Drawing.Point(639, 123);
            this.urunAciklamaTXT.Multiline = true;
            this.urunAciklamaTXT.Name = "urunAciklamaTXT";
            this.urunAciklamaTXT.Size = new System.Drawing.Size(183, 63);
            this.urunAciklamaTXT.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(542, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Açıklama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(222, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ürün Tarihi :";
            // 
            // exceleAktarButonu
            // 
            this.exceleAktarButonu.Location = new System.Drawing.Point(795, 482);
            this.exceleAktarButonu.Name = "exceleAktarButonu";
            this.exceleAktarButonu.Size = new System.Drawing.Size(117, 72);
            this.exceleAktarButonu.TabIndex = 18;
            this.exceleAktarButonu.Text = "Excel\'e Aktar";
            this.exceleAktarButonu.UseVisualStyleBackColor = true;
            this.exceleAktarButonu.Click += new System.EventHandler(this.exceleAktarButonu_Click);
            // 
            // urunTarihiDateTime
            // 
            this.urunTarihiDateTime.Location = new System.Drawing.Point(323, 31);
            this.urunTarihiDateTime.Name = "urunTarihiDateTime";
            this.urunTarihiDateTime.Size = new System.Drawing.Size(174, 20);
            this.urunTarihiDateTime.TabIndex = 1;
            // 
            // raporStartDatePicker
            // 
            this.raporStartDatePicker.Location = new System.Drawing.Point(775, 374);
            this.raporStartDatePicker.Name = "raporStartDatePicker";
            this.raporStartDatePicker.Size = new System.Drawing.Size(155, 20);
            this.raporStartDatePicker.TabIndex = 16;
            // 
            // numuneDataGrid
            // 
            this.numuneDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.numuneDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.numuneDataGrid.Location = new System.Drawing.Point(12, 367);
            this.numuneDataGrid.Name = "numuneDataGrid";
            this.numuneDataGrid.Size = new System.Drawing.Size(740, 322);
            this.numuneDataGrid.TabIndex = 98;
            this.numuneDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.numuneDataGrid_CellContentClick);
            // 
            // raporEndDatePicker
            // 
            this.raporEndDatePicker.Location = new System.Drawing.Point(775, 456);
            this.raporEndDatePicker.Name = "raporEndDatePicker";
            this.raporEndDatePicker.Size = new System.Drawing.Size(155, 20);
            this.raporEndDatePicker.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(792, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Başlangıç Tarihi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(810, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bitiş Tarihi :";
            // 
            // urunMPSAramaTXT
            // 
            this.urunMPSAramaTXT.Location = new System.Drawing.Point(601, 341);
            this.urunMPSAramaTXT.Name = "urunMPSAramaTXT";
            this.urunMPSAramaTXT.Size = new System.Drawing.Size(151, 20);
            this.urunMPSAramaTXT.TabIndex = 12;
            this.urunMPSAramaTXT.TextChanged += new System.EventHandler(this.urunMPSAramaTXT_TextChanged);
            this.urunMPSAramaTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urunMPSAramaTXT_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(502, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ürün MPS :";
            // 
            // geriDonButonu
            // 
            this.geriDonButonu.BackColor = System.Drawing.Color.Transparent;
            this.geriDonButonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.geriDonButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geriDonButonu.FlatAppearance.BorderSize = 0;
            this.geriDonButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriDonButonu.Image = global::KaliteKontrolOtomasyonu.Properties.Resources.previous;
            this.geriDonButonu.Location = new System.Drawing.Point(12, 12);
            this.geriDonButonu.Name = "geriDonButonu";
            this.geriDonButonu.Size = new System.Drawing.Size(128, 125);
            this.geriDonButonu.TabIndex = 99;
            this.geriDonButonu.UseVisualStyleBackColor = false;
            this.geriDonButonu.Click += new System.EventHandler(this.geriDonButonu_Click);
            // 
            // numuneKaydetmeButonu
            // 
            this.numuneKaydetmeButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numuneKaydetmeButonu.Location = new System.Drawing.Point(749, 228);
            this.numuneKaydetmeButonu.Name = "numuneKaydetmeButonu";
            this.numuneKaydetmeButonu.Size = new System.Drawing.Size(99, 48);
            this.numuneKaydetmeButonu.TabIndex = 8;
            this.numuneKaydetmeButonu.Text = "Kaydet";
            this.numuneKaydetmeButonu.UseVisualStyleBackColor = false;
            this.numuneKaydetmeButonu.Click += new System.EventHandler(this.numuneKaydetmeButonu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(572, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Onay :";
            // 
            // hepsiniListeleCheckBox
            // 
            this.hepsiniListeleCheckBox.AutoSize = true;
            this.hepsiniListeleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hepsiniListeleCheckBox.Location = new System.Drawing.Point(323, 341);
            this.hepsiniListeleCheckBox.Name = "hepsiniListeleCheckBox";
            this.hepsiniListeleCheckBox.Size = new System.Drawing.Size(122, 22);
            this.hepsiniListeleCheckBox.TabIndex = 13;
            this.hepsiniListeleCheckBox.Text = "Hepsini Listele";
            this.hepsiniListeleCheckBox.UseVisualStyleBackColor = true;
            this.hepsiniListeleCheckBox.CheckedChanged += new System.EventHandler(this.hepsiniListeleCheckBox_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(300, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(542, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Kaydeden Kullanıcı :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(619, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "*";
            // 
            // verileriTemizle
            // 
            this.verileriTemizle.Location = new System.Drawing.Point(423, 233);
            this.verileriTemizle.Name = "verileriTemizle";
            this.verileriTemizle.Size = new System.Drawing.Size(75, 43);
            this.verileriTemizle.TabIndex = 11;
            this.verileriTemizle.Text = "Temizle";
            this.verileriTemizle.UseVisualStyleBackColor = true;
            this.verileriTemizle.Click += new System.EventHandler(this.verileriTemizle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(620, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(215, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "Onaylanmadıysa sebebini belirtiniz";
            // 
            // tariheGoreAzalanRadio
            // 
            this.tariheGoreAzalanRadio.AutoSize = true;
            this.tariheGoreAzalanRadio.Location = new System.Drawing.Point(14, 338);
            this.tariheGoreAzalanRadio.Name = "tariheGoreAzalanRadio";
            this.tariheGoreAzalanRadio.Size = new System.Drawing.Size(116, 17);
            this.tariheGoreAzalanRadio.TabIndex = 15;
            this.tariheGoreAzalanRadio.TabStop = true;
            this.tariheGoreAzalanRadio.Text = "Tarihe Göre Azalan";
            this.tariheGoreAzalanRadio.UseVisualStyleBackColor = true;
            this.tariheGoreAzalanRadio.CheckedChanged += new System.EventHandler(this.tariheGoreAzalanRadio_CheckedChanged);
            // 
            // tariheGoreArtanRadio
            // 
            this.tariheGoreArtanRadio.AutoSize = true;
            this.tariheGoreArtanRadio.Location = new System.Drawing.Point(136, 338);
            this.tariheGoreArtanRadio.Name = "tariheGoreArtanRadio";
            this.tariheGoreArtanRadio.Size = new System.Drawing.Size(109, 17);
            this.tariheGoreArtanRadio.TabIndex = 14;
            this.tariheGoreArtanRadio.TabStop = true;
            this.tariheGoreArtanRadio.Text = "Tarihe Göre Artan";
            this.tariheGoreArtanRadio.UseVisualStyleBackColor = true;
            this.tariheGoreArtanRadio.CheckedChanged += new System.EventHandler(this.tariheGoreArtanRadio_CheckedChanged);
            // 
            // onayDurumuCombo
            // 
            this.onayDurumuCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.onayDurumuCombo.FormattingEnabled = true;
            this.onayDurumuCombo.Location = new System.Drawing.Point(639, 68);
            this.onayDurumuCombo.Name = "onayDurumuCombo";
            this.onayDurumuCombo.Size = new System.Drawing.Size(148, 21);
            this.onayDurumuCombo.TabIndex = 6;
            // 
            // baslangicDate
            // 
            this.baslangicDate.Location = new System.Drawing.Point(16, 262);
            this.baslangicDate.Name = "baslangicDate";
            this.baslangicDate.Size = new System.Drawing.Size(104, 20);
            this.baslangicDate.TabIndex = 20;
            // 
            // BitisDate
            // 
            this.BitisDate.Location = new System.Drawing.Point(136, 261);
            this.BitisDate.Name = "BitisDate";
            this.BitisDate.Size = new System.Drawing.Size(103, 20);
            this.BitisDate.TabIndex = 21;
            // 
            // zamanAraliginiListele
            // 
            this.zamanAraliginiListele.Location = new System.Drawing.Point(92, 287);
            this.zamanAraliginiListele.Name = "zamanAraliginiListele";
            this.zamanAraliginiListele.Size = new System.Drawing.Size(84, 35);
            this.zamanAraliginiListele.TabIndex = 22;
            this.zamanAraliginiListele.Text = "Zaman Aralığını Listele";
            this.zamanAraliginiListele.UseVisualStyleBackColor = true;
            this.zamanAraliginiListele.Click += new System.EventHandler(this.zamanAraliginiListele_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(121, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "-";
            // 
            // numuneGuncelleButonu
            // 
            this.numuneGuncelleButonu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.numuneGuncelleButonu.Location = new System.Drawing.Point(639, 230);
            this.numuneGuncelleButonu.Name = "numuneGuncelleButonu";
            this.numuneGuncelleButonu.Size = new System.Drawing.Size(96, 50);
            this.numuneGuncelleButonu.TabIndex = 9;
            this.numuneGuncelleButonu.Text = "Güncelle";
            this.numuneGuncelleButonu.UseVisualStyleBackColor = false;
            this.numuneGuncelleButonu.Click += new System.EventHandler(this.numuneGuncelleButonu_Click);
            // 
            // numuneKaldir
            // 
            this.numuneKaldir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.numuneKaldir.Location = new System.Drawing.Point(519, 230);
            this.numuneKaldir.Name = "numuneKaldir";
            this.numuneKaldir.Size = new System.Drawing.Size(96, 48);
            this.numuneKaldir.TabIndex = 10;
            this.numuneKaldir.Text = "Kaldır";
            this.numuneKaldir.UseVisualStyleBackColor = false;
            this.numuneKaldir.Click += new System.EventHandler(this.numuneKaldir_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(636, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Onay Durumu Belirtilmemiş";
            // 
            // NumuneKontrolPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 719);
            this.Controls.Add(this.numuneKaldir);
            this.Controls.Add(this.numuneGuncelleButonu);
            this.Controls.Add(this.zamanAraliginiListele);
            this.Controls.Add(this.BitisDate);
            this.Controls.Add(this.baslangicDate);
            this.Controls.Add(this.onayDurumuCombo);
            this.Controls.Add(this.tariheGoreArtanRadio);
            this.Controls.Add(this.tariheGoreAzalanRadio);
            this.Controls.Add(this.verileriTemizle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.hepsiniListeleCheckBox);
            this.Controls.Add(this.numuneKaydetmeButonu);
            this.Controls.Add(this.geriDonButonu);
            this.Controls.Add(this.urunMPSAramaTXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numuneDataGrid);
            this.Controls.Add(this.raporEndDatePicker);
            this.Controls.Add(this.raporStartDatePicker);
            this.Controls.Add(this.urunTarihiDateTime);
            this.Controls.Add(this.exceleAktarButonu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunAciklamaTXT);
            this.Controls.Add(this.urunFirmasiTXT);
            this.Controls.Add(this.urunAdiTXT);
            this.Controls.Add(this.urunMPSTXT);
            this.Controls.Add(this.urunKoduTXT);
            this.Name = "NumuneKontrolPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalite Kontrol Otomasyonu - Numune Kontrol Paneli";
            this.Load += new System.EventHandler(this.NumuneKontrolPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numuneDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urunKoduTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urunMPSTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urunAdiTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urunFirmasiTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urunAciklamaTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exceleAktarButonu;
        private System.Windows.Forms.DateTimePicker urunTarihiDateTime;
        private System.Windows.Forms.DateTimePicker raporStartDatePicker;
        private System.Windows.Forms.DataGridView numuneDataGrid;
        private System.Windows.Forms.DateTimePicker raporEndDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox urunMPSAramaTXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button geriDonButonu;
        private System.Windows.Forms.Button numuneKaydetmeButonu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox hepsiniListeleCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button verileriTemizle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton tariheGoreAzalanRadio;
        private System.Windows.Forms.RadioButton tariheGoreArtanRadio;
        private System.Windows.Forms.ComboBox onayDurumuCombo;
        private System.Windows.Forms.DateTimePicker baslangicDate;
        private System.Windows.Forms.DateTimePicker BitisDate;
        private System.Windows.Forms.Button zamanAraliginiListele;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button numuneGuncelleButonu;
        private System.Windows.Forms.Button numuneKaldir;
        private System.Windows.Forms.Label label16;
    }
}