using System;
using System.Collections.Generic;
using System.Text;

namespace ORDER.Entities.Enums
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem Item)
        {
            Items.Add(Item);        }
        public void RemoveItem(OrderItem Item)
        {
            Items.Remove(Item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum = sum + item.SubTotal();
            }
            return sum;
        }
    }
}
