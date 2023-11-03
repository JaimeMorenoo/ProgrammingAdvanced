using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_01;

namespace Module_01
{
    internal class aaaa
    {
        public string naive(string[] array, int input)
        {
            string s = "";

            foreach (string x in array)
            {
                s += x;
            }

            return s[input].ToString();
        }

        public string NthCharacter(int number, string filename)
        {
            // Time Complexity O(n) & Space Complexity O(1)
            string[] array = File.ReadAllLines(filename);
            string words = string.Join("", array);
            return words[number].ToString();
        }
    }
}
