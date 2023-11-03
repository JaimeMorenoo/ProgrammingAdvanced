using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MissingLink
{
    internal class Missing
    {
        public void Bubble(int[]array, int n)
        {
            if (n == 1) return;

            for(int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }

            Bubble(array, n - 1);
        }
        
        public int MissingLink(int[] array, int n, int result)
        {
            if (n == array.Length - 1) return -1;

            if (array[n]  + 1 != array[n + 1] && array[n] > 0)
            {
                result = array[n] + 1;
                return result;
            }


            if(result == -1)
            {
                return MissingLink(array, n + 1, result);
            }
            else
            {
                return result;
            }
        }
    }
}
