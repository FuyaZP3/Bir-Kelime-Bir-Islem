using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bir_Kelime_Bir_İşlem
{
    public partial class Klavye_Sayi : Form
    {
        public Klavye_Sayi()
        {
            InitializeComponent();
        }

        private void Klavye_Sayi_Load(object sender, EventArgs e)
        {
            sayilariAtama();
            int[] donenSayilar = { Oyun_Degiskenleri.donenSayi1, Oyun_Degiskenleri.donenSayi2,Oyun_Degiskenleri.donenSayi3,Oyun_Degiskenleri.donenSayi4,Oyun_Degiskenleri.donenSayi5,
                Oyun_Degiskenleri.donenCiftSayi, Oyun_Degiskenleri.donenIstenilen};

            txtSayi1.MaxLength = 4;
            txtSayi2.MaxLength = 4;
            txtSonuc.MaxLength = 4;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtSayi1.Enabled == true)
            {
                if (txtSayi1.Text.Length > 0)
                    txtSayi1.Text = txtSayi1.Text.Remove(txtSayi1.Text.Length - 1);
                txtSayi1.Focus();
            }

            else if (txtSayi2.Enabled == true)
            {
                if (txtSayi2.Text.Length > 0)
                    txtSayi2.Text = txtSayi2.Text.Remove(txtSayi2.Text.Length - 1);
                txtSayi2.Focus();
            }

            else if (txtSonuc.Enabled == true)
            {
                if (txtSonuc.Text.Length > 0)
                    txtSonuc.Text = txtSonuc.Text.Remove(txtSonuc.Text.Length - 1);
                txtSonuc.Focus();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                txtSayi1.Text = "";
                txtSayi2.Text = "";
                txtSonuc.Text = "";
            }
            catch
            {
                
            }
        }

        private void sayilariAtama()
        {
            lstEkranveSonuclar.Items.Add(Oyun_Degiskenleri.donenSayi1);
            lstEkranveSonuclar.Items.Add(Oyun_Degiskenleri.donenSayi2);
            lstEkranveSonuclar.Items.Add(Oyun_Degiskenleri.donenSayi3);
            lstEkranveSonuclar.Items.Add(Oyun_Degiskenleri.donenSayi4);
            lstEkranveSonuclar.Items.Add(Oyun_Degiskenleri.donenSayi5);
            lstEkranveSonuclar.Items.Add(Oyun_Degiskenleri.donenCiftSayi);
        }

        int olmayanSayi = 0;
        int hatalıIslem = 0;
        bool silindimi;
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                for (int i = 0; i < lstKullaniciSayilari.Items.Count;)
                {
                    silindimi = false;
                    for (int k = 0; k < lstEkranveSonuclar.Items.Count; k++)
                    {
                        if (lstKullaniciSayilari.Items[i].ToString() == lstEkranveSonuclar.Items[k].ToString())
                        {
                            lstKullaniciSayilari.Items.RemoveAt(i);
                            lstEkranveSonuclar.Items.RemoveAt(k);
                            silindimi = true;
                            break;
                        }
                    }
                    if (silindimi == false)
                    {
                        i++;
                        olmayanSayi++;
                    }
                    if (lstKullaniciSayilari.Items.Count == 0)
                        break;
                }

                for (int j = 0; j < listView1.Items.Count; j++)
                {
                    if (listView1.Items[j].BackColor == Color.Red)
                        hatalıIslem++;
                }

                int fark = Oyun_Degiskenleri.donenIstenilen - int.Parse(lstEkranveSonuclar.Items[lstEkranveSonuclar.Items.Count - 1].ToString());
                if (listView1.Items.Count == 0)
                    MessageBox.Show("İşleminizi yaptırmadan devam edemezsiniz!");
                else
                {
                    if (olmayanSayi > 0 || hatalıIslem > 0)
                        Oyun_Degiskenleri.cevapDurum = -1;
                    else
                    {
                        if (Soru_Islem.gecerliSure != 0)
                        {
                            if (fark == 0)
                                Oyun_Degiskenleri.cevapDurum = 0;
                            else
                                Oyun_Degiskenleri.cevapDurum = -1;
                        }
                        else
                        {
                            if (fark == 0)
                                Oyun_Degiskenleri.cevapDurum = 0;
                            else if (fark == 1 || fark == -1)
                                Oyun_Degiskenleri.cevapDurum = 1;
                            else if (fark == 2 || fark == -2)
                                Oyun_Degiskenleri.cevapDurum = 2;
                            else if (fark == 3 || fark == -3)
                                Oyun_Degiskenleri.cevapDurum = 3;
                        }
                    }
                    this.Close();
                }
            }
            else
                MessageBox.Show("Herhangi bir işlem yapmadan devam edemezsiniz!");
        }

        int i = 0, sonucKullanici, sonucAI;
        private void btnTopla_Click(object sender, EventArgs e)
        {
            try
            {
                sonucAI = Convert.ToInt32(txtSonuc.Text);
                sonucKullanici = Convert.ToInt32(txtSayi1.Text) + Convert.ToInt32(txtSayi2.Text);
                
                listView1.Items.Add(txtSayi1.Text + " + " + txtSayi2.Text + " = " + txtSonuc.Text);

                if (sonucKullanici == sonucAI)
                    listView1.Items[i].BackColor = Color.Green;
                else
                    listView1.Items[i].BackColor = Color.Red;
                i++;

                lstKullaniciSayilari.Items.Add(txtSayi1.Text);
                lstKullaniciSayilari.Items.Add(txtSayi2.Text);
                lstEkranveSonuclar.Items.Add(txtSonuc.Text);
                btnTemizle.PerformClick();
                txtSayi1.Enabled = false;
                txtSayi2.Enabled = false;
                txtSonuc.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Kutuların hepsine sayı yazmadan devam edemezsiniz!");
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            try
            {
                sonucAI = Convert.ToInt32(txtSonuc.Text);
                sonucKullanici = Convert.ToInt32(txtSayi1.Text) - Convert.ToInt32(txtSayi2.Text);
               
                listView1.Items.Add(txtSayi1.Text + " - " + txtSayi2.Text + " = " + txtSonuc.Text);

                if (sonucKullanici == sonucAI)
                    listView1.Items[i].BackColor = Color.Green;
                else
                    listView1.Items[i].BackColor = Color.Red;
                i++;
                lstKullaniciSayilari.Items.Add(txtSayi1.Text);
                lstKullaniciSayilari.Items.Add(txtSayi2.Text);
                lstEkranveSonuclar.Items.Add(txtSonuc.Text);
                btnTemizle.PerformClick();
                txtSayi1.Enabled = false;
                txtSayi2.Enabled = false;
                txtSonuc.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Kutuların hepsine sayı yazmadan devam edemezsiniz!");
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            try
            {
                sonucAI = Convert.ToInt32(txtSonuc.Text);
                sonucKullanici = Convert.ToInt32(txtSayi1.Text) * Convert.ToInt32(txtSayi2.Text);
                
                listView1.Items.Add(txtSayi1.Text + " x " + txtSayi2.Text + " = " + txtSonuc.Text);

                if (sonucKullanici == sonucAI)
                    listView1.Items[i].BackColor = Color.Green;
                else
                    listView1.Items[i].BackColor = Color.Red;
                i++;
                lstKullaniciSayilari.Items.Add(txtSayi1.Text);
                lstKullaniciSayilari.Items.Add(txtSayi2.Text);
                lstEkranveSonuclar.Items.Add(txtSonuc.Text);
                btnTemizle.PerformClick();
                txtSayi1.Enabled = false;
                txtSayi2.Enabled = false;
                txtSonuc.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Kutuların hepsine sayı yazmadan devam edemezsiniz!");
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            try
            {
                sonucAI = Convert.ToInt32(txtSonuc.Text);
                sonucKullanici = Convert.ToInt32(txtSayi1.Text) / Convert.ToInt32(txtSayi2.Text);
                
                listView1.Items.Add(txtSayi1.Text + " ÷ " + txtSayi2.Text + " = " + txtSonuc.Text);

                if (sonucKullanici == sonucAI)
                    listView1.Items[i].BackColor = Color.Green;
                else
                    listView1.Items[i].BackColor = Color.Red;
                i++;
                lstKullaniciSayilari.Items.Add(txtSayi1.Text);
                lstKullaniciSayilari.Items.Add(txtSayi2.Text);
                lstEkranveSonuclar.Items.Add(txtSonuc.Text);
                btnTemizle.PerformClick();
                txtSayi1.Enabled = false;
                txtSayi2.Enabled = false;
                txtSonuc.Enabled = false;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Herhangi bir sayıyı 0(Sıfır)'a bölemezsiniz!");
            }
            catch
            {
                MessageBox.Show("Kutuların hepsine sayı yazmadan devam edemezsiniz!");
            }
        }

        private void btnSayi1_Click(object sender, EventArgs e)
        {
            txtSayi1.Enabled = true;
            txtSayi2.Enabled = false;
            txtSonuc.Enabled = false;
            txtSayi1.Focus();
        }

        private void btnSayi2_Click(object sender, EventArgs e)
        {
            txtSayi1.Enabled = false;
            txtSayi2.Enabled = true;
            txtSonuc.Enabled = false;
            txtSayi2.Focus();
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            txtSayi1.Enabled = false;
            txtSayi2.Enabled = false;
            txtSonuc.Enabled = true;
            txtSonuc.Focus();
        }

        private void tusKontrol(object sender, KeyPressEventArgs e)
        {
            char ktr = e.KeyChar;

            if (ktr >= 48 && ktr <= 57 || ktr == 127 || ktr == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnTopla_MouseEnter(object sender, EventArgs e)
        {
            lblOperator.Text = "+";
        }

        private void btnCikar_MouseEnter(object sender, EventArgs e)
        {
            lblOperator.Text = "-";
        }

        private void btnCarp_MouseEnter(object sender, EventArgs e)
        {
            lblOperator.Text = "x";
        }

        private void btnBol_MouseEnter(object sender, EventArgs e)
        {
            lblOperator.Text = "÷";
        }

        private void btnTopla_MouseLeave(object sender, EventArgs e)
        {
            lblOperator.Text = "";
        }
    }
}
