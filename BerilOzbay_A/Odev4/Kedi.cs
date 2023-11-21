using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4
{
    internal class Kedi : Canli
    {
        public Kedi(string ad, string yas) : base(ad,yas)
        {
            
        }
        public override void SesCikar()
        {
            Console.WriteLine("Kedi");
        }
    }
}
