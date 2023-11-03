using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Conquer
{
    internal class Tower
    {
        public void Solve(int number, char from, char to, char other)
        {
            if(number == 1)
            {
                Console.WriteLine($"Move disk 1 from peg {from} to peg {to}");

                return;
            }

            Solve(number - 1, from, other, to);
            Console.WriteLine($"Move disk {number} from peg {from} to peg {to}");


            Solve(number - 1, other, to, from);
        }
    }
}
