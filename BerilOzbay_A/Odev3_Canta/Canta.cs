using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_Canta
{
    internal class Canta
    {
        private double _hacim;
        private double _agırlık;

        public double Agırlık
        {
            get { return _agırlık; }
            set
            {
                if (value > 0)
                {
                    _agırlık = value;
                }
                else
                {
                    _agırlık = 0;
                }
            }
        }

        public double Hacim
        {
            get { return _hacim; }
            set
            {
                if (value > 0)
                {
                    _hacim = value;
                }
                else
                {
                    _hacim = 0;
                }
            }
        }
    }
}
