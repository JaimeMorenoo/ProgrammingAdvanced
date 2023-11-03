using System.Security.Cryptography.X509Certificates;

namespace _04_Minimum
{
   
    internal class Program
    {
        
        static void Main(string[] args)
        {
            test clase = new test();

            int[] test = { 1, 2, 3, 4, 5, 6 };
            int n = test.Length;

            Console.WriteLine(clase.Minimum(test, n));

            

        }
    }
}