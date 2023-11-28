using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Kasımuygulama1
{
    public class Malzeme
    {
        static Malzeme()
        {
            Console.WriteLine("Static yapıcı çalışıyor...");
        }
        public Malzeme()
        {
            Console.WriteLine("Normal yapıcı çalışıyor...");
        }
    }
}
