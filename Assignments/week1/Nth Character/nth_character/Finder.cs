using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nth_character
{
    internal class Finder
    {
        public string naive(string[]array, int input)
        {
            string s = "";

            foreach(string x in array)
            {
                s += x;
            }

            return s[input].ToString();
        }

        public string search(string[]array, int input)
        {
            // Time Complexity O(n) & Space Complexity O(1)
            string words = string.Join("", array);
            return words[input].ToString();
        }
    }
}
