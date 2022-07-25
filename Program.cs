using System;
using System.Collections.Generic;
using System.Globalization;

namespace Primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numNegativo = 0;

            int num = int.Parse(Console.ReadLine());
            int[,] matriz = new int[num, num];

            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                for(int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.WriteLine("Escreva o numero inteiro que ficará no local: [" + l + "] [" + c + "]\n" );
                    int inteiro = 
                    matriz[l,c] = int.Parse(Console.ReadLine());
                }
            }

            for (int l = 0; l < matriz.GetLength(0); l++)
            {

                Console.WriteLine("[" + matriz[l,0] + "]" + "[" + matriz[l, 1] + "]" + "[" + matriz[l, 2] + "]");
            }

            Console.WriteLine();
            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++) 
                {
                    if (l == c)
                    {
                        Console.WriteLine("[" + matriz[l, c] + "]");
                    }

                    if (matriz[l,c] < 0)
                    {
                        numNegativo += 1;
                    }
                }
            }
            Console.WriteLine("Numero de negativos: " + numNegativo
                );
        }

        }
    }

