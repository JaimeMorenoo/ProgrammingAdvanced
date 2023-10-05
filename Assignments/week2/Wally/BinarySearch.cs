using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wally
{
    internal class BinarySearch
    {
        public string search(string[] array,string word, bool swap)
        {
             int start = 0;
             int end = array.Length - 1;
             
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (array[mid] == word)
                {
                    return word;
                }
                else if ( swap == false && string.Compare(word, array[mid]) > 0)
                {
                    end = mid - 1;
                }
                else if (swap == true && string.Compare(word, array[mid]) < 0)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }

            }
            return "Not founded";
        }
    }
}
