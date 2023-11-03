# Magic Square

A magic square is when in a matrix the rows, columns and both diagonals are equal to n * (n² +1)/2 (in a 3x3  3 * (3² +1)/2 = 30/2 = 15. )

![MagicSquare](https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Magicsquareexample.svg/1200px-Magicsquareexample.svg.png)

We are going to create one with the following methods:

___
public int[,] Square { get; set; } //must be public property so I can play with in the Unit-Test
private int size; 

public MagicSquare(int square_size) // constructor

public string Create(int row, int col, int placed) //create magic square

public Tuple<int, int> NextPosition(int row, int col) //find next position to fill (next column, or next column and first column again)

public bool IsValid(int number) //is it valid to place this number? Is this number already in the square?

public bool IsMagic() //is it a magic square? Checks every row/column/diagonal for the right magic constant

public override string ToString() //prints magic square
___

## Class MagicSquare & Constructor

```c#
 int[,] Square { get; set; }
        int n { get; set; }

        public Magic(int size)
        {
            Square = new int[size, size];
            n = size;
        }
```
## isMagic()
This method will check the sum of each row and column (And diagonals) to see if its equal to the magicSum
```c#
public bool isMagic()
        {
            int magicSum = n * (n * n + 1) / 2; // The magic sum of the Square

            for(int i = 0; i < n; i++)
            {
                int rowSum = 0;
                int colSum = 0;

                for(int j = 0; j < n; j++)
                {
                    rowSum += Square[i,j]; // The sum of all the rows [(0,0),(0,1),(0,1),(0,2)] THEN [(1,0),(1,1),(1,2)]....
                    colSum += Square[j,i]; // The sum of all the columns[(0,0),(1,0),(2,0)] THEN [(0,1),(1,1),(2,1)]....
                }

                if (rowSum != magicSum || colSum != magicSum)
                {
                    return false;
                }
            }
            int diagonalSum1 = 0;
            int diagonalSum2 = 0;

            for(int i = 0; i < n; i++)
            {
                diagonalSum1 += Square[i,i]; // The sum of [(0,0),(1,1),(2,2)]
                diagonalSum2 += Square[i, n-1-i]; // The sum of [(0,2),(1,1),(2,0)]
            }

            return diagonalSum1 == magicSum && diagonalSum2 == magicSum; // If its equal to the magicSum its a magic square
            
        }
```

## isValid()
This method will check if the number we want to put in a place is valid (it belongs in the range of the size x size) also it will check if the number is already in the square
```c#
public bool isValid(int number)
        {
            foreach(var numbers in Square)
            {
                if(numbers == number)
                {
                    return false;
                }
            }

            return number >= 1 && number <= n * n; // Check if the number is between 1 or (3x3) which is the maximum value possible.

        }
```
## NextPosition(int row, int column)
This method will check the next position by going up in rows and left in columns, the % will make it be "Linked". If the newrows and columns selected are free we have them if not we try again.
```c#
public Tuple<int, int> NextPosition(int row, int col)
{
    int newRow = (row - 1 + size) % size;
    int newCol = (col + 1) % size;

    if (Square[newRow, newCol] != 0)
    {
        newRow = (row + 1) % size;
        newCol = col;
    }

    return Tuple.Create(newRow, newCol);
}
```

## Create()
If there it is a valid place we put the number
```c#
 public string Create(int row, int column, int placed)
        {
            if (!isValid(placed)) return "Invalid Place";

            Square[row, column] = placed;

            return ToString();
        }
```

## Main
We will specify a default first position row 0 column 1 and place the first number (1)
```c#
Magic magic = new Magic(size);



int row = 0;
int column = 1;

    for (int i = 1; i <= size * size; i++)
      {
        magic.Create(row, column, i); // We will iterate from 1 to size * size
        var next = magic.NextPosition(row, column);
        row = next.Item1;
        column = next.Item2;
         }

    Console.WriteLine(magic);

```