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
    public partial class SiparisEkleme : Form
    {
        List<MenuEkle> menuler;
        public SiparisEkleme(List<MenuEkle> menuler)
        {
            InitializeComponent();
            this.menuler = menuler;
        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            MenuEkle yenimenuEkle = new MenuEkle();
            yenimenuEkle.Price= numericUpDown1.Value;
            yenimenuEkle.MenuName=textMenuAdi.Text;
            menuler.Add(yenimenuEkle);
        }
    }
}
