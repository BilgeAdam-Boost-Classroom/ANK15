using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_oop.Model
{
    internal class Firin
    {

        public Firin()
        {
            Console.WriteLine("Firin nesnesi olusturuluyor...");
        }
        public Firin(string marka, string model, bool garantiVarmi)
        {

            GarantiVarmi = garantiVarmi;
            Marka = marka;
            Model = model;
            if (garantiVarmi)
                Console.WriteLine("Garantisi var");
            else
                Console.WriteLine("Garantisi Yok");
        }
        ~Firin()
        {
            Console.WriteLine("Firin nesnesi olusturuldu!");
        }
        public string Marka { get; set; }
        public double Fiyat { get; set; }
        public string Guc { get; set; }
        public string Model { get; set; }
        public int GarantiSuresi { get; set; }
        public bool GarantiVarmi { get; set; }
        public int MaksDerece { get; set; }
        public int GarantuUzat(int uzatilanSure)
        {
            return GarantiSuresi += uzatilanSure;
        }

    }
}
