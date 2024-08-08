using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml.Style;

namespace KaliteKontrolOtomasyonu.Forms
{
    public partial class NumuneKontrolPaneli : Form
    {
        public string numune_kullaniciAdiSoyadi;
        public string numune_kullaniciRolu; //Çalışan
                                            //Admin

        //bum kullaniciId;
        public int numune_KullaniciID;

        private string fileDirectory;

        private bool excelSec = false;

        public NumuneKontrolPaneli()
        {
            // EPPlus Lisans
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;


            InitializeComponent();
        }

        KaliteKontrolOtomasyonuEntities db = new KaliteKontrolOtomasyonuEntities();

        private void veriTemizle()
        {
            urunTarihiDateTime.Value = DateTime.Now;
            urunKoduTXT.Text = "";
            urunAdiTXT.Text = "";
            urunMPSTXT.Text = "";
            urunFirmasiTXT.Text = "";
            urunAciklamaTXT.Text = "";

            onayDurumuCombo.SelectedIndex = -1;
        }

        private void gridTemizle()
        {
            numuneDataGrid.DataSource = null;
        }

        private void NumuneKontrolPaneli_Load(object sender, EventArgs e)
        {
            var calisan = db.calisanBilgileri.Where(x => x.Calisan_Id.Equals(numune_KullaniciID)).FirstOrDefault();

            label12.Text = "İşlem Yapan Kullanıcı : " + calisan.Calisan_Adi + " " + calisan.Calisan_Soyadi;

            onayDurumuCombo.Items.Add("ONAY VERİLDİ");
            onayDurumuCombo.Items.Add("ONAYLANMADI");
            onayDurumuCombo.Items.Add("BEKLEMEDE");
            label16.Visible = false;


        }

        //Geri Dön Butonu
        private void geriDonButonu_Click(object sender, EventArgs e)
        {
            AnaPanel ana = new AnaPanel();

            ana.kullaniciID = numune_KullaniciID;
            ana.kullaniciAdiSoyadi = numune_kullaniciAdiSoyadi;
            ana.kullaniciRolu = numune_kullaniciRolu;

            ana.Show();
            this.Hide();
        }

        //Verileri Temizle Butonu
        private void verileriTemizle_Click(object sender, EventArgs e)
        {
            veriTemizle();
        }

        //Kaldır Butonu
        private void numuneKaldir_Click(object sender, EventArgs e)
        {
            if (urunMPSTXT.Text == "" || urunMPSTXT.Text == " " || urunMPSTXT.Text == null)
            {
                MessageBox.Show("Ürün MPS'sini giriniz...", "Hata", MessageBoxButtons.OK);
            }
            else
            {
                int kaldir_secilenId = Convert.ToInt16(numuneDataGrid.CurrentRow.Cells[0].Value);
                var numune = db.numuneBilgileri.Where(x => x.urun_Id == kaldir_secilenId).FirstOrDefault();

                DialogResult onay = MessageBox.Show(numune.urun_MPS + " kodlu numuneyi kaldırmak istiyor musun?",
                                                                            "Onaylama İşlemi", MessageBoxButtons.YesNo);



                if (onay == DialogResult.Yes)
                {
                    db.numuneBilgileri.Remove(numune);
                    db.SaveChanges();
                    MessageBox.Show("Numune kaldırıldı...", "Başarılı", MessageBoxButtons.OK);
                    veriTemizle();
                }
                else if (onay == DialogResult.No)
                {

                }
            }

            gridTemizle();
            numuneDataGrid.ClearSelection();
        }

        //Güncelle Butonu
        private void numuneGuncelleButonu_Click(object sender, EventArgs e)
        {
            if (urunMPSTXT.Text == "" || urunMPSTXT.Text == " " || urunMPSTXT.Text == null)
            {
                MessageBox.Show("Ürün MPS'sini giriniz...", "Hata", MessageBoxButtons.OK);
            }
            else
            {
                string onayDurumu = onayDurumuCombo.Text;

                if (onayDurumu == "ONAY VERİLDİ" || onayDurumu == "ONAYLANMADI" || onayDurumu == "BEKLEMEDE")
                {
                    if (onayDurumu == "ONAYLANMADI")
                    {
                        if (urunAciklamaTXT.Text == "" || urunAciklamaTXT.Text == " " || urunAciklamaTXT.Text == null)
                        {
                            MessageBox.Show("Onaylanmamasının sebebini giriniz...");
                        }
                        else
                        {
                            Guncelle();
                        }
                    }
                    else
                    {
                        Guncelle();
                    }
                }
                else
                {
                    MessageBox.Show("Onay Durumunu Belirtiniz...", "Hata", MessageBoxButtons.OK);
                }
            }
        }

