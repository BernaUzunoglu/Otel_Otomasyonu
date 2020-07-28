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
    public partial class Sifre_kayıt : Form
    {
        Database db = new Database();
        public Sifre_kayıt()
        {
            InitializeComponent();
        }
        private void btn_sifre_kayıt_Click(object sender, EventArgs e)
        {
            if (txt_ilk_sifre.Text == txt_iki_sifre.Text) 
            {
                db.baglanti.Open();
                if (cmb_Box_Kul_Tip.Text == "Yönetici")
                {
                    db.komut = new SqlCommand("select TC_No from Yonetici Where TC_No='" + txt_tc.Text + "'", db.baglanti);
                    SqlDataReader alınan_veri;
                    alınan_veri = db.komut.ExecuteReader();
                    while (alınan_veri.Read())
                    {
                        if (txt_tc.Text == alınan_veri["TC_No"].ToString())
                        {
                            db.komut = new SqlCommand("insert into Yon_Giris_Sifre(Uyruk,Kullanıcı_Tipi,TC_No,Adı_Soyadı,Sifre)values('" + rdo_btn_Tc.Checked + "','" + cmb_Box_Kul_Tip.Text + "','" + txt_tc.Text + "','" + txt_AdSoyad.Text + "','" + txt_ilk_sifre.Text + "')", db.baglanti);
                            db.komut.ExecuteNonQuery();
                            MessageBox.Show("Şifre Alma İşlemi Tamamlandı :) ");
                            this.Close();
                            break;

                        }
                        //else { MessageBox.Show("Müşteri kaydınız yapılmamış."); break; }
                    }
                    MessageBox.Show("Müşteri kaydınız yapılmamış.");

                }
                else if (cmb_Box_Kul_Tip.Text == "Personel")
                {
                    db.komut = new SqlCommand("select TC_No from Personel Where TC_No='" + txt_tc.Text + "'", db.baglanti);
                    SqlDataReader alınan_veri;
                    alınan_veri = db.komut.ExecuteReader();
                    while (alınan_veri.Read())
                    {
                        if (txt_tc.Text == alınan_veri["TC_No"].ToString())
                        {
                            db.komut = new SqlCommand("insert into Per_Gir_Sifre(Uyruk,Kullanıcı_Tipi,TC_No,Adı_Soyadı,Sifre)values('" + rdo_btn_Tc.Checked + "','" + cmb_Box_Kul_Tip.Text + "','" + txt_tc.Text + "','" + txt_AdSoyad.Text + "','" + txt_ilk_sifre.Text + "')", db.baglanti);
                            db.komut.ExecuteNonQuery();
                            MessageBox.Show("Şifre Alma İşlemi Tamamlandı :) ");
                            this.Close();
                            break;
                        }
                        //else { MessageBox.Show("Müşteri kaydınız yapılmamış."); break; }
                    }
                    MessageBox.Show("Müşteri kaydınız yapılmamış.");
                }
                else
                {
                    db.komut = new SqlCommand("select TcNo from Musteri Where TcNo='" + txt_tc.Text + "'", db.baglanti);
                    SqlDataReader alınan_veri;
                    alınan_veri = db.komut.ExecuteReader();
                    while (alınan_veri.Read())
                    {
                        if (txt_tc.Text == alınan_veri["TcNo"].ToString())
                        {
                            db.komut = new SqlCommand("insert into Mus_Giris_Sifre(Uyruk,Kullanıcı_Tipi,TC_No,Adı_Soyadı,Sifre)values('" + rdo_btn_Tc.Checked + "','" + cmb_Box_Kul_Tip.Text + "','" + txt_tc.Text + "','" + txt_AdSoyad.Text + "','" + txt_ilk_sifre.Text + "')", db.baglanti);
                            db.komut.ExecuteNonQuery();
                            MessageBox.Show("Şifre Alma İşlemi Tamamlandı :) ");
                            this.Close();
                            break; 
                        }
                        //else { MessageBox.Show("Müşteri kaydınız yapılmamış."); break; }
                    }
                    MessageBox.Show("Müşteri kaydınız yapılmamış.");                 
                }
                db.baglanti.Close();
            }
            else
            {
                MessageBox.Show("Girdiğiniz şifreler uyuşmamaktadır");
            }
            
        }
        private void chck_box_Sifre_Kayıt_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_box_Sifre_Kayıt.Checked)
            {
                txt_ilk_sifre.PasswordChar = '\0'; //karakteri göster.
                txt_iki_sifre.PasswordChar = '\0';         
            }
            else //değilse karakterlerin yerine * koy.
            {
                txt_ilk_sifre.PasswordChar = '*';
                txt_iki_sifre.PasswordChar = '*';
            }
        }

    }
}
