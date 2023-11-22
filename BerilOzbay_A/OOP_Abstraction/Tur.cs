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
        //virtual ile tanımlanmıs metotların alt sınıflar tarafından ezilmek zorunda değildir.
        public virtual void TurGoster()
        {
            Console.WriteLine("Tur sinifindan gelen Canli Turu:"+ CanliTuru);
        }
        public void AileGoster()
        {
            Console.WriteLine("Tur sinifindan gelen Aile:" + Aile);
        }

        // abstract bir metot alt sınıf tarafından miras alındıktan sonra ezilir.
        public abstract void FamilyaGoster();
    }
}
