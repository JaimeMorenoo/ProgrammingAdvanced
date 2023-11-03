using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Balance
{
    internal class Assignment
    {
        private string[] Elements { get; set; }
        private int Top { get; set; }


        public Assignment(int size)
        {
            Elements = new string[size];
            Top = 0;
        }

        public void Push(string value)
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
                return "1";
            }
            string popped = Elements[Top - 1];
            Elements[Top - 1] = null;
            Top--;
            return "Value popped: " + popped;

        }
        public string Balance (string input)
        {

            input = Regex.Replace(input, "[A-Za-z ]", "");

            //()[](())

            string opening = "([{";
            string closing = ")]}";

            Assignment stack = new Assignment(input.Length);

            foreach(char s in input)
            {
                if (opening.Contains(s))
                {
                    stack.Push(s.ToString());
                }
                if (closing.Contains(s))
                {
                    if(stack.Pop() == "1")
                    {
                        return "Too many close symbols";
                    }
                    else
                    {
                        stack.Pop();
                    }
                }

            }

            int count_open = 0;
            int count_close = 0;

            foreach(string s in stack.Elements)
            {
                if(s == "(" || s== "[" || s== "{")
                {
                    count_open++;
                }
                if (s == ")" || s == "]" || s == "}")
                {
                    count_close++;
                }
            }

            if(count_open > count_close)
            {
                return "Too many open symbols";
            }

            if (count_open < count_close)
            {
                return "Too many close symbols";
            }


            return "Balanced expression";



        }
    }
}
