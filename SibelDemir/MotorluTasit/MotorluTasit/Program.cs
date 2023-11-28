namespace MotorluTasit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorluTasit motorluTasit = new MotorluTasit();
            motorluTasit.Git();

            Araba araba = new Araba();
            araba.Git();

            MotorluTasit nesne1 = new MotorluTasit();
            MotorluTasit nesne2 = new Araba();

            nesne1.Git();
            nesne2.Git();
        }
    }
}