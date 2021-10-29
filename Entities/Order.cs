using System;
using System.Globalization;
using System.Collections.Generic;
namespace system_store{
    class Order{
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(){

        }

        public Order(DateTime moment, OrderStatus status, Client client){
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item){
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item){
            Items.Remove(item);
        }

        public double Total(){
            double totalValue=0;
            foreach(OrderItem or in Items){
                Console.WriteLine(or.Product.Name + ", $"+ or.Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + or.Quantity + ", Subtotal: " + or.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                totalValue += or.SubTotal();
            }
            return totalValue;
        }
    }
}