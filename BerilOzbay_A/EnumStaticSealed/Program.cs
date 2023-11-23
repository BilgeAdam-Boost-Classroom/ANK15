using System.ComponentModel;

namespace EnumStaticSealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Durum numarasini secin.");
            int durumNo = Convert.ToInt32(Console.ReadLine());

            var secilenDurum = Enum.GetName(typeof(Durum), durumNo);

            var durumId = (int)(Durum.Muaf);
            Console.WriteLine(durumId);
            Console.WriteLine(secilenDurum);

            Ogrenci ogrenci = new Ogrenci()
            {
                Ad = "Beril",
                Soyad = "Ozbay",
                OgrenciNo = 12,
                DersDurumu = Durum.Muaf
            };

            Console.WriteLine(ogrenci.DersDurumu);
        }
    }
}