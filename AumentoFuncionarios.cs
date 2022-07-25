using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    internal class AumentoFuncionarios
    {
        public int CodigoFun { get; set; }
        public string NomeFun { get; set;}
        public double SalarioFun { get; private set; }

        public AumentoFuncionarios(int codigoFun, string nomeFun, double salarioFun)
        {
            CodigoFun = codigoFun;
            NomeFun = nomeFun;
            SalarioFun = salarioFun;
        }

        public double aumentaSalario(double porcentagem)
        {
            SalarioFun = SalarioFun + (SalarioFun * porcentagem / 100.0);
            return SalarioFun;
        }
        public override string ToString()
        {
            return CodigoFun
                + ", "
                + NomeFun
                + ", "
                + SalarioFun.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
