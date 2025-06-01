using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CommaDelimiters
    {
        public static string PrintArray(object[] array)
        {
            char padStart = '"';
            char padEnd = '"';
            string resultArray = "";
           
            bool hasString = false;

            string insertVirgule = string.Join(",", array);
                               
            foreach (var item in insertVirgule)
            {
                if (item.GetType() == typeof(string))
                {
                    hasString = true;
                }

                resultArray += item;                
            }            

            var result =  resultArray.PadLeft(resultArray.Length + 1, padStart).PadRight(resultArray.Length + 2, padEnd);


            if (hasString)
            {
                return result;
            }
            else
            {
                return resultArray;
            }
        }
    }
}


//Sempre que usar padLeft ou padEnd eu preciso atribuir a uma variavel (pois se eu nao fizer isso ele nao criará uma copia da original e nao atribuirá a modificaçao dos pad)
//Padleft precisa ser maior que o tamanho da string + 1
//PadRight precisa ser maior que o tamanho da string + 2