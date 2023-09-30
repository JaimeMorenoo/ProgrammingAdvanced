using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wally
{
    internal class Brick
    {
        public string brick(string[] array, string word)
        {
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;
                string temp = "";

                // Perform Bubble sort on
                // odd indexed element
                for (int i = 1; i <= array.Length - 2; i = i + 2)
                {
                    if (string.Compare(array[i] , array[i + 1]) < 0)
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSorted = false;
                    }
                }

                // Perform Bubble sort on
                // even indexed element
                for (int i = 0; i <= array.Length - 2; i = i + 2)
                {
                    if (string.Compare(array[i] , array[i + 1]) < 0)
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSorted = false;
                    }
                }
            }
            BinarySearch search = new BinarySearch();
            return search.search(array, word, false);
        }
    }
}
