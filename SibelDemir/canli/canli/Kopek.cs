﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canli
{
    internal class Kopek:Canli
    {
        public Kopek(string ad, int yas) : base(ad, yas)
        {
        }

        public override void SesCikar()
        {
            Console.WriteLine("Hav hav!");
        }
    }
}
