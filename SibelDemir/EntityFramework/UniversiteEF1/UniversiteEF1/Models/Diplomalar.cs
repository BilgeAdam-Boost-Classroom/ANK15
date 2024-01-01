using System;
using System.Collections.Generic;

namespace UniversiteEF1.Models;

public partial class Diplomalar
{
    public int Id { get; set; }

    public int No { get; set; }

    public DateOnly Tarih { get; set; }

    public virtual Ogrenciler? Ogrenciler { get; set; }


}
