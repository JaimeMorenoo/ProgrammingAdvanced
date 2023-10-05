using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Priciples
{
    internal class Insertion
    {
        public void insertion(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                int tmp = array[i];
                int j;

                for (j = i; j > 0; j--)
                {
                    if (array[j - 1] < tmp) break;
                    array[j] = array[j - 1];
                }
                array[j] = tmp;
            }
        }
    }
}
