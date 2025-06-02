using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class DecTools
    {
        public static int Digits(ulong n)
        {
            var ulongLength = n.ToString().Length;
            return ulongLength;
        }        
    }
}
