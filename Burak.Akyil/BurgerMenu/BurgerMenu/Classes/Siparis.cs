using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMenu.Classes
{
    public class Siparis : Menu
    {
        public Menu Menu { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public static List<EkstraMalzeme> ekstraMalzemeler { get; set; }
    }
}
