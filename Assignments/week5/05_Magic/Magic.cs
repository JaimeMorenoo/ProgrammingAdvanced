using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _05_Magic
{
    internal class Magic
    {
        int[,] Square { get; set; }
        int n { get; set; }

        public Magic(int size)
        {
            
            Square = new int[size, size];
            n = size;
        }

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


        public Tuple<int,int> NextPosition(int row, int col)
        {
            int newRow = (row - 1 + n) % n;
            int newColumns = (col + 1) % n;

            if (Square[newRow, newColumns] != 0) // Here we check if there is a number and if there is we go to the next row
            {
                newRow = (row + 1) % n;
                newColumns = col;
            }

            return Tuple.Create(newRow, newColumns);
        }



        public string Create(int row, int col, int placed)
        {
            if (!isValid(placed)) return "Invalid Place";

            Square[row, col] = placed;

            return isMagic() ? "Magic Square Created!" : "Not a Magic Square.";
        }

        public bool GenerateMagicSquare()
        {
            return GenerateMagicSquare(0, 0);
        }

        public bool GenerateMagicSquare(int row, int col)
        {
            if (row == size - 1 && col == size)
            {
                return IsMagic(); // When we are in last row and column check if its magic
            }

            if (col == size) // If we are not in the last row we go to the next one
            {
                row++;
                col = 0;
            }

            for (int i = 1; i <= size * size; i++)
            {
                if (IsValid(i))
                {
                    Square[row, col] = i;
                    if (GenerateMagicSquare(row, col + 1))
                    {
                        return true;
                    }
                    Square[row, col] = 0; //If we dont find a valid magic square we try again
                }
            }

            return false;
        }






        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < Square.GetLength(0); i++)
            {
                for (int j = 0; j < Square.GetLength(0); j++)
                {
                    s += Square[i, j] + " ";
                }

                s += "\n";
            }

            return s;
        }
    }
}
