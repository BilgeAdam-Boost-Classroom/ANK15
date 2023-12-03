using BurgerMenu.Classes;
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
    public partial class SiparisEkleme : Form
    {
        public SiparisEkleme()
        {
            InitializeComponent();
            lblTutar.Text = string.Format(new CultureInfo("tr-TR"), "TOPLAM TUTAR: {0:C}", 0.00);

            cmbMenu.Items.Add("Big King Menü");
            cmbMenu.Items.Add("Whopper Menü");
            cmbMenu.Items.Add("Chicken Royal Menü");

            clbSos.Items.Add("Ketçap");
            clbSos.Items.Add("Mayonez");
            clbSos.Items.Add("Hardal");
            clbSos.Items.Add("BBQ");
            clbSos.Items.Add("Ranch");
            clbSos.Items.Add("Buffalo");





        }

        private void btnSipraisEkle_Click(object sender, EventArgs e)
        {
            lbSiparis.Items.Add((string)cmbMenu.SelectedItem);
            

            
        }
    }
}
