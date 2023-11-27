using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev7_2
{
    public class Kitap : BaseKitap
    {
        public override void GetLog()
        {
            Console.WriteLine("Kitap get log...");
        }
        public sealed override void GetUser()
        {
            Console.WriteLine("Kitap get user...");
        }
    }
}
