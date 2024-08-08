using KaliteKontrolOtomasyonu.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaliteKontrolOtomasyonu
{
    public partial class AnaPanel : Form
    {
        public string kullaniciAdiSoyadi;
        public string kullaniciRolu; //Çalışan
                                     //Admin

        public int kullaniciID;


        private void AnaPanel_Load(object sender, EventArgs e)
        {
            label4.Text = kullaniciAdiSoyadi + " , Hoşgeldiniz...";
            if (kullaniciRolu == "Admin")
            {

            }
            else if (kullaniciRolu == "Çalışan")
            {
                calisanPaneliButonu.Visible = false;
                label1.Visible = false;
            }
        }

        public AnaPanel()
        {
            InitializeComponent();
        }

        private void geriDonButonu_Click(object sender, EventArgs e)
        {
            GirisPaneli giris = new GirisPaneli();
            giris.Show();
            this.Hide();
        }

        private void calisanPaneliButonu_Click(object sender, EventArgs e)
        {
            CalisanPaneli calisan = new CalisanPaneli();

            calisan.cal_kullaniciID = kullaniciID;
            calisan.cal_kullaniciRolu = kullaniciRolu;
            calisan.cal_kullaniciAdiSoyadi = kullaniciAdiSoyadi;

            calisan.Show();
            this.Hide();
        }

        private void raporListelemeButonu_Click(object sender, EventArgs e)
        {
            RaporListelemePaneli rapor = new RaporListelemePaneli();

            rapor.rapor_KullaniciId = kullaniciID;
            rapor.rapor_kullaniciRolu = kullaniciRolu;
            rapor.rapor_kullaniciAdiSoyadi = kullaniciAdiSoyadi;

            rapor.Show();
            this.Hide();
        }

        private void NumuneKontrolButonu_Click(object sender, EventArgs e)
        {
            NumuneKontrolPaneli numune = new NumuneKontrolPaneli();

            numune.numune_KullaniciID = kullaniciID;
            numune.numune_kullaniciRolu = kullaniciRolu;
            numune.numune_kullaniciAdiSoyadi = kullaniciAdiSoyadi;

            numune.Show();
            this.Hide();
        }
    }
}
