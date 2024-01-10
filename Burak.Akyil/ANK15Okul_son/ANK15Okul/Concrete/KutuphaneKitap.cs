using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15Okul.Concrete
{
    public class KutuphaneKitap
    {
        public int Id { get; set; }
        public Kitap Kitap { get; set; }
        public int KitapNo { get; set; }
        public Kutuphane Kutuphane { get; set; }
        public int KutuphaneNo { get; set; }
    }
}
