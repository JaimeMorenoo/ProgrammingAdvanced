using System.Text;

namespace _04_Unique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment uni = new Assignment();

            string test = "aabbccdde eff";

            string[] splitted = test.Split(" ");
            string result = "";

            Console.WriteLine(uni.Unique(test, 0, ""));
            Console.WriteLine(uni.Unique2(splitted,0, result));
        }
    }
}