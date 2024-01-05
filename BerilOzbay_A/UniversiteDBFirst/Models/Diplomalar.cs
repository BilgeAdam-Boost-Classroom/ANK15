using System;
using System.Collections.Generic;

namespace UniversiteDBFirst.Models
{
    public partial class Diplomalar
    {
        public int Id { get; set; }
        public int No { get; set; }
        public DateTime Tarih { get; set; }

        public virtual Ogrenciler? Ogrenciler { get; set; }
    }
}
