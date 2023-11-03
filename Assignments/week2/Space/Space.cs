using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    internal class Space
    {
        public string space(string[] array)
        {
            int[] numbers = new int[array.Length];
            string result = "";
            for(int i = 0; i < array.Length; i++)
            {
                string[] split = array[i].Split(" ");

                int number = Convert.ToInt32(split[1].Substring(0, 1));
                numbers[i] = number;
                                      
            }
      
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int number = i;
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[j] < numbers[number])
                    {
                        number = j;
                    }
                }
                int x = numbers[i];
                numbers[i] = numbers[number];
                numbers[number] = x;
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                string number = numbers[i].ToString();

                for(int j = 0; j < array.Length; j++)
                {
                    string phrase = array[j];
                    string[] split = phrase.Split(" ");
                    if (split[1].Contains(number))
                    {

                        result += split[3].Replace("\"","") + " ";
                    }

                    
                }
            }
            return result;

        }

        public void order(string[] array)
        {

            for(int i = array.Length - 1; i >= 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    string[] a = array[j].Split(" ");
                    string[] b = array[j + 1].Split(" ");

                    int number_a = Convert.ToInt32(a[1].Substring(0,1));
                    int number_b = Convert.ToInt32(b[1].Substring(0, 1));

                    if (number_a > number_b)
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        
                    }
                }
            }

            for(int i = 0; i < array.Length; i++)
            {
                string[] word = array[i].Split(" ");
                Console.WriteLine(word[3].Replace("\"","") + " ");
            }
        }
    }
}
