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
            lblCiro.Text = string.Format(new CultureInfo("tr-TR"), "{0:C}", 0.00);
            lblToplamSiparis.Text = "0";
            lblEkstraMalzeme.Text = string.Format(new CultureInfo("tr-TR"), "{0:C}", 0.00);
            lblSatılamUrun.Text = "0";
            
        }
        

    }
}
