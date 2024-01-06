using ANK15Burger.Entity.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANK15Burger
{
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            decimal malzemeUcreti = 0;
            Field.Siparisler.ForEach(s => s.EkstraMalzemeler.ForEach(e => malzemeUcreti +=e.Fiyat));
            lblCiro.Text = Field.Siparisler.Sum(s => s.Fiyat).ToString();
            lblMalzemeGeliri.Text = malzemeUcreti.ToString();
            lblTotalSiparis.Text = Field.Siparisler.Count.ToString();
            lblÜrünAdedi.Text = Field.Siparisler.Sum(s=>s.Adet).ToString();
            foreach (var item in Field.Siparisler)
            {
                listBox1.Items.Add(item);
            }
            
        }
    }
}
