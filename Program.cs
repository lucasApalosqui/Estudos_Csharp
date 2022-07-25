using System;
using System.Collections.Generic;
using System.Globalization;

namespace Primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroFunc, codigoFunc;
            string nomeFunc;
            double porcentagemAumento, salario;

            List<AumentoFuncionarios> listFun = new List<AumentoFuncionarios>();

            Console.WriteLine("Informe o numero de funcionarios: ");
            numeroFunc = int.Parse(Console.ReadLine());

            for(int i = 0; i < numeroFunc; i++)
            {
                Console.WriteLine("Informe o codigo do funcionario: ");
                codigoFunc = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o nome do funcionario: ");
                nomeFunc = Console.ReadLine();

                Console.WriteLine("Informe o salario do funcionario: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listFun.Add(new AumentoFuncionarios(codigoFunc, nomeFunc, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Informe o codigo do funcionario que deseja aumentar o salario: ");
            int codFunAu = int.Parse(Console.ReadLine());
            AumentoFuncionarios codAumento = listFun.Find(x => x.CodigoFun == codFunAu);
            if(codAumento != null)
            {
                Console.Write("Entre com a porcentagem: ");
                porcentagemAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                codAumento.aumentaSalario(porcentagemAumento);
                Console.WriteLine();
            }
            else
            {
                Console.Write("Esse ID não existe");
                Console.WriteLine();
            }

            Console.WriteLine("Lista atualizada dos funcionarios:");
            foreach (AumentoFuncionarios obj in listFun)
            {
                Console.WriteLine(obj);
            }



        }

        }
    }

