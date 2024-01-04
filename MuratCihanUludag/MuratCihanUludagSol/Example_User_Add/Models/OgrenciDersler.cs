using System;
using System.Collections.Generic;

namespace Example_User_Add.Models;

public partial class OgrenciDersler
{
    public int OgrenciId { get; set; }

    public int DersId { get; set; }

    public int Not { get; set; }

    public virtual Dersler Ders { get; set; } = null!;

    public virtual Ogrenciler Ogrenci { get; set; } = null!;
}