        //Güncelel Fonksiyonu
        private void Guncelle()
        {
            var guncelle_SecilenId = Convert.ToInt16(numuneDataGrid.CurrentRow.Cells[0].Value);
            var guncelNumune = db.numuneBilgileri.Where(x => x.urun_Id == guncelle_SecilenId).FirstOrDefault();

            guncelNumune.urun_Tarihi = urunTarihiDateTime.Value;
            guncelNumune.urun_Adi = urunAdiTXT.Text.ToString();
            guncelNumune.urun_Kodu = urunKoduTXT.Text.ToString();

            guncelNumune.urun_MPS = urunMPSTXT.Text.ToString();
            guncelNumune.urun_Firmasi = urunFirmasiTXT.Text.ToString();
            guncelNumune.urun_Aciklama = urunAciklamaTXT.Text.ToString();

            string onayDurumu = onayDurumuCombo.Text.ToString();
            if (onayDurumu == "ONAY VERİLDİ")
            {
                guncelNumune.urun_OnayDurumu = "ONAY VERİLDİ";
            }
            else if (onayDurumu == "ONAYLANMADI")
            {
                guncelNumune.urun_OnayDurumu = "ONAYLANMADI";
            }
            else if (onayDurumu == "BEKLEMEDE")
            {
                guncelNumune.urun_OnayDurumu = "BEKLEMEDE";
            }
            else
            {
                MessageBox.Show("Onay Durumunu Belirtiniz...", "Hata", MessageBoxButtons.OK);
            }


            //Onay Kutusu
            DialogResult onay = MessageBox.Show(guncelNumune.urun_MPS + " MMPS'li numuneyi güncellemek istiyor musun?",
                                                                        "Onaylama İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                db.SaveChanges();
            }
            else if (onay == DialogResult.No)
            {

            }

            numuneDataGrid.ClearSelection();
            veriTemizle();
        }

