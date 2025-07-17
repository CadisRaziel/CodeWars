using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Divisor
    {
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            List<int> novaLista = new List<int>();                 
        
            foreach(var item in numbers)
            {
                if(item % divisor == 0)
                {
                    novaLista.Add(item);
                }
            }

            return novaLista.ToArray(); 
        }
    }
}
