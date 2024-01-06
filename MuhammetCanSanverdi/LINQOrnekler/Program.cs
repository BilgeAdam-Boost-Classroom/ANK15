using LINQOrnekler.Models;

namespace LINQOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //var context = new NorthwindContext();
            //var result = context.Employees.Select(e => new Employee()
            //{
            //    FirstName = e.FirstName,
            //    LastName = e.LastName,
            //});

            //var result1 = context.Employees.Where(e=> e.FirstName.StartsWith("a",StringComparison.OrdinalIgnoreCase)).Select(e => new Employee()
            //{
            //    FirstName = e.FirstName,
            //    LastName = e.LastName,
            //});

            //var resul2 = context.Employees.Where(e => e.FirstName.Contains('a',StringComparison.OrdinalIgnoreCase)).Select(e => new Employee()
            //{
            //    FirstName = e.FirstName,
            //    LastName = e.LastName,
            //});

            //var maxUnitPrice = context.Products.ToList().MaxBy(p=>p.UnitPrice);
            //var result3 = context.Products.Where(p => p.UnitPrice == maxUnitPrice.UnitPrice).Select(p=>p.ProductName);
            ////5
            //var minUnitPriceProuct = context.Products.ToList().MinBy(p => p.UnitPrice);
            //var result4 = context.Products.Where(p => p.UnitPrice == minUnitPriceProuct.UnitPrice).Select(p => new Product { ProductName=p.ProductName });

            //foreach (var item in result4)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            //var result5 = context.Products.OrderByDescending(p => p.UnitsInStock).ThenByDescending(p => p.ProductName)
            //    .Select(p=>new Product { ProductName=p.ProductName,UnitsInStock=p.UnitsInStock});

            //var result6 = context.Employees.ToList().LastOrDefault();
            //Console.WriteLine(result6.FirstName + "  " +result6.LastName);

            //var result7 = context.Employees.ToList().FirstOrDefault();
            //Console.WriteLine(result6.FirstName + "  " + result6.LastName);

            //var result8 = context.Employees.OrderBy(e=>e.BirthDate).FirstOrDefault();

            //var result9 = context.Employees.OrderByDescending(e => e.BirthDate).LastOrDefault();

            //var result10 = context.Employees.Where(e => e.Address.Contains("House") == false || e.TitleOfCourtesy=="Dr.").Select(e=>new Employee { FirstName=e.FirstName,LastName=e.LastName,Address=e.Address,TitleOfCourtesy=e.TitleOfCourtesy});

            //var result11 = context.Employees.Where(e => e.Address.Contains("House") == false || e.TitleOfCourtesy == "Dr.").OrderByDescending(e=>e.FirstName).Select(e => new Employee { FirstName = e.FirstName, LastName = e.LastName, Address = e.Address, TitleOfCourtesy = e.TitleOfCourtesy });

            //var result12 = context.Employees.Where(e => e.FirstName=="Andrew").Select(e => new Employee { FirstName = e.FirstName, LastName = e.LastName, Address = e.Address});

            //var result13 = context.Employees.Where(e => e.FirstName.StartsWith("A",StringComparison.OrdinalIgnoreCase)).Select(e => new Employee { FirstName = e.FirstName, LastName = e.LastName, BirthDate = e.BirthDate });

            //var avgUnitPrice = context.Products.Average(p => p.UnitPrice);
            //var result14 = context.Products.Where(p => p.UnitPrice > avgUnitPrice).Select(p => new Product { ProductName=p.ProductName,UnitPrice=p.UnitPrice});


            //---------------------------------------------


            //    var result = context.Employees.OrderBy(e=>e.FirstName).Select(e=>e.FirstName);

            //    var result1 = context.Customers.Where(c => c.Fax != null).Select(c => new Customer { CompanyName=c.CompanyName,Phone = c.Phone});

            //    var result2 = context.Customers.Where(c=>c.City=="Berlin" ||( c.Country=="Canada" && c.Region=="BC")).Select(c=>new Customer { CompanyName=c.CompanyName,City=c.City,Country=c.Country,Region=c.Region}).OrderByDescending(c=>c.CustomerId);

            //    var result3 = context.Customers.Where(c => c.Country == "Spain").Count();

            //    var result4 = context.Customers.Count(c => c.Country == "USA") - context.Customers.Count(c => c.City == "London");

            //    var result5 = context.OrderDetails.Average(o => o.Quantity);

            //    var result6 = context.OrderDetails.OrderByDescending(o => o.UnitPrice).ThenBy(o=>o.OrderId).FirstOrDefault();

            //    var result7 = context.OrderDetails.OrderBy(o => o.UnitPrice).ThenByDescending(o => o.OrderId).FirstOrDefault();

            //    var result8 = context.OrderDetails.Where(c => c.OrderId >= 10400 && c.OrderId <= 10450).Sum(c=>c.UnitPrice);

            //    var result10 = context.OrderDetails.Where(c => c.Quantity % 3 == 0 && c.Quantity % 5 == 0).Sum(o=>o.Quantity);
        }


    }
}
