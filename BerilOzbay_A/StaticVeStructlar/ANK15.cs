using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVeStructlar
{
    public static class ANK15
    {
        public static int Nufus { get; set; }
        public static double Ucgen(params double[] numbers)
        {
            double ort = 0;
            double toplam = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                toplam += numbers[i];

            }
            ort = toplam / numbers.Length;
            return ort * 3;
        }

        public static int Kare(int sayi1, int sayi2)
        {
            return sayi1 * 2 + sayi2 + 2;
        }

        public static string Daire(string text)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(text);

            if (text.EndsWith('y'))
            {
                sb.Remove(text.Length - 1,1).Append("ies");
            }

            else if (!text.EndsWith('s'))
            {
                sb.Append('s');
            }
            else
            {
                sb.Append("es");
            }

            return sb.ToString();

        }
    }
}
