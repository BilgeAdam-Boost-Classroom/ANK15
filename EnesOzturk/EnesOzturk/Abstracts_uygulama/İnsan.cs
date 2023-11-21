using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts_uygulama
{
    public class İnsan : Tur
    {
        public override void FamilyaGoster()
        {
            Console.WriteLine("familya ");
        }
        public override void CanliTuruGoster()
        {
            Console.WriteLine("canlı türü");
        }
    }
}
