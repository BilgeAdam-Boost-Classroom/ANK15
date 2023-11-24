using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class Ank15
    {
        public static string Nufus { get; set; }
        public static double Ucgen(params int[] sayilar)
        {
            double toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
                toplam += sayilar[i];
            return (toplam/sayilar.Length) * 3; 
        }
        public static double Kare(double x, double y)
        {
            return (2 * x) + (y + 2);
        }
        public static string Daire(string kelime)
        {
            StringBuilder sb = new StringBuilder();
            
            if (kelime.EndsWith("y"))
            {
                sb.Append(kelime.Substring(0, kelime.Length - 1)).Append("ies");
            }
            else if (!kelime.EndsWith("s"))
            {
                sb.Append(kelime).Append("s");
            }
            else
            {
                sb.Append(kelime).Append("es");
            }
            return sb.ToString();
        }
    }
}
