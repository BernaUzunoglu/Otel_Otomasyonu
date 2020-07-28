namespace Otel_Otomasyonu1
{
    partial class MusteriArayuz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriArayuz));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_mus_giris = new System.Windows.Forms.Button();
            this.txt_mus_sifre = new System.Windows.Forms.TextBox();
            this.txt_mus_kuladı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sif_kayıt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(36, 174);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 36);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // btn_mus_giris
            // 
            this.btn_mus_giris.Location = new System.Drawing.Point(123, 243);
            this.btn_mus_giris.Name = "btn_mus_giris";
            this.btn_mus_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_mus_giris.TabIndex = 12;
            this.btn_mus_giris.Text = "GİRİŞ";
            this.btn_mus_giris.UseVisualStyleBackColor = true;
            // 
            // txt_mus_sifre
            // 
            this.txt_mus_sifre.Location = new System.Drawing.Point(36, 144);
            this.txt_mus_sifre.Multiline = true;
            this.txt_mus_sifre.Name = "txt_mus_sifre";
            this.txt_mus_sifre.PasswordChar = '*';
            this.txt_mus_sifre.Size = new System.Drawing.Size(136, 24);
            this.txt_mus_sifre.TabIndex = 11;
            // 
            // txt_mus_kuladı
            // 
            this.txt_mus_kuladı.Location = new System.Drawing.Point(35, 86);
            this.txt_mus_kuladı.Multiline = true;
            this.txt_mus_kuladı.Name = "txt_mus_kuladı";
            this.txt_mus_kuladı.Size = new System.Drawing.Size(137, 23);
            this.txt_mus_kuladı.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_sif_kayıt
            // 
            this.btn_sif_kayıt.Location = new System.Drawing.Point(36, 243);
            this.btn_sif_kayıt.Name = "btn_sif_kayıt";
            this.btn_sif_kayıt.Size = new System.Drawing.Size(75, 23);
            this.btn_sif_kayıt.TabIndex = 14;
            this.btn_sif_kayıt.Text = "KAYIT OL";
            this.btn_sif_kayıt.UseVisualStyleBackColor = true;
            this.btn_sif_kayıt.Click += new System.EventHandler(this.btn_sif_kayıt_Click);
            // 
            // MusteriArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 283);
            this.Controls.Add(this.btn_sif_kayıt);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_mus_giris);
            this.Controls.Add(this.txt_mus_sifre);
            this.Controls.Add(this.txt_mus_kuladı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MusteriArayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Arayüz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_mus_giris;
        private System.Windows.Forms.TextBox txt_mus_sifre;
        private System.Windows.Forms.TextBox txt_mus_kuladı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sif_kayıt;
    }
}