using Prolab2_1.deneme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolab2deneme1
{
    public partial class FirmaKaydıPaneli : Form
    {
        public FirmaKaydıPaneli()
        {
            InitializeComponent();

           
        }

        public void FirmaKaydıPaneli_Load(object sender, EventArgs e)
        { /*
            string textveri= txtveri.Text;
            Firma firma = new Firma();                   //hata var çözemedim yorum satırlarını kaldırırsanız firmakaydıpanelini açmıyor
            firma.firmaEkle(Firma r);
           */  
            }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
         

        
        }

       
       

        

        private void button2_Click(object sender, EventArgs e)
        {
            FirmalariGoruntule firmalariGoruntule=new FirmalariGoruntule();
            //firmalariGoruntule.Owner = this;
            firmalariGoruntule.Show();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //.listBox1.Items.Add(txtveri.Text);
        }

        public void txtveri_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
