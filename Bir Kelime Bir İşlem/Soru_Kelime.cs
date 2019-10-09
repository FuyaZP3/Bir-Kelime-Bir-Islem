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
using System.Xml;


namespace Bir_Kelime_Bir_İşlem
{
    public partial class Soru_Kelime : Form
    {
        public Soru_Kelime()
        {
            InitializeComponent();
        }

        SoundPlayer harfDonme = new SoundPlayer(Application.StartupPath + "\\Harf_Sesi.wav");
        SoundPlayer buton = new SoundPlayer(Application.StartupPath + "\\Ses_SoruCevap.wav");
        SoundPlayer harfOkuma = new SoundPlayer();
        SoundPlayer sureKelime = new SoundPlayer(Application.StartupPath + "\\Ses_SoruKelime.wav");
        public void Soru_Kelime_Load(object sender, EventArgs e)
        {
            
            #region Alinan Kişiler
            if (Oyun_Degiskenleri.oynayanKisi == 1)
            {
                pbxOyuncu1.Location = new Point(587, 446);
                lblOyuncu1.Location = new Point(583, 601);
                lblPuan1.Location = new Point(583, 634);

                pbxOyuncu1.Visible = true;
                lblOyuncu1.Visible = true;
                lblPuan1.Visible = true;

                pbxOyuncu1.Image = imageList1.Images[Oyun_Degiskenleri.resimIndex1];

                lblOyuncu1.Text = Oyun_Degiskenleri.isimO1;

                lblPuan1.Text = Oyun_Degiskenleri.puanO1.ToString();
            }
            else if (Oyun_Degiskenleri.oynayanKisi == 2)
            {
                pbxOyuncu1.Location = new Point(487, 446);
                lblOyuncu1.Location = new Point(483, 601);
                lblPuan1.Location = new Point(483, 634);
                pbxOyuncu2.Location = new Point(687, 446);
                lblOyuncu2.Location = new Point(683, 601);
                lblPuan2.Location = new Point(683, 634);

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
                pbxOyuncu1.Location = new Point(387, 446);
                lblOyuncu1.Location = new Point(383, 601);
                lblPuan1.Location = new Point(383, 634);
                pbxOyuncu2.Location = new Point(587, 446);
                lblOyuncu2.Location = new Point(583, 601);
                lblPuan2.Location = new Point(583, 634);
                pbxOyuncu3.Location = new Point(787, 446);
                lblOyuncu3.Location = new Point(783, 601);
                lblPuan3.Location = new Point(783, 634);

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
                pbxOyuncu1.Location = new Point(287, 446);
                lblOyuncu1.Location = new Point(283, 601);
                lblPuan1.Location = new Point(283, 634);
                pbxOyuncu2.Location = new Point(487, 446);
                lblOyuncu2.Location = new Point(483, 601);
                lblPuan2.Location = new Point(483, 634);
                pbxOyuncu3.Location = new Point(687, 446);
                lblOyuncu3.Location = new Point(683, 601);
                lblPuan3.Location = new Point(683, 634);
                pbxOyuncu4.Location = new Point(887, 446);
                lblOyuncu4.Location = new Point(883, 601);
                lblPuan4.Location = new Point(883, 634);

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
            else if (Oyun_Degiskenleri.oynayanKisi == 5)
            {
                pbxOyuncu1.Location = new Point(187, 446);
                lblOyuncu1.Location = new Point(183, 601);
                lblPuan1.Location = new Point(183, 634);
                pbxOyuncu2.Location = new Point(387, 446);
                lblOyuncu2.Location = new Point(383, 601);
                lblPuan2.Location = new Point(383, 634);
                pbxOyuncu3.Location = new Point(587, 446);
                lblOyuncu3.Location = new Point(583, 601);
                lblPuan3.Location = new Point(583, 634);
                pbxOyuncu4.Location = new Point(787, 446);
                lblOyuncu4.Location = new Point(783, 601);
                lblPuan4.Location = new Point(783, 634);
                pbxOyuncu5.Location = new Point(987, 446);
                lblOyuncu5.Location = new Point(983, 601);
                lblPuan5.Location = new Point(983, 634);

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
            lblSure.Parent = pbxSure;
            lblPuan.BackColor = Color.Transparent;
            lblSure.BackColor = Color.Transparent;

            XmlDataDocument xmlData = new XmlDataDocument();
            xmlData.DataSet.ReadXml(Application.StartupPath + "\\KelimeSozluk.xml");

            dataGridView1.DataSource = xmlData.DataSet;
            dataGridView1.DataMember = "Kelime_Verileri";

            timer1.Start();
            timer1.Enabled = true;
            lblHarf1.Visible = true;
            harfDonme.Play();
        }

        private void okuHarf(char harf)
        {
            #region Harflerin Seslendirmesi
            switch (harf)
            {
                case 'A':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_A.wav";
                    harfOkuma.Play();
                    break;
                case 'B':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_B.wav";
                    harfOkuma.Play();
                    break;
                case 'C':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_C.wav";
                    harfOkuma.Play();
                    break;
                case 'Ç':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_Ç.wav";
                    harfOkuma.Play();
                    break;
                case 'D':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_D.wav";
                    harfOkuma.Play();
                    break;
                case 'E':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_E.wav";
                    harfOkuma.Play();
                    break;
                case 'F':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_F.wav";
                    harfOkuma.Play();
                    break;
                case 'G':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_G.wav";
                    harfOkuma.Play();
                    break;
                case 'Ğ':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_Ğ.wav";
                    harfOkuma.Play();
                    break;
                case 'H':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_H.wav";
                    harfOkuma.Play();
                    break;
                case 'I':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_I.wav";
                    harfOkuma.Play();
                    break;
                case 'İ':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_İ.wav";
                    harfOkuma.Play();
                    break;
                case 'J':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_J.wav";
                    harfOkuma.Play();
                    break;
                case 'K':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_K.wav";
                    harfOkuma.Play();
                    break;
                case 'L':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_L.wav";
                    harfOkuma.Play();
                    break;
                case 'M':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_M.wav";
                    harfOkuma.Play();
                    break;
                case 'N':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_N.wav";
                    harfOkuma.Play();
                    break;
                case 'O':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_O.wav";
                    harfOkuma.Play();
                    break;
                case 'Ö':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_Ö.wav";
                    harfOkuma.Play();
                    break;
                case 'P':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_P.wav";
                    harfOkuma.Play();
                    break;
                case 'R':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_R.wav";
                    harfOkuma.Play();
                    break;
                case 'S':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_S.wav";
                    harfOkuma.Play();
                    break;
                case 'Ş':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_Ş.wav";
                    harfOkuma.Play();
                    break;
                case 'T':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_T.wav";
                    harfOkuma.Play();
                    break;
                case 'U':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_U.wav";
                    harfOkuma.Play();
                    break;
                case 'Ü':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_Ü.wav";
                    harfOkuma.Play();
                    break;
                case 'V':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_V.wav";
                    harfOkuma.Play();
                    break;
                case 'Y':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_Y.wav";
                    harfOkuma.Play();
                    break;
                case 'Z':
                    harfOkuma.SoundLocation = Application.StartupPath + "\\Harf_Z.wav";
                    harfOkuma.Play();
                    break;
            }
            #endregion
        }

        #region Harflerin Dönmesi
        int sayac1 = 0, sayac2 = 0, sayac3 = 0, sayac4 = 0, sayac5 = 0, sayac6 = 0, sayac7 = 0, sayac8 = 0;
        string sesliler = "AEIİOÖUÜ";
        string sessizler = "BCÇDFGĞHJKLMNPRSŞTVYZ";
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHarf1.Text = sesliler[rnd.Next(1, 8)].ToString();
            sayac1++;
            if (sayac1 == 6)
            {
                timer1.Stop();
                okuHarf(Convert.ToChar(lblHarf1.Text));
                timerBekleme1.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblHarf2.Text = sessizler[rnd.Next(1, 21)].ToString();
            sayac2++;
            if (sayac2 == 6)
            {
                timer2.Stop();
                okuHarf(Convert.ToChar(lblHarf2.Text));
                timerBekleme2.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblHarf3.Text = sessizler[rnd.Next(1, 21)].ToString();
            sayac3++;
            if (sayac3 == 6)
            {
                timer3.Stop();
                okuHarf(Convert.ToChar(lblHarf3.Text));
                timerBekleme3.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            lblHarf4.Text = sesliler[rnd.Next(1, 8)].ToString();
            sayac4++;
            if (sayac4 == 6)
            {
                timer4.Stop();
                okuHarf(Convert.ToChar(lblHarf4.Text));
                timerBekleme4.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            lblHarf5.Text = sessizler[rnd.Next(1, 21)].ToString();
            sayac5++;
            if (sayac5 == 6)
            {
                timer5.Stop();
                okuHarf(Convert.ToChar(lblHarf5.Text));
                timerBekleme5.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            lblHarf6.Text = sesliler[rnd.Next(1, 8)].ToString();
            sayac6++;
            if (sayac6 == 6)
            {
                timer6.Stop();
                okuHarf(Convert.ToChar(lblHarf6.Text));
                timerBekleme6.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            lblHarf7.Text = sesliler[rnd.Next(1, 8)].ToString();
            sayac7++;
            if (sayac7 == 6)
            {
                timer7.Stop();
                okuHarf(Convert.ToChar(lblHarf7.Text));
                timerBekleme7.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            lblHarf8.Text = sessizler[rnd.Next(1, 21)].ToString();
            sayac8++;
            if (sayac8 == 6)
            {
                timer8.Stop();
                okuHarf(Convert.ToChar(lblHarf8.Text));
                timerBekleme8.Start();
            }
        }
        #endregion

        int tusBasma = 0;
        bool o1 = false;
        bool o2 = false;
        bool o3 = false;
        bool o4 = false;
        bool o5 = false;
        Klavye klv = new Klavye();
        private void Soru_Kelime_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Yarışmacı cevap için butona basar
            if (lblSure.Visible == true)
            {
                if (tusBasma == 0)
                {
                    if (lblSure.Text != Convert.ToString(0))
                    {
                        e.Handled = false;
                        if (e.KeyChar == Oyun_Degiskenleri.kisayolO1)
                        {
                            sureKelime.Stop();
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
                            Kontrol();
                            puanKontrol();
                        }
                        else if (e.KeyChar == Oyun_Degiskenleri.kisayolO2)
                        {
                            sureKelime.Stop();
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
                            Kontrol();
                            puanKontrol();
                        }
                        else if (e.KeyChar == Oyun_Degiskenleri.kisayolO3)
                        {
                            sureKelime.Stop();
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
                            Kontrol();
                            puanKontrol();
                        }
                        else if (e.KeyChar == Oyun_Degiskenleri.kisayolO4)
                        {
                            sureKelime.Stop();
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
                            Kontrol();
                            puanKontrol();
                        }
                        else if (e.KeyChar == Oyun_Degiskenleri.kisayolO5)
                        {
                            sureKelime.Stop();
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
                            Kontrol();
                            puanKontrol();
                        }
                    }
                    else
                        e.Handled = true;
                }
                else
                    MessageBox.Show("Bir soruya bir kişi yalnızca bir kere cevap verebilir. Lütfen sıradaki soruya geçiniz.");
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
            DrawToBitmap(carkSureDur, new Rectangle(new Point(1120, 70), new Size(pbxSure.Width, pbxSure.Height)));
            pbxSure.Image = carkSureDur;
        }
        
        private void harfleriAtama()
        {
            for (int i = 0; i < cevapHarfleri.Length; i++)
                lstKullaniciHarfleri.Items.Add(cevapHarfleri[i]);

            lstEkranHarfleri.Items.Add(lblHarf1.Text);
            lstEkranHarfleri.Items.Add(lblHarf2.Text);
            lstEkranHarfleri.Items.Add(lblHarf3.Text);
            lstEkranHarfleri.Items.Add(lblHarf4.Text);
            lstEkranHarfleri.Items.Add(lblHarf5.Text);
            lstEkranHarfleri.Items.Add(lblHarf6.Text);
            lstEkranHarfleri.Items.Add(lblHarf7.Text);
            lstEkranHarfleri.Items.Add(lblHarf8.Text);
        }

        private void veriTabaniKontrol()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    if (searchValue == dataGridView1.Rows[i].Cells[0].Value.ToString().Trim())
                    {
                        lblCevapKontrol.Text = "Cevap Doğru";
                        lblCevapKontrol.BackColor = Color.Lime;
                        MessageBox.Show("Kelime : " + dataGridView1.Rows[i].Cells[0].Value.ToString().Trim()
                                    + "\nKökeni : " + dataGridView1.Rows[i].Cells[1].Value.ToString().Trim()
                                    + "\nAnlamı : " + dataGridView1.Rows[i].Cells[2].Value.ToString().Trim());
                        dur++;
                    }
                }
                catch
                {

                }
            }
            if (dur != 1)
            {
                dur = -1;
                lblCevapKontrol.Text = "Cevap Yanlış";
                lblCevapKontrol.BackColor = Color.Red;
                lblCevapAciklama.Text = "Kelime veritabanında bulunamadı!";
                lblCevapAciklama.BackColor = Color.Red;
            }
        }


        int dur = 0;
        string[] cevapHarfleri;
        string searchValue;
        private void Kontrol()
        {
            lblCevapDurumu.Visible = true;
            lblCevapKontrol.Visible = true;
            lblCevapAciklama.Visible = true;

            searchValue = Oyun_Degiskenleri.arananKelime;
            cevapHarfleri = Oyun_Degiskenleri.cevapKontrolHarfleri.Trim().Split(' ');
            bool silindimi;
            int k = 0, silinen = 0;
            harfleriAtama();
            int uzunluk = lstKullaniciHarfleri.Items.Count;
            
            if (lblSure.Text != Convert.ToString(0))
            {
                if (searchValue.Length > 6)
                {
                    while (lstKullaniciHarfleri.Items.Count > -1)
                    {
                        silindimi = false;
                        for (int i = 0; i < lstEkranHarfleri.Items.Count; i++)
                        {
                            if (lstKullaniciHarfleri.Items[k].ToString() == lstEkranHarfleri.Items[i].ToString())
                            {
                                lstKullaniciHarfleri.Items.RemoveAt(k);
                                lstEkranHarfleri.Items.RemoveAt(i);
                                silinen++;
                                silindimi = true;
                                break;
                            }
                        }
                        if (silindimi == false)
                            k++;
                        if (uzunluk == k + silinen)
                            break;
                    }
                    if (lstKullaniciHarfleri.Items.Count < 2)
                    {
                        veriTabaniKontrol();
                    }
                    else
                    {
                        pbxBlur.Visible = false;
                        dur = -1;
                        lblCevapKontrol.Text = "Cevap Yanlış";
                        lblCevapKontrol.BackColor = Color.Red;
                        lblCevapAciklama.Text = "Birden fazla joker harf kullandınız!";
                        lblCevapAciklama.BackColor = Color.Red;
                    }
                }
                else
                {
                    pbxBlur.Visible = false;
                    dur = -1;
                    lblCevapKontrol.Text = "Cevap Yanlış";
                    lblCevapKontrol.BackColor = Color.Red;
                    lblCevapAciklama.Text = "Süre bitmeden önce basmanız durumunda cevabınızın en az 7 harfli olması gerekir!"; ;
                    lblCevapAciklama.BackColor = Color.Red;
                }
            }
            else
            {
                if (Oyun_Degiskenleri.soylenenCevap == "00")
                {
                    pbxBlur.Visible = false;
                    lblCevapKontrol.Text = "Cevap Yok";
                    lblCevapKontrol.BackColor = Color.White;
                }
                else
                {
                    while (lstKullaniciHarfleri.Items.Count > -1)
                    {
                        silindimi = false;
                        for (int i = 0; i < lstEkranHarfleri.Items.Count; i++)
                        {
                            if (lstKullaniciHarfleri.Items[k].ToString() == lstEkranHarfleri.Items[i].ToString())
                            {
                                lstKullaniciHarfleri.Items.RemoveAt(k);
                                lstEkranHarfleri.Items.RemoveAt(i);
                                silinen++;
                                silindimi = true;
                                break;
                            }
                        }
                        if (silindimi == false)
                            k++;
                        if (uzunluk == k + silinen)
                            break;
                    }

                    KimCevapVerecek();

                    switch (Oyun_Degiskenleri.soylenenCevap.ToString())
                    {
                        case "51":
                            if (searchValue.Length == 5 && lstKullaniciHarfleri.Items.Count == 1)
                                veriTabaniKontrol();
                            else
                            {
                                pbxBlur.Visible = false;
                                dur = -1;
                                lblCevapKontrol.Text = "Cevap Yanlış";
                                lblCevapKontrol.BackColor = Color.Red;
                                lblCevapAciklama.Text = "Verdiğiniz cevap ile söylediğiniz cevap türü uyuşmamaktadır!";
                                lblCevapAciklama.BackColor = Color.Red;
                            }
                            break;
                        case "50":
                            if (searchValue.Length == 5 && lstKullaniciHarfleri.Items.Count == 0)
                                veriTabaniKontrol();
                            else
                            {
                                pbxBlur.Visible = false;
                                dur = -1;
                                lblCevapKontrol.Text = "Cevap Yanlış";
                                lblCevapKontrol.BackColor = Color.Red;
                                lblCevapAciklama.Text = "Verdiğiniz cevap ile söylediğiniz cevap türü uyuşmamaktadır!";
                                lblCevapAciklama.BackColor = Color.Red;
                            }
                            break;
                        case "61":
                            if (searchValue.Length == 6 && lstKullaniciHarfleri.Items.Count == 1)
                                veriTabaniKontrol();
                            else
                            {
                                pbxBlur.Visible = false;
                                dur = -1;
                                lblCevapKontrol.Text = "Cevap Yanlış";
                                lblCevapKontrol.BackColor = Color.Red;
                                lblCevapAciklama.Text = "Verdiğiniz cevap ile söylediğiniz cevap türü uyuşmamaktadır!";
                                lblCevapAciklama.BackColor = Color.Red;
                            }
                            break;
                        case "60":
                            if (searchValue.Length == 6 && lstKullaniciHarfleri.Items.Count == 0)
                                veriTabaniKontrol();
                            else
                            {
                                pbxBlur.Visible = false;
                                dur = -1;
                                lblCevapKontrol.Text = "Cevap Yanlış";
                                lblCevapKontrol.BackColor = Color.Red;
                                lblCevapAciklama.Text = "Verdiğiniz cevap ile söylediğiniz cevap türü uyuşmamaktadır!";
                                lblCevapAciklama.BackColor = Color.Red;
                            }
                            break;
                        case "71":
                            if (searchValue.Length == 7 && lstKullaniciHarfleri.Items.Count == 1)
                                veriTabaniKontrol();
                            else
                            {
                                pbxBlur.Visible = false;
                                dur = -1;
                                lblCevapKontrol.Text = "Cevap Yanlış";
                                lblCevapKontrol.BackColor = Color.Red;
                                lblCevapAciklama.Text = "Verdiğiniz cevap ile söylediğiniz cevap türü uyuşmamaktadır!";
                                lblCevapAciklama.BackColor = Color.Red;
                            }
                            break;
                        case "70":
                            if (searchValue.Length == 7 && lstKullaniciHarfleri.Items.Count == 0)
                                veriTabaniKontrol();
                            else
                            {
                                pbxBlur.Visible = false;
                                dur = -1;
                                lblCevapKontrol.Text = "Cevap Yanlış";
                                lblCevapKontrol.BackColor = Color.Red;
                                lblCevapAciklama.Text = "Verdiğiniz cevap ile söylediğiniz cevap türü uyuşmamaktadır!";
                                lblCevapAciklama.BackColor = Color.Red;
                            }
                            break;
                        case "81":
                            if (searchValue.Length == 8 && lstKullaniciHarfleri.Items.Count == 1)
                                veriTabaniKontrol();
                            else
                            {
                                pbxBlur.Visible = false;
                                dur = -1;
                                lblCevapKontrol.Text = "Cevap Yanlış";
                                lblCevapKontrol.BackColor = Color.Red;
                                lblCevapAciklama.Text = "Verdiğiniz cevap ile söylediğiniz cevap türü uyuşmamaktadır!";
                                lblCevapAciklama.BackColor = Color.Red;
                            }
                            break;
                        case "80":
                            if (searchValue.Length == 8 && lstKullaniciHarfleri.Items.Count == 0)
                                veriTabaniKontrol();
                            else
                            {
                                pbxBlur.Visible = false;
                                dur = -1;
                                lblCevapKontrol.Text = "Cevap Yanlış";
                                lblCevapKontrol.BackColor = Color.Red;
                                lblCevapAciklama.Text = "Verdiğiniz cevap ile söylediğiniz cevap türü uyuşmamaktadır!";
                                lblCevapAciklama.BackColor = Color.Red;
                            }
                            break;
                        case "91":
                            if (searchValue.Length == 9 && lstKullaniciHarfleri.Items.Count == 1)
                                veriTabaniKontrol();
                            else
                            {
                                pbxBlur.Visible = false;
                                dur = -1;
                                lblCevapKontrol.Text = "Cevap Yanlış";
                                lblCevapKontrol.BackColor = Color.Red;
                                lblCevapAciklama.Text = "Verdiğiniz cevap ile söylediğiniz cevap türü uyuşmamaktadır!";
                                lblCevapAciklama.BackColor = Color.Red;
                            }
                            break;
                        case "90":
                            if (searchValue.Length == 9 && lstKullaniciHarfleri.Items.Count == 0)
                                veriTabaniKontrol();
                            else
                            {
                                pbxBlur.Visible = false;
                                dur = -1;
                                lblCevapKontrol.Text = "Cevap Yanlış";
                                lblCevapKontrol.BackColor = Color.Red;
                                lblCevapAciklama.Text = "Verdiğiniz cevap ile söylediğiniz cevap türü uyuşmamaktadır!";
                                lblCevapAciklama.BackColor = Color.Red;
                            }
                            break;
                    }
                }
            }
            tusBasma++;
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
                Soru_Islem siradaki = new Soru_Islem();
                //this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                siradaki.Show();
                this.Hide();
            }
        }

        private void lblSure_TextChanged(object sender, EventArgs e)
        {
            if (lblSure.Text == Convert.ToString(0))
            {
                Cark();
                CevapYok_Kelime cvp = new CevapYok_Kelime();
                btnSonrakiSoru.Visible = true;
                Blur();
                cvp.ShowDialog();
                if (Oyun_Degiskenleri.soylenenCevap == "00")
                {
                    pbxBlur.Visible = false;
                    lblCevapDurumu.Visible = true;
                    lblCevapKontrol.Visible = true;
                    lblCevapKontrol.Text = "Cevap Yok";
                    lblCevapKontrol.BackColor = Color.White;
                }
                else
                {

                    klv.ShowDialog();
                    pbxBlur.Visible = false;
                    Kontrol();
                    puanKontrol();
                }
            }
        }

        #region harflerin beklemesi
        int bekleme1 = 0, bekleme2 = 0, bekleme3 = 0, bekleme4 = 0, bekleme5 = 0, bekleme6 = 0, bekleme7 = 0, bekleme8 = 0;

        private void timerBekleme1_Tick(object sender, EventArgs e)
        {
            bekleme1++;
            if (bekleme1 == 1)
            {
                timerBekleme1.Stop();
                timer2.Start();
                timer2.Enabled = true;
                lblHarf2.Visible = true;
                harfDonme.Play();
            }
        }

        private void timerBekleme2_Tick(object sender, EventArgs e)
        {
            bekleme2++;
            if (bekleme2 == 1)
            {
                timerBekleme2.Stop();
                timer3.Start();
                timer3.Enabled = true;
                lblHarf3.Visible = true;
                harfDonme.Play();
            }
        }

        private void timerBekleme3_Tick(object sender, EventArgs e)
        {
            bekleme3++;
            if (bekleme3 == 1)
            {
                timerBekleme3.Stop();
                timer4.Start();
                timer4.Enabled = true;
                lblHarf4.Visible = true;
                harfDonme.Play();
            }
        }

        private void timerBekleme4_Tick(object sender, EventArgs e)
        {
            bekleme4++;
            if (bekleme4 == 1)
            {
                timerBekleme4.Stop();
                timer5.Start();
                timer5.Enabled = true;
                lblHarf5.Visible = true;
                harfDonme.Play();
            }
        }

        private void timerBekleme5_Tick(object sender, EventArgs e)
        {
            bekleme5++;
            if (bekleme5 == 1)
            {
                timerBekleme5.Stop();
                timer6.Start();
                timer6.Enabled = true;
                lblHarf6.Visible = true;
                harfDonme.Play();
            }
        }

        private void timerBekleme6_Tick(object sender, EventArgs e)
        {
            bekleme6++;
            if (bekleme6 == 1)
            {
                timerBekleme6.Stop();
                timer7.Start();
                timer7.Enabled = true;
                lblHarf7.Visible = true;
                harfDonme.Play();
            }
        }

        private void timerBekleme7_Tick(object sender, EventArgs e)
        {
            bekleme7++;
            if (bekleme7 == 1)
            {
                timerBekleme7.Stop();
                timer8.Start();
                timer8.Enabled = true;
                lblHarf8.Visible = true;
                harfDonme.Play();
            }
        }

        private void timerBekleme8_Tick(object sender, EventArgs e)
        {
            bekleme8++;
            if (bekleme8 == 1)
            {
                timerBekleme8.Stop();
                axWindowsMediaPlayer1.URL = Application.StartupPath + "/Joker_Hakkımız.wav";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pbxSoruIsareti.Visible = true;
                pbxPuan.Visible = true;
                pbxSure.Visible = true;
                lblPuan.Visible = true;
                lblSure.Visible = true;
                timerSure.Enabled = true;
            }
        }
        #endregion

        int gecerliSure;
        private void puanKontrol()
        {
            gecerliSure = Convert.ToInt32(lblSure.Text);
            #region Cevap için Puan Kontrolü
            if (dur == 1)
            {
                if (gecerliSure == 0)
                {
                    //Doğru Cevap, Süre Bitmiş
                    if (o1)
                        lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + ((Oyun_Degiskenleri.arananKelime.Length * 5) - 5));
                    else if (o2)
                        lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + ((Oyun_Degiskenleri.arananKelime.Length * 5) - 5));
                    else if (o3)
                        lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + ((Oyun_Degiskenleri.arananKelime.Length * 5) - 5));
                    else if (o4)
                        lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + ((Oyun_Degiskenleri.arananKelime.Length * 5) - 5));
                    else if (o5)
                        lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + ((Oyun_Degiskenleri.arananKelime.Length * 5) - 5));
                }
                else if (gecerliSure != 0)
                {
                    //Doğru Cevap, Süre Bitmemiş
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
            else if (dur == -1)
            {
                if (gecerliSure == 0)
                {
                    //Yanlış Cevap, Süre Bitmiş
                    if (o1)
                    {
                        if (Oyun_Degiskenleri.oynayanKisi == 1)
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        else if (Oyun_Degiskenleri.oynayanKisi == 2)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 3)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 4)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 5)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                    }
                    else if (o2)
                    {
                        if (Oyun_Degiskenleri.oynayanKisi == 2)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi== 3)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 4)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 5)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                    }
                    else if (o3)
                    {
                        if (Oyun_Degiskenleri.oynayanKisi == 3)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 4)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 5)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                    }
                    else if (o4)
                    {
                        if (Oyun_Degiskenleri.oynayanKisi == 4)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                        else if (Oyun_Degiskenleri.oynayanKisi == 5)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                    }
                    else if (o5)
                    {
                        if (Oyun_Degiskenleri.oynayanKisi == 5)
                        {
                            lblPuan1.Text = Convert.ToString(Convert.ToInt32(lblPuan1.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan2.Text = Convert.ToString(Convert.ToInt32(lblPuan2.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan3.Text = Convert.ToString(Convert.ToInt32(lblPuan3.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan4.Text = Convert.ToString(Convert.ToInt32(lblPuan4.Text) + (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                            lblPuan5.Text = Convert.ToString(Convert.ToInt32(lblPuan5.Text) - (((Oyun_Degiskenleri.arananKelime.Length * 5) - 5) / 2));
                        }
                    }
                }
            
                else if (gecerliSure != 0)
                {
                    //Yanlış Cevap, Süre Bitmemiş
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
            }
            #endregion
            btnSonrakiSoru.Visible = true;
        }


        int saniye = -1;
        int sayacSure = 48;
        int sayacPuan = 72;
        private void timerSure_Tick(object sender, EventArgs e)
        {
            if (sayacSure == 46)
                sureKelime.Play();
            if (sayacSure != 0)
            {
                if (sayacSure <= 46)
                {
                    sayacSure--;
                    saniye++;
                    lblSure.Text = sayacSure.ToString();
                    lblPuan.Text = sayacPuan.ToString();

                    if (saniye == 5)
                    {
                        sayacPuan = sayacPuan - 4;
                        saniye = 0;
                    }
                }
                else
                    sayacSure--;
            }
            if (sayacSure == 0)
            {
                sureKelime.Stop();
                timerSure.Stop();
            }
        }
    }
}
