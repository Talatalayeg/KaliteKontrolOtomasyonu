using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Media.Media3D;
using System.Drawing.Printing;

using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.PdfViewer.Asp;
using Spire.Pdf.General.Find;

namespace KaliteKontrolOtomasyonu.Forms
{
    public partial class RaporListelemePaneli : Form
    {
        //bum staj için üsttekini seç

        string sabitKlasor = "C:\\Users\\KALITE\\Desktop\\YAZAROĞLUKALİTE\\Kalite Kontrol Test Raporları\\TEMMUZ2024\\";
        //string sabitKlasor = "C:\\Users\\asus\\Desktop\\test";
        //string sabitKlasor = "C:\\Users\\Taha\\Desktop\\StajDosyaları\\testklasoru\\";

        // Orijinal dosyaların listesini saklamak için bir liste
        private List<string> allFiles = new List<string>();

        public string rapor_kullaniciAdiSoyadi;
        public string rapor_kullaniciRolu; //Çalışan
                                           //Admin

        //bum sıfırla
        public int rapor_KullaniciId;

        public string fileDirectory;
        private bool listelendi = false;
        private bool masaustuneKaydet = false;
        private bool secildi = false;

        KaliteKontrolOtomasyonuEntities db = new KaliteKontrolOtomasyonuEntities();

        public RaporListelemePaneli()
        {
            InitializeComponent();
        }

        // Kelime bilgisi için sınıf
        class BulunanKelime
        {
            public string Word { get; set; }
            public int PageNumber { get; set; }
            public PointF Position { get; set; }
        }

        private void RaporListelemePaneli_Load(object sender, EventArgs e)
        {
            fileDirectory = sabitKlasor;
            label2.Text = sabitKlasor;
            dosyalariListele();

            masaustuneKaydetCheck.Visible = true;

            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                printersCombo.Items.Add(printer);
            }

            printersCombo.SelectedIndex = -1;
        }

        //Geri Dön Butonu
        private void geriDonButonu_Click(object sender, EventArgs e)
        {
            AnaPanel ana = new AnaPanel();

            ana.kullaniciID = rapor_KullaniciId;
            ana.kullaniciAdiSoyadi = rapor_kullaniciAdiSoyadi;
            ana.kullaniciRolu = rapor_kullaniciRolu;

            ana.Show();
            this.Hide();
        }

