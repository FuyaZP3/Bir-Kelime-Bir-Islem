namespace Bir_Kelime_Bir_İşlem
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnKurallar = new System.Windows.Forms.Button();
            this.btnOyna = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.lblTesekkur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKurallar
            // 
            this.btnKurallar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKurallar.Font = new System.Drawing.Font("Exo 2.0 Semi Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKurallar.ForeColor = System.Drawing.Color.Black;
            this.btnKurallar.Location = new System.Drawing.Point(14, 441);
            this.btnKurallar.Name = "btnKurallar";
            this.btnKurallar.Size = new System.Drawing.Size(175, 62);
            this.btnKurallar.TabIndex = 10;
            this.btnKurallar.Text = "KURALLAR";
            this.btnKurallar.UseVisualStyleBackColor = false;
            this.btnKurallar.Click += new System.EventHandler(this.btnKurallar_Click);
            // 
            // btnOyna
            // 
            this.btnOyna.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOyna.Font = new System.Drawing.Font("Exo 2.0 Semi Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOyna.ForeColor = System.Drawing.Color.Black;
            this.btnOyna.Location = new System.Drawing.Point(14, 241);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(175, 62);
            this.btnOyna.TabIndex = 9;
            this.btnOyna.Text = "OYNA";
            this.btnOyna.UseVisualStyleBackColor = false;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // btnCik
            // 
            this.btnCik.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCik.Font = new System.Drawing.Font("Exo 2.0 Semi Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCik.ForeColor = System.Drawing.Color.Black;
            this.btnCik.Location = new System.Drawing.Point(12, 641);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(175, 62);
            this.btnCik.TabIndex = 7;
            this.btnCik.Text = "ÇIK";
            this.btnCik.UseVisualStyleBackColor = false;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.BackColor = System.Drawing.Color.Transparent;
            this.lblHosgeldin.Font = new System.Drawing.Font("BankGothic Md BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldin.ForeColor = System.Drawing.Color.Yellow;
            this.lblHosgeldin.Location = new System.Drawing.Point(149, 45);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(1033, 126);
            this.lblHosgeldin.TabIndex = 13;
            this.lblHosgeldin.Text = "BİR KELİME BİR İŞLEM\r\nYARIŞMASINA HOŞGELDİNİZ";
            this.lblHosgeldin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTesekkur
            // 
            this.lblTesekkur.AutoSize = true;
            this.lblTesekkur.BackColor = System.Drawing.Color.Transparent;
            this.lblTesekkur.Font = new System.Drawing.Font("Exo 2.0", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesekkur.ForeColor = System.Drawing.Color.Black;
            this.lblTesekkur.Location = new System.Drawing.Point(766, 533);
            this.lblTesekkur.Name = "lblTesekkur";
            this.lblTesekkur.Size = new System.Drawing.Size(542, 170);
            this.lblTesekkur.TabIndex = 14;
            this.lblTesekkur.Text = "Sorulardaki seslendirmelerinden dolayı\r\nÜmmü Hanım\'a\r\nve\r\nBatuhan Bey\'e\r\nteşekkür" +
    "lerimizi iletiyoruz.\r\n";
            this.lblTesekkur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1320, 720);
            this.Controls.Add(this.lblTesekkur);
            this.Controls.Add(this.lblHosgeldin);
            this.Controls.Add(this.btnKurallar);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.btnCik);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKurallar;
        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Label lblTesekkur;
    }
}