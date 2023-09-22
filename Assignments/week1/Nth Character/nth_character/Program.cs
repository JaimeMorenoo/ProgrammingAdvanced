namespace nth_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "words.txt";

            string[] words = File.ReadAllLines(file);

            Finder find = new Finder();

            // naive will take a very very long time to find it.
            //Console.WriteLine(find.naive(words, 1));

            Console.WriteLine(find.search(words, 4728391));

          
        }
    }
}