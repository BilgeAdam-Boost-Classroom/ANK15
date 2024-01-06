using System;
using System.Collections.Generic;

namespace LINQOrnekler.Models
{
    public partial class Subeler
    {
        public int SubeId { get; set; }
        public int SubeNo { get; set; }
        public int? SehirId { get; set; }

        public virtual Sehirler? Sehir { get; set; }
    }
}
