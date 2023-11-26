using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_6
{
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public string UretimYili { get; set; }

        public string OzellikleriYaz()
        {
            return $"Markası: {Marka} Model: {Model} Renk:{Renk} Uretim yılı:{UretimYili}";
        }
    }
}
