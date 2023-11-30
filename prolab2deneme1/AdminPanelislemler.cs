using Prolab2_1.deneme;
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
    public partial class AdminPanelislemler : Form
    {

        List<Firma> firmaList = new List<Firma>();
        public List<string> firmalarListesi;

        public AdminPanelislemler()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirmalariGoruntule firmalariGoruntule=new FirmalariGoruntule(firmalarListesi);
            firmalariGoruntule .Show();
            

           

        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            FirmaKaydıPaneli firmaKaydıPaneli=new FirmaKaydıPaneli();   
            firmaKaydıPaneli .Show();

        }
    }
}
