using System.Globalization;
using ExInterfaceContracts.Entities;
using ExInterfaceContracts.Services;
namespace Primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            string number = Console.ReadLine();

            Console.Write("Date (dd/mm/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int num = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);

            ContractService contractService = new ContractService();
            contractService.processContract(contract, num, new PaypalService());

            Console.WriteLine("Installments: ");
            foreach(Installment i in contract.installments)
            {
                Console.WriteLine("(" + i.dueDate.ToString("dd/MM/yyyy") + ") - " + i.amount.ToString("F2", CultureInfo.InvariantCulture));
            }





        }

    }
}