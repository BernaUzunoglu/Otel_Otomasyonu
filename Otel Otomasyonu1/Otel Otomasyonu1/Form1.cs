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
    public partial class kul_form : Form
    {
        public kul_form()
        {
            InitializeComponent();
        }

        private void btn_yöngir_Click(object sender, EventArgs e)
        {
            Yoneticiarayuzu gösteryön_ara = new Yoneticiarayuzu();
            gösteryön_ara.Show();
        }

        private void btn_pergir_Click(object sender, EventArgs e)
        {
            PersonelArayuzu gösterper_ara = new PersonelArayuzu();
            gösterper_ara.Show();
        }

        private void btn_müsgir_Click(object sender, EventArgs e)
        {
            MusteriArayuz göstermüs_ara = new MusteriArayuz();
            göstermüs_ara.Show();
        }
    }
}
