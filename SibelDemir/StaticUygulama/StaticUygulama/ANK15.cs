using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticUygulama
{
    public static class ANK15
    {
        public static int Nufus { get; set; }
        public static double ucgen(params int[] sayilar)
        {
            int toplam = 0;

            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }

            double ortalama = (double)toplam / sayilar.Length;

            return 3 * ortalama;
        }
        public static int Kare(int sayi1, int sayi2)
        {
            int toplam = (sayi1 * 2) + (sayi2 + 2);

            return toplam;
        }

        public static string Daire(string kelime)
        {
            if (kelime.EndsWith("s") || kelime.EndsWith("x") || kelime.EndsWith("z") ||
                (kelime.EndsWith("y") ))
            {
                return kelime + "es";
            }
            else if (kelime.EndsWith("y"))
            {
                return kelime.Substring(0, kelime.Length - 1) + "ies";
            }
            else
            {
                return kelime + "s";
            }
        }

       
    }
}