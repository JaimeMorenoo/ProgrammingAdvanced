using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Priciples
{
    internal class Selection
    {
        public void selection(int[] array)
        {
            for (int i = 0;  i < array.Length; i++)
            {
                int min = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min]) min = j;

                }
                int number = array[i];
                array[i] = array[min];
                array[min] = number;
            }
            
        }
    }
}
