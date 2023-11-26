using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_A_6
{
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public string UretimYili { get; set; }
   
        public override string ToString()
        {
            return $"{Marka} {Model}";
        }
        public string OzellikleriYaz()
        {
            return $"{Marka} {Model} {Renk} {UretimYili}";
        }
    }
}
