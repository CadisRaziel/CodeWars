using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    public class MexicanWave
    {
        public static List<string> wave(string str)
        {

            //O que eu preciso fazer.. \/
            //"hello" => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]

            //o que seria mais interessante eu tentar criar a sequencia de UpperCase
            //ou adicionar a string em uma nova lista ?


            //para eu adicionar em uma nova lista as varias strings eu necessariamente precisaria primeiro fazer os uppercases, pois seriam novas strings..



            List<string> result = new List<string>();
          

            for (int i = 0; i < str.Length; i++)
            {

                var x = Regex.Replace(str[i].ToString(), @"\b([a-z])", m => m.Value.ToUpper());
                Console.WriteLine(string.Join(", ", x));
                //i -> indice <0,1,2,3,4>...
                //str[i] -> h - e - l - l - o
                //str -> hello 5x

                //Console.WriteLine(string.Join(", ", str));

                //guardar = str[i].ToString().ToUpper();

                //result.Add(guardar);




            }



            return result;
        }
    }
}
