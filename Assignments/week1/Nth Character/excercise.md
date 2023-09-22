# 01 Nth Character

Combine all words from the given file Download from the given file(already in CodeGrade) into one big string and find the nth character. Try to solve each exercise in different ways, always start from the naive approach first (brute force), and then try to work more efficiently based on what we saw in the lesson! Think what Big(O) could be!

**Input/Output**

input:

>4728391

output:

>h
___
input:

>9256087

output:

>k

```c#
        public string search(string[]array, int input)
        {
            // Time Complexity O(n) & Space Complexity O(1)
            string words = string.Join("", array);
            return words[input].ToString();
        }
```
**Time Complexity (O)n & Space Complexity O(1)**
