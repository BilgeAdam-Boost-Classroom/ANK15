using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerMenu
{
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
            decimal toplamCiro = 0;
            foreach (var item in SiparisEkleme.siparisler)
            {


                if (item.OnaylandiMi)
                    toplamCiro += item.ToplamTutar;
            }
            lblCiro.Text = toplamCiro.ToString();
            
        }
        

    }
}
