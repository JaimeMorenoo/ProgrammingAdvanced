# Exercises

## Excerise 1: Duplicates

<ins>**01 Duplicates**</ins>

Find all duplicates starting with a given sequence in the given file Download the given file(already in CodeGrade). Try to solve each exercise in different ways, always start from the naive approach first (brute force), and then try to work more efficiently based on what we saw in the lesson! Think what Big(O) could be!

**Input/Output**

<ins>input</ins>:
>
>aa
>
<ins>output</ins>:
>
>aaaogvhosm aaarwdshpe aabetaeils aacfrlsdtd aacguuwgmu aaddhroonm aadgjyuviz aafajokdlu aafhakixki aaheyrnjzo aahkjrnvhr aahpixoayl aahxwxcizt >aalkylujbh aamdipybjk aamqfpmnqu aaptqhdcwm aaqejjuict aaqnfgbglt aarfnsmwbd aarnlwpfce aauckqruos aaukjnnsnb aavjvxzqhn aavoilagcu aawwvajmny >aaxktlbwye
 ___
<ins>input</ins>:
>
>1
>
<ins>output</ins>:
>
>No duplicates found.

```c#
 public string naive(string[]array,string input)
        {
            string s = "";
            int counter = 0;
            for(int i=0;i<array.Length;i++)
            {
                string word = array[i].Substring(0,input.Length);
                counter++;
                if(input == word)
                {
                    string match = array[i];
                    for(int j = counter; j < array.Length; j++)
                    {
                        if(array[j] == match)
                        {
                            s += match + " ";
                        }
                    }
                }                           
            }
            if(s == "")
            {
                return "No duplicates found.";
            }
            return s.Trim();
        }

        // Advanced Method

        public string search(string[]array,string input)
        {
            // Time Complexity = O(n^2) & Space Complexity = O(1)

            StringBuilder result = new StringBuilder();
         
            foreach(string word in array)
            {
                if (word.StartsWith(input))
                {
                    int count = array.Count(x => x == word);

                    if(count > 1)
                    {
                       result.Append(word).Append(' ');
                    }                   
                }
            }

            if (result.Length == 0)
            {
                return "No duplicates found.";
            }


            return result.ToString().TrimEnd();
        }
```
### Time & Space Complexity

**The function search has a time complexity of O(n^2) because of the nested loops being used (foreach & count) and a space complexity of O(1) as it just uses variables for the data.**
