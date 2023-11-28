using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArabaFom
{
    public class Araba
    {
        public string Marka { get; set; }

        public string Model { get; set; }

        public string Renk { get; set; }
        public string UretimYili { get; set; }

        public string OzellikleriYaz()
        {
            return $"Markası: {Marka} \nModel: {Model} \nRenk:{Renk} \nUretim yılı:{UretimYili}";
        }
    }
}
