using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts_uygulama
{
    public abstract class Tur


    {




        public string Familya { get; set; }
               
        public string Aile { get; set; }
        public string CanliTuru { get; set; }

        public virtual void CanliTuruGoster() 
        {

            Console.WriteLine("canlı türü ");
            
        
        }
        public void AileGoster()
        {
            Console.WriteLine("aile");
        }
        public abstract void FamilyaGoster();

        public override string ToString()
        {
            return Familya + Aile + CanliTuru;
        }


    }
}
