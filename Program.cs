namespace ExFileHandling;
using System.Globalization;
internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<string> list = new List<string>();
            string[] all;
            string actualPath = @"C:\Users\Legale\projects\Primeiro\ExFileHandling\requests.csv";
            string destinyPath = @"C:\Users\Legale\projects\Primeiro\ExFileHandling\out";

            using (FileStream fs = new FileStream(actualPath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        list.Add(line);
                    }
                }
            }
            Directory.CreateDirectory(destinyPath);
            

            using (StreamWriter sw = File.AppendText(destinyPath + "\\summary.csv"))
            {
                foreach (string n in list)
                {
                    all = n.Split(",");
                    double value = double.Parse(all[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(all[2]);
                    sw.WriteLine(all[0] + ", " + (value * quantity).ToString("F2", CultureInfo.InvariantCulture));
                    
                }
            }
        }catch(IOException e)
        {
            Console.WriteLine(e.Message);
        }



    }
}