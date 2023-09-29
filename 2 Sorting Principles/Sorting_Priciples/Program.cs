using System.Diagnostics;

namespace Sorting_Priciples

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("numbers.txt");

            int[] array = Array.ConvertAll(file, int.Parse);

            Stopwatch s_bubble = new Stopwatch();
            Stopwatch s_select = new Stopwatch();
            Stopwatch s_insert = new Stopwatch();


            Bubble bubble = new Bubble();
            Selection select = new Selection();
            Insertion insertion = new Insertion();  
            s_select.Start();
            bubble.bubble(array);
            s_select.Stop();

            Console.WriteLine(s_select.ElapsedMilliseconds);
           
          
        }
    }
}