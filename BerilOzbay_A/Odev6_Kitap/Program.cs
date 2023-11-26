namespace Odev6_Kitap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseKitap baseKitap = new BaseKitap();
            Kitap kitap = new Kitap();
            TuremisKitap turemisKitap = new TuremisKitap();

            baseKitap.GetLog();
            baseKitap.GetUser();
            kitap.GetLog();
            kitap.GetUser();
            turemisKitap.GetUser();
        }
    }
}