using System;
using System.Collections.Generic;
using System.Globalization;

namespace Primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n,x, num;

            Console.WriteLine("Informe o numero de linhas da matriz: ");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o numero de colunas da matriz: ");
            n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for(int l = 0; l < matriz.GetLength(0); l++)
            {
                for(int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.WriteLine("Escreva o numero inteiro que ficará no local: [" + l + "] [" + c + "]\n");
                    matriz[l,c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Informe o numero que quer pesquisar na tabela: ");
            x = int.Parse(Console.ReadLine());

            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    if (matriz[l,c] == x)
                    {
                        Console.WriteLine("Dados:");
                        if (l > 0)
                        {
                            Console.WriteLine("Cima: " + matriz[l - 1,c]);
                        }
                        if(c > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[l , c - 1]);
                        }
                        if(c + 1 < matriz.GetLength(1))
                        {
                            Console.WriteLine("Direita: " + matriz[l, c + 1]);
                        }
                        if(l + 1 < matriz.GetLength(0))
                        {
                            Console.WriteLine("Baixo: " + matriz[l + 1, c]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

        }
    }

