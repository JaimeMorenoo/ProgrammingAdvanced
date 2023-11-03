using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Multiplication
{
    internal class Assignment
    {
        public int Multiplication(int a, int b)
        {
            if (b == 0) return 0;
            else if( b > 0)
            {
                return a + Multiplication(a, b - 1);
            }
            else
            {
                return -Multiplication(a, -b);
            }

            
        }

        public int Multiplication2(int[]array, int index)
        {
            if (index >= array.Length) return 1;

            int current = array[index];

            return Multiplication(current, Multiplication2(array, index + 1));  
        }
    }
}
