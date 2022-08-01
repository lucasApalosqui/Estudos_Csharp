using System;
using System.Globalization;
using System.Collections.Generic;
using ExHerancaFuncionarioTerceirizado.Entities;

namespace ExHerancaFuncionarioTerceirizado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            Console.Write("Enter number of employeers: ");
            int numemployeers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numemployeers; i++)
            {
                Console.Write("Employee #" + (i + 1) + " Data: ");
                Console.Write("Outsourced? (y/n): ");
                string outsourced = Console.ReadLine();


                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == "y")
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employee.Add(new OutSourceEmployee(name, hours, valuePerHours, additionalCharge));
                }
                else
                {
                    employee.Add(new Employee(name, hours, valuePerHours));
                }




            }
            foreach (Employee func in employee)
            {
                Console.WriteLine(func.Name + " - $ " + func.Payment().ToString("F2", CultureInfo.InvariantCulture));


            }


        }
    }
}
