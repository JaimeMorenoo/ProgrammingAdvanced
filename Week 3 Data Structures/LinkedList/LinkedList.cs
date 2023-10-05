using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
            Next = null;
        }
    }
    internal class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Node head = null;
        }
        public LinkedList(Node head)
        {
            Head = head;
        }

        private Node Last()
        {
            Node iterator = Head;
            // Igualamos el primer node del linked list al head
            while(iterator.Next != null)
            {
                //Cuando el next del node sea null sera el ultimo 
                iterator = iterator.Next;

            }
            // Devolvemos el ultimo node
            return iterator;
        }

        public void Insert(Node node)
        {
            if(Head == null)
            {
                Head = node;
            }
            else
            {
                // Al ultimo node le añadimos un next
                Last().Next = node;
            }
        }

        public override string ToString()
        {
            string result = "";

            Node iterator = Head;

            if (Head == null)
            {
                return "Empty";
            }
            
            while (iterator.Next != null)
            {
                result += iterator.Data +" --> ";
                iterator = iterator.Next;

            }

            result += iterator.Data;

            return result;
        }


        public bool Search(int value)
        {
            if (Head == null) return false;

            if (Head.Data == value) return true;

            Node iterator = Head;

            while( iterator.Next != null)
            {
                iterator = iterator.Next;

                if (iterator.Data == value)
                {
                    return true;
                }
                
            }                      
            return false;

        }

        public void Delete(int value)
        {
            if(Head.Data == value)
            {
                Head = Head.Next;
                return;
            }
            Node iterator = Head;

            while (iterator.Next != null)
            {             

                if (iterator.Next.Data == value)
                {
                    iterator.Next = iterator.Next.Next;
                    return;
                }
                iterator = iterator.Next;


            }
        }
    }
}
