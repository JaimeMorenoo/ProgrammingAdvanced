using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wally
{
    internal class Selection
    {
        public string selection(string[] array, string word)
        {
            BinarySearch binarySearch = new BinarySearch();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (string.Compare(array[j], array[min]) < 0)
                    {
                        min = j;
                    }
                    string temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                }
            }

            return binarySearch.search(array, word, true);
        }
    }
}
