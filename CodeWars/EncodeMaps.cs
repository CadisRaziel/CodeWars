using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class EncodeMaps
    {
        public static string Encode(string str)
        {

            str = str.ToLowerInvariant();
            List<string> acumular = new List<string>();

            var Mapeamento = new Dictionary<string, string>()
            {
                {"a", "1"},
                {"b", "2"},
                {"c", "3"},
                {"d", "4"},
                {"e", "5"},
                {"f", "6"},
                {"g", "7"},
                {"h", "8"},
                {"i", "9"},
                {"j", "10"},
                {"k", "11"},
                {"l", "12"},
                {"m", "13"},
                {"n", "14"},
                {"o", "15"},
                {"p", "16"},
                {"q", "17"},
                {"r", "18"},
                {"s", "19"},
                {"t", "20"},
                {"u", "21"},
                {"v", "22"},
                {"w", "23"},
                {"x", "24"},
                {"y", "25"},
                {"z", "26"}
            };

            char[] chars = str.ToCharArray();          

            foreach(var item in chars)
            {
                var mapped = Mapeamento.Where(x => x.Key == item.ToString()).Select(x => x.Value);
                acumular.AddRange(mapped); // Acumula o resultado
            }

            var resultadoFinal = string.Join("", acumular); // Concatena tudo em uma string 

            return resultadoFinal;
        }
    }
}


//foreach (var item in chars)
//{
//    var key = item.ToString();

//    if (Mapeamento.ContainsKey(key))
//    {
//        result.Add(Mapeamento[key]);
//    }
//    else
//    {
//        result.Add(key); // mantém o caractere original se não estiver no dicionário
//    }
//}