using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_2
{
    internal class Canta
    {
        private double hacim;
        private double agirlik;
        public double Hacim 
        {
            get { return hacim; }
            set
            {
                if ( value > 0)
                {
                    hacim = value;
                }
                else
                {
                    Console.WriteLine("Hacim sıfırdan büyük olamlıdır.");
                }
            } 
        }
        public double Agirlik
        {
            get { return agirlik; }
            set
            {
                if ( value > 0)
                {
                    agirlik = value;
                }
                else
                {
                    Console.WriteLine("Ağırlık sıfırdan büyük olmalıdır.");
                }
            }
        }
    }
}
