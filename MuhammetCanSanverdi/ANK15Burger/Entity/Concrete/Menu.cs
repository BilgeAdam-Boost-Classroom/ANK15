using ANK15Burger.Entity.Abstract;
using ANK15Burger.Entity.Concrete.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ANK15Burger.Entity.Concrete
{
    public class Menu : IEntity
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return Ad + "   " + Fiyat + " " + RegionInfo.CurrentRegion.CurrencySymbol;
        }
    }
    public class SiparisMenu : Menu
    {
        public Boyut Boyut { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }
        public int Adet { get; set; }

        public override string ToString()
        {
            return Adet+" Adet " +Ad + "   " + Fiyat + " " + RegionInfo.CurrentRegion.CurrencySymbol;
        }
    }
    public class EkstraMalzeme : IEntity
    {

        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return Ad + "   " + Fiyat+" "+RegionInfo.CurrentRegion.CurrencySymbol;
        }
    }

    public class Siparis:IEntity
    {
        public List<SiparisMenu> Menuler { get; set; }
        public decimal ToplamFiyat { get; set; }
    }
}
