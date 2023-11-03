using System.Text.RegularExpressions;

namespace _04_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment test = new Assignment();

            string input = Console.ReadLine();

            Regex regex = new Regex(@"\d+");
            Match match = regex.Match(input);
            int x;
            if (match.Success)
            {
                x = Convert.ToInt32(match.Value);
            }
            else
            {
                x = 0;
            }
            if(x != 0)
            {
                Console.WriteLine(test.Sum(x));

            }
            else
            {
                Console.WriteLine(0);
            }
            
        }
    }
}