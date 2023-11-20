namespace OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Buzdolabi buzdolabi = new Buzdolabi();
            //BeyazEsya beyazEsya = new BeyazEsya();

            //GeometrikSekil geometrikSekil = new GeometrikSekil();
            //Kare kare = new Kare();
            //Dikdortgen dikdortgen = new Dikdortgen();

            //geometrikSekil.Yukseklik = 8;
            //geometrikSekil.Genislik = 9;
            //Console.WriteLine(geometrikSekil.CevreHesapla());
            //Console.WriteLine(geometrikSekil.AlanHesapla());

            //kare.Genislik = 5;
            //kare.Yukseklik = 5;
            //Console.WriteLine(kare.CevreHesapla());
            //Console.WriteLine(kare.AlanHesapla());

            //dikdortgen.Genislik = 7;
            //dikdortgen.Yukseklik = 3;
            //Console.WriteLine(dikdortgen.CevreHesapla());
            //Console.WriteLine(dikdortgen.AlanHesapla());

            Akademisyen akademisyen = new Akademisyen();
            akademisyen.Ad = "Ramis";
            akademisyen.Soyad = "Yuksel";
            akademisyen.MakaleEkle("Yazi1");
            akademisyen.MakaleEkle("Yazi2");
            akademisyen.MakaleEkle("Yazi3");
            Console.WriteLine(akademisyen.Ad + " " + akademisyen.Soyad);
            akademisyen.MakaleGoster();

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Beril";
            ogrenci.Soyad = "Ozbay";
            Console.WriteLine(ogrenci.Ad + " " + ogrenci.Soyad);
            ogrenci.DersEkle("Matematik");
            ogrenci.DersGoster();
 
            IdariPersonel idariPersonel = new IdariPersonel();
            idariPersonel.Ad = "Esra";
            idariPersonel.Soyad = "Aykut";
            idariPersonel.Birim = "Matematik Bolumu";

            Console.WriteLine(idariPersonel.Ad + " " + idariPersonel.Soyad + " " + idariPersonel.Birim);


        }
    }
}