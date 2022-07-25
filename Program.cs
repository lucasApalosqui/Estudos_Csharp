using System;
using System.Globalization;

namespace Primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, email;
            int numAluguel, sala;

            AluguelQuartos[] aluguel = new AluguelQuartos[10];

            Console.WriteLine("Informe o numero de alugueis que deseja realizar: ");
            numAluguel = int.Parse(Console.ReadLine());

            for (int i = 0; i < numAluguel; i++)
            {
                Console.WriteLine("Informe os dados da " + (i + 1) + "° reserva\nInforme o seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Informe o seu email: ");
                email = Console.ReadLine();

                Console.WriteLine("Informe o numero da sala que deseja alugar: ");
                sala = int.Parse(Console.ReadLine());

                aluguel[sala] = new AluguelQuartos { nome = nome, email = email };

            }

            Console.WriteLine("Salas alugadas:");
            for (int i = 0; i < aluguel.Length; i++)
            {
                if (aluguel[i] != null )
                {
                    Console.WriteLine(i + " sala: " + aluguel[i].nome + ", " + aluguel[i].email);
                }
            }

       



        }
    }
}
