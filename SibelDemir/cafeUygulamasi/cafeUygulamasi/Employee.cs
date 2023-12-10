using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeUygulamasi
{
    internal class Employee:Person
    {
        public EmployeeStatus Status { get; set; } = EmployeeStatus.Available;
        public Employee(string name):base(name) 
        { 
        }
        public async  Task<Order> TakeOrder(Cafe cafe,Customer customer,params OrderItem[] orderItems)
        {
            Status = EmployeeStatus.TakingOrder;
            var order = new Order(customer, orderItems);
            await Task.Delay(1000);

            var preparer = cafe.GetAvailableEmbloyee ?? this;

            Status=EmployeeStatus.Available;

             preparer.PrepareOrder(cafe, order);

            return order;

        }
        public async Task PrepareOrder(Cafe cafe,Order order)
        {
            Status = EmployeeStatus.PreparingOrder;
            await Task.Delay(order.TotalPrepTime);
            cafe.PreparedOrders.Add(order);
            Status = EmployeeStatus.Available;
        }
    }
}
