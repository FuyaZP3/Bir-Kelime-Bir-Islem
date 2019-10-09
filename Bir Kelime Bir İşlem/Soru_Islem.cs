using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Bir_Kelime_Bir_İşlem
{
    public partial class Soru_Islem : Form
    {
        public Soru_Islem()
        {
            InitializeComponent();
        }

        SoundPlayer sayiDonme = new SoundPlayer(Application.StartupPath + "\\Harf_Sesi.wav");
        SoundPlayer sayiOkuma = new SoundPlayer();
        SoundPlayer sureİslem = new SoundPlayer(Application.StartupPath + "\\Ses_SoruIslem.wav");
        SoundPlayer sureBasladi = new SoundPlayer(Application.StartupPath + "\\Sayi_SureBasladi.wav");
        SoundPlayer buton = new SoundPlayer(Application.StartupPath + "\\Ses_SoruCevap.wav");
        Oyun_Degiskenleri oyun = new Oyun_Degiskenleri();
        private void Soru_Islem_Load(object sender, EventArgs e)
        {
            #region Yarışmaya katılan kişiler
            if (Oyun_Degiskenleri.oynayanKisi == 1)
            {
                pbxOyuncu1.Location = new Point(692, 446);
                lblOyuncu1.Location = new Point(688, 601);
                lblPuan1.Location = new Point(688, 634);

                pbxOyuncu1.Visible = true;
                lblOyuncu1.Visible = true;
                lblPuan1.Visible = true;

                pbxOyuncu1.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex1];

                lblOyuncu1.Text = Oyun_Degiskenleri.isimO1;

                lblPuan1.Text = Oyun_Degiskenleri.puanO1.ToString();

            }
            else if (Oyun_Degiskenleri.oynayanKisi == 2)
            {
                pbxOyuncu1.Location = new Point(592, 446);
                lblOyuncu1.Location = new Point(588, 601);
                lblPuan1.Location = new Point(588, 634);
                pbxOyuncu2.Location = new Point(792, 446);
                lblOyuncu2.Location = new Point(788, 601);
                lblPuan2.Location = new Point(788, 634);

                pbxOyuncu1.Visible = true;
                lblOyuncu1.Visible = true;
                lblPuan1.Visible = true;
                pbxOyuncu2.Visible = true;
                lblOyuncu2.Visible = true;
                lblPuan2.Visible = true;

                pbxOyuncu1.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex1];
                pbxOyuncu2.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex2];

                lblOyuncu1.Text = Oyun_Degiskenleri.isimO1;
                lblOyuncu2.Text = Oyun_Degiskenleri.isimO2;

                lblPuan1.Text = Oyun_Degiskenleri.puanO1.ToString();
                lblPuan2.Text = Oyun_Degiskenleri.puanO2.ToString();
            }
            else if (Oyun_Degiskenleri.oynayanKisi == 3)
            {
                pbxOyuncu1.Location = new Point(492, 446);
                lblOyuncu1.Location = new Point(488, 601);
                lblPuan1.Location = new Point(488, 634);
                pbxOyuncu2.Location = new Point(692, 446);
                lblOyuncu2.Location = new Point(688, 601);
                lblPuan2.Location = new Point(688, 634);
                pbxOyuncu3.Location = new Point(892, 446);
                lblOyuncu3.Location = new Point(888, 601);
                lblPuan3.Location = new Point(888, 634);

                pbxOyuncu1.Visible = true;
                lblOyuncu1.Visible = true;
                lblPuan1.Visible = true;
                pbxOyuncu2.Visible = true;
                lblOyuncu2.Visible = true;
                lblPuan2.Visible = true;
                pbxOyuncu3.Visible = true;
                lblOyuncu3.Visible = true;
                lblPuan3.Visible = true;

                pbxOyuncu1.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex1];
                pbxOyuncu2.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex2];
                pbxOyuncu3.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex3];

                lblOyuncu1.Text = Oyun_Degiskenleri.isimO1;
                lblOyuncu2.Text = Oyun_Degiskenleri.isimO2;
                lblOyuncu3.Text = Oyun_Degiskenleri.isimO3;

                lblPuan1.Text = Oyun_Degiskenleri.puanO1.ToString();
                lblPuan2.Text = Oyun_Degiskenleri.puanO2.ToString();
                lblPuan3.Text = Oyun_Degiskenleri.puanO3.ToString();

            }
            else if (Oyun_Degiskenleri.oynayanKisi == 4)
            {
                pbxOyuncu1.Location = new Point(392, 446);
                lblOyuncu1.Location = new Point(388, 601);
                lblPuan1.Location = new Point(388, 634);
                pbxOyuncu2.Location = new Point(592, 446);
                lblOyuncu2.Location = new Point(588, 601);
                lblPuan2.Location = new Point(588, 634);
                pbxOyuncu3.Location = new Point(792, 446);
                lblOyuncu3.Location = new Point(788, 601);
                lblPuan3.Location = new Point(788, 634);
                pbxOyuncu4.Location = new Point(992, 446);
                lblOyuncu4.Location = new Point(988, 601);
                lblPuan4.Location = new Point(988, 634);

                pbxOyuncu1.Visible = true;
                lblOyuncu1.Visible = true;
                lblPuan1.Visible = true;
                pbxOyuncu2.Visible = true;
                lblOyuncu2.Visible = true;
                lblPuan2.Visible = true;
                pbxOyuncu3.Visible = true;
                lblOyuncu3.Visible = true;
                lblPuan3.Visible = true;
                pbxOyuncu4.Visible = true;
                lblOyuncu4.Visible = true;
                lblPuan4.Visible = true;

                pbxOyuncu1.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex1];
                pbxOyuncu2.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex2];
                pbxOyuncu3.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex3];
                pbxOyuncu4.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex4];

                lblOyuncu1.Text = Oyun_Degiskenleri.isimO1;
                lblOyuncu2.Text = Oyun_Degiskenleri.isimO2;
                lblOyuncu3.Text = Oyun_Degiskenleri.isimO3;
                lblOyuncu4.Text = Oyun_Degiskenleri.isimO4;

                lblPuan1.Text = Oyun_Degiskenleri.puanO1.ToString();
                lblPuan2.Text = Oyun_Degiskenleri.puanO2.ToString();
                lblPuan3.Text = Oyun_Degiskenleri.puanO3.ToString();
                lblPuan4.Text = Oyun_Degiskenleri.puanO4.ToString();
            }
            else if(Oyun_Degiskenleri.oynayanKisi == 5)
            {
                pbxOyuncu1.Location = new Point(292, 446);
                lblOyuncu1.Location = new Point(288, 601);
                lblPuan1.Location = new Point(288, 634);
                pbxOyuncu2.Location = new Point(492, 446);
                lblOyuncu2.Location = new Point(488, 601);
                lblPuan2.Location = new Point(488, 634);
                pbxOyuncu3.Location = new Point(692, 446);
                lblOyuncu3.Location = new Point(688, 601);
                lblPuan3.Location = new Point(688, 634);
                pbxOyuncu4.Location = new Point(892, 446);
                lblOyuncu4.Location = new Point(888, 601);
                lblPuan4.Location = new Point(888, 634);
                pbxOyuncu5.Location = new Point(1092, 446);
                lblOyuncu5.Location = new Point(1088, 601);
                lblPuan5.Location = new Point(1088, 634);

                pbxOyuncu1.Visible = true;
                lblOyuncu1.Visible = true;
                lblPuan1.Visible = true;
                pbxOyuncu2.Visible = true;
                lblOyuncu2.Visible = true;
                lblPuan2.Visible = true;
                pbxOyuncu3.Visible = true;
                lblOyuncu3.Visible = true;
                lblPuan3.Visible = true;
                pbxOyuncu4.Visible = true;
                lblOyuncu4.Visible = true;
                lblPuan4.Visible = true;
                pbxOyuncu5.Visible = true;
                lblOyuncu5.Visible = true;
                lblPuan5.Visible = true;

                pbxOyuncu1.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex1];
                pbxOyuncu2.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex2];
                pbxOyuncu3.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex3];
                pbxOyuncu4.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex4];
                pbxOyuncu5.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex5];

                lblOyuncu1.Text = Oyun_Degiskenleri.isimO1;
                lblOyuncu2.Text = Oyun_Degiskenleri.isimO2;
                lblOyuncu3.Text = Oyun_Degiskenleri.isimO3;
                lblOyuncu4.Text = Oyun_Degiskenleri.isimO4;
                lblOyuncu5.Text = Oyun_Degiskenleri.isimO5;

                lblPuan1.Text = Oyun_Degiskenleri.puanO1.ToString();
                lblPuan2.Text = Oyun_Degiskenleri.puanO2.ToString();
                lblPuan3.Text = Oyun_Degiskenleri.puanO3.ToString();
                lblPuan4.Text = Oyun_Degiskenleri.puanO4.ToString();
                lblPuan5.Text = Oyun_Degiskenleri.puanO5.ToString();
            }
            #endregion

            lblPuan.Parent = pbxPuan;
            lblPuan.BackColor = Color.Transparent;
            lblSure.Parent = pbxSure;
            lblSure.BackColor = Color.Transparent;


            timer1.Start();
            lblSayi1.Visible = true;
            sayiDonme.Play();
        }

        #region Yarışmadaki sayı ile ilgili seslendirmeler
        private void okuRakam(int rakam)
        {
            switch (rakam)
            {
                case 0:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_0.wav";
                    sayiOkuma.Play();
                    break;
                case 1:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_1.wav";
                    sayiOkuma.Play();
                    break;
                case 2:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_2.wav";
                    sayiOkuma.Play();
                    break;
                case 3:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_3.wav";
                    sayiOkuma.Play();
                    break;
                case 4:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_4.wav";
                    sayiOkuma.Play();
                    break;
                case 5:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_5.wav";
                    sayiOkuma.Play();
                    break;
                case 6:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_6.wav";
                    sayiOkuma.Play();
                    break;
                case 7:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_7.wav";
                    sayiOkuma.Play();
                    break;
                case 8:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_8.wav";
                    sayiOkuma.Play();
                    break;
                case 9:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_9.wav";
                    sayiOkuma.Play();
                    break;
            }
        }

        private void okuBesliler(int besli)
        {
            switch (besli)
            {
                case 25:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve25.wav";
                    sayiOkuma.Play();
                    break;
                case 30:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve30.wav";
                    sayiOkuma.Play();
                    break;
                case 35:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve35.wav";
                    sayiOkuma.Play();
                    break;
                case 40:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve40.wav";
                    sayiOkuma.Play();
                    break;
                case 45:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve45.wav";
                    sayiOkuma.Play();
                    break;
                case 50:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve50.wav";
                    sayiOkuma.Play();
                    break;
                case 55:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve55.wav";
                    sayiOkuma.Play();
                    break;
                case 60:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve60.wav";
                    sayiOkuma.Play();
                    break;
                case 65:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve65.wav";
                    sayiOkuma.Play();
                    break;
                case 70:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve70.wav";
                    sayiOkuma.Play();
                    break;
                case 75:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve75.wav";
                    sayiOkuma.Play();
                    break;
                case 80:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve80.wav";
                    sayiOkuma.Play();
                    break;
                case 85:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve85.wav";
                    sayiOkuma.Play();
                    break;
                case 90:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve90.wav";
                    sayiOkuma.Play();
                    break;
                case 95:
                    sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_ve95.wav";
                    sayiOkuma.Play();
                    break;
            }
        }
        #endregion

        #region Sayıların dönmesi
        int sayac1 = 0, sayac2 = 0, sayac3 = 0, sayac4 = 0, sayac5 = 0, sayac6 = 0, sayac7 = 0;
        string[] besliler = { "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95" };
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSayi1.Text = rnd.Next(1, 10).ToString();
            sayac1++;
            if (sayac1 == 6)
            {
                timer1.Stop();
                okuRakam(int.Parse(lblSayi1.Text));
                timerBekleme1.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblSayi2.Text = rnd.Next(1, 10).ToString();
            sayac2++;
            if (sayac2 == 6)
            {
                timer2.Stop();
                okuRakam(int.Parse(lblSayi2.Text));
                timerBekleme2.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblSayi3.Text = rnd.Next(1, 10).ToString();
            sayac3++;
            if (sayac3 == 6)
            {
                timer3.Stop();
                okuRakam(int.Parse(lblSayi3.Text));
                timerBekleme3.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            lblSayi4.Text = rnd.Next(1, 10).ToString();
            sayac4++;
            if (sayac4 == 6)
            {
                timer4.Stop();
                okuRakam(int.Parse(lblSayi4.Text));
                timerBekleme4.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            lblSayi5.Text = rnd.Next(1, 10).ToString();
            sayac5++;
            if (sayac5 == 6)
            {
                timer5.Stop();
                okuRakam(int.Parse(lblSayi5.Text));
                timerBekleme5.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            lblCiftSayi.Text = besliler[rnd.Next(besliler.Length)].ToString();
            sayac6++;
            if (sayac6 == 6)
            {
                timer6.Stop();
                okuBesliler(int.Parse(lblCiftSayi.Text));
                timerBekleme6.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            lblIstenilen.Text = rnd.Next(100, 1000).ToString();
            sayac7++;
            if (sayac7 == 6)
            {
                timer7.Stop();
                pbxPuan.Visible = true;
                pbxSure.Visible = true;
                lblPuan.Visible = true;
                lblSure.Visible = true;
                timerSure.Enabled = true;
                axWindowsMediaPlayer2.URL = Application.StartupPath + "/Sayi_SureBasladi.wav";
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
        }
        #endregion

        #region sayıları beklemesi
        int bekleme1 = 0, bekleme2 = 0, bekleme3 = 0, bekleme4 = 0, bekleme5 = 0, bekleme6 = 0, bekleme7 = 0;
        private void timerBekleme1_Tick(object sender, EventArgs e)
        {
            bekleme1++;
            if (bekleme1 == 1)
            {
                timerBekleme1.Stop();
                timer2.Start();
                lblSayi2.Visible = true;
                sayiDonme.Play();
            }
        }

        private void timerBekleme2_Tick(object sender, EventArgs e)
        {
            bekleme2++;
            if (bekleme2 == 1)
            {
                timerBekleme2.Stop();
                timer3.Start();
                lblSayi3.Visible = true;
                sayiDonme.Play();
            }
        }

        private void timerBekleme3_Tick(object sender, EventArgs e)
        {
            bekleme3++;
            if (bekleme3 == 1)
            {
                timerBekleme3.Stop();
                timer4.Start();
                lblSayi4.Visible = true;
                sayiDonme.Play();
            }
        }

        private void timerBekleme4_Tick(object sender, EventArgs e)
        {
            bekleme4++;
            if (bekleme4 == 1)
            {
                timerBekleme4.Stop();
                timer5.Start();
                lblSayi5.Visible = true;
                sayiDonme.Play();
            }
        }

        private void timerBekleme5_Tick(object sender, EventArgs e)
        {
            bekleme5++;
            if (bekleme5 == 1)
            {
                timerBekleme5.Stop();
                timer6.Start();
                lblCiftSayi.Visible = true;
                sayiDonme.Play();
            }
        }

        private void timerBekleme6_Tick(object sender, EventArgs e)
        {
            bekleme6++;
            if (bekleme6 == 2)
            {
                timerBekleme6.Stop();
                timer7.Start();
                //sayiOkuma.SoundLocation = Application.StartupPath + "\\Sayi_HedefSayi.wav";
                axWindowsMediaPlayer1.URL = Application.StartupPath + "/Sayi_HedefSayi.wav";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                lblIstenilen.Visible = true;
                sayiDonme.Play();
            }
        }
        #endregion

        private void btnSonrakiSoru_Click(object sender, EventArgs e)
        {
            if (Oyun_Degiskenleri.oynayanKisi == 1)
            {
                Oyun_Degiskenleri.puanO1 = Convert.ToInt32(lblPuan1.Text);
            }
            else if (Oyun_Degiskenleri.oynayanKisi == 2)
            {
                Oyun_Degiskenleri.puanO1 = Convert.ToInt32(lblPuan1.Text);
                Oyun_Degiskenleri.puanO2 = Convert.ToInt32(lblPuan2.Text);
            }
            else if (Oyun_Degiskenleri.oynayanKisi == 3)
            {
                Oyun_Degiskenleri.puanO1 = Convert.ToInt32(lblPuan1.Text);
                Oyun_Degiskenleri.puanO2 = Convert.ToInt32(lblPuan2.Text);
                Oyun_Degiskenleri.puanO3 = Convert.ToInt32(lblPuan3.Text);
            }
            else if (Oyun_Degiskenleri.oynayanKisi == 4)
            {
                Oyun_Degiskenleri.puanO1 = Convert.ToInt32(lblPuan1.Text);
                Oyun_Degiskenleri.puanO2 = Convert.ToInt32(lblPuan2.Text);
                Oyun_Degiskenleri.puanO3 = Convert.ToInt32(lblPuan3.Text);
                Oyun_Degiskenleri.puanO4 = Convert.ToInt32(lblPuan4.Text);
            }
            else if (Oyun_Degiskenleri.oynayanKisi == 5)
            {
                Oyun_Degiskenleri.puanO1 = Convert.ToInt32(lblPuan1.Text);
                Oyun_Degiskenleri.puanO2 = Convert.ToInt32(lblPuan2.Text);
                Oyun_Degiskenleri.puanO3 = Convert.ToInt32(lblPuan3.Text);
                Oyun_Degiskenleri.puanO4 = Convert.ToInt32(lblPuan4.Text);
                Oyun_Degiskenleri.puanO5 = Convert.ToInt32(lblPuan5.Text);
            }

            Oyun_Degiskenleri.sorulanSoruSayisi++;
            if (Oyun_Degiskenleri.sorulanSoruSayisi == 10)
            {
                Sonuc snc = new Sonuc();
                //this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                snc.Show();
                this.Hide();
            }
            else
            {
                Soru_Kelime siradaki = new Soru_Kelime();
                //this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                siradaki.Show();
                this.Hide();
            }
        }

        Klavye_Sayi klv = new Klavye_Sayi();
        private void lblSure_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblSure.Text) == 0)
            {
                Oyun_Degiskenleri.donenSayi1 = Convert.ToInt32(lblSayi1.Text);
                Oyun_Degiskenleri.donenSayi2 = Convert.ToInt32(lblSayi2.Text);
                Oyun_Degiskenleri.donenSayi3 = Convert.ToInt32(lblSayi3.Text);
                Oyun_Degiskenleri.donenSayi4 = Convert.ToInt32(lblSayi4.Text);
                Oyun_Degiskenleri.donenSayi5 = Convert.ToInt32(lblSayi5.Text);
                Oyun_Degiskenleri.donenCiftSayi = Convert.ToInt32(lblCiftSayi.Text);
                Oyun_Degiskenleri.donenIstenilen = Convert.ToInt32(lblIstenilen.Text);

                Cark();
                CevapYok_Islem cvp = new CevapYok_Islem();
                btnSonrakiSoru.Visible = true;
                Blur();
                cvp.ShowDialog();
                if (Oyun_Degiskenleri.soylenenCevap == "00")
                {
                    lblCevapDurumu.Visible = true;
                    lblCevapKontrol.Visible = true;
                    pbxBlur.Visible = false;
                    lblCevapKontrol.Text = "Cevap Yok";
                    lblCevapKontrol.BackColor = Color.White;
                }
                else
                {
                    tusBasma++;
                    KimCevapVerecek();
                    klv.ShowDialog();
                    puanKontrol();
                }
            }
        }

        int tusBasma = 0, puan = 0;
        bool o1 = false, o2 = false, o3 = false, o4 = false, o5 = false;
        private void Soru_Islem_KeyPress(object sender, KeyPressEventArgs e)
        {
            Oyun_Degiskenleri.donenSayi1 = Convert.ToInt32(lblSayi1.Text);
            Oyun_Degiskenleri.donenSayi2 = Convert.ToInt32(lblSayi2.Text);
            Oyun_Degiskenleri.donenSayi3 = Convert.ToInt32(lblSayi3.Text);
            Oyun_Degiskenleri.donenSayi4 = Convert.ToInt32(lblSayi4.Text);
            Oyun_Degiskenleri.donenSayi5 = Convert.ToInt32(lblSayi5.Text);
            Oyun_Degiskenleri.donenCiftSayi = Convert.ToInt32(lblCiftSayi.Text);
            Oyun_Degiskenleri.donenIstenilen = Convert.ToInt32(lblIstenilen.Text);

            Klavye_Sayi klv = new Klavye_Sayi();
            #region Yarışmacının butona basarak cevap vermesi
            if (lblSure.Visible == true)
            {
                if (tusBasma == 0)
                {
                    if (lblSure.Text != Convert.ToString(0))
                    {
                        e.Handled = false;
                        if (e.KeyChar == Oyun_Degiskenleri.kisayolO1)
                        {
                            sureİslem.Stop();
                            buton.Play();
                            pbxYanit.BackColor = Color.Aqua;
                            pbxYanit.Location = new Point(pbxOyuncu1.Location.X - 12, pbxOyuncu1.Location.Y - 24);
                            o1 = true;
                            timerSure.Stop();
                            Cark();
                            Blur();
                            tusBasma++;
                            klv.ShowDialog();
                            pbxYanit.BackColor = Color.Transparent;
                            puanKontrol();
                        }
                        else if (e.KeyChar == Oyun_Degiskenleri.kisayolO2)
                        {
                            sureİslem.Stop();
                            buton.Play();
                            pbxYanit.BackColor = Color.Aqua;
                            pbxYanit.Location = new Point(pbxOyuncu2.Location.X - 12, pbxOyuncu2.Location.Y - 24);
                            o2 = true;
                            timerSure.Stop();
                            Cark();
                            Blur();
                            tusBasma++;
                            klv.ShowDialog();
                            pbxYanit.BackColor = Color.Transparent;
                            puanKontrol();
                        }
                        else if (e.KeyChar == Oyun_Degiskenleri.kisayolO3)
                        {
                            sureİslem.Stop();
                            buton.Play();
                            pbxYanit.BackColor = Color.Aqua;
                            pbxYanit.Location = new Point(pbxOyuncu3.Location.X - 12, pbxOyuncu3.Location.Y - 24);
                            o3 = true;
                            timerSure.Stop();
                            Cark();
                            Blur();
                            tusBasma++;
                            klv.ShowDialog();
                            pbxYanit.BackColor = Color.Transparent;
                            puanKontrol();
                        }
                        else if (e.KeyChar == Oyun_Degiskenleri.kisayolO4)
                        {
                            sureİslem.Stop();
                            buton.Play();
                            pbxYanit.BackColor = Color.Aqua;
                            pbxYanit.Location = new Point(pbxOyuncu4.Location.X - 12, pbxOyuncu4.Location.Y - 24);
                            o4 = true;
                            timerSure.Stop();
                            Cark();
                            Blur();
                            tusBasma++;
                            klv.ShowDialog();
                            pbxYanit.BackColor = Color.Transparent;
                            puanKontrol();
                        }
                        else if (e.KeyChar == Oyun_Degiskenleri.kisayolO5)
                        {
                            sureİslem.Stop();
                            buton.Play();
                            pbxYanit.BackColor = Color.Aqua;
                            pbxYanit.Location = new Point(pbxOyuncu5.Location.X - 12, pbxOyuncu5.Location.Y - 24);
                            o5 = true;
                            timerSure.Stop();
                            Cark();
                            Blur();
                            tusBasma++;
                            klv.ShowDialog();
                            pbxYanit.BackColor = Color.Transparent;
                            puanKontrol();
                        }
                    }
                    else
                        e.Handled = true;
                }
                else
                    MessageBox.Show("Bir soruya bir kişi yalnızca bir kere cevap verebilir.\nLütfen sıradaki soruya geçiniz.");
            }
            else
                e.Handled = true;
            #endregion
        }

        private void Cark()
        {
            Bitmap carkPuanDur = new Bitmap(pbxPuan.Width, pbxPuan.Height);
            DrawToBitmap(carkPuanDur, new Rectangle(70, 70, pbxPuan.Width, pbxPuan.Height));
            pbxPuan.Image = carkPuanDur;

            Bitmap carkSureDur = new Bitmap(pbxSure.Image);
            DrawToBitmap(carkSureDur, new Rectangle(new Point(70, 510), new Size(pbxSure.Width, pbxSure.Height)));
            pbxSure.Image = carkSureDur;
        }

        private void KimCevapVerecek()
        {
            switch (Oyun_Degiskenleri.secilenKisi)
            {
                case "1":
                    o1 = true;
                    break;
                case "2":
                    o2 = true;
                    break;
                case "3":
                    o3 = true;
                    break;
                case "4":
                    o4 = true;
                    break;
                case "5":
                    o5 = true;
                    break;
            }
        }

        private void Blur()
        {
            Bitmap ekranYakala = new Bitmap(this.Width, this.Height);
            DrawToBitmap(ekranYakala, new Rectangle(0, 0, ekranYakala.Width, ekranYakala.Height));
            StackBlur.StackBlur.Process(ekranYakala, 10);
            pbxBlur.Dock = DockStyle.Fill;
            pbxBlur.Image = ekranYakala;
            pbxBlur.Visible = true;
        }

        public static int gecerliSure;
        private void puanKontrol()
        {
            lblCevapDurumu.Visible = true;
            lblCevapKontrol.Visible = true;
            lblCevapAciklama.Visible = true;
            pbxBlur.Visible = false;
            gecerliSure = Convert.ToInt32(lblSure.Text);
            if (Oyun_Degiskenleri.cevapDurum == -1)
            {
                lblCevapKontrol.Text = "Hatalı İşlem";
                lblCevapKontrol.BackColor = Color.Red;

                if (gecerliSure != 0)
                {
                    if (o1)
                    {
                        if (Oyun_Degiskenleri.oynayanKisi == 1)
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                        else if (Oyun_Degiskenleri.oynayanKisi == 2)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 3)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 4)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 5)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                    }
                    else if (o2)
                    {
                        if (Oyun_Degiskenleri.oynayanKisi == 2)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 3)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 4)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 5)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                    }
                    else if (o3)
                    {
                        if (Oyun_Degiskenleri.oynayanKisi == 3)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 4)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 5)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                    }
                    else if (o4)
                    {
                        if (Oyun_Degiskenleri.oynayanKisi == 4)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 5)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                    }
                    else if (o5)
                    {
                        if (Oyun_Degiskenleri.oynayanKisi == 5)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (Convert.ToInt32(lblPuan.Text) / 2));
                            lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) - (Convert.ToInt32(lblPuan.Text) / 2));
                        }
                    }
                }
                else if (gecerliSure == 0)
                {
                    if (Oyun_Degiskenleri.soylenenCevap == "0±0")
                    {
                        if (o1)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 1)
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                            else if (Oyun_Degiskenleri.oynayanKisi == 2)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 3)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                        }
                        else if (o2)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 2)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 3)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                        }
                        else if (o3)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 3)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                        }
                        else if (o4)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                        }
                        else if (o5)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text)) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) - ((Convert.ToInt32(lblPuan.Text)) / 2));
                            }
                        }
                    }
                    else if (Oyun_Degiskenleri.soylenenCevap == "1±1")
                    {
                        if (o1)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 1)
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            else if (Oyun_Degiskenleri.oynayanKisi == 2)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 3)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                        }
                        else if (o2)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 2)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 3)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                        }
                        else if (o3)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 3)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                        }
                        else if (o4)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                        }
                        else if (o5)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) - ((Convert.ToInt32(lblPuan.Text) - 10) / 2));
                            }
                        }
                    }
                    else if (Oyun_Degiskenleri.soylenenCevap == "2±2")
                    {
                        if (o1)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 1)
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            else if (Oyun_Degiskenleri.oynayanKisi == 2)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 3)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                        }
                        else if (o2)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 2)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 3)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                        }
                        else if (o3)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 3)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                        }
                        else if (o4)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                        }
                        else if (o5)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) - ((Convert.ToInt32(lblPuan.Text) - 20) / 2));
                            }
                        }
                    }
                    else if (Oyun_Degiskenleri.soylenenCevap == "3±3")
                    {
                        if (o1)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 1)
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            else if (Oyun_Degiskenleri.oynayanKisi == 2)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 3)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                        }
                        else if (o2)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 2)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 3)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                        }
                        else if (o3)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 3)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                        }
                        else if (o4)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 4)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                            else if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                        }
                        else if (o5)
                        {
                            if (Oyun_Degiskenleri.oynayanKisi == 5)
                            {
                                lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                                lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) - ((Convert.ToInt32(lblPuan.Text) - 30) / 2));
                            }
                        }
                    }
                }
            }
            else if (Oyun_Degiskenleri.cevapDurum == 0)
            {
                lblCevapKontrol.Text = "İşlem Doğru";
                lblCevapKontrol.BackColor = Color.Lime;

                if (gecerliSure != 0 || gecerliSure == 0)     //Tam sonuç, Süre bitmemiş
                {
                    if (o1)
                        lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + Convert.ToInt32(lblPuan.Text));
                    else if (o2)
                        lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + Convert.ToInt32(lblPuan.Text));
                    else if (o3)
                        lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + Convert.ToInt32(lblPuan.Text));
                    else if (o4)
                        lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + Convert.ToInt32(lblPuan.Text));
                    else if (o5)
                        lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + Convert.ToInt32(lblPuan.Text));
                }
            }
            else if (Oyun_Degiskenleri.cevapDurum == 1)
            {
                lblCevapKontrol.Text = "İşlem Doğru";
                lblCevapKontrol.BackColor = Color.Lime;

                if (gecerliSure == 0)      //1 yaklaşık, Süre bitmiş
                {
                    if (o1)
                        lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + Convert.ToInt32(lblPuan.Text) - 10);
                    else if (o2)
                        lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + Convert.ToInt32(lblPuan.Text) - 10);
                    else if (o3)
                        lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + Convert.ToInt32(lblPuan.Text) - 10);
                    else if (o4)
                        lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + Convert.ToInt32(lblPuan.Text) - 10);
                    else if (o5)
                        lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + Convert.ToInt32(lblPuan.Text) - 10);
                }
            }
            else if (Oyun_Degiskenleri.cevapDurum == 2)
            {
                lblCevapKontrol.Text = "İşlem Doğru";
                lblCevapKontrol.BackColor = Color.Lime;

                if (gecerliSure == 0)
                {
                    if (o1)
                        lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + Convert.ToInt32(lblPuan.Text) - 20);
                    else if (o2)
                        lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + Convert.ToInt32(lblPuan.Text) - 20);
                    else if (o3)
                        lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + Convert.ToInt32(lblPuan.Text) - 20);
                    else if (o4)
                        lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + Convert.ToInt32(lblPuan.Text) - 20);
                    else if (o5)
                        lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + Convert.ToInt32(lblPuan.Text) - 20);
                }
            }
            else if (Oyun_Degiskenleri.cevapDurum == 3)
            {
                lblCevapKontrol.Text = "İşlem Doğru";
                lblCevapKontrol.BackColor = Color.Lime;

                if (gecerliSure == 0)
                {
                    if (o1)
                        lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + Convert.ToInt32(lblPuan.Text) - 30);
                    else if (o2)
                        lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + Convert.ToInt32(lblPuan.Text) - 30);
                    else if (o3)
                        lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + Convert.ToInt32(lblPuan.Text) - 30);
                    else if (o4)
                        lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + Convert.ToInt32(lblPuan.Text) - 30);
                    else if (o5)
                        lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + Convert.ToInt32(lblPuan.Text) - 30);
                }
            }
            btnSonrakiSoru.Visible = true;
        }

        int saniye = -1;
        int sayacPuan = 72;
        int sayacSure = 46;
        private void timerSure_Tick(object sender, EventArgs e)
        {
            if(sayacSure==46)
                sureİslem.Play();
            if (sayacSure != 0)
            {
                sayacSure--;
                saniye++;
                lblSure.Text = Convert.ToString(sayacSure);
                lblPuan.Text = Convert.ToString(sayacPuan);
                if (saniye == 5)
                {
                    sayacPuan = sayacPuan - 4;
                    saniye = 0;
                }
            }
            if (sayacSure == 0)
            {
                sureİslem.Stop();
                timerSure.Stop();
            }
        }
    }
}
