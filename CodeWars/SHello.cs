using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class SHello
    {
        public static string SayHello(string[] name, string city, string state)
        {
            string joinString = "";

            for(int i = 0; i < name.Length; i++)
            {
                joinString += name[i];
                if (i < name.Length - 1)
                {
                    joinString += " ";
                }
            }
            var result = $"Hello, {joinString}! Welcome to {city}, {state}!";            

            return result;
        }
    }
}
