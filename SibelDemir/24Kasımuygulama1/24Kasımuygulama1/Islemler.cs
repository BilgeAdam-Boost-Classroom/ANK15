using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Kasımuygulama1
{
  public static class Islemler
    {
        public static int HesapNo { get; set; }
        public static double KarliSatis(double alisFiyati)
        {
            return alisFiyati * 1.25;
        }
    }
}
