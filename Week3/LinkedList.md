# Data Structures

## Linked List

Primero en la clase de LinkedList tenemos que crear la clase Node con los valores Data y Next.
```c#
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
```
> Estos son los Nodes que iran dentro de nuesta LinkedList.

Dentro de la LinkedList tenemos que crear un Node Root (Head) que será el primero de la LinkedList. Podemos:

1. Crear un constructor con una LinkedList vacía
2. Crear un constructor con un Head Node en la LinkedList

```c#
public LinkedList()
        {
            Node head = null;
        }
        public LinkedList(Node head)
        {
            Head = head;
        }
```
Ahora vamos a añadir dos Methods (Last & Insert) para saber que cual es el último elemento de la LinkedList para poder asi Insert un elemento.
```c#
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
                // Al ultimo node le añadimos un next con el valor del Node nuevo.
                Last().Next = node;
            }
        }
```

Para borrar tenemos que igualar el valor que queremos borrar para que sea sea igual al siguiente Node
```c#
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
                    // Si el siguiente valor del siguiente Node es el valor que queremos eliminar
                    iterator.Next = iterator.Next.Next;
                    // Remplazamos ese node por su siguiente.
                    return;
                }
                iterator = iterator.Next;


            }
        }
```

Para imprimir hacemos un override a .ToString():
```c#
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
```

Y el main program se vería asi:
```c#
LinkedList list = new LinkedList();

list.Insert(new Node(10));
list.Insert(new Node(10));
list.Insert(new Node(11));
list.Insert(new Node(10));
list.Insert(new Node(12));


Console.WriteLine(list.ToString());

Console.WriteLine(list.Search(12));

list.Delete(12);

Console.WriteLine(list.ToString());
```

