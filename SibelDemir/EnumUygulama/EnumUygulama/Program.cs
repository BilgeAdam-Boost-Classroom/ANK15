namespace EnumUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int durumNo;
            Console.WriteLine("Durum numarası seçiniz");
           // durumNo = Convert.ToInt32(Console.ReadLine());
            //
         //   var secilenDurum = Enum.GetName(typeof(Durum), durumNo);
            var durumId = (int)(Durum.Muaf);
            Ogrenci ogrenci = new Ogrenci()
            {
                Ad = "Sibel",
                Soyad = "Demir",
                No = "12345",
                DersDurumu = Durum.Devamsiz
            };
            Console.WriteLine(ogrenci.DersDurumu);
            ogrenci.DersDurumu = (Durum)Enum.Parse(typeof(Durum), "Muaf");
        }
    }
}