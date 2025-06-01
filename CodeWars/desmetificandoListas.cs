using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class desmetificandoListas
    {
        public static void DesmestificandoLista()
        {
            List<string> list1 = new List<string>() { "'-", "'-", "'-", "'-", "'-", };
            List<string> list2 = new List<string>() { "'", "'", "'", "'", "'", };
            List<string> list3 = new List<string>() { "*", "*", "*", "*", "*", };
            
            var sb = new StringBuilder();

            for (int i = 0; i < list3.Count(); i++)
            {

               var result = sb.AppendLine(list3[i]);
                Console.Write(result);
                //for(int j = 0; j < list2.Count(); j++)
                //{
                //    Console.Write($"{list1[i]}{list2[i]}, ");
                //}  
            }
        }
    }
}
