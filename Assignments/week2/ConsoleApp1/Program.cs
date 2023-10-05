namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = -121;

            int[] number = new int[x.ToString().Length];

            for(int i = 0; i < x.ToString().Length; i++)
            {
                number[i] += Convert.ToInt32(x.ToString()[i]);

            }

            if(number.SequenceEqual(number.Reverse()))
            {
                Console.WriteLine(true);
            }
        }
    }
}