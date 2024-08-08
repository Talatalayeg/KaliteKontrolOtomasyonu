namespace KaliteKontrolOtomasyonu.Forms
{
    partial class RaporListelemePaneli
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
            this.label3 = new System.Windows.Forms.Label();
            this.klasorSecButonu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.geriDonButonu = new System.Windows.Forms.Button();
            this.klasorListeleButonu = new System.Windows.Forms.Button();
            this.pdfViewer1 = new Spire.PdfViewer.Forms.PdfViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.masaustuneKaydetCheck = new System.Windows.Forms.CheckBox();
            this.sabitKlasoruYukleButonu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.klasoruListeleDataGrid = new System.Windows.Forms.DataGridView();
            this.araButonu = new System.Windows.Forms.Button();
            this.dosyaAdiAramaTXT = new System.Windows.Forms.TextBox();
            this.printersCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.klasoruListeleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(655, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dosya Adı : ";
            // 
            // klasorSecButonu
            // 
            this.klasorSecButonu.Location = new System.Drawing.Point(27, 225);
            this.klasorSecButonu.Name = "klasorSecButonu";
            this.klasorSecButonu.Size = new System.Drawing.Size(89, 38);
            this.klasorSecButonu.TabIndex = 1;
            this.klasorSecButonu.Text = "Klasör seç";
            this.klasorSecButonu.UseVisualStyleBackColor = true;
            this.klasorSecButonu.Click += new System.EventHandler(this.klasorSecButonu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(25, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Klasör seçilmedi...";
            // 
            // geriDonButonu
            // 
            this.geriDonButonu.BackColor = System.Drawing.Color.Transparent;
            this.geriDonButonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.geriDonButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geriDonButonu.FlatAppearance.BorderSize = 0;
            this.geriDonButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriDonButonu.Image = global::KaliteKontrolOtomasyonu.Properties.Resources.previous;
            this.geriDonButonu.Location = new System.Drawing.Point(12, 5);
            this.geriDonButonu.Name = "geriDonButonu";
            this.geriDonButonu.Size = new System.Drawing.Size(128, 125);
            this.geriDonButonu.TabIndex = 10;
            this.geriDonButonu.UseVisualStyleBackColor = false;
            this.geriDonButonu.Click += new System.EventHandler(this.geriDonButonu_Click);
            // 
            // klasorListeleButonu
            // 
            this.klasorListeleButonu.Location = new System.Drawing.Point(122, 226);
            this.klasorListeleButonu.Name = "klasorListeleButonu";
            this.klasorListeleButonu.Size = new System.Drawing.Size(89, 37);
            this.klasorListeleButonu.TabIndex = 2;
            this.klasorListeleButonu.Text = "Listele";
            this.klasorListeleButonu.UseVisualStyleBackColor = true;
            this.klasorListeleButonu.Click += new System.EventHandler(this.klasorListeleButonu_Click);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer1.FormFillEnabled = true;
            this.pdfViewer1.IgnoreCase = false;
            this.pdfViewer1.IsToolBarVisible = true;
            this.pdfViewer1.Location = new System.Drawing.Point(28, 289);
            this.pdfViewer1.MultiPagesThreshold = 60;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OnRenderPageExceptionEvent = null;
            this.pdfViewer1.Size = new System.Drawing.Size(988, 360);
            this.pdfViewer1.TabIndex = 5;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.Threshold = 60;
            this.pdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(507, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Önizleme sadece pdf dosyalarında çalışmaktadır";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Seçiliyi Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // masaustuneKaydetCheck
            // 
            this.masaustuneKaydetCheck.AutoSize = true;
            this.masaustuneKaydetCheck.Location = new System.Drawing.Point(396, 269);
            this.masaustuneKaydetCheck.Name = "masaustuneKaydetCheck";
            this.masaustuneKaydetCheck.Size = new System.Drawing.Size(120, 17);
            this.masaustuneKaydetCheck.TabIndex = 20;
            this.masaustuneKaydetCheck.Text = "Masaüstüne Kaydet";
            this.masaustuneKaydetCheck.UseVisualStyleBackColor = true;
            this.masaustuneKaydetCheck.CheckedChanged += new System.EventHandler(this.masaustuneKaydetCheck_CheckedChanged);
            // 
            // sabitKlasoruYukleButonu
            // 
            this.sabitKlasoruYukleButonu.Location = new System.Drawing.Point(27, 169);
            this.sabitKlasoruYukleButonu.Name = "sabitKlasoruYukleButonu";
            this.sabitKlasoruYukleButonu.Size = new System.Drawing.Size(89, 37);
            this.sabitKlasoruYukleButonu.TabIndex = 21;
            this.sabitKlasoruYukleButonu.Text = "Sabit Klasör\'ü yükle";
            this.sabitKlasoruYukleButonu.UseVisualStyleBackColor = true;
            this.sabitKlasoruYukleButonu.Click += new System.EventHandler(this.sabitKlasoruYukleButonu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(25, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "2";
            // 
            // klasoruListeleDataGrid
            // 
            this.klasoruListeleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klasoruListeleDataGrid.Location = new System.Drawing.Point(510, 61);
            this.klasoruListeleDataGrid.Name = "klasoruListeleDataGrid";
            this.klasoruListeleDataGrid.Size = new System.Drawing.Size(506, 202);
            this.klasoruListeleDataGrid.TabIndex = 22;
            this.klasoruListeleDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.klasoruListeleDataGrid_CellContentClick);
            // 
            // araButonu
            // 
            this.araButonu.Location = new System.Drawing.Point(941, 19);
            this.araButonu.Name = "araButonu";
            this.araButonu.Size = new System.Drawing.Size(75, 23);
            this.araButonu.TabIndex = 23;
            this.araButonu.Text = "Ara";
            this.araButonu.UseVisualStyleBackColor = true;
            this.araButonu.Click += new System.EventHandler(this.araButonu_Click);
            // 
            // dosyaAdiAramaTXT
            // 
            this.dosyaAdiAramaTXT.Location = new System.Drawing.Point(737, 21);
            this.dosyaAdiAramaTXT.Name = "dosyaAdiAramaTXT";
            this.dosyaAdiAramaTXT.Size = new System.Drawing.Size(182, 20);
            this.dosyaAdiAramaTXT.TabIndex = 24;
            // 
            // printersCombo
            // 
            this.printersCombo.FormattingEnabled = true;
            this.printersCombo.Location = new System.Drawing.Point(383, 204);
            this.printersCombo.Name = "printersCombo";
            this.printersCombo.Size = new System.Drawing.Size(121, 21);
            this.printersCombo.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Yazıcı ";
            // 
            // RaporListelemePaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.printersCombo);
            this.Controls.Add(this.dosyaAdiAramaTXT);
            this.Controls.Add(this.araButonu);
            this.Controls.Add(this.klasoruListeleDataGrid);
            this.Controls.Add(this.sabitKlasoruYukleButonu);
            this.Controls.Add(this.masaustuneKaydetCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.klasorListeleButonu);
            this.Controls.Add(this.geriDonButonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.klasorSecButonu);
            this.Controls.Add(this.label3);
            this.Name = "RaporListelemePaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalite Kontrol Otomasyonu -Rapor Listeleme Paneli";
            this.Load += new System.EventHandler(this.RaporListelemePaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klasoruListeleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button klasorSecButonu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button geriDonButonu;
        private System.Windows.Forms.Button klasorListeleButonu;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox masaustuneKaydetCheck;
        private System.Windows.Forms.Button sabitKlasoruYukleButonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView klasoruListeleDataGrid;
        private System.Windows.Forms.Button araButonu;
        private System.Windows.Forms.TextBox dosyaAdiAramaTXT;
        private System.Windows.Forms.ComboBox printersCombo;
        private System.Windows.Forms.Label label5;
    }
}