# Space Assignment

## 03 Space

You're in a space team and got mixed-up signals from far away. Each signal has a timemark and a part of a message. Sort to order the signals by time and find the hidden message. Remember, no Array class tricks are allowed! Try to solve each exercise in different ways, always start from the naive approach first (brute force), and then try to work more efficiently based on what we saw in the lesson! Think what Big(O) could be!

Input/Output


input:


TS: 6, fragment: "system"


TS: 2, fragment: "Hello"


TS: 4, fragment: "our"


TS: 1, fragment: "Interstellar"


TS: 3, fragment: "from"


TS: 5, fragment: "solar"


output:


Interstellar Hello from our solar system


```c#
 public void order(string[] array)
        {
            for(int i = array.Length - 1; i >= 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    string[] a = array[j].Split(" ");
                    string[] b = array[j + 1].Split(" ");

                    int number_a = Convert.ToInt32(a[1].Substring(0,1));
                    int number_b = Convert.ToInt32(b[1].Substring(0, 1));

                    if (number_a > number_b)
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        
                    }
                }
            }
```