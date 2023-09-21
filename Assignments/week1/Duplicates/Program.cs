namespace Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "words.txt";

            string[] array = File.ReadAllLines(file);

            Duplicates duplicates = new Duplicates();
            //Console.WriteLine(duplicates.naive(array, "aa"));
            Console.WriteLine(duplicates.search(array, "aa"));
            
        }
    }
}