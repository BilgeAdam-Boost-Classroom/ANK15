using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    public class Yazar
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public ICollection<YazarKitap> YazarKitap { get; set; }
    }
}
