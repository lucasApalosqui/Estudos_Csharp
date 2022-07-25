using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    internal class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double salarioLiquido;
            salarioLiquido = salarioBruto - imposto;
            salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100.0);
            

        }


    }
}
