using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4
{
    public class Kedi : Canli
    {
        public Kedi(string ad, int yas) : base(ad, yas) { }
        
        public override void SesCikar()
        {
            Console.WriteLine("Miyav!");
        }
    }
}
