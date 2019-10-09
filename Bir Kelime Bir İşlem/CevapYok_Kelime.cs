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
    public partial class CevapYok_Kelime : Form
    {
        public CevapYok_Kelime()
        {
            InitializeComponent();
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
                //rdbEsitCevap.Enabled = false;
                //rdbAyrikCevap.Enabled = false;
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
                //rdbEsitCevap.Enabled = true;
                //rdbAyrikCevap.Enabled = true;
                btnOnayla.Visible = true;
            }
        }

        private void CevapYok_Kelime_Load(object sender, EventArgs e)
        {
            if (Oyun_Degiskenleri.oynayanKisi == 1)
            {
                rdbO2.Visible = false;
                rdbO3.Visible = false;
                rdbO4.Visible = false;
                rdbO5.Visible = false;

                //chkO2.Visible = false;
                //chkO3.Visible = false;
                //chkO4.Visible = false;
                //chkO5.Visible = false;

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

                //chkO3.Visible = false;
                //chkO4.Visible = false;
                //chkO5.Visible = false;

                btn3.Visible = false;
                btn4.Visible = false;
                btn5.Visible = false;
            }
            else if (Oyun_Degiskenleri.oynayanKisi == 3)
            {
                rdbO4.Visible = false;
                rdbO5.Visible = false;

                //chkO4.Visible = false;
                //chkO5.Visible = false;

                btn4.Visible = false;
                btn5.Visible = false;
            }
            else if (Oyun_Degiskenleri.oynayanKisi == 4)
            {
                rdbO5.Visible = false;

                //chkO5.Visible = false;

                btn5.Visible = false;
            }
        }

        private void cevaplarAyrik()
        {
            string isaretliAyrik = clbAyrik.Text;

            if (isaretliAyrik == "5 Harfli Jokerli")
                Oyun_Degiskenleri.soylenenCevap = "51";
            else if (isaretliAyrik == "5 Harfli Jokersiz")
                Oyun_Degiskenleri.soylenenCevap = "50";
            else if (isaretliAyrik == "6 Harfli Jokerli")
                Oyun_Degiskenleri.soylenenCevap = "61";
            else if (isaretliAyrik == "6 Harfli Jokersiz")
                Oyun_Degiskenleri.soylenenCevap = "60";
            else if (isaretliAyrik == "7 Harfli Jokerli")
                Oyun_Degiskenleri.soylenenCevap = "71";
            else if (isaretliAyrik == "7 Harfli Jokersiz")
                Oyun_Degiskenleri.soylenenCevap = "70";
            else if (isaretliAyrik == "8 Harfli Jokerli")
                Oyun_Degiskenleri.soylenenCevap = "81";
            else if (isaretliAyrik == "8 Harfli Jokersiz")
                Oyun_Degiskenleri.soylenenCevap = "80";
            else if (isaretliAyrik == "9 Harfli Jokerli")
                Oyun_Degiskenleri.soylenenCevap = "91";
            else if (isaretliAyrik == "9 Harfli Jokersiz")
                Oyun_Degiskenleri.soylenenCevap = "90";
        }

        private void cevaplarEsit()
        {
            string isaretliEsit = clbEsit.Text;

            if (isaretliEsit == "5 Harfli Jokerli")
                Oyun_Degiskenleri.soylenenCevap = "51";
            else if (isaretliEsit == "5 Harfli Jokersiz")
                Oyun_Degiskenleri.soylenenCevap = "50";
            else if (isaretliEsit == "6 Harfli Jokerli")
                Oyun_Degiskenleri.soylenenCevap = "61";
            else if (isaretliEsit == "6 Harfli Jokersiz")
                Oyun_Degiskenleri.soylenenCevap = "60";
            else if (isaretliEsit == "7 Harfli Jokerli")
                Oyun_Degiskenleri.soylenenCevap = "71";
            else if (isaretliEsit == "7 Harfli Jokersiz")
                Oyun_Degiskenleri.soylenenCevap = "70";
            else if (isaretliEsit == "8 Harfli Jokerli")
                Oyun_Degiskenleri.soylenenCevap = "81";
            else if (isaretliEsit == "8 Harfli Jokersiz")
                Oyun_Degiskenleri.soylenenCevap = "80";
            else if (isaretliEsit == "9 Harfli Jokerli")
                Oyun_Degiskenleri.soylenenCevap = "91";
            else if (isaretliEsit == "9 Harfli Jokersiz")
                Oyun_Degiskenleri.soylenenCevap = "90";
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
                    if(clbEsit.CheckedItems.Count != 1)
                        MessageBox.Show("Lütfen bir tane seçim yapınız.");
                    else
                        MessageBox.Show("Lütfen aynı cevap türüne sahip kişilerin sıra numaralarını yazınız.");
                }
                else
                {
                    int secilen = rnd.Next(0,listBox1.Items.Count);
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
