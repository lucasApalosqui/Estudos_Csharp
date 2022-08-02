using System;
using System.Collections.Generic;
using System.Globalization;
using MetodosAbstratosTaxPayer.Entities;

namespace MetodosAbstratosTaxPayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            double total = 0;

            Console.Write("Enter the number of tax payers: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Tax payer #" + (i + 1) + " data: ");
                Console.Write("Individual or Company (i/c): ");
                string inOrCom = Console.ReadLine();

                while(inOrCom != "i" && inOrCom != "c")
                {
                    Console.Write("Individual or Company invalid, try again: (i/c): ");
                    inOrCom = Console.ReadLine();
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               

                if (inOrCom == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));

                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberEmployees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer tax in list)
            {
                Console.WriteLine(tax);
                total += tax.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
