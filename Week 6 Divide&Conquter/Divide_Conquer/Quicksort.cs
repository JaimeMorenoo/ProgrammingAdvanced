using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Conquer
{
    internal class Quicksort
    {

        public List<int> Sort(List<int> list)
        {
            if(list.Count <= 1) return list;

            int pivot = list[0];

            List<int> smaller = new List<int>();
            List<int> bigger = new List<int>();

            foreach(var item in list)
            {
                if(item > pivot)
                {
                    bigger.Add(item);
                }
                else if (item < pivot)
                {
                    smaller.Add(item);
                }
            }

            smaller.Add(pivot);
            smaller = Sort(smaller);
            bigger = Sort(bigger);

            smaller.AddRange(bigger);
            

            return smaller;
        }
    }
}
