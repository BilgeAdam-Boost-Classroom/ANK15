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
    public partial class MenuEkleme : Form
    {
        public MenuEkleme()
        {
            InitializeComponent();
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            Field.Menuler.Add(new() 
            {
                Ad = txtbxMenuAd.Text,
                Fiyat = numUDMenuPrice.Value
            }
            );
        }
    }
}
