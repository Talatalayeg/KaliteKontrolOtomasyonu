using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.EntityClient;

namespace KaliteKontrolOtomasyonu
{
    public partial class GirisPaneli : Form
    {
        KaliteKontrolOtomasyonuEntities db = new KaliteKontrolOtomasyonuEntities();

        public GirisPaneli()
        {
            InitializeComponent();
        }

        private void GirisPaneli_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            veriTabaniGuncelleme.Visible = false;
            this.KeyDown += new KeyEventHandler(GirisButonu_KeyDown);
        }

        private void GirisButonu_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciAdiTXT.Text;
            string sifre = sifreTXT.Text;

            //linq Sorgusu
            var calisan = db.calisanBilgileri.Where(x => x.Calisan_KullaniciAdi.Equals(kullaniciAdi) &&
            x.Calisan_Sifre.Equals(sifre)).FirstOrDefault();

            //Kullanıcı Adı ve Şifre Kontrolü
            if (calisan == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            else
            {
                string rol = calisan.Calisan_Rol.ToString();
                MessageBox.Show(calisan.Calisan_Adi + " " + calisan.Calisan_Soyadi + " olarak " + rol + " girişi yapıldı.");
                calisan.Calisan_EnSonGiris = DateTime.Now;
                db.SaveChanges();
                AnaPanel panel = new AnaPanel();

                panel.kullaniciAdiSoyadi = calisan.Calisan_Adi + " " + calisan.Calisan_Soyadi;

                //Admin veya çalışan girişi yetkisi
                if (calisan.Calisan_Rol == "Admin")
                {
                    panel.kullaniciRolu = "Admin";
                }
                else
                {
                    panel.kullaniciRolu = "Çalışan";
                }

                panel.kullaniciID = Convert.ToInt16(calisan.Calisan_Id);

                panel.Show();
                this.Hide();
            }
        }

        private void GirisButonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Q))
            {
                GirisButonu_Click(sender, e);
            }
        }

        //Gereksiz
        #region
        private void SaveConnectionString(string connectionString)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["MyDbContext"].ConnectionString = connectionString;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        private void btnSaveConnectionString_Click(object sender, EventArgs e)
        {
            string newConnectionString = veriTabaniBasligiTXT.Text;
            SaveConnectionString(newConnectionString);
            MessageBox.Show("Connection string saved. Please restart the application.");
        }

        private void veriTabaniGuncelleButonu_Click(object sender, EventArgs e)
        {
            string connectionString = veriTabaniBasligiTXT.Text;
            SaveConnectionString(connectionString);
            MessageBox.Show("Veritabanı bağlantısı tamamlandı. Lütfen programı yeniden başlatın...");
        }

        private void veriTabaniGuncelleme_CheckedChanged(object sender, EventArgs e)
        {
            if(veriTabaniGuncelleme.Checked ==  true)
            {
                panel1.Visible = true;
            }
            else if (veriTabaniGuncelleme.Checked == false)
            {
                panel1.Visible = false;
            }
        }
        #endregion

        private void GirisButonu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter tuşuna basıldıysa
            {
                // Butonun Click olayını tetikleme
                GirisButonu.PerformClick();
                e.Handled = true; // Olayı işlediğimizi belirtiyoruz
            }
        }
    }
}
