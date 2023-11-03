using System;
using Module_01;
namespace nth
{
    using System;
    using Module_01;
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "words.txt";

            Assignment find = new Assignment();

            // naive will take a very very long time to find it.
            //Console.WriteLine(find.naive(words, 1));
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(find.NthCharacter(input, file));

           

        }
    }
}

namespace Module_01
{
    using System;
    public class Assignment
    {
        public string NthCharacter(int number, string filename)
        {
            // Time Complexity O(n) & Space Complexity O(1)
            string[] array = File.ReadAllLines(filename);
            string words = string.Join("", array);
            return words[number].ToString();
        }
    }
}