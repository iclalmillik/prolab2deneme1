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

        private void girisYap_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre;
            kullaniciadi = KullanıcıAdıText.Text;
            sifre = SifreText.Text;
            if(kullaniciadi=="a"&&sifre=="1")
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Hatali Giriş Lütfen Tekrar Deneyiniz");
            }
            AdminPaneliİslemler adminpanelislemler = new AdminPaneliİslemler();
            adminpanelislemler.Show();
        }
    }
}
