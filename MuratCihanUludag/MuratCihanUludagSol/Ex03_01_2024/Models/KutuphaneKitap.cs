using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_01_2024.Models
{
    public class KutuphaneKitap
    {
        public int LiblaryNo { get; set; }
        public int BookNo { get; set; }
        public Kutuphane Kutuphane { get; set; }
        public Kitap Kitap { get; set; }
    }
}
