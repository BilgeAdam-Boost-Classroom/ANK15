﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Kisi
    {
        public Kisi(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }

    }
}