using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Occurences
{
    internal class Assignment
    {
        public int Ocurrences(int[] array, int n, int k)
        {
            int found = 0;
           

            if (n < 0 )
                return 0;

            if (array[n] == k)
            {
                found++;
            }
            

            return found + Ocurrences(array, n - 1, k);



        }
    }
}
