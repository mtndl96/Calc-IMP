using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcIMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genel_Click(object sender, EventArgs e)
        {
            Txt1.Text = "1";
        }
		private void bir_Click(object sender, EventArgs e)
        {
            Txt1.Text = "1";
        }

        private void iki_Click(object sender, EventArgs e)
        {
            Txt1.Text = "2";
        }

        private void uc_Click(object sender, EventArgs e)
        {
            Txt1.Text = "3";
        }

        private void dort_Click(object sender, EventArgs e)
        {
            Txt1.Text = "4";
        }

        private void bes_Click(object sender, EventArgs e)
        {
            Txt1.Text = "5";
        }

        private void alti_Click(object sender, EventArgs e)
        {
            Txt1.Text = "6";
        }

        private void yedi_Click(object sender, EventArgs e)
        {
            Txt1.Text = "7";
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            Txt1.Text = "8";
        }

        private void dokuz_Click(object sender, EventArgs e)
        {
            Txt1.Text = "9";
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            Txt1.Text = "0";
        }
        void private : 
            
               { 
            
                     }
        private void clear_Click(object sender, EventArgs e)
        {
            Txt1.Clear();
        }

        private void topla_Click(object sender, EventArgs e)
        {  
        }
        // Yazılan rakamlar TextBox'da kayıtlı kalmıyor 
        // üç kez 1 butonuna basıldığında 1 kez 1 yazıyor toplamıyor.
        // Her yeni butona basıldığında textboxdaki sayıda değişiyor.Bu yüzden işlem butonları kullanılamıyor.
        // Tüm işlemlerin tek metodda yapılması gerekiyor.
    }
}
