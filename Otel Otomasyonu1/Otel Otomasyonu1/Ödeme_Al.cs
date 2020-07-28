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
    public partial class Odeme_Al : Form
    {
        Database db = new Database();
        public Odeme_Al()
        {
            InitializeComponent();
        }

        private void Ödeme_Al_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otel_OtomasyonuDataSetBorclar.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.otel_OtomasyonuDataSetBorclar.Borclar);
      
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, Adsoyad, kalan;
            secilen = dataGridViewodeme.SelectedCells[0].RowIndex;
            id = dataGridViewodeme.Rows[secilen].Cells[0].Value.ToString();
            Adsoyad = dataGridViewodeme.Rows[secilen].Cells[1].Value.ToString();
            kalan = dataGridViewodeme.Rows[secilen].Cells[3].Value.ToString();
            txt_ıd.Text = id;
            txt_AdSoyad.Text = Adsoyad;
            txt_Kln_Brc.Text = kalan;
        }

        private void btn_Odeme_Al_Click(object sender, EventArgs e)
        {
            //Ödenen tutarı kalan borçtan düşürme
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(txt_odnn.Text);
            kalan = Convert.ToInt16(txt_Kln_Brc.Text);
            yeniborc = kalan - odenen;
            txt_Kln_Brc.Text = yeniborc.ToString();
            
            //yeni tutarı veritabanına güncelleyerek kaydetme
            db.baglanti.Open();
            db.komut = new SqlCommand("update Borclar set Kalan_Borc='"+txt_Kln_Brc.Text+"' where Musteri_Id='"+txt_ıd.Text+"'",db.baglanti);
            db.komut.ExecuteNonQuery();
            db.baglanti.Close();
            MessageBox.Show("Ödeme işlemi yapıldı.");
            this.borclarTableAdapter.Fill(this.otel_OtomasyonuDataSetBorclar.Borclar);

        }
    }
}
