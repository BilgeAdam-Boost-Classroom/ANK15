using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev6_Kitap
{
    public class BaseKitap
    {
        public virtual void GetLog()
        {
            Console.WriteLine("BaseKitap get log...");
        }

        public virtual void GetUser()
        {
            Console.WriteLine("BaseKitap get user...");
        }
    }
}
