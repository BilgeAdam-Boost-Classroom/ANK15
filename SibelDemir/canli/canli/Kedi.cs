using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canli
{
    internal class Kedi:Canli
    {
        public Kedi(string ad, int yas) : base(ad, yas)
        {
        }

        public override void SesCikar()
        {
            Console.WriteLine("Miyav!");
        }
    }
}
