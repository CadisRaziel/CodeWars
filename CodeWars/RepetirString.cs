using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class RepetirString
    {
        public static string RepeatStr(int n, string s)
        {
            //if (string.IsNullOrEmpty(s)) throw new ArgumentException("Texto não pode ser vazio");

            return string.Concat(Enumerable.Repeat(s, n));
         }
    }
}
