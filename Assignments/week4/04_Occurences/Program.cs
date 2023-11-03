namespace _04_Occurences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment test = new Assignment();

            int[] array = { 7, 8, 5, 4, 1, 2, 8, 8, 9, 6, 5, 4, 8 };
            int x = 8;
            int n = array.Length - 1;

            Console.WriteLine(test.Ocurrences(array, n, x));
        }
    }
}