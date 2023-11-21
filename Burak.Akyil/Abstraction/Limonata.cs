using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Limonata : IIcecek
    {
        public double Fiyat { get ; set ; }
        public double Kalori { get ; set ; }
        public bool AsitliMi { get ; set ; }

        public void Hazirlan()
        {
            
        }
    }
}
