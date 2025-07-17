using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class SearchVogal
    {
        public static object[] IsVow(object[] a)
        {        

            var mapeamentoVogais = new Dictionary<int, string>()
            {
                {97, "a"},
                {101, "e"},
                {105, "i"},
                {111, "o"},
                {117, "u"}
            };

            var acumular = new List<object>();

            foreach (var item in a)
            {
                int numero = Convert.ToInt32(item); 
                if (mapeamentoVogais.ContainsKey(numero))
                {
                    acumular.Add(mapeamentoVogais[numero]); //Utilizar [] no dictionary o c# pega o VALUE !!
                }
                else
                {
                    acumular.Add(numero);
                }
            }

            var resultado = acumular.ToArray();

            return resultado;
        }
    }
}
