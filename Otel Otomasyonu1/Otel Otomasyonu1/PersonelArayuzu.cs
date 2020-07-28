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
    public partial class PersonelArayuzu : Form
    {
        Database db = new Database();
        public PersonelArayuzu()
        {
            InitializeComponent();
        }
        public static string isim;
        private void btn_per_giris_Click(object sender, EventArgs e)
        {
            getir();
            /*label3.Text = Adı_Soyadı;
            isim = label3.Text;*/
            db.baglanti.Open();
            db.komut = new SqlCommand("Select* from Per_Gir_Sifre where TC_No='" + txt_per_kuladı.Text + "'and Sifre='" + txt_per_sifre.Text + "'", db.baglanti);
            db.dt_reader = db.komut.ExecuteReader();
            if (db.dt_reader.Read())
            {
                PersonelIslemleri goster_PerIslem = new PersonelIslemleri();
                goster_PerIslem.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            db.baglanti.Close();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                txt_per_sifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                txt_per_sifre.PasswordChar = '*';

            }
        }
        public static string Adı_Soyadı;
        public void getir()
        {
            db.baglanti.Open();
            db.komut = new SqlCommand("select Adı_Soyadı from Per_Gir_Sifre where TC_No='" + txt_per_kuladı.Text + "'", db.baglanti);
            db.dt_reader = db.komut.ExecuteReader();
            if (db.dt_reader.Read())
            {
                Adı_Soyadı = db.dt_reader[0].ToString();
            }
            db.baglanti.Close();
        }

        private void btn_sif_kayıt_Click(object sender, EventArgs e)
        {
            Sifre_kayıt göster_Sifre_kayıt = new Sifre_kayıt();
            göster_Sifre_kayıt.Show();
        }
    }
}
