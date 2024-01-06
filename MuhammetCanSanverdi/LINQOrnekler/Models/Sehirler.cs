using System;
using System.Collections.Generic;

namespace LINQOrnekler.Models
{
    public partial class Sehirler
    {
        public Sehirler()
        {
            Subelers = new HashSet<Subeler>();
        }

        public int Id { get; set; }
        public string SehirAd { get; set; } = null!;

        public virtual ICollection<Subeler> Subelers { get; set; }
    }
}
