using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqAndLambda.Entities;

namespace LinqAndLambda
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string [] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(1, "Computers", 1);
            Category c3 = new Category(1, "Eletronics", 1);

            List<Product> products = new List<Product>()
            {
                new Product() { id = 1, name = "Computer", price = 1100.0, category = c2 },
                new Product() { id = 2, name = "Hammer", price = 90.0, category = c1 },
                new Product() { id = 3, name = "TV", price = 1700.0, category = c3 },
                new Product() { id = 4, name = "Notebook", price = 1300.0, category = c2 },
                new Product() { id = 5, name = "Saw", price = 80.0, category = c1 },
                new Product() { id = 6, name = "Tablet", price = 700.0, category = c2 },
                new Product() { id = 7, name = "Camera", price = 700.0, category = c3 },
                new Product() { id = 8, name = "Printer", price = 350.0, category = c3 },
                new Product() { id = 9, name = "MacBook", price = 1800.0, category = c2 },
                new Product() { id = 10, name = "Sound Bar", price = 700.0, category = c3 },
                new Product() { id = 11, name = "Level", price = 70.0, category = c1 }
            };

            IEnumerable<Product> r1 = products.Where(p => p.category.tier == 1 && p.price < 900.0);
            Print("TIER 1 AND PRICE < 900:", r1);

            IEnumerable<string> r2 = products.Where(p => p.category.name == "Tools").Select(p => p.name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            var r3 = products.Where(p => p.name[0] == 'C').Select(p => new { p.name, p.price, CategoryName = p.category.name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            var r4 = products.Where(p => p.category.tier == 1).OrderBy(p => p.price).ThenBy(p => p.name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or default test1: " + r6);
            var r7 = products.Where(p => p.price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);
            var r9 = products.Where(p => p.id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine();

            var r10 = products.Max(p => p.price);
            Console.WriteLine("Max price: " + r10);
            var r11 = products.Min(p => p.price);
            Console.WriteLine("Min price: " + r11);
            var r12 = products.Where(p => p.category.id == 1).Sum(p => p.price);
            Console.WriteLine("Category 1 Sum prices: " + r12);
            var r13 = products.Where(p => p.category.id == 1).Average(p => p.price).ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine("Category 1 Average prices: " + r13);
            var r14 = products.Where(p => p.category.id == 5).Select(p => p.price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);
            var r15 = products.Where(p => p.category.id == 1).Select(p => p.price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.category);
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
