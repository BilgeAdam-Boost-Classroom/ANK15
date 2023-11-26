using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_23_11_2023
{
    public class Calisan
    {
        public string FullName { get; set; }
        public Birimler Birimler { get; set; }
        public override string ToString()
        {
            return $"{FullName} {Birimler}";
        }
    }
}
