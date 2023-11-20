using _01_oop.Model;

namespace _01_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yorum satiri
            //double result;
            //Firin firin = new Firin();
            //Console.WriteLine("Markasini giriniz");
            //firin.Marka = Console.ReadLine();
            //Console.WriteLine("Fiyatini giriniz");
            //while (!double.TryParse(Console.ReadLine(), out  result))
            //{
            //    Console.WriteLine("Hatalai giris yaptiniz Tekrark fiyati giriniz!!");
            //}
            //Console.WriteLine("Model giriniz");
            //firin.Model = Console.ReadLine();
            //firin.Fiyat = result;
            //Console.WriteLine("Lutfen Gucu giriniz");
            //firin.Guc = Console.ReadLine();
            //firin.GarantiSuresi = 1;
            //firin.MaksDerece = 100;

            //Console.WriteLine($"Marka:{firin.Marka}\nModel:{firin.Model}\nFiyat:{firin.Fiyat}\nGuc:{firin.Guc}\nGarantiVar mi:{firin.GarantiVarmi}\nGaranti Suresi:{firin.GarantiSuresi} yil \nMaksSure:{firin.MaksDerece}");
            //firin.GarantuUzat(1);
            //Console.WriteLine(new string('-',count:50));
            //Console.WriteLine($"Marka:{firin.Marka}\nModel: {firin.Model} \nFiyat: {firin.Fiyat} \nGuc: {firin.Guc} \nGarantiVar mi: {firin.GarantiVarmi} \nGaranti Suresi: {firin.GarantiSuresi} Yil \nMaksSure: {firin.MaksDerece}");
            //Console.WriteLine(new string('-', count: 50));

            //Firin firin1 = new Firin("Arcelik","Firin",true);

            //Console.WriteLine(new string('-', count: 50));
            //Console.WriteLine("Fiyatini giriniz");
            //while (!double.TryParse(Console.ReadLine(), out result))
            //{
            //    Console.WriteLine("Hatalai giris yaptiniz Tekrark fiyati giriniz!!");
            //}

            //firin1.Fiyat = result;

            //Console.WriteLine("Lutfen Gucu giriniz");
            //firin1.Guc = Console.ReadLine();
            //firin1.GarantiSuresi = 1;
            //firin1.MaksDerece = 100;

            //Console.WriteLine($"Marka:{firin1.Marka}\nModel:{firin1.Model}\nFiyat:{firin1.Fiyat}\nGuc:{firin1.Guc}\nGarantiVar mi:{firin1.GarantiVarmi}\nGaranti Suresi:{firin1.GarantiSuresi}\nMaksSure:{firin1.MaksDerece}");
            //firin1.GarantuUzat(1);
            //Console.WriteLine(new string('-', count: 50));
            //Console.WriteLine($"Marka:{firin1.Marka}\nModel:{firin1.Model}\nFiyat:{firin1.Fiyat}\nGuc:{firin1.Guc}\nGarantiVar mi:{firin1.GarantiVarmi}\nGaranti Suresi:{firin1.GarantiSuresi}\nMaksSure:{firin1.MaksDerece}");
            //Esya esya = new Esya();
            //esya.Fiyat = 2000;
            //Console.WriteLine(esya.Fiyat);
            //esya.Fiyat = 1000;
            //Console.WriteLine(esya.Fiyat);
            #endregion

            long result;
            Musteri musteri = new Musteri();

            Console.WriteLine("Tc kimlik numaranizi giriniz.");
            while (!long.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Hatali giris yaptiniz tekrar giriniz!");
            }

            musteri.TcKimlik = result;
            Console.WriteLine($"Tc Kimlik Numaraniz: {musteri.TcKimlik}");

            HesapTrigo hesapTrigo = new HesapTrigo();

            hesapTrigo.Aci = 180;
            Console.WriteLine($"Aciniz : {hesapTrigo.Aci}");

            try
            {
                hesapTrigo.Aci = 361;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}