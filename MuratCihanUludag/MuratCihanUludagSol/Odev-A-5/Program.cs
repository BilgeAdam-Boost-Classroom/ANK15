using Odev_A_5.Entity.Siniflar;

namespace Odev_A_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();  
            MotorluTasit motorluTasit = new MotorluTasit();
            MotorluTasit araba2 = new Araba();
            araba.Git();
            motorluTasit.Git(); 
            araba2.Git();   
        }
    }
}