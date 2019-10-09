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
    public partial class Kural_Kelime : Form
    {
        public Kural_Kelime()
        {
            InitializeComponent();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            Kural_Islem islem = new Kural_Islem();
            //this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            islem.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menu git = new Menu();
            //this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            git.Show();
            this.Hide();
        }
    }
}
