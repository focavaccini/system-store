using System;
using System.Globalization;

namespace system_store{
    class OrderItem{
        public double Price { get; private set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }

        public OrderItem(){

        }

        public OrderItem(double price, int quantity, Product product){
            Price = price;
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal(){
            return Price * Quantity;
        }

        // public override string ToString()
        // {
            
        //     return  Product.Name + ", $"+ Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + Quantity + ", Subtotal: " + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        // }
    }
}