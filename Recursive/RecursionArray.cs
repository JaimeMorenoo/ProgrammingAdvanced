using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    internal class RecursionArray
    {

        public bool arraySorted(int[] array, int index)
        {
            if (index == array.Length - 1) return true;


            return array[index] < array[index + 1] && arraySorted(array, index + 1);

        }
        // La diferencia entre que uno use && y || es que cuando buscamos un sorted array se tienen que cumplir la condicion
        // en todas las llamdas a la función mientras que en un linear search la mayoria dara false entonces tenemos que seguir buscando
        public bool linearSearch(int[]array, int index, int x)
        {
            if (index == array.Length) return false;


            return array[index] == x || linearSearch(array, index + 1, x);
        }

        public int linearSearchIndex(int[]array, int index, int x)
        {
            if(index == array.Length) return -1;

            if (array[index] == x) return index;
            else
            {
                return linearSearchIndex(array, index + 1, x);
            }
                    
        }

        public List<int> linearSearchList(int[]array,int index, int x,List<int> list)
        {
            if(index == array.Length) return list;

            if (array[index] == x)
            {
                list.Add(index);
            }


            return linearSearchList(array, index + 1, x, list);
        }

        public List<int> linearSearchListNoArgument(int[]array, int index, int x)
        {
            List<int> list = new List<int>();

            if (index == array.Length) return list;

            if(array[index] == x) list.Add(index);

            List<int> answerFromBelow = linearSearchListNoArgument(array, index + 1, x);

            list.AddRange(answerFromBelow);

            return list;
        }

            
    }
}
