using Burger.Classes;
using Burger.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Burger
{
    public partial class MenuEkleme : Form
    {
        List<Malzeme> malzemeList;
        List<MenuEkle> menuler;
        List<Siparis> siparisler;
        public MenuEkleme(List<Malzeme> malzemeList,List<MenuEkle> menuler,List<Siparis> siparisler)
        {
            InitializeComponent();
            this.malzemeList = malzemeList;
            this.menuler = menuler;
            this.siparisler = siparisler;
        }
        
        private void MenuEkleme_Load(object sender, EventArgs e)
        {

            foreach (var item in malzemeList)
            {
                checkedListBox1.Items.Add(item.Ad);
            }

            foreach (var item in menuler)
            {
                cbxMenuSec.Items.Add(item);
                
            }

           
        }

        private void btnSiparişEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            List<Malzeme> secilenMalzemeler = new List<Malzeme>();
            foreach (var c in checkedListBox1.CheckedItems)
            {
                foreach (var m in malzemeList)
                {
                    if (c == m.Ad)
                    {
                        secilenMalzemeler.Add(m);
                        siparis.ToplamTutar += m.Fiyat;
                    }
                }
            }
            
            siparis.Menu = (MenuEkle)cbxMenuSec.SelectedItem;
            siparis.ToplamTutar += siparis.Menu.Price;
            siparis.Malzemeler = secilenMalzemeler;
            siparis.Adet = Convert.ToInt32(numericUpDown1.Value);
            if (rbtnOrta.Checked)
            {
                siparis.ToplamTutar += (decimal)Boyut.Medium;
            }
            else if (rbtnBuyuk.Checked)
            {
                siparis.ToplamTutar += (decimal)Boyut.Large;
            }
            siparis.ToplamTutar *= numericUpDown1.Value;


            lblTutar.Text = siparis.ToplamTutar.ToString();
            listBox1.Items.Add(siparis.ToString());

            siparisler.Add(siparis);

        }


    }
}
