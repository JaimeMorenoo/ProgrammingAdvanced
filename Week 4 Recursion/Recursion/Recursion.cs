using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Recursion
    {
        public int natural(int n)
        {
            // Sum of first n natural numbers
            if (n == 0) return 0;
            if (n == 1) return 1;

            return n + natural(n - 1);
        }

        public int digits (int n)
        {
            if (n < 10) return 1;

            return 1 + digits(n/10);
        }

        public string reverse (string s)
        {
            if (s.Length == 1 || string.IsNullOrEmpty(s)) return s;

            return reverse(s.Substring(1)) + s[0];
        }
    }
}
