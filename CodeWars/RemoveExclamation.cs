using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class RemoveExclamation
    {
        public static string RemoveExclamationMarks(string s) => string.Join("", s.Select(x => x.ToString().Replace("!", "")));

    }
}
