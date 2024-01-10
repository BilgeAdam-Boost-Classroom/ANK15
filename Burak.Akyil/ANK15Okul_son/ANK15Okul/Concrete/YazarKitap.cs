using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15Okul.Concrete
{
    public class YazarKitap
    {
        public int Id { get; set; }
        public Yazar Yazar { get; set; }
        public int Author { get; set; }
        public Kitap Kitap { get; set; }
        public int Book { get; set; }
    }
}
