# Stacks

La clase stack tiene como propiedades un array del valor que queramos hacer el stack y una propiedad llamada Top que sera el top del stack.

```c#
private string[] Elements { get; set; }
        private int Top  { get; set; }

        // Constructor del stack
        public Stack(int size)
        {
            Elements = new string[size];
            Top = 0;
        }
```

Creamos el method push para añadir un elemento y que se vuelva el top:

```c#
 public void Push(string value)
        {
            if(Top == Elements.Length)
            {
                throw new Exception("Stack Overflow");
            }

            Elements[Top] = value;
            Top++;

        }
```

Y el method pop para eliminar el ulitmo elemento añadido

```c#
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
```