        //Klasor Seçim Fonksiyonu
        private void klasorsecimi()
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            label4.Text = dlg.SelectedPath.ToString();
            fileDirectory = dlg.SelectedPath.ToString();
        }

        //Dosyaların variable'a atanması fonksiyonu
        private void dosyalariListele()
        {
            allFiles.Clear();

            if (fileDirectory == null || fileDirectory == "" || fileDirectory == " ")
            {
                MessageBox.Show("Klasör seçiniz...", "Hata", MessageBoxButtons.OK);
            }

            else
            {
                allFiles.AddRange(Directory.GetFiles(fileDirectory));

                // DataGridView'i temizle
                klasoruListeleDataGrid.Rows.Clear();
                klasoruListeleDataGrid.Columns.Clear();

                // Sütunları ekle
                klasoruListeleDataGrid.Columns.Add("FileName", "File Name");
                klasoruListeleDataGrid.Columns.Add("FileType", "File Type");

                // Dosyaları DataGridView'e ekle
                foreach (string file in allFiles)
                {
                    int rowIndex = klasoruListeleDataGrid.Rows.Add();
                    DataGridViewRow row = klasoruListeleDataGrid.Rows[rowIndex];
                    row.Cells["FileName"].Value = System.IO.Path.GetFileName(file);
                    row.Cells["FileType"].Value = System.IO.Path.GetExtension(file);
                }

                // Kolon genişliklerini ayarla
                klasoruListeleDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                listelendi = true;
            }
        }

        // TXTBox içeriğini kontrol eder
        private void araButonu_Click(object sender, EventArgs e)
        {
            allFiles.Clear();

            if (fileDirectory == null || fileDirectory == "" || fileDirectory == " ")
            {
                MessageBox.Show("Klasör seçiniz...", "Hata", MessageBoxButtons.OK);
            }
            else
            {
                // Arama metni kontrolü
                if (dosyaAdiAramaTXT.Text.Length > 2)
                {
                    string bosSearchText = dosyaAdiAramaTXT.Text.ToLower();
                    string searchText = dosyaAdiAramaTXT.Text.ToLower().Replace(" ", "_");

                    allFiles.AddRange(Directory.GetFiles(fileDirectory));

                    // DataGridView'i temizle
                    klasoruListeleDataGrid.Rows.Clear();
                    klasoruListeleDataGrid.Columns.Clear();

                    // Sütunları ekle
                    klasoruListeleDataGrid.Columns.Add("FileName", "File Name");
                    klasoruListeleDataGrid.Columns.Add("FileType", "File Type");

                    // Dosyaları DataGridView'e ekle
                    foreach (string file in allFiles)
                    {
                        string fileName = Path.GetFileName(file).ToLower();

                        // Dosya adının arama metni içerip içermediğini kontrol edin
                        if (fileName.Contains(searchText))
                        {
                            int rowIndex = klasoruListeleDataGrid.Rows.Add();
                            DataGridViewRow row = klasoruListeleDataGrid.Rows[rowIndex];
                            row.Cells["FileName"].Value = Path.GetFileName(file);
                            row.Cells["FileType"].Value = Path.GetExtension(file);
                        }
                        else if (fileName.Contains(bosSearchText))
                        {
                            int rowIndex = klasoruListeleDataGrid.Rows.Add();
                            DataGridViewRow row = klasoruListeleDataGrid.Rows[rowIndex];
                            row.Cells["FileName"].Value = Path.GetFileName(file);
                            row.Cells["FileType"].Value = Path.GetExtension(file);
                        }
                        else
                        {

                        }
                    }
                    // Kolon genişliklerini ayarla
                    klasoruListeleDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
        }

        //Klasor Seç Butonu
        private void klasorSecButonu_Click(object sender, EventArgs e)
        {
            if (listelendi == false)
            {
                klasorsecimi();
            }
            else if (listelendi == true)
            {
                // DataGridView'i temizle
                klasoruListeleDataGrid.Rows.Clear();
                klasoruListeleDataGrid.Columns.Clear();
                listelendi = false;
                klasorsecimi();
            }

        }

        //Klasör Listeleme Butonu
        private void klasorListeleButonu_Click(object sender, EventArgs e)
        {
            dosyalariListele();
        }

        //DataGridde seçili pdfi önizleme
        private void klasoruListeleDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (klasoruListeleDataGrid.SelectedCells.Count > 0)
            {
                string selectedFile = fileDirectory + "/" + klasoruListeleDataGrid.SelectedCells[0].Value.ToString();

                // Spire.PDFViewer kontrolüne seçilen PDF dosyasını yükle
                this.pdfViewer1.LoadFromFile(selectedFile);
            }
        }

        //Seçiliyi Yazdır Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            string yazici = printersCombo.Text;
            if (yazici == null || yazici == "" || yazici == " " || yazici == "-1")
            {
                MessageBox.Show("Lütfen Yazıcı Seçiniz...");
            }
            else
            {
                var calisan = db.calisanBilgileri.Where(x => x.Calisan_Id.Equals(rapor_KullaniciId)).FirstOrDefault();
                string selectedFileName = klasoruListeleDataGrid.SelectedCells[0].Value.ToString();
                string selectedFile = fileDirectory + "/" + klasoruListeleDataGrid.SelectedCells[0].Value.ToString();

                // PDF belgesini yükle
                PdfDocument pdf = new PdfDocument();
                pdf.LoadFromFile(selectedFile);

                string printerName = printersCombo.Text.Trim();
                pdf.PrintSettings.PrinterName = printerName;

                // Aranacak kelime
                string yeniSearchText = "SONUCUN";
                string eskiSearchText = "KARAR";

                // Kelime bilgilerini saklamak için liste oluştur
                List<BulunanKelime> foundWords = new List<BulunanKelime>();

                // Kelimeyi aramak için tüm sayfaları döngüye al
                for (int i = 0; i < pdf.Pages.Count; i++)
                {
                    PdfPageBase page = pdf.Pages[i];

                    // Sayfa üzerinde metin ara
                    PdfTextFindCollection finds = page.FindText(yeniSearchText);

                    // Bulunan kelimelerin bilgilerini listeye ekle
                    foreach (PdfTextFind find in finds.Finds)
                    {
                        BulunanKelime kelimeBilgisi = new BulunanKelime
                        {
                            Word = find.SearchText,
                            PageNumber = i + 1, // Sayfa numarası 0'dan başladığı için +1 ekliyoruz
                            Position = find.Position
                        };
                        foundWords.Add(kelimeBilgisi);
                    }
                }

                if (foundWords.Count > 0)
                {
                    // Her kelime için bilgileri yazdır
                    foreach (BulunanKelime kelimeBilgisi in foundWords)
                    {
                        Console.WriteLine($"Kelime: {kelimeBilgisi.Word}, Sayfa: {kelimeBilgisi.PageNumber}, Pozisyon: {kelimeBilgisi.Position}");
                    }

                    // Her sayfada kelimenin pozisyonunu kullanarak işlem yap
                    foreach (BulunanKelime kelimeBilgisi in foundWords)
                    {
                        float x = kelimeBilgisi.Position.X - 15;
                        float y = kelimeBilgisi.Position.Y + 20;

                        PdfPageBase page = pdf.Pages[kelimeBilgisi.PageNumber - 1]; // Sayfa numarası 0'dan başladığı için -1 ekliyoruz
                        PdfFont font = new PdfFont(PdfFontFamily.Helvetica, 6);
                        PdfBrush brush = PdfBrushes.Black;
                        page.Canvas.DrawString(calisan.Calisan_Adi, font, brush, x, y);
                    }

                    // Kayıt yolunu masaüstü olarak ayarla
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string outputPath = System.IO.Path.Combine(desktopPath, "Yenioutput.pdf");


                    if (masaustuneKaydet == true)
                    {
                        try
                        {
                            // Değişiklikleri kaydet
                            pdf.SaveToFile(outputPath);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Sorunla Karşılaşıldı.\nMasaüstündeki eskioutput adlı dosyayı kapatınız....", "Hata", MessageBoxButtons.OK);
                        }
                    }

                    try
                    {
                        // 1 
                        pdf.Print();
                        Console.WriteLine("Çıktı yolu :" + pdf.PrintSettings.PrinterName + " Dosya Adı: " + selectedFileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(pdf.PrintSettings.PrinterName + " ile bağlantı kurulamadı veya yazıcı bulunamadı...", "Hata", MessageBoxButtons.OK);
                    }
                    pdf.Close();
                }

                else if (foundWords.Count <= 0)
                {
                    // Kayıt yolunu masaüstü olarak ayarla
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string outputPath = System.IO.Path.Combine(desktopPath, "Eskioutput.pdf");


                    if (masaustuneKaydet == true)
                    {
                        try
                        {
                            // Değişiklikleri kaydet
                            pdf.SaveToFile(outputPath);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Masaüstündeki eskioutput adlı dosyayı kapatınız....", "Hata", MessageBoxButtons.OK);
                        }
                    }

                    try
                    {
                        // 2
                        pdf.Print();
                        Console.WriteLine("Çıktı yolu :" + yazici + " Dosya Adı: " + selectedFileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(pdf.PrintSettings.PrinterName + " ile bağlantı kurulamadı veya yazıcı bulunamadı...", "Hata", MessageBoxButtons.OK);
                    }
                    pdf.Close();
                }
            }
        }

        //Masaüstüne Kaydet Butonu
        private void masaustuneKaydetCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (masaustuneKaydetCheck.Checked == false)
            {
                masaustuneKaydet = false;
            }
            else if (masaustuneKaydetCheck.Checked == true)
            {
                masaustuneKaydet = true;
            }
        }

        //Sabit Klasörü listele Butonu
        private void sabitKlasoruYukleButonu_Click(object sender, EventArgs e)
        {
            fileDirectory = sabitKlasor.ToString();

            dosyalariListele();
        }

    }
}