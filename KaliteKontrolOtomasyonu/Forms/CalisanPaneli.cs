using Spire.Pdf.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KaliteKontrolOtomasyonu.Forms
{
    public partial class CalisanPaneli : Form
    {
        public string cal_kullaniciAdiSoyadi;
        public string cal_kullaniciRolu; //Çalışan
                                     //Admin

        public int cal_kullaniciID;

        KaliteKontrolOtomasyonuEntities db = new KaliteKontrolOtomasyonuEntities();

        public CalisanPaneli()
        {
            InitializeComponent();
        }

        private void geriDonButonu_Click(object sender, EventArgs e)
        {
            AnaPanel ana = new AnaPanel();

            ana.kullaniciID = cal_kullaniciID;
            ana.kullaniciAdiSoyadi = cal_kullaniciAdiSoyadi;
            ana.kullaniciRolu = cal_kullaniciRolu;

            ana.Show();
            this.Hide();
        }

        private void Temizle()
        {
            calisanAdiTXT.Text = "";
            calisanSoyadiTXT.Text = "";
            calisanTCTXT.Text = "";

            calisanKullaniciAdiTXT.Text = "";
            calisanSifreTXT.Text = "";

            calisanTelefonTXT.Text = "";
            calisanEpostaTXT.Text = "";
            calisanAdresTXT.Text = "";
            
            //calisanRolComboBox.Text = "";

            calisanRolAdmin.Checked = false;
            calisanRolCalisan.Checked = false;
        }

        private void Listele()
        {
            var calisanlar = db.calisanBilgileri.ToList();
            calisanListesiDataGrid.DataSource = calisanlar;

            string[] sutunBasliklari = {
            "ID", "Adı", "Soyadı", "TC", "ROL",
            "KUllanıcı Adı", "Şifre", "TelNo", "Eposta", "Adres","En Son Giriş","Eklenme Tarihi"
              };

            foreach (DataGridView dataGridView in new[] { calisanListesiDataGrid })
            {
                for (int i = 0; i < sutunBasliklari.Length; i++)
                {
                    dataGridView.Columns[i].HeaderText = sutunBasliklari[i];
                }
            }
        }

        private void CalisanPaneli_Load(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        // DataGrid hepsini listele checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                Listele();
            }
            else if(checkBox1.Checked == false)
            {
                calisanListesiDataGrid.DataSource = null;
            }
        }

        // Çalışan TC ile Arama
        private void calisanTCaraTXT_TextChanged(object sender, EventArgs e)
        {
            if (calisanTCaraTXT.Text == "" || calisanTCaraTXT.Text == " " || calisanTCaraTXT.Text == null)
            {
                calisanListesiDataGrid.Columns.Clear();
            }
            else
            {
                string aranan = calisanTCaraTXT.Text.ToString();
                var bulunanUye = db.calisanBilgileri.Where(x => x.Calisan_Tc.Contains(aranan)).ToList();
                calisanListesiDataGrid.DataSource = bulunanUye;
            }
        }

        //Data Grid üzerindeki veriyi TXT aktarma
        private void calisanListesiDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenId = Convert.ToInt16(calisanListesiDataGrid.CurrentRow.Cells[0].Value);
            var calisan = db.calisanBilgileri.Where(x => x.Calisan_Id == secilenId).FirstOrDefault();

            calisanAdiTXT.Text = calisan.Calisan_Adi?.ToString() ?? "";
            calisanSoyadiTXT.Text = calisan.Calisan_Soyadi?.ToString() ?? "";
            calisanTCTXT.Text = calisan.Calisan_Tc?.ToString() ?? "";

            calisanKullaniciAdiTXT.Text = calisan.Calisan_KullaniciAdi?.ToString() ?? "";
            calisanSifreTXT.Text = calisan.Calisan_Sifre?.ToString() ?? "";

            calisanEpostaTXT.Text = calisan.Calisan_Eposta?.ToString() ?? "";
            calisanTelefonTXT.Text = calisan.Calisan_TelNo?.ToString() ?? "";
            calisanAdresTXT.Text = calisan.Calisan_Adres?.ToString() ?? "";

            //ROLcalisan
            if (calisan.Calisan_Rol == "Admin")
            {
                label8.Text = "Admin";
            }
            else if (calisan.Calisan_Rol == "Çalışan")
            {
                label8.Text = "Çalışan";
            }
            else if (calisan.Calisan_Rol == null)
            {
                label8.Visible = true;
            }
        }

        //Çalışanın kaydedilmesi Butonu
        private void calisanKaydetButonu_Click(object sender, EventArgs e)
        {
            if (calisanTCTXT.Text == "" || calisanTCTXT.Text == " " || calisanTCTXT.Text == null)
            {
                MessageBox.Show("Kırmızı İşaretli alanları doldurunuz...", "Hata", MessageBoxButtons.OK);
            }
            else
            {
                if (calisanTCTXT.Text.Length != 11)
                {
                    MessageBox.Show("Kimlik NO 11 karakterden oluşmalıdır...", "Hata", MessageBoxButtons.OK);
                }
                else
                {
                    if(calisanKullaniciAdiTXT.Text == "" 
                        || calisanKullaniciAdiTXT.Text == " " 
                        || calisanKullaniciAdiTXT.Text == null)
                    {
                        MessageBox.Show("Kullanıcı Adını Giriniz...", "Hata", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (calisanSifreTXT.Text == ""
                            || calisanSifreTXT.Text == " "
                            || calisanSifreTXT.Text == null)
                        {
                            MessageBox.Show("Şifreyi Giriniz...", "Hata", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if(calisanRolAdmin.Checked == false && calisanRolCalisan.Checked == false)
                            {
                                MessageBox.Show("Çalışan Rolünü belirleyiniz...", "Hata", MessageBoxButtons.OK);
                            }
                            else
                            {
                                if(calisanRolAdmin.Checked == true)
                                {
                                    calisanKaydet("Admin");
                                }
                                else if(calisanRolCalisan.Checked == true)
                                {
                                    calisanKaydet("Çalışan");
                                }
                                else
                                {
                                    MessageBox.Show("Çalışan Rolünü belirleyiniz...", "Hata", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void calisanKaydet(string rol)
        {
            string deger = calisanTCTXT.Text.ToString();
            bool tcVarMi = db.calisanBilgileri.Any(x => x.Calisan_Tc == deger);

            if (tcVarMi == true)
            {
                MessageBox.Show("Aynı TC numarasına sahip çalışan bulunuyor...", "Hata", MessageBoxButtons.OK);
            }
            else
            {
                string k_adi = calisanKullaniciAdiTXT.Text.ToString();
                bool k_adiVarmi = db.calisanBilgileri.Any(x => x.Calisan_KullaniciAdi.Contains(k_adi));

                if (k_adiVarmi == true)
                {
                    MessageBox.Show("Aynı Kullanıcı Adına sahip çalışan bulunuyor...", "Hata", MessageBoxButtons.OK);
                }
                else
                {
                    calisanBilgileri yeniCalisan = new calisanBilgileri();
                    yeniCalisan.Calisan_Adi = calisanAdiTXT.Text.ToString();
                    yeniCalisan.Calisan_Soyadi = calisanSoyadiTXT.Text.ToString();
                    yeniCalisan.Calisan_Tc = calisanTCTXT.Text.ToString();

                    yeniCalisan.Calisan_KullaniciAdi = calisanKullaniciAdiTXT.Text.ToString();
                    yeniCalisan.Calisan_Sifre = calisanSifreTXT.Text.ToString();

                    yeniCalisan.Calisan_TelNo = calisanTelefonTXT.Text.ToString();
                    yeniCalisan.Calisan_Eposta = calisanEpostaTXT.Text.ToString();
                    yeniCalisan.Calisan_Adres = calisanAdresTXT.Text.ToString();

                    DateTime bugun = DateTime.Now;

                    yeniCalisan.Calisan_EklenmeTarihi = bugun;
                    yeniCalisan.Calisan_EnSonGiris = null;

                    string calisanRolu = rol;
                    if (calisanRolu == "Admin")
                    {
                        yeniCalisan.Calisan_Rol = "Admin";
                    }
                    else if (calisanRolu == "Çalışan")
                    {
                        yeniCalisan.Calisan_Rol = "Çalışan";
                    }

                    db.calisanBilgileri.Add(yeniCalisan);
                    db.SaveChanges();

                    MessageBox.Show(yeniCalisan.Calisan_Adi + " adlı çalışan başarıyla kaydedildi...", "Başarılı", MessageBoxButtons.OK);
                }



                
            }
        }

        // Düzenleme Butonu
        private void calisaniDuzenleButonu_Click(object sender, EventArgs e)
        {
            if (calisanTCTXT.Text == "" || calisanTCTXT.Text == " " || calisanTCTXT.Text == null)
            {
                MessageBox.Show("Kırmızı İşaretli alanları doldurunuz...", "Hata", MessageBoxButtons.OK);
            }
            else
            {
                if (calisanTCTXT.Text.Length != 11)
                {
                    MessageBox.Show("Kimlik NO 11 karakterden oluşmalıdır...", "Hata", MessageBoxButtons.OK);
                }
                else
                {
                    if (calisanKullaniciAdiTXT.Text == ""
                        || calisanKullaniciAdiTXT.Text == " "
                        || calisanKullaniciAdiTXT.Text == null)
                    {
                        MessageBox.Show("Kullanıcı Adını Giriniz...", "Hata", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (calisanSifreTXT.Text == ""
                            || calisanSifreTXT.Text == " "
                            || calisanSifreTXT.Text == null)
                        {
                            MessageBox.Show("Şifreyi Giriniz...", "Hata", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (calisanRolAdmin.Checked == false && calisanRolCalisan.Checked == false)
                            {
                                MessageBox.Show("Çalışanın Rolünü Belirleyiniz...", "Hata", MessageBoxButtons.OK);
                            }
                            else
                            {
                                var guncelle_SecilenId = Convert.ToInt16(calisanListesiDataGrid.CurrentRow.Cells[0].Value);
                                var guncelCalisan = db.calisanBilgileri.Where(x => x.Calisan_Id == guncelle_SecilenId).FirstOrDefault();
                                
                                guncelCalisan.Calisan_Adi = calisanAdiTXT.Text.ToString();
                                guncelCalisan.Calisan_Soyadi = calisanSoyadiTXT.Text.ToString();
                                guncelCalisan.Calisan_Tc = calisanTCTXT.Text.ToString();

                                guncelCalisan.Calisan_KullaniciAdi = calisanKullaniciAdiTXT.Text.ToString();
                                guncelCalisan.Calisan_Sifre = calisanSifreTXT.Text.ToString();

                                guncelCalisan.Calisan_TelNo = calisanTelefonTXT.Text.ToString();
                                guncelCalisan.Calisan_Eposta = calisanEpostaTXT.Text.ToString();
                                guncelCalisan.Calisan_Adres = calisanAdresTXT.Text.ToString();

                                if (calisanRolAdmin.Checked == true)
                                {
                                    guncelCalisan.Calisan_Rol = "Admin";
                                }
                                else if (calisanRolCalisan.Checked == true)
                                {
                                    guncelCalisan.Calisan_Rol = "Çalışan";
                                }
                                else
                                {
                                    MessageBox.Show("Çalışanın Rolünü Belirleyiniz...", "Hata", MessageBoxButtons.OK);
                                }


                                //Onay Kutusu
                                DialogResult onay = MessageBox.Show(guncelCalisan.Calisan_Adi + " adlı Çalışanı güncellemek istiyor musun?",
                                                                                            "Onaylama İşlemi", MessageBoxButtons.YesNo);
                                if (onay == DialogResult.Yes)
                                {
                                    db.SaveChanges();
                                }
                                else if (onay == DialogResult.No)
                                {

                                }
                            }
                        }
                    }
                }
            }
        }

        // Kaldır Butonu
        private void calisaniKaldirButonu_Click(object sender, EventArgs e)
        {
            int kaldir_secilenId = Convert.ToInt16(calisanListesiDataGrid.CurrentRow.Cells[0].Value);
            var calisan = db.calisanBilgileri.Where(x => x.Calisan_Id == kaldir_secilenId).FirstOrDefault();

            DialogResult onay = MessageBox.Show(calisan.Calisan_Adi + " adlı çalışanı kaldırmak istiyor musun?",
                                                                        "Onaylama İşlemi", MessageBoxButtons.YesNo);

            string calisanAdi = calisan.Calisan_Adi;

            if (onay == DialogResult.Yes)
            {
                db.calisanBilgileri.Remove(calisan);
                db.SaveChanges();
                MessageBox.Show(calisanAdi + " adlı çalışan kaldırıldı...", "Başarılı", MessageBoxButtons.OK);
                Listele();
            }
            else if (onay == DialogResult.No)
            {

            }
        }

        //Formu Temizle
        private void formuTemizle_Click(object sender, EventArgs e)
        {
            calisanAdiTXT.Text = "";
            calisanSoyadiTXT.Text = "";
            calisanTCTXT.Text = "";

            calisanKullaniciAdiTXT.Text = "";
            calisanSifreTXT.Text = "";

            calisanEpostaTXT.Text = "";
            calisanTelefonTXT.Text = "";
            calisanAdresTXT.Text = "";

            calisanRolAdmin.Checked = false;
            calisanRolCalisan.Checked = false;
        }








        //Tc yi sayı ile kısıtlama
        private void calisanTCTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

    }
}
