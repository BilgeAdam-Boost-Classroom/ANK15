using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurgerMenu.Classes;

namespace BurgerMenu
{
    public partial class MenuEkleme : Form
    {
        public MenuEkleme()
        {
            InitializeComponent();
            
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Ad = txtMenuAdi.Text;
            menu.Fiyat = Convert.ToDecimal(nudMenuFiyat.Value);
            SiparisEkleme.menuList.Add(menu);

        }
    }
}
