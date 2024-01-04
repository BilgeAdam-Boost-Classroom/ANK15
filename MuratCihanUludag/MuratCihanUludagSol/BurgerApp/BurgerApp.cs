using BurgerApp.Entity.Solids;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerApp
{
    public partial class BurgerApp : Form
    {
        public BurgerApp()
        {
            InitializeComponent();
            MenuAdd();
        }
        private void MenuAdd()
        {
            MenuList.BurgerList.AddRange(new Menu[]
         {
                new Menu("Whopper Menü", 200),
                new Menu("Tavuklu Barbekü Menü", 170),
                new Menu("Texas SmokeHouse Menü", 230),
                new Menu("Klasis Gurme Menü", 190),
                new Menu("Big King", 180),
                new Menu("ChesseBurger", 175),
                new Menu("King Chicken", 160),
         });

            ExtraMetarials.ExtraMalzemeler.Add("Ketcap", 1.5);
            ExtraMetarials.ExtraMalzemeler.Add("Mayonez", 1.5);
            ExtraMetarials.ExtraMalzemeler.Add("Hardal", 2);
            ExtraMetarials.ExtraMalzemeler.Add("Ranch", 3);
            ExtraMetarials.ExtraMalzemeler.Add("BBQ", 2.5);
        }
        private void OpenForm(Form showForm)
        {
            showForm.StartPosition = 0;

            if (!MdiChildren.Contains(showForm))
                showForm.MdiParent = this;

            //bu form cocuklari icerisinde doneli. Istenileni gorunur yapalim.
            foreach (Form childrenForm in MdiChildren)
            {
                if (showForm.Text == childrenForm.Text)
                    childrenForm.Show();
                else
                    childrenForm.Close();
            }
        }

        private void siparisOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new SiparisEkle());

        }

        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new SiparisBilgileri());
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new MenuEkleme());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new EkstraMelzemeEkleme());
        }

        private void BurgerApp_Load(object sender, EventArgs e)
        {

        }
    }
}
