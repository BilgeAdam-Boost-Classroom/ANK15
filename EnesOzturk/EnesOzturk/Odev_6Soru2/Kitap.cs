using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_6Soru2
{
    public class Kitap:BaseKitap
    {
        public override void GetLog()
        {
            Console.WriteLine("kitap getlog");
        }
        public sealed override void GetUser()
        {
            Console.WriteLine("kitap get user");
        }
    }
}
