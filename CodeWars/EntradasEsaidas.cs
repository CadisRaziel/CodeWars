using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class EntradasEsaidas
    {
        public static string GetDrinkByProfession(string p)
        {

            var Jabroni = "Jabroni";
            var SchoolCounselor = "School Counselor";
            var Programmer = "Programmer";
            var BikeGangMember = "Bike Gang Member";
            var Politician = "Politician";
            var Rapper = "Rapper";
            var defaultString = "Beer";

            var result = "";

            if (p.Equals(Jabroni, StringComparison.OrdinalIgnoreCase))
            {
                result = "Patron Tequila";
            }
            else if (p.Equals(SchoolCounselor, StringComparison.OrdinalIgnoreCase))
            {
                result = "Anything with Alcohol";
            }
            else if (p.Equals(Programmer, StringComparison.OrdinalIgnoreCase))
            {
                result = "Hipster Craft Beer";
            }
            else if (p.Equals(BikeGangMember, StringComparison.OrdinalIgnoreCase))
            {
                result = "Moonshine";
            }
            else if (p.Equals(Politician, StringComparison.OrdinalIgnoreCase))
            {
                result = "Your tax dollars";
            }
            else if (p.Equals(Rapper, StringComparison.OrdinalIgnoreCase))
            {
                result = "Cristal";
            }
            else
            {
                return defaultString;
            }

            return result;
        }


        //public static string GetDrinkByProfession(string p)
        //{
        //    return new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
        //    {
        //      { "Jabroni", "Patron Tequila" },
        //      { "School Counselor", "Anything with Alcohol" },
        //      { "Programmer", "Hipster Craft Beer" },
        //      { "Bike Gang Member", "Moonshine" },
        //      { "Politician", "Your tax dollars" },
        //      { "Rapper", "Cristal" }
        //    }.TryGetValue(p, out string value) ? value : "Beer";
        //        }
        //    }
    }
}
