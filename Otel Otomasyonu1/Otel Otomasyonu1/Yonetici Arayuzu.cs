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
    public partial class Yoneticiarayuzu : Form
    {
        Database db = new Database();

        public Yoneticiarayuzu()
        {
            InitializeComponent();
        }

        public static string isim;
        private void btn_yon_giris_Click(object sender, EventArgs e)
        {
           getir();
           /*label3.Text = Adı_Soyadı;
           isim = label3.Text; */
            db.baglanti.Open();
            db.komut = new SqlCommand("Select* from Yon_Giris_Sifre where TC_No='" + txt_yon_kuladı.Text + "'and Sifre='" + txt_yon_sifre.Text + "'", db.baglanti);
            db.dt_reader = db.komut.ExecuteReader();
            if (db.dt_reader.Read())
            { 
                YoneticiIslemleri goster_YonIslem = new YoneticiIslemleri();
                goster_YonIslem.Show();     
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre hatalı");
            }
            db.baglanti.Close();      
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_yon_sifre.PasswordChar = '\0'; //karakteri göster.
            }
            else//değilse karakterlerin yerine * koy.
            {
                txt_yon_sifre.PasswordChar = '*';
            }
        }
        public static string Adı_Soyadı;
        private void getir()
        {
            db.baglanti.Open();
            db.komut = new SqlCommand("select Adı_Soyadı from Yon_Giris_Sifre where TC_No='" + txt_yon_kuladı.Text + "'", db.baglanti);
            db.dt_reader = db.komut.ExecuteReader();
            if (db.dt_reader.Read())
            {
                Adı_Soyadı = db.dt_reader[0].ToString();
            }
            db.baglanti.Close();    
        }

        private void btn_kyt_Click(object sender, EventArgs e)
        {
            Sifre_kayıt göster_Sifre_kayıt = new Sifre_kayıt();
            göster_Sifre_kayıt.Show();
        }
    }
}

