namespace ExDictionaryUrn;
using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> peoples = new Dictionary<string, int>();
        Console.Write("Enter full path file: ");
        string path = Console.ReadLine();

        try
        {
            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(",");
                    string name = line[0];
                    int value = int.Parse(line[1], CultureInfo.InvariantCulture);
                    if (peoples.ContainsKey(name))
                    {
                        peoples[name] += value;
                    }
                    else
                    {
                        peoples[name] = value;
                    }
                   
                }

            }
            Console.WriteLine("All peoples votes:");
            foreach(KeyValuePair<string, int> item in peoples)
            {
                Console.WriteLine(item.Key + " / Votes: " + item.Value);
            }
        }catch(IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}