using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    internal class Insan : Tur
    {
        public override void FamilyaGoster()
        {
            Console.WriteLine("İnsan sinifindan gelen Familya:" + Familya);
        }

        public override void TurGoster()
        {
            Console.WriteLine("İnsan sinifinden gelen Tur:" + CanliTuru);
        }
    }
}
