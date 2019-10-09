namespace Bir_Kelime_Bir_İşlem
{
    partial class CevapYok_Kelime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CevapYok_Kelime));
            this.btnOnayla = new System.Windows.Forms.Button();
            this.clbAyrik = new System.Windows.Forms.CheckedListBox();
            this.gbxAyrikCevap = new System.Windows.Forms.GroupBox();
            this.rdbO5 = new System.Windows.Forms.RadioButton();
            this.rdbO4 = new System.Windows.Forms.RadioButton();
            this.rdbO3 = new System.Windows.Forms.RadioButton();
            this.rdbO2 = new System.Windows.Forms.RadioButton();
            this.rdbO1 = new System.Windows.Forms.RadioButton();
            this.gbxEsitCevap = new System.Windows.Forms.GroupBox();
            this.lblAynilar = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.clbEsit = new System.Windows.Forms.CheckedListBox();
            this.rdbAyrikCevap = new System.Windows.Forms.RadioButton();
            this.rdbEsitCevap = new System.Windows.Forms.RadioButton();
            this.rdbYanitYok = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbxAyrikCevap.SuspendLayout();
            this.gbxEsitCevap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.Lime;
            this.btnOnayla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnayla.BackgroundImage")));
            this.btnOnayla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnayla.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOnayla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOnayla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Exo 2.0 Semi Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnayla.Location = new System.Drawing.Point(551, 538);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(97, 50);
            this.btnOnayla.TabIndex = 34;
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Visible = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // clbAyrik
            // 
            this.clbAyrik.BackColor = System.Drawing.Color.Aqua;
            this.clbAyrik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbAyrik.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clbAyrik.FormattingEnabled = true;
            this.clbAyrik.Items.AddRange(new object[] {
            "5 Harfli Jokerli",
            "5 Harfli Jokersiz",
            "6 Harfli Jokerli",
            "6 Harfli Jokersiz",
            "7 Harfli Jokerli",
            "7 Harfli Jokersiz",
            "8 Harfli Jokerli",
            "8 Harfli Jokersiz",
            "9 Harfli Jokerli",
            "9 Harfli Jokersiz"});
            this.clbAyrik.Location = new System.Drawing.Point(25, 21);
            this.clbAyrik.Name = "clbAyrik";
            this.clbAyrik.Size = new System.Drawing.Size(188, 240);
            this.clbAyrik.TabIndex = 38;
            // 
            // gbxAyrikCevap
            // 
            this.gbxAyrikCevap.Controls.Add(this.rdbO5);
            this.gbxAyrikCevap.Controls.Add(this.rdbO4);
            this.gbxAyrikCevap.Controls.Add(this.rdbO3);
            this.gbxAyrikCevap.Controls.Add(this.rdbO2);
            this.gbxAyrikCevap.Controls.Add(this.rdbO1);
            this.gbxAyrikCevap.Controls.Add(this.clbAyrik);
            this.gbxAyrikCevap.Enabled = false;
            this.gbxAyrikCevap.Location = new System.Drawing.Point(12, 72);
            this.gbxAyrikCevap.Name = "gbxAyrikCevap";
            this.gbxAyrikCevap.Size = new System.Drawing.Size(211, 441);
            this.gbxAyrikCevap.TabIndex = 39;
            this.gbxAyrikCevap.TabStop = false;
            // 
            // rdbO5
            // 
            this.rdbO5.AutoSize = true;
            this.rdbO5.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbO5.Location = new System.Drawing.Point(25, 401);
            this.rdbO5.Name = "rdbO5";
            this.rdbO5.Size = new System.Drawing.Size(109, 24);
            this.rdbO5.TabIndex = 43;
            this.rdbO5.Text = "5. Oyuncu";
            this.rdbO5.UseVisualStyleBackColor = true;
            // 
            // rdbO4
            // 
            this.rdbO4.AutoSize = true;
            this.rdbO4.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbO4.Location = new System.Drawing.Point(25, 371);
            this.rdbO4.Name = "rdbO4";
            this.rdbO4.Size = new System.Drawing.Size(110, 24);
            this.rdbO4.TabIndex = 42;
            this.rdbO4.Text = "4. Oyuncu";
            this.rdbO4.UseVisualStyleBackColor = true;
            // 
            // rdbO3
            // 
            this.rdbO3.AutoSize = true;
            this.rdbO3.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbO3.Location = new System.Drawing.Point(25, 341);
            this.rdbO3.Name = "rdbO3";
            this.rdbO3.Size = new System.Drawing.Size(109, 24);
            this.rdbO3.TabIndex = 41;
            this.rdbO3.Text = "3. Oyuncu";
            this.rdbO3.UseVisualStyleBackColor = true;
            // 
            // rdbO2
            // 
            this.rdbO2.AutoSize = true;
            this.rdbO2.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbO2.Location = new System.Drawing.Point(25, 311);
            this.rdbO2.Name = "rdbO2";
            this.rdbO2.Size = new System.Drawing.Size(109, 24);
            this.rdbO2.TabIndex = 40;
            this.rdbO2.Text = "2. Oyuncu";
            this.rdbO2.UseVisualStyleBackColor = true;
            // 
            // rdbO1
            // 
            this.rdbO1.AutoSize = true;
            this.rdbO1.Checked = true;
            this.rdbO1.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbO1.Location = new System.Drawing.Point(25, 281);
            this.rdbO1.Name = "rdbO1";
            this.rdbO1.Size = new System.Drawing.Size(106, 24);
            this.rdbO1.TabIndex = 39;
            this.rdbO1.TabStop = true;
            this.rdbO1.Text = "1. Oyuncu";
            this.rdbO1.UseVisualStyleBackColor = true;
            // 
            // gbxEsitCevap
            // 
            this.gbxEsitCevap.Controls.Add(this.lblAynilar);
            this.gbxEsitCevap.Controls.Add(this.btnTemizle);
            this.gbxEsitCevap.Controls.Add(this.btn5);
            this.gbxEsitCevap.Controls.Add(this.btn4);
            this.gbxEsitCevap.Controls.Add(this.btn3);
            this.gbxEsitCevap.Controls.Add(this.btn2);
            this.gbxEsitCevap.Controls.Add(this.btn1);
            this.gbxEsitCevap.Controls.Add(this.clbEsit);
            this.gbxEsitCevap.Enabled = false;
            this.gbxEsitCevap.Location = new System.Drawing.Point(360, 72);
            this.gbxEsitCevap.Name = "gbxEsitCevap";
            this.gbxEsitCevap.Size = new System.Drawing.Size(288, 441);
            this.gbxEsitCevap.TabIndex = 40;
            this.gbxEsitCevap.TabStop = false;
            // 
            // lblAynilar
            // 
            this.lblAynilar.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAynilar.Location = new System.Drawing.Point(27, 332);
            this.lblAynilar.Name = "lblAynilar";
            this.lblAynilar.Size = new System.Drawing.Size(229, 23);
            this.lblAynilar.TabIndex = 52;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(96, 359);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(89, 43);
            this.btnTemizle.TabIndex = 51;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(215, 282);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(41, 43);
            this.btn5.TabIndex = 50;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(168, 282);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(41, 43);
            this.btn4.TabIndex = 49;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(121, 282);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(41, 43);
            this.btn3.TabIndex = 48;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(74, 282);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(41, 43);
            this.btn2.TabIndex = 47;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(27, 282);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(41, 43);
            this.btn1.TabIndex = 46;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // clbEsit
            // 
            this.clbEsit.BackColor = System.Drawing.Color.Aqua;
            this.clbEsit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbEsit.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clbEsit.FormattingEnabled = true;
            this.clbEsit.Items.AddRange(new object[] {
            "5 Harfli Jokerli",
            "5 Harfli Jokersiz",
            "6 Harfli Jokerli",
            "6 Harfli Jokersiz",
            "7 Harfli Jokerli",
            "7 Harfli Jokersiz",
            "8 Harfli Jokerli",
            "8 Harfli Jokersiz",
            "9 Harfli Jokerli",
            "9 Harfli Jokersiz"});
            this.clbEsit.Location = new System.Drawing.Point(6, 21);
            this.clbEsit.Name = "clbEsit";
            this.clbEsit.Size = new System.Drawing.Size(188, 240);
            this.clbEsit.TabIndex = 44;
            // 
            // rdbAyrikCevap
            // 
            this.rdbAyrikCevap.AutoSize = true;
            this.rdbAyrikCevap.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbAyrikCevap.Location = new System.Drawing.Point(13, 13);
            this.rdbAyrikCevap.Name = "rdbAyrikCevap";
            this.rdbAyrikCevap.Size = new System.Drawing.Size(225, 44);
            this.rdbAyrikCevap.TabIndex = 41;
            this.rdbAyrikCevap.Text = "Aynı cevap türüne sahip\r\nbirden fazla oyuncu yok";
            this.rdbAyrikCevap.UseVisualStyleBackColor = true;
            this.rdbAyrikCevap.CheckedChanged += new System.EventHandler(this.rdbAyrikCevap_CheckedChanged);
            // 
            // rdbEsitCevap
            // 
            this.rdbEsitCevap.AutoSize = true;
            this.rdbEsitCevap.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEsitCevap.Location = new System.Drawing.Point(360, 13);
            this.rdbEsitCevap.Name = "rdbEsitCevap";
            this.rdbEsitCevap.Size = new System.Drawing.Size(225, 44);
            this.rdbEsitCevap.TabIndex = 42;
            this.rdbEsitCevap.Text = "Aynı cevap türüne sahip\r\nbirden fazla oyuncu var";
            this.rdbEsitCevap.UseVisualStyleBackColor = true;
            this.rdbEsitCevap.CheckedChanged += new System.EventHandler(this.rdbAyrikCevap_CheckedChanged);
            // 
            // rdbYanitYok
            // 
            this.rdbYanitYok.AutoSize = true;
            this.rdbYanitYok.Font = new System.Drawing.Font("Exo 2.0 Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbYanitYok.Location = new System.Drawing.Point(13, 564);
            this.rdbYanitYok.Name = "rdbYanitYok";
            this.rdbYanitYok.Size = new System.Drawing.Size(103, 24);
            this.rdbYanitYok.TabIndex = 43;
            this.rdbYanitYok.Text = "Yanıt Yok";
            this.rdbYanitYok.UseVisualStyleBackColor = true;
            this.rdbYanitYok.CheckedChanged += new System.EventHandler(this.rdbYanitYok_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(230, 443);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 20);
            this.listBox1.TabIndex = 44;
            this.listBox1.Visible = false;
            // 
            // CevapYok_Kelime
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(660, 598);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rdbYanitYok);
            this.Controls.Add(this.rdbEsitCevap);
            this.Controls.Add(this.rdbAyrikCevap);
            this.Controls.Add(this.gbxEsitCevap);
            this.Controls.Add(this.gbxAyrikCevap);
            this.Controls.Add(this.btnOnayla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CevapYok_Kelime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CevapYok_Kelime";
            this.Load += new System.EventHandler(this.CevapYok_Kelime_Load);
            this.gbxAyrikCevap.ResumeLayout(false);
            this.gbxAyrikCevap.PerformLayout();
            this.gbxEsitCevap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.CheckedListBox clbAyrik;
        private System.Windows.Forms.GroupBox gbxAyrikCevap;
        private System.Windows.Forms.RadioButton rdbO1;
        private System.Windows.Forms.RadioButton rdbO5;
        private System.Windows.Forms.RadioButton rdbO4;
        private System.Windows.Forms.RadioButton rdbO3;
        private System.Windows.Forms.RadioButton rdbO2;
        private System.Windows.Forms.GroupBox gbxEsitCevap;
        private System.Windows.Forms.CheckedListBox clbEsit;
        private System.Windows.Forms.RadioButton rdbAyrikCevap;
        private System.Windows.Forms.RadioButton rdbEsitCevap;
        private System.Windows.Forms.RadioButton rdbYanitYok;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblAynilar;
        private System.Windows.Forms.ListBox listBox1;
    }
}