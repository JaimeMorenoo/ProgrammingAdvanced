using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wally
{
    internal class Finding
    {
        public string Bubble(string[] array, string word)
        {
            for(int i = array.Length - 1; i >= 0; i--)
            {
                bool flag = false;
                for(int j = 0; j < i; j++)
                {
                    if (string.Compare(array[j], array[j + 1]) < 0)
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
                    }
                    
                }
                if (!flag) break;
            }

            BinarySearch look = new BinarySearch();
            return look.search(array, word, false);
        }
    }
}
