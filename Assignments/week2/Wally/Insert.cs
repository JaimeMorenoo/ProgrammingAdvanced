using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wally
{
    internal class Insert
    {
        public string insert(string[] array, string word)
        {
            for (int i = 0; i < array.Length; i++)
            {


                string tmp = array[i];
                int j;

                for (j = i; j > 0; j--)
                {
                    if (string.Compare(array[j - 1], tmp)< 0) break;
                    array[j] = array[j - 1];
                }
                array[j] = tmp;
            }

            BinarySearch search = new BinarySearch();
            return search.search(array, word, true);
        
    }
    }
}
