using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_oop.Model
{
    internal class HesapTrigo
    {
        private int _aci;
        public int Aci
        {
            get
            {
                return _aci;
            }
            set
            {
                if (value >= 0 && value <= 360)
                    _aci = value;
                else
                    throw new Exception("Deger 0 ile 360 derece arasinda olamlidir");
            }
        }
    }
}
