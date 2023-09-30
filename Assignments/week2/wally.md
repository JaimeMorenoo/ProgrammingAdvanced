# Where is Wally?

## Binary Search
Used as a different class with a swap bool to change if we use a method where it needs a differente use of string.Compare()
```c#
public string search(string[] array,string word, bool swap)
        {
             int start = 0;
             int end = array.Length - 1;
             
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (array[mid] == word)
                {
                    return word;
                }
                else if ( swap == false && string.Compare(word, array[mid]) > 0)
                {
                    end = mid - 1;
                }
                else if (swap == true && string.Compare(word, array[mid]) < 0)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }

            }
            return "Not founded";
```




## Bubble Sort

The first part of the method will be sorting the names in the array.

```c#
public string Bubble(string[] array, string word)
        {
    for(int i = array.Length - 1; i >= 0; i--)
                {
                    bool flag = false;
                    for(int j = 0; j < i; j++)
                    {
                        if (string.Compare(array[j], array[j + 1]) > 0)
                        {
                            string temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            flag = true;
                        }
                    }
                    if (!flag) break;
                }

    BinarySearch search = new BinarySearch();
            return search.search(array, word, true);
```
> Because it is a string array we need to use string.Compare which return < 0, == 0 or > 0. So if array[j] is bigger than the next one they swap position. I also added a flag to make it more efficient, if there are no more strings to move the method will stop searching.

Then we need to do a binary search to look for the name in the sorted array.

I added a function of binary search that has a swap bool in case I want to use it with either selection or Bubble, as they use different > and < symbols

> It has a Time Complexity of O(n) in the best case and 0(n^2) in the worst. It has a Space Complexity of O(1)

## Selection Sort

* Find the smallest element, and put it to the first position.
* Find the next smallest element, and put it to the second position.
* Repeat until all elements are sorted

```c#
public string Selection (string[] array, string word)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(string.Compare(array[j], array[min]) > 0)
                    {
                        min = j;
                    }
                    string temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                }                            
            }
            int start = 0;
            int end = array.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (array[mid] == word)
                {
                    return word;
                }
                else if (string.Compare(word, array[mid]) > 0)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }

            }
            return "Not founded";

            
```

> It has a Time Complexity of O(n^2) and a Space Complexity of O(1)

## Insert Sort
* Take the first element as a sorted subarray
* Insert the second element into the sorted subarray (shift elements if needed)
* Insert the third element into the sorted subarray
* Repeat until all elements are inserted.

```c#
public string insert(string[] array, string word)
        {
            for (int i = 0; i < array.Length; i++)
            {


                string tmp = array[i];
                int j;

                for (j = i; j > 0; j--)
                {
                    if (string.Compare(array[j - 1], tmp)< 0) break;
                    array[j] = array[j - 1];
                }
                array[j] = tmp;
            }

            BinarySearch search = new BinarySearch();
            return search.search(array, word, true);
        
    }
```

> It has a Time Complexity of O(n) and a Space Complexity of O(1)

## Brick Sort
* Variation of Bubble Sort
* Divided in two phases (Odd & Even)

![BRICK](https://media.geeksforgeeks.org/wp-content/cdn-uploads/odd-even-sort.png)

```c#
public string brick(string[] array, string word)
        {
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;
                string temp = "";

                // Perform Bubble sort on
                // odd indexed element
                for (int i = 1; i <= array.Length - 2; i = i + 2)
                {
                    if (string.Compare(array[i] , array[i + 1]) < 0)
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSorted = false;
                    }
                }

                // Perform Bubble sort on
                // even indexed element
                for (int i = 0; i <= array.Length - 2; i = i + 2)
                {
                    if (string.Compare(array[i] , array[i + 1]) < 0)
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSorted = false;
                    }
                }
            }
            BinarySearch search = new BinarySearch();
            return search.search(array, word, false);
```

## Gnome Sort

* It is based on a Garden Gnome sorting his flower pots
* He looks at the flower next to him and the next one, if they are in the right order he steps one pot if not he swaps and steps backwards
* If there is at the starting line he steps foward and if he reaches the end he stops

![Gnome](https://upload.wikimedia.org/wikipedia/commons/c/c2/GnomeSort.png)

```c#
 public string gnome(string[] array, string word)
        {
            int index = 0;

            while (index < array.Length)
            {
                if (index == 0)
                    index++;
                if (string.Compare(array[index] , array[index - 1]) <= 0)
                    index++;
                else
                {
                    string temp = "";
                    temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;
                    index--;
                }
            }

            BinarySearch search = new BinarySearch();
            return search.search(array, word, false);
        }
```



## Program.cs
This is how the main class would look like

```c#
string[] file = File.ReadAllLines("names.txt");

Finding bubble = new Finding();
Selection select = new Selection();
Insert insert = new Insert();
Brick brick = new Brick();
Gnome gnome = new Gnome();

            

Console.WriteLine("Bubble Sort: "+bubble.Bubble(file, "Wally"));
Console.WriteLine("Select Sort: " + select.selection(file, "Wally"));
Console.WriteLine("Inert Sort: " + insert.insert(file, "Wally"));
Console.WriteLine("Brick Sort: " + brick.brick(file, "Wally"));
Console.WriteLine("Gnome Sort: " + gnome.gnome(file, "Wally"));
```