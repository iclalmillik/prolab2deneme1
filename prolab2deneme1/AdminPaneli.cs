using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolab2deneme1
{
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre;

            kullaniciadi = textBox1.Text;
            sifre = textBox2.Text;
            if (kullaniciadi == "aaa" && sifre == "123")
            {
                MessageBox.Show("Giris basarılı.");
                AdminPanelislemler adminPanelislemler = new AdminPanelislemler();
                adminPanelislemler.Show();
            }
            else
            {
               MessageBox.Show("Hatali giris lütfen tekrar deneyiniz");
            }
        }
    }
}
