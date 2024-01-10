using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15Okul.Concrete
{
    public class Yazar
    {
        public int Id { get; set; }
        public List<YazarKitap> YazarKitaplar { get; set; }
    }
}
