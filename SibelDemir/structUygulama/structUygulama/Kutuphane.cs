using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structUygulama
{
    public struct Kutuphane
    {
        public List<string>Kitaplar {  get; set; }

        public string Ad {  get; set; }

        public int Alan;//field

        public void KitapOduncVer()
        {
            Console.WriteLine("kitaplar ödünç veriliyor..");
        }
    }
}
