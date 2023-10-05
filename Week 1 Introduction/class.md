# Introduction Class : Searching and Big O Notation
### What are Algorithms?
>+ Step by step instructions to solve an specific problem
>+ The same problem can be often solved in multiple ways using different algorithms

### Why is Algorithm Choice Important?

>+ **Eficiency** -> Some algorithsm can solve problems faster than others
>+ **Space** -> The amount of memory an algorithm uses can vary
>+ **Robustness** -> Some can better handle errors or unexpected inputs.

## Searching: Finding Information Efficiently

>+ Searching is locating specific information within a larger set of data.
>+ Access the information we need, when we need it in the most efficient way.

## Linear Search
With an array of 1000 numbers we do a simple linear search that will just iterate through all the numbers of the array until finding the number
```c#
 // Linear Algorithm in the searching.cs
        public int Linear(int[] array, int number)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == number)
                {
                    return i;
                }
            }
            return -1;

// In the main.cs:
search.Linear(array, 45)
            
        }
```
## Random Search
This will generate random numbers with a max count of the size of the array * 2, if the count reaches the max count it will stop looking.
```c#
// Random Search in the searching.cs
public int random(int[] array, int number)
        {
            int count = 0;
            int max_count = array.Length * 2;

            Random random = new Random();

            while(count < max_count)
            {
                // Busca un numero del 0 al 100
                int index = random.Next(0, array.Length);
                if (array[index] == number)
                {
                    return index;
                }
                count++;
            }
            return -1;
        }

// In the main.cs
search.random(array, 45)
```
## Binary Search
This search will create a start, mid ( (start + end)/2x ) and end. If the number is less than the middle the end will become the middle - 1. If the number is bigger than the middle the start will become the middle + 1.

```c#
// In the searching.cs
 public int binary(int[] array, int number)
        {
            int start = 0;
            int end = array.Length - 1;

            // We set the beginning and end of the number search

            while(start <= end)
            {
                int mid = (start + end) / 2;
                // We declare the mmid number
                if(array[mid] == number)
                {
                    return mid;
                }
                else if(number < array[mid])   
                {
                    // If the number is less than the mid the end will be the mid (end = 499)
                    end = mid - 1;
                }
                else
                {
                    // If the number is more than the mid the start becomes the mid (start = 501)
                    start = mid + 1;
                }
            }
            return -1;
        }

// In the main.cs
search.binary(array, 45)
```

## Time & Space Complexity

**Time**
1. O(log n): Por ejemplo, en algoritmos de búsqueda binaria, la complejidad es O(log n), lo que significa que el tiempo o espacio requerido aumenta de forma logarítmica con el tamaño de la entrada.

2. O(n): Muchos algoritmos tienen una complejidad lineal, lo que significa que el tiempo o espacio requerido aumenta de forma proporcional al tamaño de la entrada. Por ejemplo, recorrer una lista enlazada o un array.

3. O(n log n): Muchos algoritmos de clasificación eficientes, como el algoritmo Quicksort o Mergesort, tienen una complejidad de O(n log n)

4. O(n^2): Algunos algoritmos tienen una complejidad cuadrática, donde el tiempo o espacio requerido aumenta cuadráticamente con el tamaño de la entrada. Por ejemplo, algoritmos de ordenamiento ineficientes como Bubble Sort.

5. O(2^n): Algunos algoritmos exponenciales, donde el tiempo o espacio requerido se duplica con cada adición de un solo elemento en la entrada. Por ejemplo, algunos algoritmos recursivos ineficientes.

**Space**
#### O(1) - Complejidad Espacial Constante:

La notación O(1) para la complejidad espacial indica que la cantidad de memoria adicional utilizada por el algoritmo es constante, independientemente del tamaño de la entrada. Algunos ejemplos comunes de O(1) en complejidad espacial incluyen:

1. Variables locales: El espacio utilizado para variables locales y parámetros de entrada. Este espacio es constante y no depende del tamaño de la entrada.
2. Espacio para un número o un objeto: Independientemente del tamaño de la entrada, almacenar un número o una referencia a un objeto ocupa un espacio constante.

### Cuándo no es O(1):

1. O(n): Si tienes una estructura de datos que almacena n elementos, como un array o una lista, la complejidad espacial será O(n) porque el espacio requerido aumenta linealmente con el número de elementos.

2. O(log n): En estructuras de datos como árboles balanceados, la complejidad espacial puede ser logarítmica en función del número de elementos.

3. O(n^2), O(2^n): Algunos algoritmos pueden generar una cantidad significativa de datos adicionales basados en la entrada, lo que resulta en complejidades espaciales cuadráticas o exponenciales.