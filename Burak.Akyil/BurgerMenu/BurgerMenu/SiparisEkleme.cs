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
        public static List<Siparis> siparisler = new List<Siparis>();
        public SiparisEkleme()
        {
            InitializeComponent();
            lblTutar.Text = "₺" + siparisler.Sum(s => s.ToplamTutar).ToString();
            cmbMenu.Items.AddRange(menuList.ToArray());
            clbSos.Items.AddRange(ekstraMalzemeler.ToArray());

            lbxSiparis.Items.AddRange(siparisler.ToArray());



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
            
            Siparis siparis = new Siparis();
            EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
            siparis.Ad = cmbMenu.SelectedItem.ToString();
            siparis.Adet = (int)nudAdet.Value;
            siparis.ToplamTutar = ((siparis.Adet * ((Menu)cmbMenu.SelectedItem).Fiyat));
            lblTutar.Text = siparis.ToplamTutar.ToString();
            for (int i = 0; i < clbSos.Items.Count; i++)
            {
                if (clbSos.GetItemChecked(i))
                {
                    siparis.ToplamTutar += ((EkstraMalzeme)(clbSos.Items[i])).Fiyat;
                    siparis.ekstraMalzemeler.Add((EkstraMalzeme)(clbSos.Items[i]));
                }
            }
            if (rdbKucuk.Checked == true)
            {
                siparis.Boyut = Boyut.Kucuk;
                siparis.ToplamTutar -= 20;
            }
            else if (rdbOrta.Checked == true)
            {
                siparis.Boyut = Boyut.Orta;
            }
            else
            {
                siparis.Boyut = Boyut.Buyuk;
                siparis.ToplamTutar += 20;
            }
            siparisler.Add(siparis);
            lbxSiparis.Items.Add(siparis);

            lblTutar.Text = "₺" + siparisler.Sum(s => s.ToplamTutar).ToString();
            
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            lbxSiparis.Items.Clear();
           
            foreach (var item in siparisler)
            {
                item.OnaylandiMi = true;
            }
            
        }
    }


}
