using Ank15Kutuphane.BL.Repository;
using AnkKutuphane.DAL.Concrete;
using AnkKutuphane.DAL.Context;

namespace Ank15Kutuphane.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            KutuphaneDbContext _db= new KutuphaneDbContext();
            Repository<Bandrol> _bandrolRepository = new Repository<Bandrol>(_db);
            Repository<kitap> _kitaprepository = new Repository<kitap>(_db);

            //Bandrol bandrol = new Bandrol();
            //bandrol.No=new Random().Next();
            //Console.WriteLine(bandrol.No);
            //_bandrolRepository.Ekle(bandrol);

            //var guncelenecekBandrol = _bandrolRepository.IdyeGoreGetir(1);
            //guncelenecekBandrol.No=new Random().Next();
            //Console.WriteLine(guncelenecekBandrol.No);
            //_bandrolRepository.Guncele();

            ////var bandroller = _bandrolRepository.HepsiniGetir();
            //YayinEvi yayinEvi = new YayinEvi();
            //yayinEvi.Name = "Dost";

            //kitap kitap = new kitap();
            //kitap.Name = "Programlamaya Giriş I";
            //kitap.BasimYeri = 1;
            //kitap.Etiket = 1;
            //_kitaprepository.Ekle(kitap);

            var arananKitap = _kitaprepository.HepsiniGetir().ToList();


        }
    }
}
