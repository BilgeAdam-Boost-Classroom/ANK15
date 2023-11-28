using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap
{
    public class TuremisKitap:Kitap
    {
        public sealed override void GetLog()
        {
            base.GetLog(); 
            Console.WriteLine("BaseKitap Get log..." );
        }
        public  override void GetUser()
        {
            base.GetUser();
            Console.WriteLine("BaseKitap get user...");
        }
    }
}
