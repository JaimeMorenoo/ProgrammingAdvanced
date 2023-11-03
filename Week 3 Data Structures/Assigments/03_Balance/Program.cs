using System.Text.RegularExpressions;

namespace _03_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            string input = Console.ReadLine();

            input = Regex.Replace(input, "[A-Za-z ]", "");
            Assignment Search = new Assignment(input.Length);

            Console.WriteLine(Search.Balance(input));
        }
    }
}