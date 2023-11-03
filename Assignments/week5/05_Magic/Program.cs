namespace _05_Magic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());

            MagicSquare magicSquare = new MagicSquare(size);

            if (magicSquare.GenerateMagicSquare())
            {
                Console.WriteLine(magicSquare);
            }
            else
            {
                Console.WriteLine("");
            }


        }
    }
}