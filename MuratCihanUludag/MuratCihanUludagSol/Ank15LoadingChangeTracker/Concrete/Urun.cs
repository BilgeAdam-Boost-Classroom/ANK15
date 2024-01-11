using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank15LoadingChangeTracker.Concrete
{
    public class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LisansId { get; set; }
        public virtual Lisans Lisans { get; set; }
        public int BandrolId { get; set; }
        public virtual Bandrol Bandrol { get; set; }
    }
}
