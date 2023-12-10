using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeUygulamasi
{
    internal class Cafe
    {
        //Menu
        Menuu Menuu { get; }
        //musteri sirasi
        public Queue<Customer> CustomerLine { get; private set; } = new();
        //calisanlar
        private List<Employee> Employees { get; }
       

        //kasa
        public readonly int RegisterCount = 3;
        public List<Order> PreparedOrders {  get; } = new();
        public Employee? GetAvailableEmbloyee=>Employees.FirstOrDefault(Employee=>Employee.Status==EmployeeStatus.Available);
        public bool CanREgisterTakeOrder()
        {
            return Employees.Any(Employee => Employee.Status == EmployeeStatus.Available)&&Employees.Count(Employee=>Employee.Status==EmployeeStatus.TakingOrder) < RegisterCount;
        }
        public void RegisterTakeOrder(Customer customer, params OrderItem[] orderItems)
        {
            var registerer = Employees.First(Employee => Employee.Status == EmployeeStatus.Available);
            registerer.TakeOrder(this,customer,orderItems);
        }

        public void GetInLine(Customer customer)
        {
            CustomerLine.Enqueue(customer);
        }

        public bool IsNext(Customer customer)
        {
            if (CustomerLine.TryPeek(out var nextCustomer))
            {
                return nextCustomer == customer;
            }
            return false;
        }
    }
}
