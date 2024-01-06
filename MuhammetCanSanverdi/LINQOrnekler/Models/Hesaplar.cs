using System;
using System.Collections.Generic;

namespace LINQOrnekler.Models
{
    public partial class Hesaplar
    {
        public int Id { get; set; }
        public int HesapNo { get; set; }
        public int? MusteriId { get; set; }

        public virtual Musteriler? Musteri { get; set; }
    }
}
