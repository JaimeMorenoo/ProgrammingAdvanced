using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Factorial
    {
        // n! = n * (n-1) * (n-2)....

        public int Iterative(int n)
        {
            if (n < 2) return 1;

            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;

        }

        public int recursion (int n)
        {
            if (n <= 2) return 1;
            return n * recursion(n - 1);
        }
    }
}
