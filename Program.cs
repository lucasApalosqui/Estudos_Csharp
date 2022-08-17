namespace DelegatesAndMulticastDelegates;
using DelegatesAndMulticastDelegates.Services;

internal class Program
{
    delegate void PrintContent(string a, string b);
    delegate string JuntaNomes(string a, string b);
    static void Main(string[] args)
    {
        PrintContent print = StringAlterService.trocaPalavra;
        JuntaNomes junta = StringAlterService.juntaNomes;

        print += StringAlterService.juntaPalavrinhas;
        string palavraUnida = junta.Invoke("barraquinha", "de milhões");

        print.Invoke("pao", "saladinha");
        Console.WriteLine(palavraUnida);

        
    }
}