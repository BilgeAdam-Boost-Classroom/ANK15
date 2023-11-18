namespace Odev3_Calisan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan("Beril","Ozbay","Yazilim","A100",new DateTime(1997,06,26));
            Calisan calisan2 = new Calisan("Beril", "Ozbay", "Yazilim", "C100", new DateTime(1997, 06, 26));
            Calisan calisan3 = new Calisan("Beril", "Ozbay", "Yazilim", "ABCD", new DateTime(1997, 06, 26));
            Console.WriteLine(calisan.SicilNo);
            Console.WriteLine(calisan2.SicilNo);
            Console.WriteLine(calisan3.SicilNo);
        }
    }
}