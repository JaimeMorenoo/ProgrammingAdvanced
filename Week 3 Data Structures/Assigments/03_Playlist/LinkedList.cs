using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Playlist
{
    public class Node
    {
        public string Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(string value)
        {
            this.Value = value;
            Next = null;
            Previous = null;
        }
       

    }
    internal class LinkedList
    {
        public Node Root { get; set; }

        public LinkedList()
        {
            Node Root = null;
        }

        public LinkedList(Node root)
        {
            this.Root = root;
        }


        public Node Last()
        {
            Node iterator = Root;

            while(iterator.Next != null)
            {
                iterator = iterator.Next;  // We get the last of the list of the .Next is equal to null
            }

            return iterator;
        }

        public Node Next(Node node)
        {
            if(node == this.Last())  // We are doing it circular so if the node is the last one it returns the root
            {
                
                return Root;
            }
            
            return node.Next;

        }

        public Node Previous(Node node)
        {
            if(node == Root)
            {
                return this.Last();  // The previous of the Root is the last one
            }
            Node iterator = Root;

            while(iterator.Next != node)
            {
                if(iterator.Next == node)
                {
                    node.Previous = iterator;  // We do a loop in the circular list so if we reach that the .Next is our Node we know its the previous of our node
                    // so our parameter node.Previous will be the iterator
                }
                
                
            }

            return iterator;
        }

        public Node Search(string value)
        {
            if (Root == null) return null;

            Node iterator = Root;

            while (iterator.Next != null)
            {
                
                if (iterator.Value == value)
                {

                    return iterator;
                }
                iterator = iterator.Next;

            }
            return null;

        }

        public void Add(Node node)
        {


            if(Root == null)
            {
                Root = node;
            }
            else
            {
                Last().Next = node;
            }
        }

        public void Remove (string song)
        {
            if (Root.Value == song)
            {
                Root = Root.Next;
                return;
            }


            

            Node iterator = Root;

            while (iterator.Next != null)
            {
                if(iterator.Next.Value == song)
                {
                    iterator.Next = iterator.Next.Next;
                    return;
                }
                iterator = iterator.Next;
            }
        }


        public override string ToString()
        {
            string result = "";

            Node iterator = Root;

            if (Root == null)
            {
                return "Empty";
            }

            while (iterator.Next != null)
            {
                result += iterator.Value + " --> ";
                iterator = iterator.Next;

            }

            result += iterator.Value;

            return result;
        }

    }
}
