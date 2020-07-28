namespace Otel_Otomasyonu1
{
    partial class PersonelIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelIslemleri));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleSilGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriŞifreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeALToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doluOdalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boşOdalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Ad_Soyad = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.ödemeAlToolStripMenuItem,
            this.odalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleSilGüncelleToolStripMenuItem,
            this.müşteriListesiToolStripMenuItem,
            this.müşteriŞifreToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // müşteriEkleSilGüncelleToolStripMenuItem
            // 
            this.müşteriEkleSilGüncelleToolStripMenuItem.Name = "müşteriEkleSilGüncelleToolStripMenuItem";
            this.müşteriEkleSilGüncelleToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.müşteriEkleSilGüncelleToolStripMenuItem.Text = "Müşteri Ekle-Sil-Güncelle";
            this.müşteriEkleSilGüncelleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleSilGüncelleToolStripMenuItem_Click);
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri Listesi";
            // 
            // müşteriŞifreToolStripMenuItem
            // 
            this.müşteriŞifreToolStripMenuItem.Name = "müşteriŞifreToolStripMenuItem";
            this.müşteriŞifreToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.müşteriŞifreToolStripMenuItem.Text = "Müşteri Şifre";
            // 
            // ödemeAlToolStripMenuItem
            // 
            this.ödemeAlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödemeALToolStripMenuItem1});
            this.ödemeAlToolStripMenuItem.Name = "ödemeAlToolStripMenuItem";
            this.ödemeAlToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.ödemeAlToolStripMenuItem.Text = "Kasa";
            // 
            // ödemeALToolStripMenuItem1
            // 
            this.ödemeALToolStripMenuItem1.Name = "ödemeALToolStripMenuItem1";
            this.ödemeALToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ödemeALToolStripMenuItem1.Text = "Ödeme AL";
            this.ödemeALToolStripMenuItem1.Click += new System.EventHandler(this.ödemeALToolStripMenuItem1_Click);
            // 
            // odalarToolStripMenuItem
            // 
            this.odalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doluOdalarToolStripMenuItem,
            this.boşOdalarToolStripMenuItem,
            this.tekKToolStripMenuItem});
            this.odalarToolStripMenuItem.Name = "odalarToolStripMenuItem";
            this.odalarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.odalarToolStripMenuItem.Text = "Odalar";
            // 
            // doluOdalarToolStripMenuItem
            // 
            this.doluOdalarToolStripMenuItem.Name = "doluOdalarToolStripMenuItem";
            this.doluOdalarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.doluOdalarToolStripMenuItem.Text = "Dolu Odalar";
            // 
            // boşOdalarToolStripMenuItem
            // 
            this.boşOdalarToolStripMenuItem.Name = "boşOdalarToolStripMenuItem";
            this.boşOdalarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.boşOdalarToolStripMenuItem.Text = "Boş Odalar";
            // 
            // tekKToolStripMenuItem
            // 
            this.tekKToolStripMenuItem.Name = "tekKToolStripMenuItem";
            this.tekKToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tekKToolStripMenuItem.Text = "Oda Tipleri";
            // 
            // lbl_Ad_Soyad
            // 
            this.lbl_Ad_Soyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ad_Soyad.Font = new System.Drawing.Font("Lucida Calligraphy", 10F);
            this.lbl_Ad_Soyad.Location = new System.Drawing.Point(361, 24);
            this.lbl_Ad_Soyad.Name = "lbl_Ad_Soyad";
            this.lbl_Ad_Soyad.Size = new System.Drawing.Size(176, 23);
            this.lbl_Ad_Soyad.TabIndex = 2;
            this.lbl_Ad_Soyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 336);
            this.Controls.Add(this.lbl_Ad_Soyad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PersonelIslemleri";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.PersonelIslemleri_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleSilGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeALToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doluOdalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boşOdalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriŞifreToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Ad_Soyad;
    }
}