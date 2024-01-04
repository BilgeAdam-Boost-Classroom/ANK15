using Microsoft.EntityFrameworkCore;
using ÖDEV_A_12.Models;

namespace ÖDEV_A_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Müşterileri isimlerine göre artan olacak şekilde (A'dan Z'ye) listeleyiniz. (Sadece isimlerini getirebilirsiniz)
                Fax'ı null olan müşterilerin isimlerini ve telefonlarını getiriniz.
                Şehri Berlin olup, görevi Sales Representative olanları VEYA ülkesi Canada olup bölgesi BC olan                 müşterilerinisimlerini,``görevlerini, şehirlerini,ülkelerini,bölgelerini müşteriId'ye göre azalan olarak sıralayıp          listeleyiniz.
                Ülkesi Spain olan müşterilerin sayılarını bulunuz.
                Ülkesi USA olan müşterilerin sayıları ile şehri London olan müşterilerin sayılarının farkını bulunuz.
                Order details tablosundaki quantity'lerin ortalamasını bulunuz.
                Order details tablosundaki en yüksek unitprice'a sahip olan en küçük OrderId'yi bulunuz.
                Order details tablosundaki en düşük unitprice'a sahip olan en büyük OrderId'yi bulunuz.
                Order details tablosundaki OrderId'leri 10400 ile 10450 arasında olanların (10400 ve 10450 dahil)               unitprice'larıtoplamını``bulunuz.
                Order details tablosundaki 3 ile bölünebilen VE 5 ile bölünemeyen quantity'lerin toplamını bulunuz.
            */
            NorthwindContext _context = new NorthwindContext();
            // Cevap 1:
            foreach (var item in _context.Customers.OrderBy(c => c.ContactName))
            {
                Console.WriteLine(item.ContactName);
            }
            Console.WriteLine(new string('-', 50));
            //Cevap 2:
            foreach (var item in _context.Customers.Where(c => c.Fax == null))
            {
                Console.WriteLine($"Name:{item.ContactName}, Phone Number:{item.Phone}");
            }
            Console.WriteLine(new string('-', 50));

            //Cevap 3:
            foreach (var item in _context.Customers
                .Where(c => (c.City.Contains("Berlin") && c.ContactTitle.Contains("Sales Representative")) ||
                            (c.City.Contains("Canada") && c.Country.Contains("BC")))
                .OrderByDescending(c => c.ContactName))
            {
                Console.WriteLine($"Customer ID: {item.CustomerId}");
                Console.WriteLine($"Contact Name: {item.ContactName}");
                Console.WriteLine($"Contact Title: {item.ContactTitle}");
                Console.WriteLine($"City: {item.City}");
                Console.WriteLine($"Country: {item.Country}");
                // Ek bilgileri ekleyebilirsiniz.
                Console.WriteLine("--------------------------------------------");
            }
            Console.WriteLine(new string('-', 50));

            //Cevap 4
            int customerSpainCount = _context.Customers.Count(c => c.Country.Contains("Spain"));
            Console.WriteLine($"Spian Count: {customerSpainCount}");
            Console.WriteLine(new string('-', 50));
            //Cevap 5
            int customerUsaCount = _context.Customers.Count(c => c.Country.Contains("USA"));
            int customerLondonCount = _context.Customers.Count(c => c.City.Contains("London"));
            Console.WriteLine($"USA Count:{customerUsaCount}\nLondon Count:{customerLondonCount}" +
                $"\nDiff:{customerUsaCount - customerLondonCount}");
            Console.WriteLine(new string('-', 50));
            //Cevap 6 
            var orderQuantitiyAvarage = _context.OrderDetails.Average(od => od.Quantity);
            Console.WriteLine($"Ortalama:{orderQuantitiyAvarage}");
            Console.WriteLine(new string('-', 50));
            //Cevap 7
            var maxUnitPriceMinId = _context.OrderDetails.OrderByDescending(od => od.UnitPrice)
                                                           .ThenBy(od => od.OrderId).FirstOrDefault();
            Console.WriteLine(maxUnitPriceMinId.OrderId + " " + maxUnitPriceMinId.UnitPrice);
            Console.WriteLine(new string('-', 50));
            //Cevap 8
            var minUnitPriceMaxId = _context.OrderDetails.OrderBy(od => od.UnitPrice)
                                                         .ThenByDescending(od => od.OrderId)
                                                         .FirstOrDefault();
            Console.WriteLine(minUnitPriceMaxId.UnitPrice+" "+minUnitPriceMaxId.OrderId);
            Console.WriteLine(new string('-', 50));

            //Cevap 9 
            var TotalPrice = _context.OrderDetails
                            .Where(od=> od.OrderId >= 10400 && od.OrderId <= 10450).Sum(s=> s.UnitPrice);
            Console.WriteLine($"Total Price: {TotalPrice}");
            Console.WriteLine(new string('-', 50));
            //Cevap 10
            var mod = _context.OrderDetails.Where(od=> od.Quantity % 3 == 0 && od.Quantity % 5 != 0).Sum(s=> s.Quantity);
            Console.WriteLine(mod);
        }
    }
}
