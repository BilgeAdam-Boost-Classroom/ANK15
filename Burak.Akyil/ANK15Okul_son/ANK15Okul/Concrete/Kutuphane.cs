using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15Okul.Concrete
{
    public class Kutuphane
    {
        public int Id { get; set; }
        public List<KutuphaneKitap> kutuphaneKitaplar { get; set; }
    }
}
