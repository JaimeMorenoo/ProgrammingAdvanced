using System;
namespace Module_01;

internal class Program
{
  
    static void Main(string[] args)
    {
        string file = "words.txt"; 
        Assignment duplicates = new Assignment();
        string input = Console.ReadLine();
        Console.WriteLine(duplicates.Duplicates(input, "words.txt"));

    }
}