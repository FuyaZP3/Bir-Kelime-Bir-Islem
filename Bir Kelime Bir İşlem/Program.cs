using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bir_Kelime_Bir_İşlem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IlkGiris());
            Application.Run(new GirisEkrani());
            Application.Run(new Menu());
            //Application.Run(new Kural_Kelime());
            //Application.Run(new Kural_Islem());
            //Application.Run(new Ayarlar());
            //Application.Run(new Oyuncu_Bilgileri());
            //Application.Run(new Soru_Islem());
            //Application.Run(new Soru_Kelime());
            //Application.Run(new Sonuc());
            //Application.Run(new Klavye());
            //Application.Run(new Klavye_Sayi());
            //Application.Run(new CevapYok_Kelime());
            //Application.Run(new CevapYok_Islem());
        }

    }
}
