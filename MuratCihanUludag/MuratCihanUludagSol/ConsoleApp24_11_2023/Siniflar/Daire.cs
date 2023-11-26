using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24_11_2023.Siniflar
{
     public static class Daire
    {
        public static string Kelime( string kelime)
        {
            StringBuilder sb = new StringBuilder();
            if (kelime.EndsWith("s"))
            {
                sb.Append(kelime).Append("es");                
            }else if (kelime.EndsWith("y"))
            {
                sb.Append(kelime.Substring(0,kelime.Length - 1)).Append("ies");
            }
            else
            {
                sb.Append(kelime).Append("s");
            }
            return sb.ToString();   
        }
    }
}
