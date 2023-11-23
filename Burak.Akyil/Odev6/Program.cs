namespace Odev6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorluTasit tasit = new MotorluTasit();
            tasit.Git();
            Araba araba = new Araba();
            araba.Git();
            MotorluTasit tasit2 = new Araba();
            tasit2.Git();
        }
    }
}