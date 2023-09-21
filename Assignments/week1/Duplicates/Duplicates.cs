using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicates
{
    internal class Duplicates
    {
        public string naive(string[]array,string input)
        {
            string s = "";
            int counter = 0;
            for(int i=0;i<array.Length;i++)
            {
                string word = array[i].Substring(0,input.Length);
                counter++;
                if(input == word)
                {
                    string match = array[i];
                    for(int j = counter; j < array.Length; j++)
                    {
                        if(array[j] == match)
                        {
                            s += match + " ";
                        }
                    }
                }                           
            }
            if(s == "")
            {
                return "No duplicates found.";
            }
            return s.Trim();
        }

        public string search(string[]array,string input)
        {
            // Time Complexity = O(n^2) & Space Complexity = O(1)

            StringBuilder result = new StringBuilder();
         
            foreach(string word in array)
            {
                if (word.StartsWith(input))
                {
                    int count = array.Count(x => x == word);

                    if(count > 1)
                    {
                       result.Append(word).Append(' ');
                    }                   
                }
            }

            if (result.Length == 0)
            {
                return "No duplicates found.";
            }


            return result.ToString().TrimEnd();
        }
    }
}
