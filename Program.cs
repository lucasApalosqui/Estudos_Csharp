namespace ExtensionsMethods;
using ExtensionsMethods.Extensions;
internal class Program
{
    static void Main(string [] args)
    {
        Console.Write("Qual numero deseja analisar: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Qual numero de vezes: ");
        int numV = int.Parse(Console.ReadLine());

        Console.WriteLine(num.countNumbers(numV));
    }
}