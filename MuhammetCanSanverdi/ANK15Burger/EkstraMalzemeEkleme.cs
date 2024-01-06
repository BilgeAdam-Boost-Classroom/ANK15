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
    public partial class EkstraMalzemeEkleme : Form
    {
        public EkstraMalzemeEkleme()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMalzemeAdd_Click(object sender, EventArgs e)
        {
            Field.EkstraMalzemeler.Add(new() 
            {
                Ad=txtbxExMalzemeAd.Text,
                Fiyat =numUDExMalzemePrice.Value
            });
        }
    }
}
