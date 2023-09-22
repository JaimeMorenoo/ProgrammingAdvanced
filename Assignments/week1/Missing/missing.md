# 01 Missing

01 Missing

You are given a sorted array of numbers. Find the missing number in the array. If there is no missing number, print out 'No missing number.' Try to solve each exercise in different ways, always start from the naive approach first (brute force), and then try to work more efficiently based on what we saw in the lesson! Think what Big(O) could be!

**Input/Output**

>input:

1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59 60 62 63 64 65 66 67 68 69 70 71 72 73 74 75 76 77 78 79 80 81 82 83 84 85 86 87 88 89 90 91 92 93 94 95 96 97 98 99

>output:

61
___
>input:

6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59 60 61 62 63 64 65 66 67 68 69 70 71 72 73 74 75 76 77 78 79 80 81 82 83 84 85 86 87 88 89 90 91 92 93 94 95 96 97 98 99

>output:

43

```c#
        public int advanced(int[] array)
        {
            // Time Complexity O(n) & Space Complexity O(1)

            int length = array.Length;

            int n = ((length + 1) * (array[0] + array[length - 1]))/ 2;

            int m = 0; 

            foreach(int x in array)
            {
                m += x;
            }


            return n - m;
        }
```

**Time Complexity O(n) & Space Complexity O(1)**