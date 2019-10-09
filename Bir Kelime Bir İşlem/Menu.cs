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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            Oyuncu_Bilgileri oyna = new Oyuncu_Bilgileri();
            //this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            oyna.Show();
            this.Hide();
        }

        private void btnKurallar_Click(object sender, EventArgs e)
        {
            Kural_Kelime kural1 = new Kural_Kelime();
            //this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            kural1.Show();
            this.Hide();
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Location = new Point((this.Width / 2 - lblHosgeldin.Width / 2), 45);
            lblTesekkur.Location = new Point(900, 571);
        }
    }
}
