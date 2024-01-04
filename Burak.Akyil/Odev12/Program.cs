using Odev12.Models;

namespace Odev12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            NORTHWNDContext _db = new NORTHWNDContext();
            //Gorev 1
            foreach (var item in _db.Customers.OrderBy(c => c.ContactName))
            {
                Console.WriteLine(item.ContactName);
            }
            
            Console.WriteLine("--------------------------");

            //Gorev 2
            foreach (var item in _db.Customers.Where(c=>c.Fax == null))
            {
                Console.WriteLine("Adı: " + item.ContactName + ", " + "Telefonu: " + item.Phone);
            }
            
            Console.WriteLine("--------------------------");

            //Gorev 3
            foreach (var item in _db.Customers.Where(c=>c.City == "Berlin" && c.ContactTitle == "Sales Representative" || c.Country == "Canada" && c.Region == "BC").OrderByDescending(c=>c.CustomerId))
            {
                Console.WriteLine("Adı: " + item.ContactName + ", " + "Görevi: " + item.ContactTitle + ", " + "Ülkesi: " + item.Country + ", " + "Bölgesi: " + item.Region);
            }

            Console.WriteLine("--------------------------");

            //Gorev 4
            Console.WriteLine(_db.Customers.Count(c=>c.Country == "Spain"));

            Console.WriteLine("--------------------------");

            //Gorev 5
            int country = _db.Customers.Count(c => c.Country == "USA");
            int city = _db.Customers.Count(c => c.City == "London");
            Console.WriteLine(country - city);

            Console.WriteLine("--------------------------");

            //Gorev 6
            Console.WriteLine(_db.OrderDetails.Average(od=>od.Quantity));

            Console.WriteLine("--------------------------");

            //Gorev 7 -- Hocaya sor!
            var highestUnitPriceOrder = _db.OrderDetails.OrderByDescending(od => od.UnitPrice).ThenBy(od => od.OrderId).FirstOrDefault();
            if(highestUnitPriceOrder != null)
            {
                Console.WriteLine(highestUnitPriceOrder);
            }
            else
            {
                Console.WriteLine("Veri bulunamadı.");
            }

            //Gorev 8

            
        }
    }
}