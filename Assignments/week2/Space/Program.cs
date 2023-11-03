using System.Runtime.InteropServices;

namespace Space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = " ";
            string split = "";
            while(input != "")
            {
                
                input = Console.ReadLine();
                if(input != "")
                {
                    split += input + "!";
                }
                
                
            }
            split = split.Trim().Remove(split.Length - 1, 1);
            string[] output = split.Split("!");


            Space space = new Space();

            space.order(output);
        }
    }
}