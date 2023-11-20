using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canta
{
    internal class Canta
    {
        private int _hacim;

        public int hacim
        {
            get { return _hacim; }
            set
            {
                if (value > 0)
                    _hacim = value;
                else
                    Console.WriteLine("Hacim pozitif bir değer olmalıdır.");
            }
        }
        private int _agirlik;
        public int agirlik
        {
            get { return _agirlik; }
            set
            {
                if (value > 0)
                    _agirlik = value;
                else
                    Console.WriteLine("Ağırlık pozitif bir değer olmalıdır.");
            }
        }

    }
}
