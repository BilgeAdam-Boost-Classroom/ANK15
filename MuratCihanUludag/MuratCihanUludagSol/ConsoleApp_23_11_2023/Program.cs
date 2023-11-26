namespace ConsoleApp_23_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int durumNo = 1;
            var secilen = Enum.GetName(typeof(Durum), durumNo);

            Console.WriteLine(secilen);

            Console.WriteLine(Durum.Basarisiz);

            int durumId = (int)Durum.Basarisiz;
            Console.WriteLine(durumId);

            Ogrenci ogrenci = new Ogrenci() { Name = "Cihan" , Sifat = Durum.Muaf};
            Console.WriteLine(ogrenci.Sifat);

            var x = Enum.Parse(typeof(Durum),"Muaf");
            Console.WriteLine(x);
        }
    }
}