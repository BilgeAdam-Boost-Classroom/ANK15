namespace Odev5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorluTasit motorluTasit = new MotorluTasit();
            
            MotorluTasit tasit = new Araba();

            Araba araba = new Araba();

            motorluTasit.Git();
            
            tasit.Git();

            araba.Git();
        }
    }
}