using ORDER.Entities;
using ORDER.Entities.Enums;
using System;

namespace ORDER
{
    class Program
    {
        static void Main(string[] args)
        {
            //data cliente
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, date);


            //order data
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, os, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter {i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, priceProduct);

                Console.Write("Quantity: ");
                int qtdProduct = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(qtdProduct, priceProduct, product);
                order.AddItem(orderItem);
            }
        }
    }
}
