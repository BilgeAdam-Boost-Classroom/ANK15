using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_bilgisi
{
    internal class Insan:Tur
    {
        public override void FamilyaGoster()
        {
            Console.WriteLine("Hominidae");
        }
        public override void TurGoster()
        {
            base.TurGoster();
            Console.WriteLine("Homo sapiens");
        }
    }
}
