using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1
{
    internal class Searching
    {


        public int count { get; set; }
        // Linear Algorithm
        public int Linear(int[] array, int number)
        {
            count = 0;

            for(int i = 0; i < array.Length; i++)
            {
                count++;
                if(array[i] == number)
                {
                    return i;
                }
            }
            return -1;
            
        }

        public int random(int[] array, int number)
        {
            count = 0;
            int max_count = array.Length * 2;

            Random random = new Random();

            while(count < max_count)
            {
                // Busca un numero del 0 al 100
                int index = random.Next(0, array.Length);
                if (array[index] == number)
                {
                    return index;
                }
                count++;
            }
            return -1;
        }

        public int binary(int[] array, int number)
        {
            int start = 0;
            int end = array.Length - 1;
            count = 0;

            // We set the beginning and end of the number search

            while(start <= end)
            {
                count++;
                int mid = (start + end) / 2;
                // We declare the mmid number
                if(array[mid] == number)
                {
                    return mid;
                }
                else if(number < array[mid])   
                {
                    // If the number is less than the mid the end will be the mid (end = 499)
                    end = mid - 1;
                }
                else
                {
                    // If the number is more than the mid the start becomes the mid (start = 501)
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
