namespace KaliteKontrolOtomasyonu
{
    partial class GirisPaneli
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
            this.kullaniciAdiTXT = new System.Windows.Forms.TextBox();
            this.sifreTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GirisButonu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.veriTabaniGuncelleme = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.veriTabaniBasligiTXT = new System.Windows.Forms.TextBox();
            this.veriTabaniGuncelleButonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullaniciAdiTXT
            // 
            this.kullaniciAdiTXT.Location = new System.Drawing.Point(223, 264);
            this.kullaniciAdiTXT.Name = "kullaniciAdiTXT";
            this.kullaniciAdiTXT.Size = new System.Drawing.Size(210, 20);
            this.kullaniciAdiTXT.TabIndex = 1;
            // 
            // sifreTXT
            // 
            this.sifreTXT.Location = new System.Drawing.Point(223, 323);
            this.sifreTXT.Name = "sifreTXT";
            this.sifreTXT.PasswordChar = '*';
            this.sifreTXT.Size = new System.Drawing.Size(210, 20);
            this.sifreTXT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // GirisButonu
            // 
            this.GirisButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButonu.Location = new System.Drawing.Point(303, 373);
            this.GirisButonu.Name = "GirisButonu";
            this.GirisButonu.Size = new System.Drawing.Size(130, 50);
            this.GirisButonu.TabIndex = 3;
            this.GirisButonu.Text = "Giriş";
            this.GirisButonu.UseVisualStyleBackColor = true;
            this.GirisButonu.Click += new System.EventHandler(this.GirisButonu_Click);
            this.GirisButonu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GirisButonu_KeyDown);
            this.GirisButonu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GirisButonu_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::KaliteKontrolOtomasyonu.Properties.Resources.uye2;
            this.pictureBox1.Location = new System.Drawing.Point(150, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 175);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // veriTabaniGuncelleme
            // 
            this.veriTabaniGuncelleme.AutoSize = true;
            this.veriTabaniGuncelleme.ForeColor = System.Drawing.Color.White;
            this.veriTabaniGuncelleme.Location = new System.Drawing.Point(21, 488);
            this.veriTabaniGuncelleme.Name = "veriTabaniGuncelleme";
            this.veriTabaniGuncelleme.Size = new System.Drawing.Size(132, 17);
            this.veriTabaniGuncelleme.TabIndex = 4;
            this.veriTabaniGuncelleme.Text = "Veritabanı Güncelleme";
            this.veriTabaniGuncelleme.UseVisualStyleBackColor = true;
            this.veriTabaniGuncelleme.CheckedChanged += new System.EventHandler(this.veriTabaniGuncelleme_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.veriTabaniBasligiTXT);
            this.panel1.Controls.Add(this.veriTabaniGuncelleButonu);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(159, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 128);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(67, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "giriniz...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "başlığını sağ tarafa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(133, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 11);
            this.label6.TabIndex = 2;
            this.label6.Text = "DESKTOP-NASE28F\\SQLEXPRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SQL Veritabanının";
            // 
            // veriTabaniBasligiTXT
            // 
            this.veriTabaniBasligiTXT.Location = new System.Drawing.Point(127, 32);
            this.veriTabaniBasligiTXT.Name = "veriTabaniBasligiTXT";
            this.veriTabaniBasligiTXT.Size = new System.Drawing.Size(183, 20);
            this.veriTabaniBasligiTXT.TabIndex = 1;
            // 
            // veriTabaniGuncelleButonu
            // 
            this.veriTabaniGuncelleButonu.ForeColor = System.Drawing.Color.Black;
            this.veriTabaniGuncelleButonu.Location = new System.Drawing.Point(199, 81);
            this.veriTabaniGuncelleButonu.Name = "veriTabaniGuncelleButonu";
            this.veriTabaniGuncelleButonu.Size = new System.Drawing.Size(98, 44);
            this.veriTabaniGuncelleButonu.TabIndex = 0;
            this.veriTabaniGuncelleButonu.Text = "Guncelle";
            this.veriTabaniGuncelleButonu.UseVisualStyleBackColor = true;
            this.veriTabaniGuncelleButonu.Click += new System.EventHandler(this.veriTabaniGuncelleButonu_Click);
            // 
            // GirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.veriTabaniGuncelleme);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kullaniciAdiTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifreTXT);
            this.Controls.Add(this.GirisButonu);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(500, 619);
            this.MinimumSize = new System.Drawing.Size(500, 619);
            this.Name = "GirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalite Kontrol Otomasyonu - Giriş Paneli";
            this.Load += new System.EventHandler(this.GirisPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciAdiTXT;
        private System.Windows.Forms.TextBox sifreTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GirisButonu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox veriTabaniGuncelleme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox veriTabaniBasligiTXT;
        private System.Windows.Forms.Button veriTabaniGuncelleButonu;
        private System.Windows.Forms.Label label6;
    }
}

