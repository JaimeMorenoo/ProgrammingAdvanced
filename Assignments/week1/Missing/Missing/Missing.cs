using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Missing
{
    internal class Missing
    {
        public string naive(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                int number = array[i];

                int next_number = array[i + 1];

                if(number + 1 != next_number)
                {
                    return (number + 1).ToString();
                }
            }
            return "There is no missing value";
        }

        public string advanced(int[] array)
        {
            // Time Complexity O(n) & Space Complexity O(1)

            int length = array.Length;

            int n = ((length + 1) * (array[0] + array[length - 1]))/ 2;

            int m = 0; 

            foreach(int x in array)
            {
                m += x;
            }

            if(n == m)
            {
                return "There is no missing number";   
            }


            return (n - m).ToString();
        }
    }
}
