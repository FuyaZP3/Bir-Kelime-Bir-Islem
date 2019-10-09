namespace Bir_Kelime_Bir_İşlem
{
    partial class IlkGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IlkGiris));
            this.pbxFuyaz = new System.Windows.Forms.PictureBox();
            this.lblSunar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFuyaz)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxFuyaz
            // 
            this.pbxFuyaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxFuyaz.Enabled = false;
            this.pbxFuyaz.Image = ((System.Drawing.Image)(resources.GetObject("pbxFuyaz.Image")));
            this.pbxFuyaz.Location = new System.Drawing.Point(0, 0);
            this.pbxFuyaz.Name = "pbxFuyaz";
            this.pbxFuyaz.Size = new System.Drawing.Size(450, 236);
            this.pbxFuyaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFuyaz.TabIndex = 0;
            this.pbxFuyaz.TabStop = false;
            // 
            // lblSunar
            // 
            this.lblSunar.AutoSize = true;
            this.lblSunar.BackColor = System.Drawing.Color.Aqua;
            this.lblSunar.Font = new System.Drawing.Font("BankGothic Md BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSunar.Location = new System.Drawing.Point(165, 174);
            this.lblSunar.Name = "lblSunar";
            this.lblSunar.Size = new System.Drawing.Size(115, 25);
            this.lblSunar.TabIndex = 1;
            this.lblSunar.Text = "SUNAR";
            this.lblSunar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IlkGiris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 236);
            this.Controls.Add(this.lblSunar);
            this.Controls.Add(this.pbxFuyaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IlkGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IlkGiris";
            this.Load += new System.EventHandler(this.IlkGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFuyaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxFuyaz;
        private System.Windows.Forms.Label lblSunar;
        private System.Windows.Forms.Timer timer1;
    }
}