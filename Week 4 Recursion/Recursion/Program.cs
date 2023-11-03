using System;
using TM.ProgrammingAdvanced;


namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
  

            string folder = @"C:\abay1iiitky";

            FindKey find = new FindKey();

            Recursion recursion = new Recursion();

            Console.WriteLine(recursion.natural(5));

            Console.WriteLine(recursion.digits(123));

            Console.WriteLine(recursion.reverse("hello"));
            

        }
    }
}