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
    public partial class MusteriArayuz : Form
    {
        public MusteriArayuz()
        {
            InitializeComponent();
        }

        private void btn_mus_giris_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                txt_mus_sifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                txt_mus_sifre.PasswordChar = '*';

            }
        }

        private void btn_sif_kayıt_Click(object sender, EventArgs e)
        {
            Sifre_kayıt göster_Sifre_kayıt = new Sifre_kayıt();
            göster_Sifre_kayıt.Show();
        }
    }
}
