using BurgerMenu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerMenu
{
    public partial class EkstraMalzemeEkleme : Form
    {
        public EkstraMalzemeEkleme()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
            ekstraMalzeme.Ad = txtEkstraMalzeme.Text;
            ekstraMalzeme.Fiyat = Convert.ToDecimal(nudTutar);
            
        }
    }
}
