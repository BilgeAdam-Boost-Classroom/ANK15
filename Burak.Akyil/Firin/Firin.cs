using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirinSatıs
{
    public class Firin
    {
        public string Marka { get; set; }
        public double Fiyat { get; set; }
        public string Guc { get; set; }
        public string Model { get; set; }
        public int GarantiSuresi { get; set; }
        public bool GarantiVarMi { get; set; }
        public int MaksimumDerece { get; set; }
        public Firin()
        {
            Console.WriteLine("Fırın nesnesi oluşturuluyor.");
        }
        public Firin(string marka, string model, bool garantiVarMi)
        {
            Marka = marka;
            Model = model;
            GarantiVarMi = garantiVarMi;
            if (garantiVarMi == true)
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
