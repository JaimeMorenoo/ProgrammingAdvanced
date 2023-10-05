namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* LinkedList list = new LinkedList();

             list.Insert(new Node(10));
             list.Insert(new Node(10));
             list.Insert(new Node(11));
             list.Insert(new Node(10));
             list.Insert(new Node(12));


             Console.WriteLine(list.ToString());

             Console.WriteLine(list.Search(12));

             list.Delete(12);

             Console.WriteLine(list.ToString()); */

            Stack stack = new Stack(5);
            stack.Push("Hello");
            stack.Push("Bye");
            Console.WriteLine(stack.ToString());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.ToString());




        }
    }
}