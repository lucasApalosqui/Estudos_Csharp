using System;
using EnumAndComposition.Entities;
using EnumAndComposition.Entities.Enums;
using System.Globalization;

namespace EnumAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email, status, productName;
            DateTime birthDate;
            int qntItemsOrder, quantityProduct;
            double priceProduct;



            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Email: ");
            email = Console.ReadLine();

            Console.Write("DateBirth (DD/MM/YYYY) ");
            birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client()
            {
                Name = name,
                Email = email,
                BirthDate = birthDate
            };





            Console.WriteLine("Enter Order Data");
            Console.Write("Status: ");
            status = Console.ReadLine();

            Order order = new Order()
            {
                Client = client,
                Moment = DateTime.Now,
                Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), status)
               
            };

            Console.Write("How many to this order: ");
            qntItemsOrder = int.Parse(Console.ReadLine());

            for(int i = 0; i < qntItemsOrder; i++)
            {
                Console.WriteLine("Enter #" + (i + 1) + " Item Data: ");
                Console.Write("Product Name: ");
                productName = Console.ReadLine();

                Console.Write("Product Price: ");
                priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Product Quantity: ");
                quantityProduct = int.Parse(Console.ReadLine());

                Product product = new Product()
                {
                    Name = productName,
                    Price = priceProduct

                };

                OrderItem orderItem = new OrderItem()
                {
                    Product = product,
                    Price = priceProduct,
                    Quantity = quantityProduct
                };

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);





        }
    }
}
