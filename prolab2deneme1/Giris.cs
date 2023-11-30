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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void AdminPaneli_Click(object sender, EventArgs e)
        {
            AdminPaneli adminPaneli = new AdminPaneli();
            adminPaneli.Show();

        }
    }
}
