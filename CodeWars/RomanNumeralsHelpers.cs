using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class RomanNumeralsHelpers
    {
        public static string ToRoman(int n)
        {
        
           

            return "";
        }

        public static int FromRoman(string romanNumeral)
        {
            switch(romanNumeral)
            {
                case "I":
                    return 1;
                case "IV":
                    return 4;
                case "V":
                    return 5;
                case "IX":
                    return 9;
                case "X":
                    return 10;
                case "XL":
                    return 40;
                case "L":
                    return 50;
                case "XC":
                    return 90;
                case "C":
                    return 100;
                case "CD":
                    return 400;
                case "D":
                    return 500;
                case "CM":
                    return 900;
                case "M":
                    return 1000;
                default:
                    return 0;
            }           
        }
    }
}



/*
 
 to roman:
2000 -> "MM"
1666 -> "MDCLXVI"
  86 -> "LXXXVI"
   1 -> "I"

from roman:
"MM"      -> 2000
"MDCLXVI" -> 1666
"LXXXVI"  ->   86
"I"       ->    1



+--------+-------+
| Symbol | Value |
+--------+-------+
|    M   |  1000 |
|   CM   |   900 |
|    D   |   500 |
|   CD   |   400 |
|    C   |   100 |
|   XC   |    90 |
|    L   |    50 |
|   XL   |    40 |
|    X   |    10 |
|   IX   |     9 |
|    V   |     5 |
|   IV   |     4 |
|    I   |     1 |
+--------+-------+
 
 
 */