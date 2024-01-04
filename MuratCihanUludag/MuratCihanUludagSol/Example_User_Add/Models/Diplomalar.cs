using System;
using System.Collections.Generic;

namespace Example_User_Add.Models;

public partial class Diplomalar
{
    public int Id { get; set; }

    public int No { get; set; }

    public DateOnly Tarih { get; set; }

    public virtual Ogrenciler? Ogrenciler { get; set; }
}
