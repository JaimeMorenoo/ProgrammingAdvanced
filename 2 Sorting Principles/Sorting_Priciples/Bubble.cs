using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Priciples
{
    internal class Bubble
    {
        public void bubble(int[] array)
        {
            for(int i = array.Length - 1; i >= 0; i--)
            {
                bool flag = false;
                for(int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int number = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = number;

                        flag = true;
                    }
                }
                if (!flag) break;
            }
        }
    }
}
