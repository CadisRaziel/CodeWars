using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace CodeWars
{
    public class Dupe
    {
        public static bool Twins(int[] arr)
        {

            bool resultado = false;
         
            List<int> lista = new List<int>();

            Dictionary<int, int> Mapeamento = arr
            .GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count());

            var condicao = Mapeamento.Values.All(value => value == 2);


            for (int i = 0; i < arr.Length; i++)
            {    
                if (lista.Contains(arr[i]) && arr[i] % 2 == 0 && condicao)
                {      
                    resultado = true;
                } else
                {
                    lista.Add(arr[i]);
                }
            }


            return resultado;
        }
    }
}





//namespace CodeWars
//{
//    public class Dupe
//    {
//        public static bool Twins(int[] arr)
//        {

//            bool resultado = false;
//            int tamanho = arr.Length;
//            List<int> lista = new List<int>();


//            //GroupBy -> Agrupa os iguais
//            //Where(g => g.Count() > 2) -> filtra só os que se repetem mais de 2 vezes 
//            //Select(g => g.Key) → pega o número (não os itens).
//            //ToList() → coloca numa lista.

//            //Em uma condicional ele nao tem como verificar se é maior que 2 etc..
//            var repetidos = arr
//             .GroupBy(x => x)
//             .Where(g => g.Count() > 2)
//             .Select(g => g.Key)
//             .ToList();
//            Console.WriteLine($"uepa {string.Join(",", repetidos)}");

//            Dictionary<int, int> Mapeamento = arr
//            .GroupBy(x => x)
//            .ToDictionary(g => g.Key, g => g.Count());
//            Console.WriteLine($"uepa {string.Join(",", Mapeamento.Values)}");
//            /*
//             ARRAY:
//            int[] arraylist15 = { 2, 16, 2, 17, 0, 16, 2};
            
//            RETORNO:
//            2 => 3
//            16 => 2
//            17 => 1
//            0 => 1

//             */

//            Console.WriteLine($"uepa {string.Join(",", Mapeamento.Values)}");

//            bool existeMaiorQueDois = Mapeamento.Any(kvp => kvp.Value > 2);



//            for (int i = 0; i < tamanho; i++)
//            {
//                if (lista.Contains(arr[i]) && arr[i] % 2 == 0 && existeMaiorQueDois)
//                {
//                    resultado = true;
//                }
//                else
//                {
//                    lista.Add(arr[i]);
//                }
//            }


//            return resultado;
//        }
//    }
//}
