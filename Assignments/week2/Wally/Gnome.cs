using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wally
{
    internal class Gnome
    {
        public string gnome(string[] array, string word)
        {
            int index = 0;

            while (index < array.Length)
            {
                if (index == 0)
                    index++;
                if (string.Compare(array[index] , array[index - 1]) <= 0)
                    index++;
                else
                {
                    string temp = "";
                    temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;
                    index--;
                }
            }

            BinarySearch search = new BinarySearch();
            return search.search(array, word, false);
        }
    }
}
