using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPersonel
{
    public class Calisan
    {
        public string Ad { get; set; }
        public Bolum Bolum { get; set; }
        public override string ToString()
        {
            return Ad;
        }
    }
}
