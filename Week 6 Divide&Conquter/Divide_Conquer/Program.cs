namespace Divide_Conquer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();
            int[] array = { 1, 2, 3 };


            List<int> list = new List<int>(new int[] { 3, 4, 6, 8, 12, 13, 17, 65, 34, 79, 23, 11, 9, 88, 76 });
            Quicksort quicksort = new Quicksort();

            list = quicksort.Sort(list);
            Tower tower = new Tower();

            int disk = 3;
            tower.Solve(disk, 'A', 'B', 'C');


            //Console.WriteLine(String.Join(" ", list));
        }
    }
}