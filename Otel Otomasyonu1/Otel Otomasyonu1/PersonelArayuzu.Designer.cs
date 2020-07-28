namespace Otel_Otomasyonu1
{
    partial class PersonelArayuzu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelArayuzu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_per_giris = new System.Windows.Forms.Button();
            this.txt_per_kuladı = new System.Windows.Forms.TextBox();
            this.txt_per_sifre = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_sif_kayıt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(302, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(302, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_per_giris
            // 
            this.btn_per_giris.Location = new System.Drawing.Point(397, 276);
            this.btn_per_giris.Name = "btn_per_giris";
            this.btn_per_giris.Size = new System.Drawing.Size(75, 22);
            this.btn_per_giris.TabIndex = 3;
            this.btn_per_giris.Text = "GİRİŞ";
            this.btn_per_giris.UseVisualStyleBackColor = true;
            this.btn_per_giris.Click += new System.EventHandler(this.btn_per_giris_Click);
            // 
            // txt_per_kuladı
            // 
            this.txt_per_kuladı.Location = new System.Drawing.Point(305, 76);
            this.txt_per_kuladı.Multiline = true;
            this.txt_per_kuladı.Name = "txt_per_kuladı";
            this.txt_per_kuladı.Size = new System.Drawing.Size(136, 25);
            this.txt_per_kuladı.TabIndex = 4;
            // 
            // txt_per_sifre
            // 
            this.txt_per_sifre.Location = new System.Drawing.Point(305, 154);
            this.txt_per_sifre.Multiline = true;
            this.txt_per_sifre.Name = "txt_per_sifre";
            this.txt_per_sifre.PasswordChar = '*';
            this.txt_per_sifre.Size = new System.Drawing.Size(136, 28);
            this.txt_per_sifre.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(305, 188);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 36);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_sif_kayıt
            // 
            this.btn_sif_kayıt.Location = new System.Drawing.Point(305, 276);
            this.btn_sif_kayıt.Name = "btn_sif_kayıt";
            this.btn_sif_kayıt.Size = new System.Drawing.Size(75, 23);
            this.btn_sif_kayıt.TabIndex = 7;
            this.btn_sif_kayıt.Text = "KAYIT OL";
            this.btn_sif_kayıt.UseVisualStyleBackColor = true;
            this.btn_sif_kayıt.Click += new System.EventHandler(this.btn_sif_kayıt_Click);
            // 
            // PersonelArayuzu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(503, 333);
            this.Controls.Add(this.btn_sif_kayıt);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_per_sifre);
            this.Controls.Add(this.txt_per_kuladı);
            this.Controls.Add(this.btn_per_giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelArayuzu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Arayüzü";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_per_giris;
        private System.Windows.Forms.TextBox txt_per_kuladı;
        private System.Windows.Forms.TextBox txt_per_sifre;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_sif_kayıt;
    }
}