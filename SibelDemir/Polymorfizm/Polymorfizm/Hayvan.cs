﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizm
{
    public class Hayvan
    {
        public string Isim { get; set; }
        public int Yas { get; set; }

        public virtual void Kos() 
        {
            Console.WriteLine("hayvan koşuyor");
        }
    }
}
