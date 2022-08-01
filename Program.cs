using System;
using ExercicioEnum1.Entities;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioEnum1.Entities.Enums;

namespace ExercicioEnum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department´s name: ");
            string dptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("name: ");
            string name = Console.ReadLine();
            Console.Write("level (junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(dptName);
            Worker worker = new Worker()
            {
                Name = name,
                BaseSalary = baseSalary,
                Level = level,
                Department = dept
            };

            Console.Write("How many contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #" + (i + 1) + " Contract date: ");
                Console.Write("Date (dd/mm/yyyy): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract()
                {
                    date = dateContract,
                    hours = hours,
                    valuePerHour = valuePerHour
                };

                worker.AddContract(contract);

            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (mm/yyyy): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.name);
            Console.WriteLine("Income for: " + monthAndYear + ": " + worker.Income(year, month)); 





        }
    }
}
