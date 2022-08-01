using System;
using System.Globalization;
using System.Collections.Generic;
using ExHerancaPolimorfismoProdutoImportado.Entities;

namespace ExHerancaPolimorfismoProdutoImportado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Product #" + (i + 1) + " Data: ");
                Console.Write("Commom, used or imported? (c/u/i): ");
                string   version = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(version == "i")
                {
                    Console.Write("Custom Fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else if(version == "u")
                {
                    Console.Write("Manufacture date (dd/mm/yyyy): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufacture));
                }
                else
                {
                    list.Add(new Product(name, price));
                }



            }

            foreach(Product all in list)
            {
                Console.WriteLine();
                Console.WriteLine(all.priceTag());
            }
        }
    }
}
