using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerMenu
{
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
            decimal toplamCiro = 0;
            foreach (var item in SiparisEkleme.siparisler)
            {
                if (item.OnaylandiMi)
                    toplamCiro += item.ToplamTutar;
            }
            lblCiro.Text = "₺" + toplamCiro.ToString();
            foreach (var item in SiparisEkleme.siparisler)
            {
                if (item.OnaylandiMi)
                    lbxSonuc.Items.Add(item);
            }

            
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            lblToplamSiparis.Text = SiparisEkleme.siparisler.Count.ToString();
            lblSatılanUrun.Text = SiparisEkleme.siparisler.Where(s => s.OnaylandiMi).Sum(s => s.Adet).ToString();
            decimal ekstraMalzemeGeliri = 0;
            foreach (var item in SiparisEkleme.siparisler.Where(s => s.OnaylandiMi))
            {
                foreach (var item2 in item.ekstraMalzemeler)
                {
                    ekstraMalzemeGeliri += item2.Fiyat;
                    lblEkstraMalzeme.Text = "₺" + ekstraMalzemeGeliri.ToString();
                }
            }
        }
    }
}
