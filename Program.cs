using System;
using System.Globalization;

namespace system_store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Client client = new Client(name, email, birthDate);

            Console.Write("Enter cliente data:");
            DateTime date = DateTime.Now;
            Console.WriteLine();

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Order order = new Order(date, status, client);

            Console.WriteLine();
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            OrderItem items;
            for(int i=1; i<=n; i++){
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product prod = new Product(productName, price);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                items = new OrderItem(price, quantity, prod);
                order.AddItem(items);
            }
            OrderItem or = new OrderItem();
            double subTotal = or.SubTotal();
            
            Console.WriteLine();
            Console.Write("Order Sumary: ");
            Console.WriteLine("Order moment: " + order.Moment);
            Console.WriteLine("Order status: " + order.Status);
            Console.WriteLine("Client: " + order.Client.Name + " (" + order.Client.BirthDate.ToString("dd/MM/yyyy") + ")" + " - " + order.Client.Email );
            Console.Write("Order items: ");        
            Console.WriteLine();
            double total = order.Total();
            Console.WriteLine("Total price: " + total.ToString("F2", CultureInfo.InvariantCulture) );
           
        }
    }
}
