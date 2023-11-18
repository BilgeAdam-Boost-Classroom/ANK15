using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firinÖzellikler
{
    internal class Musteri
    {
        private long _tc;

        public long TC
        {
            get { return _tc; }
            set
            {
                if (value.ToString().Length == 11)
                {
                    _tc = value;
                }
                else
                {
                    Console.WriteLine("TC numarası 11 haneli olmalı!");
                    _tc = 0;
                }
                
            }
        }

    }
}
