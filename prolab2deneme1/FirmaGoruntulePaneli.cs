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
    public partial class FirmaGoruntulePaneli : Form
    {
        public FirmaGoruntulePaneli()
        {
            InitializeComponent();
        }

        firmalariSakla _firmalariSakla = new firmalariSakla();
        private void FirmaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FirmaGoruntulePaneli_Load(object sender, EventArgs e)
        {
            FirmaListesi.Items.Add(_firmalariSakla.list[0]);
            FirmaListesi.Items.Add(_firmalariSakla.list[1]);
            FirmaListesi.Items.Add(_firmalariSakla.list[2]);
            FirmaListesi.Items.Add(_firmalariSakla.list[3]);
            FirmaListesi.Items.Add(_firmalariSakla.list[4]);
        }
    }
}
