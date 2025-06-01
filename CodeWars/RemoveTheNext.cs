using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class RemoveTheNext
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            List<object> result = new List<object>();

            for (int i = 0; i < arr.Length; i++) {

                if(i % 2 == 0)
                {
                    result.Add(arr[i]);
                }  
            }

            return result.ToArray();
        }
    }
}
