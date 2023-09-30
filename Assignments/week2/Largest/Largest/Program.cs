namespace Largest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Largest l = new Largest();
            int[] array = { 6, 9, 16, 5};

            Console.WriteLine(l.largest(array));
        }
    }
}