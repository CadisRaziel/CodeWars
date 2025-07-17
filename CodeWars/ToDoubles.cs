using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ToDoubles
    {
        public static double[] ToDoubleArray(string[] stringArray)
        {
           
            var resultado = stringArray.Select(x => Double.Parse(x, CultureInfo.InvariantCulture)).ToArray();

            return resultado;
        }
    }
}
