using KaliteKontrolOtomasyonu.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaliteKontrolOtomasyonu
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Application start logic
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //bum GirisPaneli aktif et

            Application.Run(new GirisPaneli());
            //Application.Run(new AnaPanel());

            //Application.Run(new CalisanPaneli());
            //Application.Run(new RaporListelemePaneli());
            //Application.Run(new NumuneKontrolPaneli());
        }
    }
}
