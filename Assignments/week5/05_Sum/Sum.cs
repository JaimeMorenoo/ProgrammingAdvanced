using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sum
{
    internal class Sum
    {

        public void MagicSum(int targetSum, int currentSum, List<int> currentList,int currentNumber)
        {
            if (currentSum == targetSum)
            {
                Console.WriteLine(String.Join(" ", currentList)); // We print the list of numbers to get the sum 
                return;
            }
            else if (currentSum > targetSum) return; // If its bigger the sum return nothing

            for(int i = currentNumber; i <= targetSum; i++)
            {
                currentList.Add(i);
                //Console.WriteLine(i);
                MagicSum(targetSum, currentSum + i, currentList, i);
                currentList.RemoveAt(currentList.Count - 1);
            } 
        }
    }
}
