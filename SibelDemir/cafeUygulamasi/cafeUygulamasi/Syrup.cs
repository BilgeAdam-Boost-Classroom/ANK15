using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeUygulamasi
{
    internal struct Syrup : IExtra
    {
        public decimal Price =>3m ;

        public TimeSpan PrepTime =>TimeSpan.FromSeconds(2) ;
    }
}
