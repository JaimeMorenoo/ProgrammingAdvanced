namespace _06_MissingLink
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string[] input_array = input.Split(" ");

            int[] array = Array.ConvertAll(input_array, int.Parse);

            Missing missing = new Missing();

            missing.Bubble(array, array.Length);

            if(missing.MissingLink(array,0,-1) == -1)
            {
                Console.WriteLine("No missing link");
            }
            else
            {
                Console.Write(missing.MissingLink(array, 0, -1));
            }
        }
    }
}