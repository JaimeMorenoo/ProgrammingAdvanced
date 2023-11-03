using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Conquer
{
    internal class Sum
    {
        public int SumR(int[] array,int index)
        {
            if (index == 0) return 0;


            return array[index - 1] + SumR(array, index - 1);
        }

        public int SumL(List<int> list, int index)
        {
            if(index == 0) return 0;

            return list[index - 1] + SumL(list, index - 1);
        }
    }
}
