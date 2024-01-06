using ANK15Burger.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15Burger.Entity.Constant
{
    public class Field
    {
        public static List<SiparisMenu> Siparisler { get; set; } = new();

        public static List<Menu> Menuler { get; set; } = new List<Menu>()
        {
            new ()
            {
                Ad="ChickenRoyale",Fiyat=105
            },
            new ()
            {
                Ad="BigMac",Fiyat=120
            },
            new()
            {
                Ad = "SmokedBeef",
                Fiyat = 140
            },
        };

        public static List<EkstraMalzeme> EkstraMalzemeler { get; set; } = new List<EkstraMalzeme>() 
        {
            new()
            {
                Ad="Ketçap",Fiyat=5
            },
            new()
            {
                Ad="Mayonez",Fiyat=6
            },
            new()
            {
                Ad="BBQ",Fiyat=7
            },
            new()
            {
                Ad="Ranch",Fiyat=8
            },
        };
        public static int[] Adetler = { 1,2,3,4,5,6,7,8,9,10};
    }
}
