using System;
using System.Collections.Generic;
using System.Text;

namespace Module_01
{
    internal class Assignment
    {
        public string naive(string[] array, string input)
        {
            string s = "";
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                string word = array[i].Substring(0, input.Length);
                counter++;
                if (input == word)
                {
                    string match = array[i];
                    for (int j = counter; j < array.Length; j++)
                    {
                        if (array[j] == match)
                        {
                            s += match + " ";
                        }
                    }
                }
            }
            if (s == "")
            {
                return "No duplicates found.";
            }
            return s.Trim();
        }

        public string Duplicates(string start, string filename)
        {
            // Time Complexity = O(n^2) & Space Complexity = O(1)

            string[] array = File.ReadAllLines(filename);
            string result = "";

            foreach (string word in array)
            {
                if (word.StartsWith(start))
                {
                    int count = array.Count(x => x == word);

                    if (count > 1 && !result.Contains(word))
                    {
                        result += word.ToString() + " ";
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
