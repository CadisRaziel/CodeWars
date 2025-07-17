using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CorrectDigitalize
    {
        public static string Correct(string text) => text.Replace("0", "O").Replace("5", "S").Replace("1", "I");         
        
    }
}
