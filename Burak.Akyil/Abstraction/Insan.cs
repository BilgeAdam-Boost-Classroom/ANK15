using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Insan : Tur
    {
        public override void FamilyaGoster()
        {
            Console.WriteLine(Familya);
        }
        public override void TurGoster()
        {
            Console.WriteLine("Canlı Türü: " + CanliTuru);
        }
    }
}
