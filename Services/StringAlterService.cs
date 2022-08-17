using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndMulticastDelegates.Services
{
    internal class StringAlterService
    {
        public static void trocaPalavra(string palavra, string novaPalavra)
        {
            Console.WriteLine(palavra.Replace(palavra, novaPalavra));
        }

        public static void juntaPalavrinhas(string palavra, string letra)
        {
            Console.WriteLine(palavra + letra);
        }

        public static string juntaNomes(string nome1, string nome2)
        {
            return nome1 + " " + nome2;
        }
    }
}
