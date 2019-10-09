using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bir_Kelime_Bir_İşlem
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = Application.StartupPath + "\\Jenerik_1.swf";
            axShockwaveFlash1.Loop = false;
            axShockwaveFlash1.Play();

            timer1.Enabled = true;
            timer1.Start();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 10;

            if (sayac == 10)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
