using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firinÖzellikler
{
    internal class firin
    {
       
        public string Marka { get; set; }
        public double Fiyat { get; set; }
        public string Guc { get; set; }
        public string Model { get; set; }
        public int GarantiSuresi { get; set; }
        public bool GarantiVarMi { get; set; }
        public int MaksimumDerece { get; set; }
        public firin()
        {
            Console.WriteLine("Fırın nesnesi oluşturuluyor");
        }

        public firin(string marka, string model, bool garantiVarMı)
        {
            Marka = marka;
            Model = model;
            GarantiVarMi = garantiVarMı;
            if (GarantiVarMi)
            {
                Console.WriteLine("Garantisi vardır.");
            }
            else
            {
                Console.WriteLine("Garantisi yoktur.");
            }
        }
        public void GarantiUzat(int uzatilanSure)
        {
            GarantiSuresi += uzatilanSure;
        }
    }
}
