using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CapitalizeLetter
    {
        public static string Capitalize(string s, List<int> idxs)
        {
            List<int> indicesIguais = new List<int> ();
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {          
                //Aqui eu tenho os indices iguais
                indicesIguais = idxs.Where(x => x == i).ToList();

                if (indicesIguais.Count > 0)
                {
                    result += s[i].ToString().ToUpper();
                }
                else
                {
                    result += s[i];
                }

                //Aqui eu apenas colocava as strings do indice em maiusculo, as que nao estava no index nao aparecia
                //for (int j = 0; j < indicesIguais.Count; j++)
                //{                  
                //    result += s[i].ToString().ToUpper();
                //}
            }

          
            return result;
        }
    }
}
