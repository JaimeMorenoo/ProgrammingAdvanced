using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Subwords
{
    internal class Subwords
    {
        public void subWords(string input, string result, List<string> words)
        {          

            if (result.Length > 1)
            {
                words.Add(result);
            }

            if (string.IsNullOrEmpty(input))
            {
                return;
            }

            for(int i = 0; i < input.Length; i++)
            {
                subWords(input.Substring(i + 1), result + input[i], words);
            }

        }
    }
}
