using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    public class Kütüphane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<KütüphaneKitap> KütüphaneKitap { get; set; }
    }
}
