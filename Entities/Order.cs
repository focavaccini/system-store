using System;
using System.Collections.Generic;
namespace system_store{
    class Order{
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public void AddItem(OrderItem item){
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item){
            Items.Remove(item);
        }
    }
}