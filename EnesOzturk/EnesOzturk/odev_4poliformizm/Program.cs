namespace odev_4poliformizm
{
    public class Program
    {
        static void Main(string[] args)
        {
         
            Araba araba = new Araba();
            araba.Git();
            MotorluTasit motorluTasit = new MotorluTasit();
            motorluTasit.Git();


            MotorluTasit motorlutasit = new Araba();
            motorluTasit.Git();


        }
    }
}