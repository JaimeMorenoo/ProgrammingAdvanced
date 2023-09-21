namespace week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "sorted_numbers.txt";
            // Convertir el array
            int[] array = Array.ConvertAll(File.ReadAllLines(file), Int32.Parse);
            Searching search = new Searching();
            Console.WriteLine($"Linear: {search.Linear(array, 45)} - count: {search.count}");
            Console.WriteLine($"Random: {search.random(array, 899)} - count: {search.count}");
            Console.WriteLine($"Binary Search: {search.binary(array, 601)} - count:  {search.count}");
            
        }
    }
}