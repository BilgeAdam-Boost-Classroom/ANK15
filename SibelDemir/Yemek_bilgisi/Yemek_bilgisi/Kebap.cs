using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek_bilgisi
{
    public class Kebap:Yemek
    {
        public override void YemekHazirlan()
        {
            Console.WriteLine("ızgarada");
        }
        public override void Sunul()
        {
            Console.WriteLine("Dürümde");
        }
    }
}
