using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    internal abstract class Tur
    {
        public string Familya { get; set; }
        public string Aile { get; set; }
        public string CanliTuru { get; set; }
        public virtual void TurGoster()
        {
            Console.WriteLine("Tur sinifindan gelen Canli Turu:"+ CanliTuru);
        }
        public void AileGoster()
        {
            Console.WriteLine("Tur sinifindan gelen Aile:" + Aile);
        }
        public abstract void FamilyaGoster();
    }
}
