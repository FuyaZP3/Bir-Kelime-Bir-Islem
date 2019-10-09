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
    public partial class Oyuncu_Bilgileri : Form
    {
        public Oyuncu_Bilgileri()
        {
            InitializeComponent();
        }

        private void Oyuncu_Bilgileri_Load(object sender, EventArgs e)
        {
            txtOyuncu1.MaxLength = 9;
            txtOyuncu2.MaxLength = 9;
            txtOyuncu3.MaxLength = 9;
            txtOyuncu4.MaxLength = 9;
            txtOyuncu5.MaxLength = 9;
        }

        private void rdbKisi1_CheckedChanged(object sender, EventArgs e)
        {
            txtOyuncu1.Enabled = true;
            txtOyuncu2.Enabled = false;
            txtOyuncu3.Enabled = false;
            txtOyuncu4.Enabled = false;
            txtOyuncu5.Enabled = false;

            cmbKisayol1.Enabled = true;
            cmbKisayol2.Enabled = false;
            cmbKisayol3.Enabled = false;
            cmbKisayol4.Enabled = false;
            cmbKisayol5.Enabled = false;

            rdbErkek1.Enabled = true;
            rdbErkek2.Enabled = false;
            rdbErkek3.Enabled = false;
            rdbErkek4.Enabled = false;
            rdbErkek5.Enabled = false;

            rdbKiz1.Enabled = true;
            rdbKiz2.Enabled = false;
            rdbKiz3.Enabled = false;
            rdbKiz4.Enabled = false;
            rdbKiz5.Enabled = false;

            txtOyuncu2.Text = "Oyuncu_2";
            txtOyuncu3.Text = "Oyuncu_3";
            txtOyuncu4.Text = "Oyuncu_4";
            txtOyuncu5.Text = "Oyuncu_5";

            cmbKisayol2.SelectedIndex = -1;
            cmbKisayol3.SelectedIndex = -1;
            cmbKisayol4.SelectedIndex = -1;
            cmbKisayol5.SelectedIndex = -1;

            Oyun_Degiskenleri.oynayanKisi = 1;
            btnIleri.Enabled = true;
        }

        private void rdbKisi2_CheckedChanged(object sender, EventArgs e)
        {
            txtOyuncu1.Enabled = true;
            txtOyuncu2.Enabled = true;
            txtOyuncu3.Enabled = false;
            txtOyuncu4.Enabled = false;
            txtOyuncu5.Enabled = false;

            cmbKisayol1.Enabled = true;
            cmbKisayol2.Enabled = true;
            cmbKisayol3.Enabled = false;
            cmbKisayol4.Enabled = false;
            cmbKisayol5.Enabled = false;

            rdbErkek1.Enabled = true;
            rdbErkek2.Enabled = true;
            rdbErkek3.Enabled = false;
            rdbErkek4.Enabled = false;
            rdbErkek5.Enabled = false;

            rdbKiz1.Enabled = true;
            rdbKiz2.Enabled = true;
            rdbKiz3.Enabled = false;
            rdbKiz4.Enabled = false;
            rdbKiz5.Enabled = false;

            txtOyuncu3.Text = "Oyuncu_3";
            txtOyuncu4.Text = "Oyuncu_4";
            txtOyuncu5.Text = "Oyuncu_5";

            cmbKisayol3.SelectedIndex = -1;
            cmbKisayol4.SelectedIndex = -1;
            cmbKisayol5.SelectedIndex = -1;

            Oyun_Degiskenleri.oynayanKisi = 2;
            btnIleri.Enabled = true;
        }

        private void rdbKisi3_CheckedChanged(object sender, EventArgs e)
        {
            txtOyuncu1.Enabled = true;
            txtOyuncu2.Enabled = true;
            txtOyuncu3.Enabled = true;
            txtOyuncu4.Enabled = false;
            txtOyuncu5.Enabled = false;

            cmbKisayol1.Enabled = true;
            cmbKisayol2.Enabled = true;
            cmbKisayol3.Enabled = true;
            cmbKisayol4.Enabled = false;
            cmbKisayol5.Enabled = false;

            rdbErkek1.Enabled = true;
            rdbErkek2.Enabled = true;
            rdbErkek3.Enabled = true;
            rdbErkek4.Enabled = false;
            rdbErkek5.Enabled = false;

            rdbKiz1.Enabled = true;
            rdbKiz2.Enabled = true;
            rdbKiz3.Enabled = true;
            rdbKiz4.Enabled = false;
            rdbKiz5.Enabled = false;

            txtOyuncu4.Text = "Oyuncu_4";
            txtOyuncu5.Text = "Oyuncu_5";

            cmbKisayol4.SelectedIndex = -1;
            cmbKisayol5.SelectedIndex = -1;

            Oyun_Degiskenleri.oynayanKisi = 3;
            btnIleri.Enabled = true;
        }

        private void rdbKisi4_CheckedChanged(object sender, EventArgs e)
        {
            txtOyuncu1.Enabled = true;
            txtOyuncu2.Enabled = true;
            txtOyuncu3.Enabled = true;
            txtOyuncu4.Enabled = true;
            txtOyuncu5.Enabled = false;

            cmbKisayol1.Enabled = true;
            cmbKisayol2.Enabled = true;
            cmbKisayol3.Enabled = true;
            cmbKisayol4.Enabled = true;
            cmbKisayol5.Enabled = false;

            rdbErkek1.Enabled = true;
            rdbErkek2.Enabled = true;
            rdbErkek3.Enabled = true;
            rdbErkek4.Enabled = true;
            rdbErkek5.Enabled = false;

            rdbKiz1.Enabled = true;
            rdbKiz2.Enabled = true;
            rdbKiz3.Enabled = true;
            rdbKiz4.Enabled = true;
            rdbKiz5.Enabled = false;

            txtOyuncu5.Text = "Oyuncu_5";

            cmbKisayol5.SelectedIndex = -1;

            Oyun_Degiskenleri.oynayanKisi = 4;
            btnIleri.Enabled = true;
        }

        private void rdbKisi5_CheckedChanged(object sender, EventArgs e)
        {
            txtOyuncu1.Enabled = true;
            txtOyuncu2.Enabled = true;
            txtOyuncu3.Enabled = true;
            txtOyuncu4.Enabled = true;
            txtOyuncu5.Enabled = true;

            cmbKisayol1.Enabled = true;
            cmbKisayol2.Enabled = true;
            cmbKisayol3.Enabled = true;
            cmbKisayol4.Enabled = true;
            cmbKisayol5.Enabled = true;

            rdbErkek1.Enabled = true;
            rdbErkek2.Enabled = true;
            rdbErkek3.Enabled = true;
            rdbErkek4.Enabled = true;
            rdbErkek5.Enabled = true;

            rdbKiz1.Enabled = true;
            rdbKiz2.Enabled = true;
            rdbKiz3.Enabled = true;
            rdbKiz4.Enabled = true;
            rdbKiz5.Enabled = true;

            Oyun_Degiskenleri.oynayanKisi = 5;
            btnIleri.Enabled = true;
        }

        private void txtOyuncu1_Enter(object sender, EventArgs e)
        {
            txtOyuncu1.Text = "";
        }

        private void txtOyuncu2_Enter(object sender, EventArgs e)
        {
            txtOyuncu2.Text = "";
        }

        private void txtOyuncu3_Enter(object sender, EventArgs e)
        {
            txtOyuncu3.Text = "";
        }

        private void txtOyuncu4_Enter(object sender, EventArgs e)
        {
            txtOyuncu4.Text = "";
        }

        private void txtOyuncu5_Enter(object sender, EventArgs e)
        {
            txtOyuncu5.Text = "";
        }

        private void txtOyuncu1_Validating(object sender, CancelEventArgs e)
        {
            if (txtOyuncu1.Text == "")
            {
                MessageBox.Show("Bu alanı boş geçemezsiniz. Lütfen bir kullanıcı adı yazınız.");
                txtOyuncu1.Focus();
            }

            else if (txtOyuncu1.Text == txtOyuncu2.Text || txtOyuncu1.Text == txtOyuncu3.Text || txtOyuncu1.Text == txtOyuncu4.Text || txtOyuncu1.Text == txtOyuncu5.Text)
            {
                MessageBox.Show("Aynı Kullanıcı İsmine Sahip Başka Bir Oyuncu Mevcut. Lütfen Kullanıcı Adınızı Değiştirip Tekrar Deneyiniz.");
                txtOyuncu1.Focus();
            }
        }

        private void txtOyuncu2_Validated(object sender, EventArgs e)
        {
            if (txtOyuncu2.Text == "")
            {
                MessageBox.Show("Bu alanı boş geçemezsiniz. Lütfen bir kullanıcı adı yazınız.");
                txtOyuncu2.Focus();
            }

            else if (txtOyuncu2.Text == txtOyuncu1.Text || txtOyuncu2.Text == txtOyuncu3.Text || txtOyuncu2.Text == txtOyuncu4.Text || txtOyuncu2.Text == txtOyuncu5.Text)
            {
                MessageBox.Show("Aynı Kullanıcı İsmine Sahip Başka Bir Oyuncu Mevcut. Lütfen Kullanıcı Adınızı Değiştirip Tekrar Deneyiniz.");
                txtOyuncu2.Focus();
            }
        }

        private void txtOyuncu3_Validated(object sender, EventArgs e)
        {
            if (txtOyuncu3.Text == "")
            {
                MessageBox.Show("Bu alanı boş geçemezsiniz. Lütfen bir kullanıcı adı yazınız.");
                txtOyuncu3.Focus();
            }

            else if (txtOyuncu3.Text == txtOyuncu1.Text || txtOyuncu3.Text == txtOyuncu2.Text || txtOyuncu3.Text == txtOyuncu4.Text || txtOyuncu3.Text == txtOyuncu5.Text)
            {
                MessageBox.Show("Aynı Kullanıcı İsmine Sahip Başka Bir Oyuncu Mevcut. Lütfen Kullanıcı Adınızı Değiştirip Tekrar Deneyiniz.");
                txtOyuncu3.Focus();
            }
        }

        private void txtOyuncu4_Validated(object sender, EventArgs e)
        {
            if (txtOyuncu4.Text == "")
            {
                MessageBox.Show("Bu alanı boş geçemezsiniz. Lütfen bir kullanıcı adı yazınız.");
                txtOyuncu4.Focus();
            }

            else if (txtOyuncu4.Text == txtOyuncu1.Text || txtOyuncu4.Text == txtOyuncu2.Text || txtOyuncu4.Text == txtOyuncu2.Text || txtOyuncu4.Text == txtOyuncu5.Text)
            {
                MessageBox.Show("Aynı Kullanıcı İsmine Sahip Başka Bir Oyuncu Mevcut. Lütfen Kullanıcı Adınızı Değiştirip Tekrar Deneyiniz.");
                txtOyuncu4.Focus();
            }
        }

        private void txtOyuncu5_Validated(object sender, EventArgs e)
        {
            if (txtOyuncu5.Text == "")
            {
                MessageBox.Show("Bu alanı boş geçemezsiniz. Lütfen bir kullanıcı adı yazınız.");
                txtOyuncu5.Focus();
            }

            else if (txtOyuncu5.Text == txtOyuncu1.Text || txtOyuncu5.Text == txtOyuncu2.Text || txtOyuncu5.Text == txtOyuncu3.Text || txtOyuncu5.Text == txtOyuncu4.Text)
            {
                MessageBox.Show("Aynı Kullanıcı İsmine Sahip Başka Bir Oyuncu Mevcut. \nLütfen Kullanıcı Adınızı Değiştirip Tekrar Deneyiniz.");
                txtOyuncu5.Focus();
            }
        }

        private void cmbKisayol1_Validating(object sender, CancelEventArgs e)
        {
            if (cmbKisayol1.SelectedIndex == -1)
            {
                MessageBox.Show("Geçerli oyuncu için kısayol tuşu seçmediniz. Lütfen bir tane kısayol tuşu seçiniz.");
                cmbKisayol1.DroppedDown = true;
                cmbKisayol1.Focus();
            }

            else if (cmbKisayol1.SelectedIndex == cmbKisayol2.SelectedIndex || cmbKisayol1.SelectedIndex == cmbKisayol3.SelectedIndex || cmbKisayol1.SelectedIndex == cmbKisayol4.SelectedIndex || cmbKisayol1.SelectedIndex == cmbKisayol5.SelectedIndex)
            {
                MessageBox.Show("Aynı kısayol tuşunu birden fazla kullanıcı alamaz. Lütfen farklı bir kısayol tuşu seçiniz.");
                cmbKisayol1.DroppedDown = true;
                cmbKisayol1.Focus();
            }
        }

        private void cmbKisayol2_Validating(object sender, CancelEventArgs e)
        {
            if (cmbKisayol2.SelectedIndex == -1)
            {
                MessageBox.Show("Geçerli oyuncu için kısayol tuşu seçmediniz. Lütfen bir tane kısayol tuşu seçiniz.");
                cmbKisayol2.DroppedDown = true;
                cmbKisayol2.Focus();
            }

            else if (cmbKisayol2.SelectedIndex == cmbKisayol1.SelectedIndex || cmbKisayol2.SelectedIndex == cmbKisayol3.SelectedIndex || cmbKisayol2.SelectedIndex == cmbKisayol4.SelectedIndex || cmbKisayol2.SelectedIndex == cmbKisayol5.SelectedIndex)
            {
                MessageBox.Show("Aynı kısayol tuşunu birden fazla kullanıcı alamaz. Lütfen farklı bir kısayol tuşu seçiniz.");
                cmbKisayol2.DroppedDown = true;
                cmbKisayol2.Focus();
            }
        }

        private void cmbKisayol3_Validating(object sender, CancelEventArgs e)
        {
            if (cmbKisayol3.SelectedIndex == -1)
            {
                MessageBox.Show("Geçerli oyuncu için kısayol tuşu seçmediniz. Lütfen bir tane kısayol tuşu seçiniz.");
                cmbKisayol3.DroppedDown = true;
                cmbKisayol4.Focus();
            }

            else if (cmbKisayol3.SelectedIndex == cmbKisayol1.SelectedIndex || cmbKisayol3.SelectedIndex == cmbKisayol2.SelectedIndex || cmbKisayol3.SelectedIndex == cmbKisayol4.SelectedIndex || cmbKisayol3.SelectedIndex == cmbKisayol5.SelectedIndex)
            {
                MessageBox.Show("Aynı kısayol tuşunu birden fazla kullanıcı alamaz. Lütfen farklı bir kısayol tuşu seçiniz.");
                cmbKisayol3.DroppedDown = true;
                cmbKisayol4.Focus();
            }
        }

        private void cmbKisayol4_Validating(object sender, CancelEventArgs e)
        {
            if (cmbKisayol4.SelectedIndex == -1)
            {
                MessageBox.Show("Geçerli oyuncu için kısayol tuşu seçmediniz. Lütfen bir tane kısayol tuşu seçiniz.");
                cmbKisayol4.DroppedDown = true;
                cmbKisayol4.Focus();
            }

            else if (cmbKisayol4.SelectedIndex == cmbKisayol1.SelectedIndex || cmbKisayol4.SelectedIndex == cmbKisayol2.SelectedIndex || cmbKisayol4.SelectedIndex == cmbKisayol3.SelectedIndex || cmbKisayol4.SelectedIndex == cmbKisayol5.SelectedIndex)
            {
                MessageBox.Show("Aynı kısayol tuşunu birden fazla kullanıcı alamaz. Lütfen farklı bir kısayol tuşu seçiniz.");
                cmbKisayol4.DroppedDown = true;
                cmbKisayol4.Focus();
            }
        }

        private void cmbKisayol5_Validating(object sender, CancelEventArgs e)
        {
            if (cmbKisayol5.SelectedIndex == -1)
            {
                MessageBox.Show("Geçerli oyuncu için kısayol tuşu seçmediniz. Lütfen bir tane kısayol tuşu seçiniz.");
                cmbKisayol5.DroppedDown = true;
                cmbKisayol5.Focus();
            }
            else if (cmbKisayol5.SelectedIndex == cmbKisayol1.SelectedIndex || cmbKisayol5.SelectedIndex == cmbKisayol2.SelectedIndex || cmbKisayol5.SelectedIndex == cmbKisayol3.SelectedIndex || cmbKisayol5.SelectedIndex == cmbKisayol4.SelectedIndex)
            {
                MessageBox.Show("Aynı kısayol tuşunu birden fazla kullanıcı alamaz. Lütfen farklı bir kısayol tuşu seçiniz.");
                cmbKisayol5.DroppedDown = true;
                cmbKisayol5.Focus();
            }
        }


        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (rdbKisi1.Checked)
            {
                if (cmbKisayol1.SelectedIndex != -1)
                {
                    Oyun_Degiskenleri.isimO1 = txtOyuncu1.Text;

                    Oyun_Degiskenleri.kisayolO1 = Convert.ToChar(cmbKisayol1.Text);
                    Kaydetme();
                }
                else
                    MessageBox.Show("Lütfen geçerli oyuncu için kısayol tuşu atamasını gerçekleştiriniz.");
                
            }

            else if (rdbKisi2.Checked)
            {
                if (cmbKisayol1.SelectedIndex != -1 && cmbKisayol2.SelectedIndex != -1)
                {
                    Oyun_Degiskenleri.isimO1 = txtOyuncu1.Text;
                    Oyun_Degiskenleri.isimO2 = txtOyuncu2.Text;

                    Oyun_Degiskenleri.kisayolO1 = Convert.ToChar(cmbKisayol1.Text);
                    Oyun_Degiskenleri.kisayolO2 = Convert.ToChar(cmbKisayol2.Text);
                    Kaydetme();
                }
                else
                    MessageBox.Show("Lütfen geçerli oyuncu için kısayol tuşu atamasını gerçekleştiriniz.");
            }

            else if (rdbKisi3.Checked)
            {
                if (cmbKisayol1.SelectedIndex != -1 && cmbKisayol2.SelectedIndex != -1 && cmbKisayol3.SelectedIndex != -1)
                {
                    Oyun_Degiskenleri.isimO1 = txtOyuncu1.Text;
                    Oyun_Degiskenleri.isimO2 = txtOyuncu2.Text;
                    Oyun_Degiskenleri.isimO3 = txtOyuncu3.Text;

                    Oyun_Degiskenleri.kisayolO1 = Convert.ToChar(cmbKisayol1.Text);
                    Oyun_Degiskenleri.kisayolO2 = Convert.ToChar(cmbKisayol2.Text);
                    Oyun_Degiskenleri.kisayolO3 = Convert.ToChar(cmbKisayol3.Text);
                    Kaydetme();
                }
                else
                    MessageBox.Show("Lütfen geçerli oyuncu için kısayol tuşu atamasını gerçekleştiriniz.");
            }

            else if (rdbKisi4.Checked)
            {
                if (cmbKisayol1.SelectedIndex != -1 && cmbKisayol2.SelectedIndex != -1 && cmbKisayol3.SelectedIndex != -1 && cmbKisayol4.SelectedIndex != -1)
                {
                    Oyun_Degiskenleri.isimO1 = txtOyuncu1.Text;
                    Oyun_Degiskenleri.isimO2 = txtOyuncu2.Text;
                    Oyun_Degiskenleri.isimO3 = txtOyuncu3.Text;
                    Oyun_Degiskenleri.isimO4 = txtOyuncu4.Text;

                    Oyun_Degiskenleri.kisayolO1 = Convert.ToChar(cmbKisayol1.Text);
                    Oyun_Degiskenleri.kisayolO2 = Convert.ToChar(cmbKisayol2.Text);
                    Oyun_Degiskenleri.kisayolO3 = Convert.ToChar(cmbKisayol3.Text);
                    Oyun_Degiskenleri.kisayolO4 = Convert.ToChar(cmbKisayol4.Text);
                    Kaydetme();
                }
                else
                    MessageBox.Show("Lütfen geçerli oyuncu için kısayol tuşu atamasını gerçekleştiriniz.");
            }

            else if (rdbKisi5.Checked)
            {
                if (cmbKisayol1.SelectedIndex != -1 && cmbKisayol2.SelectedIndex != -1 && cmbKisayol3.SelectedIndex != -1 && cmbKisayol4.SelectedIndex != -1&&cmbKisayol5.SelectedIndex!=-1)
                {
                    Oyun_Degiskenleri.isimO1 = txtOyuncu1.Text;
                    Oyun_Degiskenleri.isimO2 = txtOyuncu2.Text;
                    Oyun_Degiskenleri.isimO3 = txtOyuncu3.Text;
                    Oyun_Degiskenleri.isimO4 = txtOyuncu4.Text;
                    Oyun_Degiskenleri.isimO5 = txtOyuncu5.Text;

                    Oyun_Degiskenleri.kisayolO1 = Convert.ToChar(cmbKisayol1.Text);
                    Oyun_Degiskenleri.kisayolO2 = Convert.ToChar(cmbKisayol2.Text);
                    Oyun_Degiskenleri.kisayolO3 = Convert.ToChar(cmbKisayol3.Text);
                    Oyun_Degiskenleri.kisayolO4 = Convert.ToChar(cmbKisayol4.Text);
                    Oyun_Degiskenleri.kisayolO5 = Convert.ToChar(cmbKisayol5.Text);
                    Kaydetme();
                }
                else
                    MessageBox.Show("Lütfen geçerli oyuncu için kısayol tuşu atamasını gerçekleştiriniz.");
            }
        }

        private void Kaydetme()
        {
            Bitmap ekranYakala = new Bitmap(this.Width, this.Height);
            DrawToBitmap(ekranYakala, new Rectangle(0, 0, ekranYakala.Width, ekranYakala.Height));
            StackBlur.StackBlur.Process(ekranYakala, 10);
            pbxBlur.Dock = DockStyle.Fill;
            pbxBlur.Image = ekranYakala;
            pbxKontrol.ImageLocation = "Kontrol.gif";
            pbxKontrol.Location = new Point((this.Width / 2) - (pbxKontrol.Width / 2), (this.Height / 2) - (pbxKontrol.Height / 2));
            pbxKontrol.Visible = true;
            pbxBlur.Visible = true;
            timer1.Enabled = true;
        }

        int saniye = 0;
        Soru_Kelime gecis = new Soru_Kelime();
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye += 4;
            if (saniye == 16)
            {
                timer1.Stop();
                pbxKontrol.Visible = false;
                pbxBlur.Visible = false;
                //this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                gecis.Show();
                this.Hide();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menu git = new Menu();
            git.ShowDialog();
            this.Close();
        }

        Random rnd = new Random();
        private void rdbKiz1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKiz1.Checked)
            {
                Oyun_Degiskenleri.resimIndex1 = rnd.Next(24, 48);
                pbxOyuncu1.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex1];
            }
        }

        private void rdbErkek1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbErkek1.Checked)
            {
                Oyun_Degiskenleri.resimIndex1 = rnd.Next(1, 23);
                pbxOyuncu1.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex1];
            }
        }

        private void rdbKiz2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKiz2.Checked)
            {
                Oyun_Degiskenleri.resimIndex2 = rnd.Next(24, 48);
                pbxOyuncu2.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex2];
            }
        }

        private void rdbErkek2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbErkek2.Checked)
            {
                Oyun_Degiskenleri.resimIndex2 = rnd.Next(1, 23);
                pbxOyuncu2.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex2];
            }
        }

        private void rdbKiz3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKiz3.Checked)
            {
                Oyun_Degiskenleri.resimIndex3 = rnd.Next(24, 48);
                pbxOyuncu3.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex3];
            }
        }

        private void rdbErkek3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbErkek3.Checked)
            {
                Oyun_Degiskenleri.resimIndex3 = rnd.Next(1, 23);
                pbxOyuncu3.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex3];
            }
        }

        private void rdbKiz4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKiz4.Checked)
            {
                Oyun_Degiskenleri.resimIndex4 = rnd.Next(24, 48);
                pbxOyuncu4.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex4];
            }
        }

        private void rdbErkek4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbErkek4.Checked)
            {
                Oyun_Degiskenleri.resimIndex4 = rnd.Next(1, 23);
                pbxOyuncu4.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex4];
            }
        }

        private void rdbKiz5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKiz5.Checked)
            {
                Oyun_Degiskenleri.resimIndex5 = rnd.Next(24, 48);
                pbxOyuncu5.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex5];
            }
        }

        private void rdbErkek5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbErkek5.Checked)
            {
                Oyun_Degiskenleri.resimIndex5 = rnd.Next(1, 23);
                pbxOyuncu5.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex5];
            }
        }

    }
}
