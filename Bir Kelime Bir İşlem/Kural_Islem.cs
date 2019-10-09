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
    public partial class Kural_Islem : Form
    {
        public Kural_Islem()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Kural_Kelime kelime = new Kural_Kelime();
            //this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            kelime.Show();
            this.Hide();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Menu git = new Menu();
            //this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            git.Show();
            this.Hide();
        }
    }
}
