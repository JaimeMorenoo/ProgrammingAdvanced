using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;
using Module_06;
using System.Reflection;


namespace nth
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string input = Console.ReadLine();

                string[] input_array = input.Split(' ');

                int[] array = Array.ConvertAll(input_array, int.Parse);

                MissingL missing = new MissingL();

                missing.Bubble(array, array.Length);

                if (missing.MissingLink(array, 0, -1) == -1)
                {
                    Console.WriteLine("No missing link");
                }
                else
                {
                    Console.WriteLine(missing.MissingLink(array, 0, -1));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            };

        }
    }
}
namespace Module_06
{
    public class MissingL
    {
        public void Bubble(int[] array, int n)
        {
            if (n == 1) return;

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }

            Bubble(array, n - 1);
        }

        public int MissingLink(int[] array, int n, int result)
        {
            if (n == array.Length - 1) return -1;

            if (array[n] + 1 != array[n + 1] && array[n] > 0)
            {
                result = array[n] + 1;
                return result;
            }


            if (result == -1)
            {
                return MissingLink(array, n + 1, result);
            }
            else
            {
                return result;
            }
        }
    }
}