using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    internal class Subset
    {
       // STRINGS
        public void Skip(string process, string unprocess)
        {
            if (string.IsNullOrEmpty(unprocess))
            {
                Console.WriteLine(process);
                return;
            }

            char ch = unprocess[0];

            if (ch == 'a')
            {
                Skip(process, unprocess.Substring(1));
            }
            else
            {
                Skip(process + ch, unprocess.Substring(1));
            }
        }

        public string Skip2(string input)
        {
            if (input.Length == 0) return "";

            char ch = input[0];

            if(ch == 'a')
            {
                return Skip2(input.Substring(1));
            }
            else
            {
                return ch + Skip2(input.Substring(1));
            }
        }

        public string skipApple (string input)
        {
            if (string.IsNullOrEmpty(input)) return "";

            char ch = input[0];

            if (input.StartsWith("apple"))
            {
                return skipApple(input.Substring(5));
            }
            else
            {
                return ch + skipApple(input.Substring(1));
            }
        }

        // SUBSETS

        public void Subseq(string process, string unprocess)
        {
            if (string.IsNullOrEmpty(unprocess) )
            {

                Console.WriteLine(process);
                return;
            }

            char ch = unprocess[0];

            Subseq(process + ch, unprocess.Substring(1));
            Subseq(process, unprocess.Substring(1));
        }
    }
}
