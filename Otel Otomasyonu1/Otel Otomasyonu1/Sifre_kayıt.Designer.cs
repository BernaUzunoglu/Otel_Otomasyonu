namespace Otel_Otomasyonu1
{
    partial class Sifre_kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sifre_kayıt));
            this.rdo_btn_Tc = new System.Windows.Forms.RadioButton();
            this.rdo_btn_Ybnc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Box_Kul_Tip = new System.Windows.Forms.ComboBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_ilk_sifre = new System.Windows.Forms.TextBox();
            this.txt_iki_sifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sifre_kayıt = new System.Windows.Forms.Button();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chck_box_Sifre_Kayıt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rdo_btn_Tc
            // 
            this.rdo_btn_Tc.AutoSize = true;
            this.rdo_btn_Tc.BackColor = System.Drawing.Color.Transparent;
            this.rdo_btn_Tc.Location = new System.Drawing.Point(134, 68);
            this.rdo_btn_Tc.Name = "rdo_btn_Tc";
            this.rdo_btn_Tc.Size = new System.Drawing.Size(39, 17);
            this.rdo_btn_Tc.TabIndex = 0;
            this.rdo_btn_Tc.TabStop = true;
            this.rdo_btn_Tc.Text = "TC";
            this.rdo_btn_Tc.UseVisualStyleBackColor = false;
            // 
            // rdo_btn_Ybnc
            // 
            this.rdo_btn_Ybnc.AutoSize = true;
            this.rdo_btn_Ybnc.BackColor = System.Drawing.Color.Transparent;
            this.rdo_btn_Ybnc.Location = new System.Drawing.Point(190, 68);
            this.rdo_btn_Ybnc.Name = "rdo_btn_Ybnc";
            this.rdo_btn_Ybnc.Size = new System.Drawing.Size(64, 17);
            this.rdo_btn_Ybnc.TabIndex = 1;
            this.rdo_btn_Ybnc.TabStop = true;
            this.rdo_btn_Ybnc.Text = "Yabancı";
            this.rdo_btn_Ybnc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F);
            this.label1.Location = new System.Drawing.Point(123, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ŞİFRE KAYIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(71, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uyruk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(44, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kullanıcı Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(38, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "TC Kimlik No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(79, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şifre";
            // 
            // cmb_Box_Kul_Tip
            // 
            this.cmb_Box_Kul_Tip.FormattingEnabled = true;
            this.cmb_Box_Kul_Tip.Items.AddRange(new object[] {
            "Yönetici",
            "Personel",
            "Müşteri"});
            this.cmb_Box_Kul_Tip.Location = new System.Drawing.Point(134, 106);
            this.cmb_Box_Kul_Tip.Name = "cmb_Box_Kul_Tip";
            this.cmb_Box_Kul_Tip.Size = new System.Drawing.Size(121, 21);
            this.cmb_Box_Kul_Tip.TabIndex = 8;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(134, 148);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(121, 20);
            this.txt_tc.TabIndex = 9;
            // 
            // txt_ilk_sifre
            // 
            this.txt_ilk_sifre.Location = new System.Drawing.Point(135, 218);
            this.txt_ilk_sifre.Name = "txt_ilk_sifre";
            this.txt_ilk_sifre.PasswordChar = '*';
            this.txt_ilk_sifre.Size = new System.Drawing.Size(121, 20);
            this.txt_ilk_sifre.TabIndex = 10;
            // 
            // txt_iki_sifre
            // 
            this.txt_iki_sifre.Location = new System.Drawing.Point(135, 256);
            this.txt_iki_sifre.Name = "txt_iki_sifre";
            this.txt_iki_sifre.PasswordChar = '*';
            this.txt_iki_sifre.Size = new System.Drawing.Size(120, 20);
            this.txt_iki_sifre.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(50, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Şifre Tekrar";
            // 
            // btn_sifre_kayıt
            // 
            this.btn_sifre_kayıt.Location = new System.Drawing.Point(134, 322);
            this.btn_sifre_kayıt.Name = "btn_sifre_kayıt";
            this.btn_sifre_kayıt.Size = new System.Drawing.Size(120, 23);
            this.btn_sifre_kayıt.TabIndex = 13;
            this.btn_sifre_kayıt.Text = "Devam";
            this.btn_sifre_kayıt.UseVisualStyleBackColor = true;
            this.btn_sifre_kayıt.Click += new System.EventHandler(this.btn_sifre_kayıt_Click);
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(135, 183);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(121, 20);
            this.txt_AdSoyad.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(52, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Adı Soyadı";
            // 
            // chck_box_Sifre_Kayıt
            // 
            this.chck_box_Sifre_Kayıt.BackColor = System.Drawing.Color.Transparent;
            this.chck_box_Sifre_Kayıt.Cursor = System.Windows.Forms.Cursors.Default;
            this.chck_box_Sifre_Kayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chck_box_Sifre_Kayıt.ForeColor = System.Drawing.Color.Black;
            this.chck_box_Sifre_Kayıt.Image = ((System.Drawing.Image)(resources.GetObject("chck_box_Sifre_Kayıt.Image")));
            this.chck_box_Sifre_Kayıt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chck_box_Sifre_Kayıt.Location = new System.Drawing.Point(136, 282);
            this.chck_box_Sifre_Kayıt.Name = "chck_box_Sifre_Kayıt";
            this.chck_box_Sifre_Kayıt.Size = new System.Drawing.Size(120, 23);
            this.chck_box_Sifre_Kayıt.TabIndex = 17;
            this.chck_box_Sifre_Kayıt.Text = "Göster";
            this.chck_box_Sifre_Kayıt.UseVisualStyleBackColor = false;
            this.chck_box_Sifre_Kayıt.CheckedChanged += new System.EventHandler(this.chck_box_Sifre_Kayıt_CheckedChanged);
            // 
            // Sifre_kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 367);
            this.Controls.Add(this.chck_box_Sifre_Kayıt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.btn_sifre_kayıt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_iki_sifre);
            this.Controls.Add(this.txt_ilk_sifre);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.cmb_Box_Kul_Tip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdo_btn_Ybnc);
            this.Controls.Add(this.rdo_btn_Tc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sifre_kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_btn_Tc;
        private System.Windows.Forms.RadioButton rdo_btn_Ybnc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Box_Kul_Tip;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_ilk_sifre;
        private System.Windows.Forms.TextBox txt_iki_sifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sifre_kayıt;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chck_box_Sifre_Kayıt;
    }
}