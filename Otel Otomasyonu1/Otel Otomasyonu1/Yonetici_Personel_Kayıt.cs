using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otel_Otomasyonu1
{
    public partial class Yonetici_Personel_Kayıt : Form
    {
        Database db = new Database();
        public Yonetici_Personel_Kayıt()
        {
            InitializeComponent();
        }
        private void göster(string a)
        {
            db.baglanti.Open();
            db.dt_adapter = new SqlDataAdapter(a,db.baglanti);
            DataTable listele_personel = new DataTable();
            db.dt_adapter.Fill(listele_personel);
            dataGridViewgöster.DataSource = listele_personel;
            db.baglanti.Close();
        }
         public void temizle()
         {
             foreach(TextBox txt in this.Controls.OfType<TextBox>())
             {
                 txt.Text="";
             }

         }

        private void btn_Yon_Per_Kayıt_Click(object sender, EventArgs e)
        {
           
                if (cmb_Clsm_Alan.Text == "Yönetici")
                {
                    db.baglanti.Open();
                    db.komut = new SqlCommand("insert into Yonetici(Uyruk,TC_No,Adı_Soyadı,Telefon,E_Mail,Adres,Cinsiyet,Egitim_Seviyesi,Calısma_Alanı,Yabancı_Dil,İse_Baslama_Tarihi,İsten_Cıkıs_Tarihi)values('" + rdio_btn_Tc.Checked + "','" + txt_Tc.Text + "','" + txt_AdSoyad.Text + "','" + mskdTxt_tel.Text + "','" + txt_mail.Text + "','" + txt_adres.Text + "','" + cmb_Cinsiyet.Text + "','" + cmb_Egtm_Svy.Text + "','" + cmb_Clsm_Alan.Text + "','" + cmb_Ybnc_dil.Text + "','" + dtTimePck_Giris.Value.ToString("yyyy-MM-dd") + "','" + dtTimePck_Cıkıs1.Value.ToString("yyyy-MM-dd") + "')", db.baglanti);
                    db.komut.ExecuteNonQuery();
                    db.baglanti.Close();
                    MessageBox.Show("Kayıt Başarı ile Yapıldı:)");
                    string sorgu = "select* from Yonetici";
                    göster(sorgu);
                }
                else
                {
                    db.baglanti.Open();
                    db.komut = new SqlCommand("insert into Personel(Uyruk,TC_No,Adı_Soyadı,Telefon,E_Mail,Adres,Cinsiyet,Egitim_Seviyesi,Calısma_Alanı,Yabancı_Dil,İse_Baslama_Tarihi,İsten_Cıkıs_Tarihi)values('" + rdio_btn_Tc.Checked + "','" + txt_Tc.Text + "','" + txt_AdSoyad.Text + "','" + mskdTxt_tel.Text + "','" + txt_mail.Text + "','" + txt_adres.Text + "','" + cmb_Cinsiyet.Text + "','" + cmb_Egtm_Svy.Text + "','" + cmb_Clsm_Alan.Text + "','" + cmb_Ybnc_dil.Text + "','" + dtTimePck_Giris.Value.ToString("yyyy-MM-dd") + "','" + dtTimePck_Cıkıs1.Value.ToString("yyyy-MM-dd") + "')", db.baglanti);
                    db.komut.ExecuteNonQuery();
                    db.baglanti.Close();
                    MessageBox.Show("Kayıt Başarı ile Yapıldı:)");
                    temizle();
                    string sorgu = "select* from Personel";
                    göster(sorgu);
                }  
        }

        private void dtTimePck_Cıkıs_ValueChanged(object sender, EventArgs e)
        {
            DateTime Kucuk_Tarih = Convert.ToDateTime(dtTimePck_Giris.Text);
            DateTime Buyuk_Tarih = Convert.ToDateTime(dtTimePck_Cıkıs1.Text);
            TimeSpan Sonuc = Buyuk_Tarih - Kucuk_Tarih;
            label15.Text = Sonuc.TotalDays.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from Personel";
            göster(sorgu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from Yonetici";
            göster(sorgu);
        }
        private void btn_Kayıt_Sil_Click(object sender, EventArgs e)
        {
            string secme_sorgusu = "select* from Personel where TC_No=@TC_No";
            string secme_sorgusu1 = "select* from Yonetici where TC_No=@TC_No";
            string silme_sorgusu = "Delete from Personel where TC_No=@TC_No";
            string silme_sorgusu1 = "Delete from Yonetici where TC_No=@TC_No";
            if (txt_Tc.Text != " ")
            {
                btn_Kayıt_Sil.Enabled = true;
                DialogResult durum = MessageBox.Show(txt_Tc.Text + " Kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum)
                {
                    db.sil(secme_sorgusu, txt_Tc.Text, "TC_No", silme_sorgusu);
                    db.sil(secme_sorgusu1, txt_Tc.Text, "TC_No", silme_sorgusu1);
                } 
                db.baglanti.Close();
            }
            else
            {
                btn_Kayıt_Sil.Enabled = false;
                MessageBox.Show("Silmel istediğiniz müşterinin TC sini giriniz");
            }  
        }

        private void dtTimePck_Cıkıs1_ValueChanged(object sender, EventArgs e)
        {
            DateTime Kucuk_Tarih = Convert.ToDateTime(dtTimePck_Giris.Text);
            DateTime Buyuk_Tarih = Convert.ToDateTime(dtTimePck_Cıkıs1.Text);
            TimeSpan Sonuc = Buyuk_Tarih - Kucuk_Tarih;
            label15.Text = Sonuc.TotalDays.ToString();

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is TextBox) Controls[i].Text = " ";
            }


        }
        
        


    }
}
