using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonu1
{
    public partial class PersonelIslemleri : Form
    {
        public PersonelIslemleri()
        {
            InitializeComponent();
        }

        private void müşteriEkleSilGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MüsteriKayıt müsteri_kayıt_göster =new MüsteriKayıt();
            müsteri_kayıt_göster.Show();
        }

        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {
            //lbl_Ad_Soyad.Text = PersonelArayuzu.isim;
            lbl_Ad_Soyad.Text = PersonelArayuzu.Adı_Soyadı.ToString();
        }

        private void ödemeALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Odeme_Al göster_OdemeAL = new Odeme_Al();
            göster_OdemeAL.Show();
        }
    }
}
