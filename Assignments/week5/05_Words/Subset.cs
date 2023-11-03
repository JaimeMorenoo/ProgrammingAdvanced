using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Words
{
    internal class Subset
    {
        public void GenerateWords(string input, int index, string currentCombination, List<string> words)
        {
            if(index == input.Length) // BASE CASE
            {
                words.Add(currentCombination);
                return;
            }

            GenerateWords(input, index + 1, currentCombination + " " + input[index], words); //with spaces recursive

            GenerateWords(input, index + 1, currentCombination + input[index], words); //without spaces recuriseve; 
        }

        public List<string> Generate(string input)
        {
            List<string> result = new List<string>();

            GenerateWords(input, 0, "", result);
            return result;
        }

        

    }
}
