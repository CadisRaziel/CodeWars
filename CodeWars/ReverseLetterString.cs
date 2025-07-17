using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ReverseLetterString
    {
        public static string ReverseLetter(string str)
        {
            var verificarStringERemoverCaracteresEspeciais = str.ToCharArray().Where(x => char.IsLetter(x));         

            var resultadoRevertido = verificarStringERemoverCaracteresEspeciais.Reverse();   

            var resultadoFinal = string.Join("", resultadoRevertido);
            
            return resultadoFinal;
        }
    }
}