        //SQL Veritabanına Kaydetme Butonu
        private void numuneKaydetmeButonu_Click(object sender, EventArgs e)
        {
            if (urunMPSTXT.Text == "" || urunMPSTXT.Text == null || urunMPSTXT.Text == " ")
            {
                MessageBox.Show("MPS değeri boş olamaz...", "Hata", MessageBoxButtons.OK);
            }
            else
            {
                if (onayDurumuCombo.Text == "" || onayDurumuCombo.Text == null || onayDurumuCombo.Text == " ")
                {
                    MessageBox.Show("Lütfen Onay durumunu seçiniz...", "Hata", MessageBoxButtons.OK);
                }
                else if (onayDurumuCombo.Text == "ONAY VERİLDİ" || onayDurumuCombo.Text == "BEKLEMEDE")
                {
                    Kaydet();
                }
                else if (onayDurumuCombo.Text == "ONAYLANMADI")
                {
                    if (urunAciklamaTXT.Text == "" || urunAciklamaTXT.Text == null || urunAciklamaTXT.Text == " ")
                    {
                        MessageBox.Show("Onaylanmama sebebini açıklama kısmında belirtiniz...", "Hata", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Kaydet();
                    }
                }
            }
        }

        //Veritabanına Kaydetme İşlemleri ( Fonksiyonu )
        private void Kaydet()
        {
            string deger = urunMPSTXT.Text.ToString();
            bool MPSVarMi = db.numuneBilgileri.Any(x => x.urun_MPS == deger);

            if (MPSVarMi == true)
            {
                MessageBox.Show("Aynı MPS'ye sahip ürün bulunuyor...", "Hata", MessageBoxButtons.OK);
            }
            else
            {
                numuneBilgileri yeniNumune = new numuneBilgileri();
                yeniNumune.urun_Kodu = urunKoduTXT.Text.ToString();
                yeniNumune.urun_Adi = urunAdiTXT.Text.ToString();
                yeniNumune.urun_Tarihi = urunTarihiDateTime.Value;
                yeniNumune.urun_MPS = urunMPSTXT.Text.ToString();
                yeniNumune.urun_Firmasi = urunFirmasiTXT.Text.ToString();
                yeniNumune.urun_Aciklama = urunAciklamaTXT.Text.ToString();

                string onayDurumu = onayDurumuCombo.SelectedItem.ToString();

                if (onayDurumu == "ONAY VERİLDİ")
                {
                    yeniNumune.urun_OnayDurumu = "ONAY VERİLDİ";
                }
                else if (onayDurumu == "ONAYLANMADI")
                {
                    yeniNumune.urun_OnayDurumu = "ONAYLANMADI";
                }
                else if (onayDurumu == "BEKLEMEDE")
                {
                    yeniNumune.urun_OnayDurumu = "BEKLEMEDE";
                }

                var calisan = db.calisanBilgileri.Where(x => x.Calisan_Id.Equals(numune_KullaniciID)).FirstOrDefault();

                yeniNumune.urun_OnaylayanKisi = calisan.Calisan_Adi + " " + calisan.Calisan_Soyadi;
                db.numuneBilgileri.Add(yeniNumune);
                db.SaveChanges();

                MessageBox.Show("Kayıt işlemi başarılı...", "Kayıt Başarılı", MessageBoxButtons.OK);

            }

            gridTemizle();
        }

        //Excel'e aktarma butonu
        private void exceleAktarButonu_Click(object sender, EventArgs e)
        {
            DateTime bas = raporStartDatePicker.Value.AddDays(-1);
            DateTime son = raporEndDatePicker.Value;
            exceleAktar(bas, son);
        }

        //Veritabanını Excel'e aktarma
        public void exceleAktar(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            ExcelPackage excelPaket = new ExcelPackage();
            ExcelWorksheet worksheet = excelPaket.Workbook.Worksheets.Add("ONAYLAMALAR");

            worksheet.Cells[1, 1].Value = "Ürün Tarihi";
            worksheet.Cells[1, 2].Value = "Ürün Kodu";
            worksheet.Cells[1, 3].Value = "Ürün Adı";
            worksheet.Cells[1, 4].Value = "Ürün MPS";
            worksheet.Cells[1, 5].Value = "Ürün Firması";
            worksheet.Cells[1, 6].Value = "ONAY DURUMU";
            worksheet.Cells[1, 7].Value = "Onaylayan Kişi";
            worksheet.Cells[1, 8].Value = "AÇIKLAMA";

            worksheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            worksheet.Row(1).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            worksheet.Row(1).Style.Font.Bold = true;
            worksheet.Row(1).Height = 20;

            worksheet.Column(1).Width = 15; // "Ürün Tarihi" sütunu genişliği

            worksheet.Column(2).Width = 20; // "Ürün Kodu" sütunu genişliği

            worksheet.Column(3).Width = 30; // "Ürün Adı" sütunu genişliği

            worksheet.Column(4).Width = 18; // "Ürün MPS" sütunu genişliği

            worksheet.Column(5).Width = 18; // "Ürün Firması" sütunu genişliği

            worksheet.Column(6).Width = 18; // "ONAY DURUMU" sütunu genişliği

            worksheet.Column(7).Width = 25; // "Onaylayan Kişi" sütunu genişliği

            worksheet.Column(8).Width = 80; // "AÇIKLAMA" sütunu genişliği

            int row = 2;

            //Veri Tabanından numune çekimi
            var numuneListesi = db.numuneBilgileri
                           .Where(br => br.urun_Tarihi >= baslangicTarihi && br.urun_Tarihi <= bitisTarihi)
                           .OrderBy(x => x.urun_Tarihi).ToList();

            if (numuneListesi.Count > 0)
            {
                foreach (var urun in numuneListesi)
                {
                    worksheet.Cells[row, 1].Value = urun.urun_Tarihi;
                    worksheet.Cells[row, 1].Style.Numberformat.Format = "dd-mm-yyyy";

                    worksheet.Cells[row, 2].Value = urun.urun_Kodu;
                    worksheet.Cells[row, 3].Value = urun.urun_Adi;
                    worksheet.Cells[row, 4].Value = urun.urun_MPS;
                    worksheet.Cells[row, 5].Value = urun.urun_Firmasi;
                    if (urun.urun_OnayDurumu == "ONAYLANMADI")
                    {
                        worksheet.Cells[row, 6].Style.Font.Color.SetColor(Color.White);
                        worksheet.Cells[row, 6].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row, 6].Style.Fill.BackgroundColor.SetColor(Color.Red);
                    }
                    else if (urun.urun_OnayDurumu == "ONAYLANDI")
                    {
                        worksheet.Cells[row, 6].Style.Font.Color.SetColor(Color.Black);
                        worksheet.Cells[row, 6].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row, 6].Style.Fill.BackgroundColor.SetColor(Color.Green);
                    }
                    else { }

                    worksheet.Cells[row, 6].Value = urun.urun_OnayDurumu;
                    worksheet.Cells[row, 7].Value = urun.urun_OnaylayanKisi;
                    worksheet.Cells[row, 8].Value = urun.urun_Aciklama;

                    row++;
                }

                // Excel dosyasını kaydetme
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel Dosyası|*.xlsx";
                saveDialog.Title = "Excel Dosyasını Kaydet";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    excelPaket.SaveAs(new FileInfo(saveDialog.FileName));
                    MessageBox.Show("Rapor başarıyla oluşturuldu ve kaydedildi.");
                }
            }
            else
            {
                MessageBox.Show("Seçilen zaman aralığında veri bulunmamaktadır.\n" +
                                "Tarihleri kontrol ediniz...");
            }
        }

        //MPS ile Arama TXT
        private void urunMPSAramaTXT_TextChanged(object sender, EventArgs e)
        {
            string arananMPS = urunMPSAramaTXT.Text.ToLower();


            if (urunMPSAramaTXT.Text == "")
            {
                gridTemizle();
                hepsiniListeleCheckBox.Checked = false;
                tariheGoreArtanRadio.Checked = false;
                tariheGoreAzalanRadio.Checked = false;
            }
            else
            {
                if (tariheGoreArtanRadio.Checked == true)
                {
                    var bulunanMPS = db.numuneBilgileri.Where(x => x.urun_MPS.Contains(arananMPS))
                                                       .OrderBy(x => x.urun_Tarihi).ToList();
                    numuneDataGrid.DataSource = bulunanMPS;
                }
                else if (tariheGoreAzalanRadio.Checked == true)
                {
                    var bulunanMPS = db.numuneBilgileri.Where(x => x.urun_MPS.Contains(arananMPS))
                                                       .OrderByDescending(x => x.urun_Tarihi).ToList();
                    numuneDataGrid.DataSource = bulunanMPS;
                }
                else
                {
                    var bulunanMPS = db.numuneBilgileri.Where(x => x.urun_MPS.Contains(arananMPS)).ToList();
                    numuneDataGrid.DataSource = bulunanMPS;
                }
            }
        }

        //Hepsini Listele Checkbox
        private void hepsiniListeleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hepsiniListeleCheckBox.Checked == true)
            {
                TariheGoreSirala();
            }
            else
            {
                gridTemizle();
            }
        }

        //Tarihe Göre Sıralama
        private void TariheGoreSirala()
        {
            var numuneler = db.numuneBilgileri.ToList();
            numuneDataGrid.DataSource = numuneler;

            string[] sutunBasliklari = {
            "Ürün Id","Ürün Tarihi", "Ürün Kodu", "Ürün MPS", "Ürün Adı", "Ürün Firması",
            "ONAY DURUMU", "ONAYLAYAN KİŞİ","Ürün Açıklama"
              };

            foreach (DataGridView dataGridView in new[] { numuneDataGrid })
            {
                for (int i = 0; i < sutunBasliklari.Length; i++)
                {
                    dataGridView.Columns[i].HeaderText = sutunBasliklari[i];
                }
            }

            if (numuneler != null)
            {
                if (tariheGoreArtanRadio.Checked == true)
                {
                    // Tarihe göre sıralama
                    var sortedNumuneler = numuneler.OrderBy(n => n.urun_Tarihi).ToList();
                    // DataGridView DataSource'u güncelleyin
                    numuneDataGrid.DataSource = sortedNumuneler;
                }
                else if (tariheGoreAzalanRadio.Checked == true)
                {
                    {
                        // Tarihe göre sıralama
                        var sortedNumuneler = numuneler.OrderByDescending(n => n.urun_Tarihi).ToList();
                        // DataGridView DataSource'u güncelleyin
                        numuneDataGrid.DataSource = sortedNumuneler;
                    }
                }
                else
                {
                    numuneDataGrid.DataSource = numuneler;
                }
            }

            numuneDataGrid.ClearSelection();
        }

        //Azalan ve Artan Radio
        #region

        private void tariheGoreAzalanRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (tariheGoreAzalanRadio.Checked == true)
            {
                tariheGoreArtanRadio.Checked = false;
                TariheGoreSirala();
            }
        }

        private void tariheGoreArtanRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (tariheGoreArtanRadio.Checked == true)
            {
                tariheGoreAzalanRadio.Checked = false;
                TariheGoreSirala();
            }
        }

        #endregion

        //zaman aralığı
        private void zamanAraliginiListele_Click(object sender, EventArgs e)
        {
            DateTime bas = baslangicDate.Value.AddDays(-1);
            DateTime son = BitisDate.Value.AddDays(1);

            var numuneListesi = db.numuneBilgileri
                           .Where(br => br.urun_Tarihi >= bas && br.urun_Tarihi <= son)
                           .OrderBy(x => x.urun_Tarihi).ToList();

            numuneDataGrid.DataSource = numuneListesi;

            if (tariheGoreArtanRadio.Checked == true)
            {
                numuneListesi = db.numuneBilgileri
                               .Where(br => br.urun_Tarihi >= bas && br.urun_Tarihi <= son)
                               .OrderBy(x => x.urun_Tarihi).ToList();

                numuneDataGrid.DataSource = numuneListesi;
            }
            else if (tariheGoreAzalanRadio.Checked == true)
            {
                numuneListesi = db.numuneBilgileri
                               .Where(br => br.urun_Tarihi >= bas && br.urun_Tarihi <= son)
                               .OrderByDescending(x => x.urun_Tarihi).ToList();

                numuneDataGrid.DataSource = numuneListesi;
            }
            else
            {

            }
        }

        //UrunKoduna Gore oto doldur
        private void urunKoduTXT_TextChanged(object sender, EventArgs e)
        {
            if (urunKoduTXT.Text.Length > 3)
            {
                UrunleriGetir(urunKoduTXT.Text);
            }
            else
            {

            }
        }

        //Oto doldur fonksiyonu
        private void UrunleriGetir(string urunKodu)
        {
            using (var context = new KaliteKontrolOtomasyonuEntities())
            {
                // Use LINQ to query the database for the matching product
                var urun = context.numuneBilgileri.FirstOrDefault(u => u.urun_Kodu.Equals(urunKodu, StringComparison.OrdinalIgnoreCase));

                // Check if a matching product is found
                if (urun != null)
                {
                    // Set the text of urunAdiTextBox to the product name
                    urunAdiTXT.Text = urun.urun_Adi;
                    urunFirmasiTXT.Text = urun.urun_Firmasi;
                }
                else
                {
                    // Clear the text box if no product is found
                    urunAdiTXT.Clear();
                    urunFirmasiTXT.Clear();
                }
            }
        }

        //Güncelleme maksatlı txtye atama
        private void numuneDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenId = Convert.ToInt16(numuneDataGrid.CurrentRow.Cells[0].Value);
            var numune = db.numuneBilgileri.Where(x => x.urun_Id == secilenId).FirstOrDefault();

            urunTarihiDateTime.Value = numune.urun_Tarihi.Value;

            urunKoduTXT.Text = numune.urun_Kodu?.ToString() ?? "";
            urunAdiTXT.Text = numune.urun_Adi?.ToString() ?? "";
            urunMPSTXT.Text = numune.urun_MPS?.ToString() ?? "";

            urunFirmasiTXT.Text = numune.urun_Firmasi?.ToString() ?? "";
            urunAciklamaTXT.Text = numune.urun_Aciklama?.ToString() ?? "";

            string onayDurumu = numune.urun_OnayDurumu?.ToString() ?? "";

            if (onayDurumu == "ONAY VERİLDİ" || onayDurumu == "ONAY VERİLDİ.")
            {
                onayDurumuCombo.Text = "ONAY VERİLDİ";
                label16.Visible = false;
            }
            else if (onayDurumu == "ONAYLANMADI")
            {
                onayDurumuCombo.Text = "ONAYLANMADI";
                label16.Visible = false;
            }
            else if (onayDurumu == "BEKLEMEDE")
            {
                onayDurumuCombo.Text = "BEKLEMEDE";
                label16.Visible = false;
            }
            else
            {
                onayDurumuCombo.SelectedIndex = -1;
                label16.Visible = true;
            }
        }








        //Textbox kısıtlamalar
        #region

        private void urunMPSAramaTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void urunMPSTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void urunKoduTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
