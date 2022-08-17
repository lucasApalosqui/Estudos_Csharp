using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods.Extensions
{
    static class IntExtensions
    {
        public static string countNumbers(this int thisObj, int number)
        {
            string result = "";
            int teste = number;
            int totalNum = 0;
            if(number == 0 || number > thisObj || thisObj == 0)
            {
                return "it´s not possible!";
            }
            for(int i = number; i <= thisObj; i+= number)
            {
                if(teste == i)
                {
                    result = "/";
                }
                result = result + number + "/";
                totalNum++;
            }
            return result + "\n total occurrences: ( " + totalNum + " )";
        }
    }
}
