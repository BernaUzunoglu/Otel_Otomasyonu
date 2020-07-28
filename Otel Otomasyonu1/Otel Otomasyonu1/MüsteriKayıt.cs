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
using System.Globalization;

namespace Otel_Otomasyonu1
{
    public partial class MüsteriKayıt : Form
    {
        public MüsteriKayıt()
        {
            InitializeComponent();
        }
        Database db = new Database();
        //public SqlCommand komut = new SqlCommand();
        public string sorgu = "select* from Musteri";
        private void göster(string a)
        {
            
            db.baglanti.Open();
            db.dt_adapter = new SqlDataAdapter(a, db.baglanti);
            DataTable listele_personel = new DataTable();
            db.dt_adapter.Fill(listele_personel);
            datagridMusteri.DataSource = listele_personel;
            db.baglanti.Close();
        }
        private void MüsteriKayıt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otel_OtomasyonuDataSetMusteriTablosu.Musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter.Fill(this.otel_OtomasyonuDataSetMusteriTablosu.Musteri);
            //Boş odaları listele
            
        }

        private void dtTimePck_Cıkıs_ValueChanged(object sender, EventArgs e)
        {
            DateTime Kucuk_Tarih = Convert.ToDateTime(dtTimePck_Giris.Text);
            DateTime Buyuk_Tarih = Convert.ToDateTime(dtTimePck_Cıkıs.Text);
            TimeSpan Sonuc = Buyuk_Tarih - Kucuk_Tarih;
            label15.Text = Sonuc.TotalDays.ToString();
            

            int ucret;
            if (cmb_odaTürleri.Text== "Standart Tek Kişilik")
            {
                ucret = Convert.ToInt32(label15.Text) * 60;
                txt_ucret.Text = ucret.ToString();
            }
            else if(cmb_odaTürleri.Text== "Standart Çift Kişilik")
            {
                ucret = Convert.ToInt32(label15.Text) * 105;
                txt_ucret.Text = ucret.ToString();
            }
            else if (cmb_odaTürleri.Text == "Birleşik Oda")
            {
                ucret = Convert.ToInt32(label15.Text) * 140;
                txt_ucret.Text = ucret.ToString();
            }
            else if(cmb_odaTürleri.Text== "Suit Oda")
            {
                ucret = Convert.ToInt32(label15.Text) * 160;
                txt_ucret.Text = ucret.ToString();
            }
        }

