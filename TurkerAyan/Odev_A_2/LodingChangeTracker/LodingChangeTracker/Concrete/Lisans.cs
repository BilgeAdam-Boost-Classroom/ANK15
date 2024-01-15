using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodingChangeTracker.Concrete
{
    public class Lisans
    {
        public int Id { get; set; }
        public string Numara { get; set; }
        public virtual Urun Urun { get; set; }

    }
}
