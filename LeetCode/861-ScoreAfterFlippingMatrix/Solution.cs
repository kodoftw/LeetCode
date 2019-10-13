using System;

namespace _861_ScoreAfterFlippingMatrix
{
    internal class Solution
    {
        public int MatrixScore(int[][] A)
        {
            int numRows = A.Length;
            int numCols = A[0].Length;

            for (int i = 0; i < numRows; i++)
            {
                if (A[i][0] == 0)
                {
                    FlipRow(A, numCols, i);
                }
            }

            int maxOnes = (numRows & 1) == 1 ? (numRows / 2) + 1 : numRows / 2;
            for (int j = 1; j < numCols; j++)
            {
                int numOnes = 0;
                for (int i = 0; i < numRows; i++)
                {
                    if (A[i][j] == 1)
                        numOnes++;

                    if (numOnes == maxOnes)
                        break;
                }

                if (numOnes < maxOnes)
                {
                    FlipCol(A, numRows, j);
                }
            }

            int sum = 0;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (A[i][j] == 0) continue;

                    sum += (1 << (numCols - j - 1));
                }
            }

            return sum;
        }

        private void FlipRow(int[][] grid, int numCols, int row)
        {
            for (int col = 0; col < numCols; col++)
            {
                grid[row][col] = Math.Abs(grid[row][col] - 1);
            }
        }

        private void FlipCol(int[][] grid, int numRows, int col)
        {
            for (int row = 0; row < numRows; row++)
            {
                grid[row][col] = Math.Abs(grid[row][col] - 1);
            }
        }
    }
}
