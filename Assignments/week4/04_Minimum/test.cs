using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _04_Minimum
{
    internal class test
    {
        public int Minimum(int[] array, int n)
        {
            if (n == 0) return 0;
            if (n == 1) return array[0];

            return Math.Min(array[n-1], Minimum(array, n-1));
        }
    }
}
