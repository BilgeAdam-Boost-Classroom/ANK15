using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeUygulamasi
{
    internal struct Milk : IExtra
    {
        public decimal Price => 2m;

        public TimeSpan PrepTime => TimeSpan.FromSeconds(2);
    }
}
