using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CapMeAgain
    {
        public static string[] CapMe(string[] strings)
        {
            List<string> list1 = new List<string>();
            var resultado = strings.Select(x => char.ToUpper(x[0]) + x.Substring(1).ToLower());
            Console.WriteLine(string.Join(", ", resultado));
            return resultado.ToArray();
        }
    }
}
