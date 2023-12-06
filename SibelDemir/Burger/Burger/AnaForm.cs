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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Burger
{
    public partial class AnaForm : Form
    {
        List<Malzeme> malzemeList = new List<Malzeme>();
        List<MenuEkle>menuler=new List<MenuEkle>();
        List<Siparis>siparisler = new List<Siparis>();
        
        public void BaslangicMenuler()
        {
            MenuEkle menu1 = new MenuEkle();
            menu1.MenuName = "BigKing Menu";
            menu1.Price = 100;
            menuler.Add(menu1);


            MenuEkle menu2 = new MenuEkle();
            menu2.MenuName = "CheeseBurger Menu";
            menu2.Price = 100;
            menuler.Add(menu2 );


            MenuEkle menu3 = new MenuEkle();
            menu3.MenuName = "King Menu";
            menu3.Price = 100;
            menuler.Add(menu3 );


            MenuEkle menu4 = new MenuEkle();
            menu4.MenuName = "Chicken Menu";
            menu4.Price = 100;
            menuler.Add(menu4 );

            
        }


        public void BaslangicMalzemleri()
        {
            Malzeme bbq = new Malzeme();
            bbq.Ad = "BBQ";
            bbq.Fiyat = 5;
            malzemeList.Add(bbq);


            Malzeme buffalo = new Malzeme();
            buffalo.Ad = "Buffalo";
            buffalo.Fiyat = 5;
            malzemeList.Add(buffalo);


            Malzeme hardal = new Malzeme();
            hardal.Ad = "Hardal";
            hardal.Fiyat = 5;
            malzemeList.Add(hardal);


            Malzeme ketchup = new Malzeme();
            ketchup.Ad = "Ketchup";
            ketchup.Fiyat = 5;
            malzemeList.Add(ketchup);

            Malzeme mayonez = new Malzeme();
            mayonez.Ad = "Mayonez";
            mayonez.Fiyat = 5;
            malzemeList.Add(mayonez);

            Malzeme ranch = new Malzeme();
            ranch.Ad = "Ranch";
            ranch.Fiyat = 5;
            malzemeList.Add(ranch);
        }

         

        public AnaForm()
        {
            InitializeComponent();
            BaslangicMalzemleri();
            BaslangicMenuler();//deneme
        }
        private void FormGoster(Form gosterilecekForm)
        {
            gosterilecekForm.StartPosition = 0;//hep aynı konumda açılması için form.
            if (!MdiChildren.Contains(gosterilecekForm))
            {
                gosterilecekForm.MdiParent = this;
            }
            //bu form çocukları içerisinde dönelim. İstenileni görünür yapalım.
            foreach (Form altForm in MdiChildren)
            {
                if (gosterilecekForm.Text == altForm.Text)
                {
                    altForm.Show();
                }
                else
                {
                    altForm.Close();
                }
            }
        }
        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new EkstraMalzemeEkleme(malzemeList));
        }

        private void siparisOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisEkleme(menuler));
        }

        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisBilgileri(siparisler));
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new MenuEkleme(malzemeList,menuler,siparisler));
        }
    }
}
