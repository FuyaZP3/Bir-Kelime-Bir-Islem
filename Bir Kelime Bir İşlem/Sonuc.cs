using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Bir_Kelime_Bir_İşlem
{
    public partial class Sonuc : Form
    {
        public Sonuc()
        {
            InitializeComponent();
        }

        int maxPuan = Oyun_Degiskenleri.puanO1, i = 0, c = 0;
        private void Sonuc_Load(object sender, EventArgs e)
        {
            lblTebrikler.Location = new Point((this.Width / 2 - lblTebrikler.Width / 2), 54);
            Atama();
            for(i = 0; i < Oyun_Degiskenleri.oynayanKisi; i++)
            {
                if (listBox2.Items[i] != null)
                {
                    if (Convert.ToInt32(listBox2.Items[i]) > maxPuan)
                    {
                        maxPuan = Convert.ToInt32(listBox2.Items[i]);
                        c = i;
                    }
                }
                else
                    break;
            }
            lblTarih.Text = DateTime.Now.ToString();
            lblLider.Text = listBox1.Items[c].ToString() + " kullanıcı adına sahip oyuncu " 
                + maxPuan.ToString() + " puan ile bu yarışmayı birinci bitirmiştir.";
        }

        private void Atama()
        {
            try
            {
                listBox1.Items.Add(Oyun_Degiskenleri.isimO1);
                listBox2.Items.Add(Oyun_Degiskenleri.puanO1);
                listBox1.Items.Add(Oyun_Degiskenleri.isimO2);
                listBox2.Items.Add(Oyun_Degiskenleri.puanO2);
                listBox1.Items.Add(Oyun_Degiskenleri.isimO3);
                listBox2.Items.Add(Oyun_Degiskenleri.puanO3);
                listBox1.Items.Add(Oyun_Degiskenleri.isimO4);
                listBox2.Items.Add(Oyun_Degiskenleri.puanO4);
                listBox1.Items.Add(Oyun_Degiskenleri.isimO5);
                listBox2.Items.Add(Oyun_Degiskenleri.puanO5);
            }
            catch
            {

            }
        }
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            Oyun_Degiskenleri.kisayolO1 = ' ';
            Oyun_Degiskenleri.kisayolO2 = ' ';
            Oyun_Degiskenleri.kisayolO3 = ' ';
            Oyun_Degiskenleri.kisayolO4 = ' ';
            Oyun_Degiskenleri.kisayolO5 = ' ';
            Oyun_Degiskenleri.puanO1 = 0;
            Oyun_Degiskenleri.puanO2 = 0;
            Oyun_Degiskenleri.puanO3 = 0;
            Oyun_Degiskenleri.puanO4 = 0;
            Oyun_Degiskenleri.puanO5 = 0;

            Oyuncu_Bilgileri yeni = new Oyuncu_Bilgileri();
            //this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            yeni.Show();
            this.Hide();
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu git = new Menu();
            //this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            git.Show();
            this.Hide();
        }
    }
}
