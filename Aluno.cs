using System.Globalization;

namespace Primeiro
{
    internal class Aluno
    {
        public double nota1, nota2, nota3, total;
        double falta;
        string aprovados, saidaMsg = "";

        private string aprovado(double total)
        {
            falta = 60.0 - total;
            if(total < 60.0)
            {

                aprovados = "REPROVADO! Faltou: " + falta.ToString("F2", CultureInfo.InvariantCulture) + " Pontos para ser aprovado";
                return aprovados;
            }else
            {
                aprovados = "APROVADO!!";
                return aprovados;
            }

        }
        public string notaFinal(double nota1, double nota2, double nota3)
        {
            total = nota1 + nota2 + nota3;
            saidaMsg = "NOTA FINAL: " + total.ToString("F2", CultureInfo.InvariantCulture) + "\n" + aprovado(total);
            return saidaMsg;
        }
    }
}