        private void btn_Mus_Kayıt_Click(object sender, EventArgs e)
        {
            //Müşteri Bilgileri kayıt
            db.baglanti.Open();
            db.komut = new SqlCommand("insert into Musteri(OdaNumarasi,Uyruk,TC_No,AdıSoyadı,Telefon,E_Mail,Adres,Cinsiyet,Oda_Türü,Ucret,Giris_Tarihi,Cikis_Tarihi)values('" + combo_odalar.Text + "','" + rdio_btn_Tc.Checked + "','" + txt_Tc.Text + "','" + txt_AdSoyad.Text + "','" + mskdTxt_tel.Text + "','" + txt_mail.Text + "','" + txt_adres.Text + "','" + cmb_Cinsiyet.Text + "','"+cmb_odaTürleri.Text+"','" + txt_ucret.Text + "','" + dtTimePck_Giris.Value.ToString("yyyy-MM-dd") + "','" + dtTimePck_Cıkıs.Value.ToString("yyyy-MM-dd") + "')", db.baglanti);
            db.komut.ExecuteNonQuery();
            db.komut = new SqlCommand("Update Odalar set Oda_Aktif ='1'  where Oda_No='" + combo_odalar.Text.ToString() + "'", db.baglanti);
            db.komut.ExecuteNonQuery();
            
           

            //Müşteri Id label a çekme
            
            db.komut = new SqlCommand("select Musteri_Id from Musteri", db.baglanti);
            db.dt_reader = db.komut.ExecuteReader();
            while (db.dt_reader.Read())
            {
                lbl_MusteriId.Text = db.dt_reader[0].ToString();
            } 
            //Kayıt yapılan müşterinin borcu tabloya ekleniyor
            db.komut = new SqlCommand("insert into Borclar(Musteri_Id,TC_No,Adı_Soyadı,Oda_Numarasi,Ucret)values('"+lbl_MusteriId.Text+"','"+txt_Tc.Text+"','"+txt_AdSoyad.Text+"','"+combo_odalar.Text+"','"+txt_ucret.Text+"')",db.baglanti);
            db.komut.ExecuteNonQuery();
            //db.baglanti.Close();
            MessageBox.Show("Kayıt Başarı ile Yapıldı:)");
            db.baglanti.Close();
            göster(sorgu);
        }
        private void btn_Mus_Lstl_Click(object sender, EventArgs e)
        {
            göster(sorgu);
           
        }
        private void btn_Mus_sil_Click(object sender, EventArgs e)
        {
            //Müşterinin Tc sine göre kayıt siliniyor
            string secme_sorgusu = "select* from Musteri where TC_No=@TC_No";
            // db.komut = new SqlCommand("select TC_No='"+txt_Tc.Text+"' from Musteri where OdaNumarasi");
            string silme_sorgusu = "Delete from Musteri where TC_No=@TC_No";
    
            if (txt_Tc.Text != "")
            {
                DialogResult kontrol = MessageBox.Show(txt_Tc.Text + " Müşteri ödemesini yapmış mı?", "Ödeme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == kontrol)
                {
                    DialogResult durum = MessageBox.Show(txt_Tc.Text + " Kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == durum)
                    {
                        db.sil(secme_sorgusu, txt_Tc.Text, "TC_No", silme_sorgusu);
                        db.baglanti.Open();
                        db.komut = new SqlCommand("Update Odalar set Oda_Aktif ='0'  where Oda_No='" + combo_odalar.Text.ToString() + "'", db.baglanti);
                        db.komut.ExecuteNonQuery();
                        db.baglanti.Close();
                        MessageBox.Show("Kayıt silindi");
                        göster(sorgu);
                    }
                }
                else
                {
                    Odeme_Al göster_odemeal = new Odeme_Al();
                    göster_odemeal.Show();
                }   
            }
            else
                MessageBox.Show("Kaydını silmek istediğiniz kişinin Tc sini giriniz");
            db.baglanti.Close();
        }
        private void btn_gncl_Click(object sender, EventArgs e)
        {
            db.baglanti.Open();
            DialogResult kontrol = MessageBox.Show(txt_Tc.Text + " Oda değişikliği var mı?", "Oda Onayı", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.No == kontrol)
            {
                db.komut = new SqlCommand("Update Musteri set OdaNumarasi='" + combo_odalar.Text + "',Telefon='" + mskdTxt_tel.Text + "',E_Mail='" + txt_mail.Text + "',Adres='" + txt_adres.Text + "',Ucret='" + txt_ucret.Text + "',Giris_Tarihi='" + dtTimePck_Giris.Value.ToString("yyyy-MM-dd") + "',Cikis_Tarihi='" + dtTimePck_Cıkıs.Value.ToString("yyyy-MM-dd") + "' where TC_NO='"+txt_Tc.Text+"'", db.baglanti);
                db.komut.ExecuteNonQuery();
            }
            else
            {
                string oda_degeri;
                DialogResult kontrol_oda = MessageBox.Show(txt_Tc.Text + " Eski oda boş olarak kaydediliyor ?", "Oda Onayı", MessageBoxButtons.OK,MessageBoxIcon.Information);
                db.komut = new SqlCommand("Select OdaNumarasi from Musteri  Where TC_No = '"+txt_Tc.Text+"'",db.baglanti);
                SqlDataReader alınan_oda;
                alınan_oda = db.komut.ExecuteReader();
                while (alınan_oda.Read())
                {
                    oda_degeri = alınan_oda["OdaNumarasi"].ToString();
                    db.komut = new SqlCommand("Update Odalar set Oda_Aktif ='0'  where Oda_No='" + oda_degeri + "'", db.baglanti);
                    db.komut.ExecuteNonQuery();
                    break;
                }
                db.komut = new SqlCommand("Update Musteri set OdaNumarasi='" + combo_odalar.Text + "',Telefon='" + mskdTxt_tel.Text + "',E_Mail='" + txt_mail.Text + "',Adres='" + txt_adres.Text + "',Ucret='" + txt_ucret.Text + "',Giris_Tarihi='" + dtTimePck_Giris.Value.ToString("yyyy-MM-dd") + "',Cikis_Tarihi='" + dtTimePck_Cıkıs.Value.ToString("yyyy-MM-dd") + "' where TC_NO='" + txt_Tc.Text + "'", db.baglanti);
                db.komut.ExecuteNonQuery();           
                db.komut = new SqlCommand("Update Odalar set Oda_Aktif ='1'  where Oda_No='" + combo_odalar.Text.ToString() + "'", db.baglanti);
                db.komut.ExecuteNonQuery();
            }
            db.baglanti.Close();
            MessageBox.Show("Güncelleme işlemi yapıldı");
            göster(sorgu);
        }
        private void datagridMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, oda, TC, Adsoyad, Telefon, E_Mail, Adres, Cinsiyet, Ucret, Giris_Tarihi,Cikis_Tarihi,Oda_Türü;

            secilen = datagridMusteri.SelectedCells[0].RowIndex;
            id = datagridMusteri.Rows[secilen].Cells[0].Value.ToString();
            oda = datagridMusteri.Rows[secilen].Cells[1].Value.ToString();
            TC = datagridMusteri.Rows[secilen].Cells[3].Value.ToString();
            Adsoyad = datagridMusteri.Rows[secilen].Cells[4].Value.ToString();
            Telefon = datagridMusteri.Rows[secilen].Cells[5].Value.ToString();
            E_Mail = datagridMusteri.Rows[secilen].Cells[6].Value.ToString();
            Adres = datagridMusteri.Rows[secilen].Cells[7].Value.ToString();
            Cinsiyet = datagridMusteri.Rows[secilen].Cells[8].Value.ToString();
            Oda_Türü = datagridMusteri.Rows[secilen].Cells[9].Value.ToString();
            Ucret = datagridMusteri.Rows[secilen].Cells[10].Value.ToString();
            Giris_Tarihi = datagridMusteri.Rows[secilen].Cells[11].Value.ToString();
            Cikis_Tarihi = datagridMusteri.Rows[secilen].Cells[12].Value.ToString();

            combo_odalar.Text = oda;
            txt_Tc.Text = TC;
            txt_AdSoyad.Text = Adsoyad;
            mskdTxt_tel.Text = Telefon;
            txt_mail.Text = E_Mail;
            txt_adres.Text = Adres;
            cmb_Cinsiyet.Text = Cinsiyet;
            txt_ucret.Text = Ucret;
            cmb_odaTürleri.Text = Oda_Türü;
            dtTimePck_Giris.Value = Convert.ToDateTime(Giris_Tarihi);
            dtTimePck_Cıkıs.Value = Convert.ToDateTime(Cikis_Tarihi);
            

        }

        public void odatürleri()
        {
            while (db.dt_reader.Read())
            {
                combo_odalar.Items.Add(db.dt_reader[0].ToString());
            }
        }
        private void cmb_odaTürleri_TextChanged(object sender, EventArgs e)
        {
            db.baglanti.Open();
            if (cmb_odaTürleri.Text == "Standart Tek Kişilik")
            {
                combo_odalar.Items.Clear();
                db.komut = new SqlCommand("select Oda_No from Odalar where Oda_Türü='Standart Tek Kişilik' AND Oda_Aktif ='0' ", db.baglanti);
                db.dt_reader = db.komut.ExecuteReader();
                odatürleri();
                
            }
            else if (cmb_odaTürleri.Text == "Standart Çift Kişilik")
            {
                combo_odalar.Items.Clear();
                db.komut = new SqlCommand("select Oda_No from Odalar where Oda_Türü='Standart Çift Kişilik' AND Oda_Aktif ='0' ", db.baglanti);
                db.dt_reader = db.komut.ExecuteReader();
                odatürleri();
            }
            else if (cmb_odaTürleri.Text == "Birleşik Oda")
            {
                combo_odalar.Items.Clear();
                db.komut = new SqlCommand("select Oda_No from Odalar where Oda_Türü='Birleşik Oda' AND Oda_Aktif ='0' ", db.baglanti);
                db.dt_reader = db.komut.ExecuteReader();
                odatürleri();
            }
            else if (cmb_odaTürleri.Text == "Suit Oda")
            {
                combo_odalar.Items.Clear();
                db.komut = new SqlCommand("select Oda_No from Odalar where Oda_Türü='Suit Oda' AND Oda_Aktif ='0' ", db.baglanti);
                db.dt_reader = db.komut.ExecuteReader();
                odatürleri();
            }
            db.baglanti.Close();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {

        }
    }
}
