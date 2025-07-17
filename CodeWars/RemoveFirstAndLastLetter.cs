using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class RemoveFirstAndLastLetter
    {
        public static string Remove_char(string s)
        {
            if(s.Length >= 2)
            {      
                return s.Substring(1, s.Length - 2);
            } else
            {
                return String.Empty;
            }               
        }
    }
}
