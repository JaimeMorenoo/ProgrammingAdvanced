namespace Missing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitted = input.Split(" "); 
            int[] numbers = Array.ConvertAll(splitted, int.Parse);

            Missing missing = new Missing();

            Console.WriteLine($"The missing value using the naive way: {missing.naive(numbers)}");
            Console.WriteLine($"The missing value using the advanced way: {missing.advanced(numbers)}");
        }
    }
}