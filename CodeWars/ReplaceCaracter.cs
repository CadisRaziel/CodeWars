using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ReplaceCaracter
    {

        /*         
        "Hi!" --> "H!!"
        "!Hi! Hi!" --> "!H!! H!!"
        "aeiou" --> "!!!!!"
        "ABCDE" --> "!BCD!"
         */

        public static string Replace(string s)
        {

            return Regex.Replace(s, "[aeiouAEIOU]", "!");
            //Regex.Replace(s, @"[aeiou]", "!", RegexOptions.IgnoreCase);
        }
    }
}
