namespace Odev7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseKitap baseKitap = new BaseKitap();
            baseKitap.GetLog();
            baseKitap.GetUser();
            Kitap kitap = new Kitap();
            kitap.GetLog();
            kitap.GetUser();
            TuremisKitap turemisKitap = new TuremisKitap();
            turemisKitap.GetLog();
        }
    }
}