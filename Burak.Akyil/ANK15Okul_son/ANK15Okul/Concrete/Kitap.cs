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
    }
}
