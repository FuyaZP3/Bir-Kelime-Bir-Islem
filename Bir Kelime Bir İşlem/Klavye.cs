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
    public partial class Klavye : Form
    {
        public Klavye()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            harfEkle(Convert.ToChar(btn.Text));
        }

        private void harfEkle(char harf)
        {
            txtCevap.Text += harf + " ";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtCevap.Text.Length > 0)
                txtCevap.Text = txtCevap.Text.Remove(txtCevap.Text.Length - 2);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (txtCevap.Text.Length > 0)
                txtCevap.Text = "";
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (txtCevap.TextLength > 0 && txtCevap.TextLength < 19)
            {
                Oyun_Degiskenleri.arananKelime = txtCevap.Text.Replace(" ", string.Empty);
                Oyun_Degiskenleri.cevapKontrolHarfleri = txtCevap.Text;
                this.Close();
            }
            else
                MessageBox.Show("En fazla 9 karakter uzunluğunda kelime yazabilirsiniz.\nSadece bastığınız harfler karakter olarak sayılmaktadır.");
        }

        private void Klavye_Load(object sender, EventArgs e)
        {
            txtCevap.MaxLength = 9;
        }
    }
}
