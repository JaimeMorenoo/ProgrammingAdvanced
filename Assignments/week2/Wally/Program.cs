using System.Diagnostics;
namespace Wally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("names.txt");

            Finding bubble = new Finding();
            Selection select = new Selection();
            Insert insert = new Insert();
            Brick brick = new Brick();
            Gnome gnome = new Gnome();

            

            Console.WriteLine("Bubble Sort: "+bubble.Bubble(file, "Wally"));
            Console.WriteLine("Select Sort: " + select.selection(file, "Wally"));
            Console.WriteLine("Inert Sort: " + insert.insert(file, "Wally"));
            Console.WriteLine("Brick Sort: " + brick.brick(file, "Wally"));
            Console.WriteLine("Gnome Sort: " + gnome.gnome(file, "Wally"));
        }
    }
}