using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekil.Okul
{
    internal class Akademisyen : Kisi
    {
        public List<string> Makale { get; set; } = new List<string>();
        public string MakaleGoster()
        {
            if (Makale.Count > 0)
            {
                return string.Join(Environment.NewLine, Makale);
            }else
            {
                return "Makale bulunmamaktadir";

            }
        }
        public void MakaleEkle(List<string> makale)
        {
            Makale.AddRange(makale);
        }
    }
}
