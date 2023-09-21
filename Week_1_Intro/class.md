# Introduction Class

## Searching and Big O Notation

### What are Algorithms?
+ Step by step instructions to solve an specific problem
+ The same problem can be often solved in multiple ways using different algorithms

### Why is Algorithm Choice Important?

+ **Eficiency** -> Some algorithsm can solve problems faster than others
+ **Space** -> The amount of memory an algorithm uses can vary
+ **Robustness** -> Some can better handle errors or unexpected inputs.

## Searching: Finding Information Efficiently

+ Searching is locating specific information within a larger set of data.
+ Access the information we need, when we need it in the most efficient way.

## Linear Search
With an array of 1000 numbers
```c#
 // Linear Algorithm
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
            
        }
```
## Random Search
