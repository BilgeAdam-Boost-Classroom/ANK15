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
    public partial class EkstraMalzemeEkleme : Form
    {
        List<Malzeme> malzemeList;
        public EkstraMalzemeEkleme(List<Malzeme> malzemeList)
        {
            InitializeComponent();
            this.malzemeList = malzemeList;

        }

      

        private void btnMalzemeKaydet_Click(object sender, EventArgs e)
        {
            Malzeme yeniMalzeme = new Malzeme();
            yeniMalzeme.Ad = textMalzemeAdi.Text;
            yeniMalzeme.Fiyat = numericUpDown1.Value;
            malzemeList.Add(yeniMalzeme);
        }
    }
}
