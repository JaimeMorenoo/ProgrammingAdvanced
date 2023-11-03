using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _04_Unique
{
    internal class Assignment
    {
        public string Unique(string s, int index, string result)
        {
            if (index >= s.Length) return result;

           
            char current = s[index];

            if(!result.Contains(current)) result += current;

            return Unique(s, index + 1, result);

        }

        public string Unique2(string[] strings, int stringIndex, string result)
        {
            if (stringIndex >= strings.Length) return result.ToString();

            string currentString = strings[stringIndex];

            string unique_string = Unique(currentString, 0, "");
            
            

            return Unique2(strings, stringIndex + 1, result + unique_string + " ");
        }
    }
}
