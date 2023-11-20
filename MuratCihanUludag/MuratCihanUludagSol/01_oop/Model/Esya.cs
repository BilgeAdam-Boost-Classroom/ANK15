using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_oop.Model
{
    internal class Esya
    {
        private int _fiyat;
        public int Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (value < 0)
                    _fiyat = 0;
                else if (value > 5)
                    _fiyat = 5;
                else
                    _fiyat = value;
            }
        }
    }
}
