using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Petalas
    {
        //Petalas caem a 5cm por segundo (5cm/s)
        //80 segundos para atingir o chao

        public static double SakuraFall(double v)
        {
            //O movimento da pétala é bastante complicado,
            //então neste caso podemos ver a velocidade como uma constante durante sua queda.
            const int ALTURA_GALHO = 400; //5x80

            //Se a velocidade inicial não for positiva, o valor de retorno deve ser 0
            if (v < 0)
            {
                return 0;
            }
                       
            double tempo = ALTURA_GALHO / v;

            return tempo;
        }
    }
}
