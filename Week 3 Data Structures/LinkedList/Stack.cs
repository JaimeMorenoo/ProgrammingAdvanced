using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Stack
    {
        private string[] Elements { get; set; }
        private int Top  { get; set; }


        public Stack(int size)
        {
            Elements = new string[size];
            Top = 0;
        }

        public void Push(string value)
        {
            if(Top == Elements.Length)
            {
                throw new Exception("Stack Overflow");
            }

            Elements[Top] = value;
            Top++;

        }

        public string Pop()
        {
            if(Top == 0)
            {
                throw new Exception("Stack underflow!");
            }
            string popped = Elements[Top - 1];
            Elements[Top - 1] = null;
            Top--;
            return "Value popped: "+popped;

        }

        public override string ToString()
        {
            string result = "";

            foreach(string element in Elements)
            {
               if(element != null)
                {
                    result += element + "\n";
                }
            }
            return result;
        }



    }
}
