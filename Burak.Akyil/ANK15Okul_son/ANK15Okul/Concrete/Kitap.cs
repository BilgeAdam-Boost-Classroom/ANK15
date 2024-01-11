using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15Okul.Concrete
{
    public class Kitap
    {
        public int Id { get; set; }
        public List<YazarKitap> KitapYazarlar { get; set; }
        public List<KutuphaneKitap> kutuphaneKitaplar { get; set; }
        public Bandrol Bandrol { get; set; }
        public int BandrolNo { get; set; }
        public YayinEvi YayinEvi { get; set; }
        public int YayinEviNo { get; set; }
    }
}
