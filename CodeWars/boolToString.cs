using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class boolToString
    {
        public static string boolToWord(bool word)
        {
            if(word == true)
            {
                return "Yes";
            }else
            {
                return "False";
            }
        }
    }
}
