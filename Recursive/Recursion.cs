using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    internal class Recursion
    {
        public string ReverseString(string input)
        {
            if (input == "") return "";

            //hello -> (h) + ello -> (e) + llo...
            return ReverseString(input.Substring(1)) + input[0];

        }

        public bool Palindrome (string input)
        {
            if (input.Length == 0 || input.Length == 1) return true;

            if (input[0] == input[input.Length - 1])
            {
                // kayak -> k = k then a = a then y
                return Palindrome(input.Substring(1,input.Length - 2));
            }

            return false;
        }

        public string Binary(int number)
        {
            if (number == 0) return "";

            return Binary(number / 2 ) + number % 2;
        }

        public int NaturalNumbers (int number)
        {
            if(number == 0) return 0;

            return NaturalNumbers(number - 1) + number;
        }

        public int BinarySearch(int[]A, int left, int right, int x)
        {
            if (left > right) return -1;

            int mid = (left + right) / 2;
            if(x == A[mid]) return mid; // position

            if (x < A[mid]) return BinarySearch(A, left, mid - 1, x);

            return BinarySearch(A, mid + 1, right, x); 
        }

        // Write a countDown(int number) method in Java using Recursion which prints countdown till zero to console,
        // like count(3) should print 3 2 1 0

        public string countDown (int number)
        {
            if (number == 0) return "0";

            return number + countDown(number - 1) ;
        }

        public int Fibonacci (int number)
        {
            if(number == 0) return 0;
            if (number == 1) return 1;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }





    }
}
