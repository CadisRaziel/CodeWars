using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class EvenOrOddunc
    {
        public static string EvenOrOdd(int number)
        {
            string result = "";

           
                if (number % 2 == 0)
                {
                    result = "Even";
                } else
                {
                    result = "Odd";
                }
           
          

            return result;
        }
    }
}
