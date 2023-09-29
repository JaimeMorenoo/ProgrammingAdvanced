# Sorting Algorithims

## Bubble Sort

Scan the array, swapping adjacent pair of elements if they are not in  order. This bubbles up the largest element to the end.

<img src="https://www.computersciencebytes.com/wp-content/uploads/2016/10/bubble_sort.png">

```c#
public void Bubble(int[] array)
{
  for (int i = array.Length - 1; i >= 0; i--)
  {
    // Console.WriteLine(String.Join(" ",array));
    for (int j = 0; j < i; j++)
    {
      if (array[j] > array[j + 1]) 
      {
         int b = array[j];
         array[j] = array[j + 1];
         array[j + 1] = b;
       }
    }
  }
}
```

> Basicamente iniciamos el array con el ultimo indice para que vaya decrementando el checkeo a medida que sortea una iteracion

![BubbleSort](https://i.stack.imgur.com/XNbE0.gif)

## Selection Sort

* Find the smallest element, and put it to the first position.
* Find the next smallest element, and put it to the second position.
* Repeat until all elements are sorted

```c#
public void Selection(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    // Console.WriteLine(String.Join(" ",array));

    int min = i;
    for (int j = i + 1; j < array.Length; j++)
    {
      if (array[j] < array[min]) min = j;
    }
    int b = array[i];
    array[i] = array[min];
    array[min] = b;
  }
}
```

![SelectionSort](https://miro.medium.com/v2/resize:fit:1144/1*5WXRN62ddiM_Gcf4GDdCZg.gif)