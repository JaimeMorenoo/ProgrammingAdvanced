namespace _05_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();
            int target = Convert.ToInt32(Console.ReadLine());
            List<int> currentCombination = new List<int>();

            sum.MagicSum(target, 0, currentCombination, 1);
        }
    }
}