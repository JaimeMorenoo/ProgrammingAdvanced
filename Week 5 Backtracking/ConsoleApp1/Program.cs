namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NQueens queens = new NQueens(8);
            queens.PlaceQueens(0);

            int[] array = { 4, 10, 2 };

            List<List<int>> result = new List<List<int>>(); // The result of the subset
            List<int> sublist = new List<int>();

            Subset subset = new Subset();
            subset.Solve(array,result,sublist);

            foreach (var item in result)
            {
                Console.WriteLine(String.Join(" ", item));
            }

            foreach (var item in subset.Solve2(array))
            {
                Console.WriteLine(String.Join(" ", item));
            }


        }
    }
}