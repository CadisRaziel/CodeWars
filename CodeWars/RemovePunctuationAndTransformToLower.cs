using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class RemovePunctuationAndTransformToLower
    {
        public static string Borrow(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in s)
            {             
                if (!char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString().ToLower().Replace(" ", "");
            
        }
    }
}
