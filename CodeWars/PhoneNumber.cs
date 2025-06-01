using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class PhoneNumber
    {
        public static string CreatePhoneNumber(int[] numbers)
        {

            var takeTreeFirstsNumbers = string.Join("", numbers.Take(3));  
            var addParentesesInTreeFirstNumbers = takeTreeFirstsNumbers.PadLeft(takeTreeFirstsNumbers.Length + 1 , '(').PadRight(takeTreeFirstsNumbers.Length + 2, ')');
            //Console.WriteLine(addParentesesInTreeFirstNumbers);
            //(123)


            var takeTreeMidNumbers = string.Join("", numbers.Skip(3).Take(3));
            //Console.WriteLine(takeTreeMidNumbers);
            //456

            var addSpacingtakeTreeMidNumbers = takeTreeMidNumbers.PadLeft(takeTreeMidNumbers.Length + 1, ' ');

            var takeLastFourNumbers = string.Join("", numbers.Skip(6).Take(4));
            //Console.WriteLine(takeLastFourNumbers);
            //7890            

            var takeApipeAndParentesesAtLastFourNumbers = takeLastFourNumbers.PadLeft(takeLastFourNumbers.Length + 1, '-');

            var concatTwoFirstStrings = string.Concat(addParentesesInTreeFirstNumbers, addSpacingtakeTreeMidNumbers);
            //Console.WriteLine(concatTwoFirstStrings);


            var concatAllString = string.Concat(concatTwoFirstStrings, takeApipeAndParentesesAtLastFourNumbers);
            //Console.WriteLine(concatAllString);


            return concatAllString;
        }
    }
}
