using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Parking
{
    internal class Assignment
    {
        private int[] Elements { get; set; }
        private int Top { get; set; }

        public Assignment(int size)
        {
            Elements = new int[size];
            Top = 0;
        }

        public void Push(int value)
        {
            if (Top == Elements.Length)
            {
                throw new Exception("Stack Overflow");
            }

            Elements[Top] = value;
            Top++;

        }

        public string Pop()
        {
            if (Top == 0)
            {
                throw new Exception("Stack underflow!");
            }
            string popped = Elements[Top - 1].ToString();
            Elements[Top - 1] = 0;
            Top--;
            return "Value popped: " + popped;

        }



        public string Parking(string input, int spots)
        {
            

            string[] cars = input.Split(" ");

            int[] entrance = new int[cars.Length];
            int[] exit = new int[cars.Length];

            for(int i = 0; i < entrance.Length; i++)
            {
                string[] value = cars[i].Split(":");
                
                int car_in = Convert.ToInt32(value[0]);
                int car_out = Convert.ToInt32(value[1]);
                entrance[i] = car_in;
                exit[i] = car_out;
            }

            Assignment stack = new Assignment(cars.Length);

      

            stack.Push(entrance[0] + exit[0]);
            spots--;

           // Console.WriteLine("Current spots --> " + spots);


            int not_in = 0;

            for(int i = 1; i < cars.Length; i++)
            {
               // Console.WriteLine(entrance[i] + exit[i]);
                
                
                if (stack.Elements[Top] >= entrance[i] + exit[i] && spots >= 1)
                {
                    spots--;
                    
                }
                if (stack.Elements[Top] > entrance[i] + exit[i] && spots < 1)
                {
                    not_in++;

                }
                if (stack.Elements[Top] < entrance[i] + exit[i]) // spots = 1
                {   
                    stack.Elements[Top] = entrance[i] + exit[i];
                    stack.Push(entrance[i]+ exit[i]);
                    spots++;
                    //Console.WriteLine("Pushing");
                }
                //Console.WriteLine("Top --> " + (stack.Elements[Top]));

                //Console.WriteLine("Current spots --> " + spots);


            }

            return not_in.ToString();


        }
    }
}
