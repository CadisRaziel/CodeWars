using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class TresTigres
    {
        public static char ComidaParaTresTigres(int n)
        {
            if (n <= 0 || n > 1000)
                return 'N';

            var divisao1 = n / 3;
            if(divisao1 >= n)
            {
                  Console.WriteLine($"divisão maior que n {string.Join("", divisao1)}");                
            } else
            {
                  Console.WriteLine($"divisão menor que n {string.Join("", divisao1)}");                

            }

                return 'S';
        }
    }
}
