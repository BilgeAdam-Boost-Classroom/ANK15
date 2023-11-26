using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24_11_2023.Siniflar
{
    public static class Ucgen
    {

        public static double IstediginKadarSayo(params double[] numbers)
        {

            return numbers.Average()*3;
        }
    }
}
