using System.Security.Cryptography.X509Certificates;

namespace Recursive
{

    internal class Program
    {
        // Given a set of characters and a positive integer k, print all possible strings of length k
        // that can be formed from the given set.

        public static void caracters(char[]array, string input, int k)
        {
            if(input.Length == k)
            {
                Console.WriteLine(input);
                return;
            }

            for(int i = 0; i < array.Length; i++)
            {
                caracters(array, input + array[i], k);
            }

        }

        public static int Factorial (int number)
        {
            if (number == 0) return 1;
            

            return number * Factorial(number - 1);

            
        }

        public static int sumOfDigits(int number)
        {
            if (number == 0) return 0;

            return (number % 10) + sumOfDigits(number / 10);
        }

        public static string reverseNumber (int number)
        {
            if (number == 0) return "";

            return number % 10 + reverseNumber(number / 10);
        }

        public static bool Palindrome(string number)
        {
            if (number.Length == 0 | number.Length == 1) return true;

            if (number[0] == number[number.Length - 1])
            {
                return Palindrome(number.Substring(1, number.Length - 2));
            }
            return false;
        }

        public static int countNumber (int number, int x, int count)
        {
            if (number == 0) return count;

            int rem = number % 10;

            if(rem == x)
            {
                return countNumber(number/10, x, count + 1);
            }

            return countNumber(number / 10, x, count);
        }

        public static int stepsToZero (int number, int steps)
        {
            if (number == 0) return steps;

            if (number % 2 == 0) return stepsToZero(number / 2, steps + 1);

            if (number % 2 == 1) return stepsToZero(number - 1, steps + 1);

            return steps;
        }
        

        

        static void Main(string[] args)
        {
            Recursion recursion = new Recursion();

            RecursionArray recursion2 = new RecursionArray();

            Patterns patterns = new Patterns();

            Subset subsets = new Subset();


            //subsets.Subseq("", "hello");
            





        }
    }
}