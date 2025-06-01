using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    //Even -> PAR
    //Odd -> IMPAR
    public class FindEvenOrOdd
    {
        public static int Find(int[] integers)
        {
            var result = FindOutlier(integers);


            return result;
        }

        private static int FindOutlier(int[] integers)
        {
            
            bool isEvenOutlier = IsEvenOutlier(integers);
            var outlier = FindOutlier(integers, isEvenOutlier ? 0 : 1);
            return outlier;
        }

        static bool IsEvenOutlier(int[] integers)
        {
            // Count odds and evens
            int even = 0;
            int odd = 0;
            foreach (var num in integers)
            {
                if (num % 2 == 0)
                {
                    even += 1;
                }
                else
                {
                    odd += 1;
                }
            }

            // Check which one occurs only once
            if (even == 1) return true;
            if (odd == 1) return false;
            throw new ArgumentException("No outlier in data.", nameof(integers));
        }

        private static int FindOutlier(int[] integers, int remainder)
        {
            foreach (var item in integers)
            {
                if (item % 2 == remainder)
                {
                    return item;
                }
            }

            throw new ArgumentException("No outlier in argument.", nameof(integers));
        }
    }
}
