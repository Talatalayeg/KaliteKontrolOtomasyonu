namespace KaliteKontrolOtomasyonu.Forms
{
    partial class CalisanPaneli
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
            this.geriDonButonu = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.formuTemizle = new System.Windows.Forms.Button();
            this.calisaniKaldirButonu = new System.Windows.Forms.Button();
            this.calisaniDuzenleButonu = new System.Windows.Forms.Button();
            this.calisanKaydetButonu = new System.Windows.Forms.Button();
            this.calisanListesiDataGrid = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.calisanAdiTXT = new System.Windows.Forms.TextBox();
            this.calisanSoyadiTXT = new System.Windows.Forms.TextBox();
            this.calisanTCTXT = new System.Windows.Forms.TextBox();
            this.calisanKullaniciAdiTXT = new System.Windows.Forms.TextBox();
            this.calisanTCaraTXT = new System.Windows.Forms.TextBox();
            this.calisanSifreTXT = new System.Windows.Forms.TextBox();
            this.calisanTelefonTXT = new System.Windows.Forms.TextBox();
            this.calisanEpostaTXT = new System.Windows.Forms.TextBox();
            this.calisanAdresTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calisanRolAdmin = new System.Windows.Forms.RadioButton();
            this.calisanRolCalisan = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.calisanListesiDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // geriDonButonu
            // 
            this.geriDonButonu.BackColor = System.Drawing.Color.Transparent;
            this.geriDonButonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.geriDonButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geriDonButonu.FlatAppearance.BorderSize = 0;
            this.geriDonButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriDonButonu.Image = global::KaliteKontrolOtomasyonu.Properties.Resources.previous;
            this.geriDonButonu.Location = new System.Drawing.Point(18, 18);
            this.geriDonButonu.Name = "geriDonButonu";
            this.geriDonButonu.Size = new System.Drawing.Size(128, 125);
            this.geriDonButonu.TabIndex = 2;
            this.geriDonButonu.UseVisualStyleBackColor = false;
            this.geriDonButonu.Click += new System.EventHandler(this.geriDonButonu_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(527, 281);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Hepsini Listele";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // formuTemizle
            // 
            this.formuTemizle.Location = new System.Drawing.Point(519, 215);
            this.formuTemizle.Name = "formuTemizle";
            this.formuTemizle.Size = new System.Drawing.Size(102, 48);
            this.formuTemizle.TabIndex = 14;
            this.formuTemizle.Text = "Temizle";
            this.formuTemizle.UseVisualStyleBackColor = true;
            this.formuTemizle.Click += new System.EventHandler(this.formuTemizle_Click);
            // 
            // calisaniKaldirButonu
            // 
            this.calisaniKaldirButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.calisaniKaldirButonu.Location = new System.Drawing.Point(154, 215);
            this.calisaniKaldirButonu.Name = "calisaniKaldirButonu";
            this.calisaniKaldirButonu.Size = new System.Drawing.Size(96, 48);
            this.calisaniKaldirButonu.TabIndex = 13;
            this.calisaniKaldirButonu.Text = "Çalışanı Kaldır";
            this.calisaniKaldirButonu.UseVisualStyleBackColor = false;
            this.calisaniKaldirButonu.Click += new System.EventHandler(this.calisaniKaldirButonu_Click);
            // 
            // calisaniDuzenleButonu
            // 
            this.calisaniDuzenleButonu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.calisaniDuzenleButonu.Location = new System.Drawing.Point(279, 215);
            this.calisaniDuzenleButonu.Name = "calisaniDuzenleButonu";
            this.calisaniDuzenleButonu.Size = new System.Drawing.Size(92, 48);
            this.calisaniDuzenleButonu.TabIndex = 12;
            this.calisaniDuzenleButonu.Text = "Çalışanı Güncelle";
            this.calisaniDuzenleButonu.UseVisualStyleBackColor = false;
            this.calisaniDuzenleButonu.Click += new System.EventHandler(this.calisaniDuzenleButonu_Click);
            // 
            // calisanKaydetButonu
            // 
            this.calisanKaydetButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.calisanKaydetButonu.Location = new System.Drawing.Point(404, 215);
            this.calisanKaydetButonu.Name = "calisanKaydetButonu";
            this.calisanKaydetButonu.Size = new System.Drawing.Size(96, 48);
            this.calisanKaydetButonu.TabIndex = 11;
            this.calisanKaydetButonu.Text = "Çalışan Kaydet";
            this.calisanKaydetButonu.UseVisualStyleBackColor = false;
            this.calisanKaydetButonu.Click += new System.EventHandler(this.calisanKaydetButonu_Click);
            // 
            // calisanListesiDataGrid
            // 
            this.calisanListesiDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.calisanListesiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calisanListesiDataGrid.Location = new System.Drawing.Point(18, 304);
            this.calisanListesiDataGrid.Name = "calisanListesiDataGrid";
            this.calisanListesiDataGrid.Size = new System.Drawing.Size(902, 372);
            this.calisanListesiDataGrid.TabIndex = 18;
            this.calisanListesiDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calisanListesiDataGrid_CellContentClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(671, 277);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "TC Kimlik :";
            // 
            // calisanAdiTXT
            // 
            this.calisanAdiTXT.Location = new System.Drawing.Point(320, 20);
            this.calisanAdiTXT.Name = "calisanAdiTXT";
            this.calisanAdiTXT.Size = new System.Drawing.Size(200, 20);
            this.calisanAdiTXT.TabIndex = 1;
            // 
            // calisanSoyadiTXT
            // 
            this.calisanSoyadiTXT.Location = new System.Drawing.Point(320, 60);
            this.calisanSoyadiTXT.Name = "calisanSoyadiTXT";
            this.calisanSoyadiTXT.Size = new System.Drawing.Size(200, 20);
            this.calisanSoyadiTXT.TabIndex = 2;
            // 
            // calisanTCTXT
            // 
            this.calisanTCTXT.Location = new System.Drawing.Point(320, 94);
            this.calisanTCTXT.MaxLength = 11;
            this.calisanTCTXT.Name = "calisanTCTXT";
            this.calisanTCTXT.Size = new System.Drawing.Size(200, 20);
            this.calisanTCTXT.TabIndex = 3;
            this.calisanTCTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calisanTCTXT_KeyPress);
            // 
            // calisanKullaniciAdiTXT
            // 
            this.calisanKullaniciAdiTXT.Location = new System.Drawing.Point(320, 126);
            this.calisanKullaniciAdiTXT.Name = "calisanKullaniciAdiTXT";
            this.calisanKullaniciAdiTXT.Size = new System.Drawing.Size(200, 20);
            this.calisanKullaniciAdiTXT.TabIndex = 4;
            // 
            // calisanTCaraTXT
            // 
            this.calisanTCaraTXT.Location = new System.Drawing.Point(758, 276);
            this.calisanTCaraTXT.Name = "calisanTCaraTXT";
            this.calisanTCaraTXT.Size = new System.Drawing.Size(162, 20);
            this.calisanTCaraTXT.TabIndex = 15;
            this.calisanTCaraTXT.TextChanged += new System.EventHandler(this.calisanTCaraTXT_TextChanged);
            // 
            // calisanSifreTXT
            // 
            this.calisanSifreTXT.Location = new System.Drawing.Point(320, 164);
            this.calisanSifreTXT.Name = "calisanSifreTXT";
            this.calisanSifreTXT.Size = new System.Drawing.Size(200, 20);
            this.calisanSifreTXT.TabIndex = 5;
            // 
            // calisanTelefonTXT
            // 
            this.calisanTelefonTXT.Location = new System.Drawing.Point(679, 20);
            this.calisanTelefonTXT.MaxLength = 11;
            this.calisanTelefonTXT.Name = "calisanTelefonTXT";
            this.calisanTelefonTXT.Size = new System.Drawing.Size(200, 20);
            this.calisanTelefonTXT.TabIndex = 6;
            // 
            // calisanEpostaTXT
            // 
            this.calisanEpostaTXT.Location = new System.Drawing.Point(679, 59);
            this.calisanEpostaTXT.Name = "calisanEpostaTXT";
            this.calisanEpostaTXT.Size = new System.Drawing.Size(200, 20);
            this.calisanEpostaTXT.TabIndex = 7;
            // 
            // calisanAdresTXT
            // 
            this.calisanAdresTXT.Location = new System.Drawing.Point(679, 129);
            this.calisanAdresTXT.Multiline = true;
            this.calisanAdresTXT.Name = "calisanAdresTXT";
            this.calisanAdresTXT.Size = new System.Drawing.Size(200, 58);
            this.calisanAdresTXT.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(598, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(612, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rol :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(583, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "E-Posta :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(250, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(204, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Çalışan TC :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(563, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Telefon No :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(179, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Çalışan Soyadı :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(197, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "Kullanıcı Adı :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(204, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 20);
            this.label18.TabIndex = 4;
            this.label18.Text = "Çalışan Adı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(297, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(297, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(297, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(656, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "*";
            // 
            // calisanRolAdmin
            // 
            this.calisanRolAdmin.AutoSize = true;
            this.calisanRolAdmin.Location = new System.Drawing.Point(679, 99);
            this.calisanRolAdmin.Name = "calisanRolAdmin";
            this.calisanRolAdmin.Size = new System.Drawing.Size(54, 17);
            this.calisanRolAdmin.TabIndex = 8;
            this.calisanRolAdmin.TabStop = true;
            this.calisanRolAdmin.Text = "Admin";
            this.calisanRolAdmin.UseVisualStyleBackColor = true;
            // 
            // calisanRolCalisan
            // 
            this.calisanRolCalisan.AutoSize = true;
            this.calisanRolCalisan.Location = new System.Drawing.Point(748, 99);
            this.calisanRolCalisan.Name = "calisanRolCalisan";
            this.calisanRolCalisan.Size = new System.Drawing.Size(59, 17);
            this.calisanRolCalisan.TabIndex = 9;
            this.calisanRolCalisan.TabStop = true;
            this.calisanRolCalisan.Text = "Çalışan";
            this.calisanRolCalisan.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(832, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Seçilmemiş";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.calisanAdiTXT);
            this.panel1.Controls.Add(this.calisanSoyadiTXT);
            this.panel1.Controls.Add(this.calisanTCTXT);
            this.panel1.Controls.Add(this.calisanKullaniciAdiTXT);
            this.panel1.Controls.Add(this.calisanSifreTXT);
            this.panel1.Controls.Add(this.calisanTelefonTXT);
            this.panel1.Controls.Add(this.calisanEpostaTXT);
            this.panel1.Controls.Add(this.calisanRolAdmin);
            this.panel1.Controls.Add(this.calisanRolCalisan);
            this.panel1.Controls.Add(this.calisanAdresTXT);
            this.panel1.Controls.Add(this.calisaniKaldirButonu);
            this.panel1.Controls.Add(this.calisaniDuzenleButonu);
            this.panel1.Controls.Add(this.calisanKaydetButonu);
            this.panel1.Controls.Add(this.formuTemizle);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.calisanTCaraTXT);
            this.panel1.Controls.Add(this.calisanListesiDataGrid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 679);
            this.panel1.TabIndex = 32;
            // 
            // CalisanPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 691);
            this.Controls.Add(this.geriDonButonu);
            this.Controls.Add(this.panel1);
            this.Name = "CalisanPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalite Kontrol Otomasyonu - Çalışan Paneli";
            this.Load += new System.EventHandler(this.CalisanPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calisanListesiDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button geriDonButonu;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox calisanTCaraTXT;
        private System.Windows.Forms.DataGridView calisanListesiDataGrid;
        private System.Windows.Forms.TextBox calisanAdiTXT;
        private System.Windows.Forms.TextBox calisanSoyadiTXT;
        private System.Windows.Forms.TextBox calisanKullaniciAdiTXT;
        private System.Windows.Forms.TextBox calisanSifreTXT;
        private System.Windows.Forms.TextBox calisanTelefonTXT;
        private System.Windows.Forms.TextBox calisanEpostaTXT;
        private System.Windows.Forms.TextBox calisanAdresTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button calisaniKaldirButonu;
        private System.Windows.Forms.Button calisaniDuzenleButonu;
        private System.Windows.Forms.Button calisanKaydetButonu;
        private System.Windows.Forms.TextBox calisanTCTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button formuTemizle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton calisanRolAdmin;
        private System.Windows.Forms.RadioButton calisanRolCalisan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}