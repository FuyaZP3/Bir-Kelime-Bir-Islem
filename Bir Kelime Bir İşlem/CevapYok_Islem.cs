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
    public partial class CevapYok_Islem : Form
    {
        public CevapYok_Islem()
        {
            InitializeComponent();
        }

        private void CevapYok_Islem_Load(object sender, EventArgs e)
        {
            if (Oyun_Degiskenleri.oynayanKisi == 1)
            {
                rdbO2.Visible = false;
                rdbO3.Visible = false;
                rdbO4.Visible = false;
                rdbO5.Visible = false;

                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = false;
                btn5.Visible = false;
            }
            else if (Oyun_Degiskenleri.oynayanKisi == 2)
            {
                rdbO3.Visible = false;
                rdbO4.Visible = false;
                rdbO5.Visible = false;

                btn3.Visible = false;
                btn4.Visible = false;
                btn5.Visible = false;
            }
            else if (Oyun_Degiskenleri.oynayanKisi == 3)
            {
                rdbO4.Visible = false;
                rdbO5.Visible = false;

                btn4.Visible = false;
                btn5.Visible = false;
            }
            else if (Oyun_Degiskenleri.oynayanKisi == 4)
            {
                rdbO5.Visible = false;
                btn5.Visible = false;
            }
        }

        private void rdbAyrikCevap_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAyrikCevap.Checked)
            {
                gbxAyrikCevap.Enabled = true;
                gbxEsitCevap.Enabled = false;
                btnOnayla.Visible = true;
            }
            else
            {
                gbxAyrikCevap.Enabled = false;
                gbxEsitCevap.Enabled = true;
                btnOnayla.Visible = true;
            }
        }

        private void rdbYanitYok_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbYanitYok.Checked)
            {
                gbxAyrikCevap.Enabled = false;
                gbxEsitCevap.Enabled = false;
                rdbO1.Enabled = false;
                rdbO2.Enabled = false;
                rdbO3.Enabled = false;
                rdbO4.Enabled = false;
                rdbO5.Enabled = false;
                btnOnayla.Visible = true;
            }
            else
            {
                gbxAyrikCevap.Enabled = true;
                gbxEsitCevap.Enabled = true;
                rdbO1.Enabled = true;
                rdbO2.Enabled = true;
                rdbO3.Enabled = true;
                rdbO4.Enabled = true;
                rdbO5.Enabled = true;
                btnOnayla.Visible = true;
            }
        }

        private void cevaplarAyrik()
        {
            string isaretliAyrik = clbAyrik.Text;

            if (isaretliAyrik == "Tam Sonuç")
                Oyun_Degiskenleri.soylenenCevap = "0±0";    //Alt + 241
            else if (isaretliAyrik == "1 Yaklaşık")
                Oyun_Degiskenleri.soylenenCevap = "1±1";
            else if (isaretliAyrik == "2 Yaklaşık")
                Oyun_Degiskenleri.soylenenCevap = "2±2";
            else if (isaretliAyrik == "3 Yaklaşık")
                Oyun_Degiskenleri.soylenenCevap = "3±3";
        }

        private void cevaplarEsit()
        {
            string isaretliEsit = clbEsit.Text;

            if (isaretliEsit == "Tam Sonuç")
                Oyun_Degiskenleri.soylenenCevap = "0±0";    //Alt + 241
            else if (isaretliEsit == "1 Yaklaşık")
                Oyun_Degiskenleri.soylenenCevap = "1±1";
            else if (isaretliEsit == "2 Yaklaşık")
                Oyun_Degiskenleri.soylenenCevap = "2±2";
            else if (isaretliEsit == "3 Yaklaşık")
                Oyun_Degiskenleri.soylenenCevap = "3±3";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblAynilar.Text = lblAynilar.Text + "1";
            listBox1.Items.Add("1");
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblAynilar.Text = lblAynilar.Text + "2";
            listBox1.Items.Add("2");
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblAynilar.Text = lblAynilar.Text + "3";
            listBox1.Items.Add("3");
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblAynilar.Text = lblAynilar.Text + "4";
            listBox1.Items.Add("4");
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblAynilar.Text = lblAynilar.Text + "5";
            listBox1.Items.Add("5");
            btn5.Enabled = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblAynilar.Text = "";
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            listBox1.Items.Clear();
        }

        Random rnd = new Random();
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (rdbAyrikCevap.Checked)
            {
                if (clbAyrik.CheckedItems.Count != 1)
                    MessageBox.Show("Lütfen bir tane seçim yapınız.");
                else
                {
                    if (rdbO1.Checked)
                    {
                        Oyun_Degiskenleri.secilenKisi = "1";
                        cevaplarAyrik();
                    }
                    else if (rdbO2.Checked)
                    {
                        Oyun_Degiskenleri.secilenKisi = "2";
                        cevaplarAyrik();
                    }
                    else if (rdbO3.Checked)
                    {
                        Oyun_Degiskenleri.secilenKisi = "3";
                        cevaplarAyrik();
                    }
                    else if (rdbO4.Checked)
                    {
                        Oyun_Degiskenleri.secilenKisi = "4";
                        cevaplarAyrik();
                    }
                    else if (rdbO5.Checked)
                    {
                        Oyun_Degiskenleri.secilenKisi = "5";
                        cevaplarAyrik();
                    }
                    this.Close();
                }
            }
            else if (rdbEsitCevap.Checked)
            {
                if (clbEsit.CheckedItems.Count != 1 || lblAynilar.Text.Length == 0)
                {
                    if (clbEsit.CheckedItems.Count != 1)
                        MessageBox.Show("Lütfen bir tane seçim yapınız.");
                    else
                        MessageBox.Show("Lütfen aynı cevap türüne sahip kişilerin sıra numaralarını yazınız.");
                }
                else
                {
                    int secilen = rnd.Next(0, listBox1.Items.Count);
                    Oyun_Degiskenleri.secilenKisi = listBox1.Items[secilen].ToString();
                    cevaplarEsit();
                    MessageBox.Show("Seçilen Kişi: " + Oyun_Degiskenleri.secilenKisi);
                    this.Close();
                }
            }
            else if(rdbYanitYok.Checked)
            {
                Oyun_Degiskenleri.soylenenCevap = "00";
                this.Close();
            }
        }

    }
}
