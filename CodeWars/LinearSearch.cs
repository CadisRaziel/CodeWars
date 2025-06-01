using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class LinearSearch
    {        
        /// O(n) -> Percorre o array inteiro, porém uma vez só    
        /// O(1) -> complexidade de memoria, pois sera retornardo apenas 1 elemento, unica coisa que preciso manter em memória
        public static int LinearS(int[] arr, int target)
        {         

            for (int i = 0; i < arr.Length; i++) {

                if(i == target)
                {
                    return i;                  
                } 
            }
            return -1;
        }
    }
}
