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
        public List<EkstraMalzeme> ekstraMalzemeler { get; set; } = new List<EkstraMalzeme>();
        public bool OnaylandiMi { get; set; }

        public override string ToString()
        {
            StringBuilder bilgi = new StringBuilder();
           
            bilgi.Append(Ad + " Adet: " + Adet + " Toplam Tutar: " + ToplamTutar.ToString());
            bilgi.Append("Ekstra Malzemeler: ");
            foreach (var item in ekstraMalzemeler)
            {
                bilgi.Append(item.Ad +  " Fiyat: " +  item.Fiyat.ToString());
            }
            return bilgi.ToString();
            
        }
    }
}
