﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm_gorev
{
    public class Hayvan
    {
        public int Isim { get; set; }
        public int Yas { get; set; }

        public virtual void Kos()
        {
            Console.WriteLine("hayvan koşuyor");
        }

    }
}
