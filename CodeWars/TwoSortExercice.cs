using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class TwoSortExercice
    {
        public static string TwoSort(string[] s)
        {
            var order = s.OrderBy(x => x);
            var orderFist = s.OrderBy(x => x, StringComparer.Ordinal).First();

            var orderFirstToArray = orderFist.ToCharArray();

            var result = string.Join("***", orderFirstToArray);
            

            return result;
        }
    }
}
