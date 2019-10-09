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
    public partial class IlkGiris : Form
    {
        public IlkGiris()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void IlkGiris_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 4;
            if (sayac == 100)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
