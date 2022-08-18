using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using ExLinqLambdaEmployee.Entities;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExLinqLambdaEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine();
            Console.WriteLine("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double sal = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, sal));

                }

                var emailMoreThan = list.Where(e => e.Salary > salary).OrderBy(e => e.Email).Select(e => e.Email);
                Console.WriteLine("Email of people whose salary is more than " + salary.ToString("F2",CultureInfo.InvariantCulture) + ":");
                foreach(string email in emailMoreThan)
                {
                    Console.WriteLine(email);
                }

                double sum = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
                
            }

        }
    }
}
