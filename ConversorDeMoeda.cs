
using System.Globalization;
namespace Primeiro
{
    internal class ConversorDeMoeda
    {
        double dolar;
        double valor;
        public static string converteDolar(double valor, double dolar)
        {
            double conversao = valor * dolar;
            string total;
            conversao = conversao + (conversao * 6 / 100);
            total = conversao.ToString("F2", CultureInfo.InvariantCulture);

            return total;

        }
    }
}
