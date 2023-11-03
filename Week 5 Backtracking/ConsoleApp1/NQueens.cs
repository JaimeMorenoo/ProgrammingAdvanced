using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NQueens
    {
        char[,] board;
        int n;
        public NQueens(int size)
        {
            board = new char[size, size];
            
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    board[i, j] = '_';
                }
            }

            n = size;
            

        }

        public bool PlaceQueens(int col) // To know in which column the queen will start
        {
            if(col == n) // base case
            {
                return true;
            }

            for(int i = 0; i < n; i++)
            {
                if (IsSafe(i, col))
                {
                    board[i,col] = 'Q';
                    if(PlaceQueens(col + 1)) return true;
                    board[i, col] = '_';
                }
            }

            return false;


        }






        private bool IsSafe(int row, int column)  // Check rows and columns
        {
            // Check row left side
            for (int i = 0; i < column; i++)
            {
                if (board[row, i] == 'Q') return false; // Check if the queen is in the row
            }
            // Check Upper Diagonal
            for(int i = row, j = column; i >= 0 && j>=0; i--, j--) // This will check upper diagonal
            {
                if (board[i, j] == 'Q') return false; // Checking if the diagonal has the Queen
            }

            // Check Lower Diagonal
            for(int i = row, j = column; i < n && j >= 0; i++,j--) // N is the size of the board
            {
                if (board[i, j] == 'Q') return false;

            }

            return true; // If there is no Queen in any of those places return true

            
        }




        public override string ToString()
        {
            string s = "";

            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(0); j++)
                {
                    s += board[i, j] + " ";
                }

                s += "\n";
            }

            return s;
        }
    }
}
