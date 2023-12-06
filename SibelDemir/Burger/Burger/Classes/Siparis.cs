using Burger.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Burger.Classes
{
    public class Siparis:MenuEkle
    {
        public MenuEkle Menu { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public List<Malzeme> Malzemeler { get; set; }

        public override string ToString()
        {
            string malzemeler="";
            foreach (var item in Malzemeler)
            {
                malzemeler += " " + item.Ad;
            }
            return "Menu: "+Menu.MenuName + " Adet: " + Adet + " Malzemler: " +malzemeler + " ToplamTutar: " + ToplamTutar;
        }
    }
}
