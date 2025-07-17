using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class HighRank
    {
        public static int HighestRank(int[] arr)
        {
            int resultadoFianl = 0;            
           
            var maisSeRepete = arr.GroupBy(x => x) //10: [10, 10, 10] / 3:  [3, 3, 3, 3]  etc..
              .Select(x => (Key: x.Key, Items: x.ToList()))  // Separa chave 3 - valor [3,3,3,3] etc..
              .GroupBy(x => x.Items.Count) // Count 3 → [{ Key: 10, Items: [10, 10, 10] }], /  Count 4 → [{ Key: 3, Items: [3, 3, 3, 3] }], etc..
              .OrderByDescending(x => x.Key) // Ordena os grupos do que tem maior contagem para o menor. ->  Count 4 → [{ Key: 3, Items: [3, 3, 3, 3] }], / Count 3 → [{ Key: 10, Items: [10, 10, 10] }], etc...
              .First() //Pega o grupo com maior contagem (neste caso, Count = 4).
              .Select(x => x.Key) //Extrai apenas os valores (chaves) desse grupo. No caso acima, só o número 3.
              .ToArray(); //Transforma isso em um array.


            //pega o numero que mais se reprete
            resultadoFianl = resultadoFianl = maisSeRepete.Max();

            /*
             // Se houver empate, retorna o maior entre os empatados
            // Se só um número mais se repete e ele for menor que o maior valor do array, retorna o maior valor
            var maiorValor = arr.Max();          
            resultadoFianl = (maisSeRepete.Length == 1 && maisSeRepete[0] < maiorValor)
                ? maiorValor
                : maisSeRepete.Max();
             */


            return resultadoFianl;
        }

    }
}
