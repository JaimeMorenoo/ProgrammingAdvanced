# Introduction Class : Searching and Big O Notation

>### What are Algorithms?
>+ Step by step instructions to solve an specific problem
>+ The same problem can be often solved in multiple ways using different algorithms
>
>### Why is Algorithm Choice Important?
>
>+ **Eficiency** -> Some algorithsm can solve problems faster than others
>+ **Space** -> The amount of memory an algorithm uses can vary
>+ **Robustness** -> Some can better handle errors or unexpected inputs.
>
>### Searching Finding Information Efficiently
>
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