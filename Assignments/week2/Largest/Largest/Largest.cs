using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest
{
    internal class Largest
    {
        public int largest(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {                             
                for(int j = 0; j < array.Length - i - 1; j++)
                {
                    string a = array[j].ToString() + array[j + 1].ToString();
                    string b = array[j + 1].ToString() + array[j].ToString();
                    // Compare both pairs to see which way they are bigger as a string
                    // If B is bigger than A they switch position

                    if(a.CompareTo(b) < 0)
                    {
                        string temp = array[j].ToString();
                        array[j] = array[j + 1];
                        array[j + 1] = Convert.ToInt32(temp);
                    }

                }
             
            }
            string largestNumber = string.Join("", array);
            return Convert.ToInt32(largestNumber);
        }
    }
}
