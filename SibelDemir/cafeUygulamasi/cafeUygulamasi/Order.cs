using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeUygulamasi
{
    internal class Order
    {
        public OrderItem[] Items { get; }
        public Customer Owner;
        private Customer customer;
        private OrderItem[] orderItems;

        public Order(Customer owner, OrderItem[] items)
        {
            Owner = owner;
            Items = items;
        }

        public decimal TotalPrice => Items.Sum(x => x.Price);
        public TimeSpan TotalPrepTime => TimeSpan.FromSeconds(Items.Sum(x => x.PrepTime.TotalSeconds));

    }
}
