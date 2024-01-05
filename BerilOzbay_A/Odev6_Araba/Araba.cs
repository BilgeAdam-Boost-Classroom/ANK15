using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev6_Araba
{
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public string UretimYili { get; set; }
        public string OzellikleriYaz()
        {
            string text = $"Markası: {Marka}\nModel:{Model}\nRengi: {Renk}\nUretim Yılı: {UretimYili}";
            return text;
        }
    }
}
