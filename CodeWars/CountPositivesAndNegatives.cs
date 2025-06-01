using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CountPositivesAndNegatives
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input is null || input.Length == 0) return new int[0];

            int negatives = 0;
            int positives = 0;         
              
            
            foreach (int i in input) { 
                if (i < 0)
                {
                    negatives += i;
                } else if (i > 0) 
                {
                    positives++;
                }
            }

            int[] newResult = { positives, negatives};
            return newResult; 
        }
    }
}
