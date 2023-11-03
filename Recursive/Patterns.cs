using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    internal class Patterns
    {
        public void Triangle (int row, int column)
        {
            if (row == 0) return;

            if(column < row)
            {
                Console.Write("*");
                Triangle(row, column + 1);
            }
            else
            {
                Console.WriteLine();
                Triangle(row - 1, 0);
            }
        }

        public void NormalTriange(int row, int column)
        {
            if (row == 0) return;

            if (column < row)
            {
                
                NormalTriange(row, column + 1);
                Console.Write("*");
            }
            else
            {
                
                NormalTriange(row - 1, 0);
                Console.WriteLine();
            }

        }

        public void Combinations(int[]array, int r, int index, int[] data, int i  )
        {
         if (i == r)
            {
                for(int j = 0; j < r; j++)
                {
                    Console.Write(data[j]);
                }
                Console.WriteLine();
                return;
            }

            if (index >= array.Length) return;
            data[i] = array[index];

            Combinations(array, r, index + 1, data, i + 1);
            Combinations(array, r, index + 1, data, i);

        }

        
    }
}
