using System;
using System.Globalization;

namespace ConsoleEstudos
{
    class Program
    {
        static void Main(string[] args)
        {
            string titular, inicial;
            double valor;
            int conta;

            Console.WriteLine("Informe o numero da conta: ");
            conta = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do titular: ");
            titular = Console.ReadLine();

            Console.WriteLine("Deseja fazer um depósito inicial? (s/n): ");
            inicial = Console.ReadLine();

            ContaBancaria contabancaria = new ContaBancaria(conta, titular, inicial);


            Console.WriteLine("Qual valor deseja depositar: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contabancaria.DepositaValor(valor);

            Console.WriteLine("Qual valor deseja sacar: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contabancaria.SacaValor(valor);



        }
    }
}
