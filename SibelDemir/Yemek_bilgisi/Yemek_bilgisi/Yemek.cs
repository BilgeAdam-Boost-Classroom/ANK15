using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek_bilgisi
{
    public abstract class Yemek
    {

        public Yemek()
        {
            Console.WriteLine("Yemek yapıcısı");
        }

        public bool DiyetMi { get; set; }

        public double SosMiktari { get; set; }


        //Kesinlikle miras alan sınıfta EZMEK ZORUNDAYIZ ÇÜNKÜ SOYUT METOD !!!!!!!!
        public abstract void YemekHazirlan();


        //isternirse abstract sınıftaki absctract olmayan metod da ezilebilir. (Ana sınıfta virtual, miras alanda override yazılarak)
        public virtual void Sunul()
        {
            Console.WriteLine("Servis ediliyor...");
        }
    }
}
