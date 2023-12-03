using BurgerMenu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerMenu
{
    public partial class SiparisEkleme : Form
    {

        public SiparisEkleme()
        {
            InitializeComponent();
            lblTutar.Text = string.Format(new CultureInfo("tr-TR"), "TOPLAM TUTAR: {0:C}", 0.00);
            cmbMenu.Items.AddRange(menuList.ToArray());
            clbSos.Items.AddRange(ekstraMalzemeler.ToArray());

        }
        public static List<Menu> menuList = new List<Menu>()
        {
            new Menu {Ad = "Big King", Fiyat = 200},
            new Menu {Ad = "Whopper", Fiyat = 200},
            new Menu {Ad = "Chicken Royal", Fiyat = 150},
            new Menu {Ad = "King Chicken", Fiyat = 150}
        };
        public static List<EkstraMalzeme> ekstraMalzemeler = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme {Ad = "Ketçap", Fiyat = 4},
            new EkstraMalzeme {Ad = "Mayonez", Fiyat = 4},
            new EkstraMalzeme {Ad = "Buffalo", Fiyat = 6},
            new EkstraMalzeme {Ad = "BBQ", Fiyat = 6},
            new EkstraMalzeme {Ad = "Hardal", Fiyat = 5},
            new EkstraMalzeme {Ad = "Ranch", Fiyat = 5},
        };

        private void btnSipraisEkle_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Siparis siparis = new Siparis();
            siparis.Ad = cmbMenu.SelectedItem.ToString();
            siparis.Adet = (int)nudAdet.Value;
            siparis.ToplamTutar = (decimal)(siparis.Adet *((Menu)cmbMenu.SelectedItem).Fiyat);
            lblTutar.Text = siparis.ToplamTutar.ToString();
            if (rdbKucuk.Checked)
            {
                siparis.Boyut = Boyut.Kucuk;
            }
            else if (rdbOrta.Checked)
            {
                siparis.Boyut = Boyut.Orta;
            }
            else
            {
                siparis.Boyut = Boyut.Buyuk;
            }
        }
    }


}
