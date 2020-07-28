using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Otel_Otomasyonu1
{
    public class  Database
    {
        public SqlConnection baglanti = new SqlConnection("Data Source=ASUS;Initial Catalog=Otel_Otomasyonu;Integrated Security=True;MultipleActiveResultSets=True");
        public SqlCommand komut = new SqlCommand();
        public SqlDataReader dt_reader;
        public SqlDataAdapter dt_adapter = new SqlDataAdapter();

        public void sil(string secme_sorgusu,string textbox,string sutun_adı,string silme_sorgusu)
        {
            baglanti.Open();
            komut = new SqlCommand(secme_sorgusu,baglanti);
            komut.Parameters.AddWithValue("@TC_No",textbox);
            dt_adapter = new SqlDataAdapter(komut);
            dt_reader = komut.ExecuteReader();

            if (dt_reader.Read())
            {
                string isim = dt_reader[sutun_adı].ToString();
                dt_reader.Close();
                SqlCommand sil_komutu = new SqlCommand(silme_sorgusu, baglanti);
                sil_komutu.Parameters.AddWithValue("@TC_No", textbox);
                sil_komutu.ExecuteNonQuery();
                baglanti.Close();
            }    
            
            baglanti.Close();
        }
    

        //public string Adı_Soyadı;
       /* public void getir(string a ,string tab_adı)
        {
            baglanti.Open();
            komut = new SqlCommand("select Adı_Soyadı from'"+tab_adı+"'where TC_No='"+a+"'",baglanti);
            dt_reader = komut.ExecuteReader();
            if (dt_reader.Read())
            {
                Adı_Soyadı = dt_reader[0].ToString();
            }
            baglanti.Close();*/

        }
    }


