using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class SumString
    {
        public static string Add(string a, string b)
        {
            BigInteger parseA = 0;
            BigInteger.TryParse(a, out parseA);

            BigInteger parseB = 0;
            BigInteger.TryParse(b, out parseB);

            BigInteger soma = 0;

           
           soma = parseA + parseB;
            
               
            var resultado = soma.ToString();

            return resultado; 
        }
    }
}
