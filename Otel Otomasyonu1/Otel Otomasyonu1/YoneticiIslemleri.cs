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
    public partial class YoneticiIslemleri : Form
    {
        Database db = new Database();
        public YoneticiIslemleri()
        {    
            InitializeComponent();
        }
        private void YoneticiIslemleri_Load(object sender, EventArgs e)
        {
           // lbl_Ad_Soyad.Text = Yoneticiarayuzu.isim;
            lbl_Ad_Soyad.Text = Yoneticiarayuzu.Adı_Soyadı.ToString();
        }

        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yonetici_Personel_Kayıt yön_per_kayıt_göster = new Yonetici_Personel_Kayıt();
            yön_per_kayıt_göster.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yonetici_Personel_Kayıt yön_per_kayıt_göster = new Yonetici_Personel_Kayıt();
            yön_per_kayıt_göster.Show();
        }

        private void yöneticiListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lısteler listeler_göster = new Lısteler();
            listeler_göster.Show();
        }
    }
}
