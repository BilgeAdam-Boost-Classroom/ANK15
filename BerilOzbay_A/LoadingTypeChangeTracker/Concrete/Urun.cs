using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingTypeChangeTracker.Concrete
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int LisansId { get; set; }
        public virtual Lisans Lisans { get; set; }
    }
}
