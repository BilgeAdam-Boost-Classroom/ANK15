using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap
{
    public class Kitap:BaseKitap
    {
        public override void GetLog()
        {
            Console.WriteLine("BaseKitap Get log...");
        }
        public sealed override void GetUser()
        {
            base.GetUser();
            Console.WriteLine("BaseKitap get user...");
        }
    }
}
