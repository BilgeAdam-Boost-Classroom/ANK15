using Burger.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burger
{
    public partial class SiparisBilgileri : Form
    {
        List<Siparis> siparisler;
        public SiparisBilgileri(List<Siparis> siparisler)
        {
            InitializeComponent();
            this.siparisler = siparisler;
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            int toplamsatilanadet = 0;
            decimal ekstrageliri = 0;
            decimal ciro = 0;

            foreach (var item in siparisler)
            {
                listBox1.Items.Add(item.ToString());

                toplamsatilanadet += item.Adet;
                ciro += item.ToplamTutar;
                foreach (var item1 in item.Malzemeler)
                {
                    ekstrageliri += item1.Fiyat;
                }


            }
            lblSatılanAdet.Text = toplamsatilanadet.ToString();
            lblToplamSiparisSayisi.Text = siparisler.Count.ToString();
            lblEkstraGeliri.Text = ekstrageliri.ToString();
            lblCiro.Text = ciro.ToString();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
