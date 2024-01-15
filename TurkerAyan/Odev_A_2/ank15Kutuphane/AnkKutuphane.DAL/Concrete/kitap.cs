using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkKutuphane.DAL.Concrete
{
    public class kitap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Bandrol Bandrol { get; set; }
        public int Etiket { get; set; }
        public YayinEvi YayinEvi { get; set; }
        public int BasimYeri { get; set; }
        public List<Kutuphane> Kutuphanes { get; set; }
    }
}
