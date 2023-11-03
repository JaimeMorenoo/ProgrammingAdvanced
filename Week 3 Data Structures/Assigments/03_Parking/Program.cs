namespace _03_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment test = new Assignment(5);

            int spots = Convert.ToInt32(Console.ReadLine());
            string times = Console.ReadLine();

            Console.WriteLine(test.Parking(times, spots));
        }
    }
}