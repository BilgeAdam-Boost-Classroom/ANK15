﻿using System;
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




            
        }



    }
}
