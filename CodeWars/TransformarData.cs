using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class TransformarData
    {
        public static string GetReadableTime(int seconds)
        {

        

            TimeSpan t = TimeSpan.FromMilliseconds(seconds);
           
            var formatado = string.Format("{0:D2}:{1:D2}:{2:D2}",
                t.Hours,
                t.Minutes,
                t.Seconds);

            foreach(var item in formatado)
            {
               //switch(item)
               // {
               //     case: 0
               // }

                Console.WriteLine(item);
            }

            return ";";

        }
    }
}
