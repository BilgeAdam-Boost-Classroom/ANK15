using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap
{
    public class BaseKitap
    {
        public virtual void GetLog()
        {
            Console.WriteLine("BaseKitap Get log...");
        }
        public virtual void GetUser() 
        {
            Console.WriteLine("BaseKitap get user...");
        }
    }
}
