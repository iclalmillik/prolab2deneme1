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
    public partial class AdminPaneliİslemler : Form
    {
        public AdminPaneliİslemler()
        {
            InitializeComponent();
        }

        private void FirmaGorButton_Click(object sender, EventArgs e)
        {
            FirmaGoruntulePaneli firmagoruntule = new FirmaGoruntulePaneli();
            firmagoruntule.Show();
        }
    }
}
