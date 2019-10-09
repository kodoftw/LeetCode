using System.Collections.Generic;

namespace _766_ToeplitzMatrix
{
    internal class Solution
    {
        public bool IsToeplitzMatrix(int[,] matrix)
        {
            foreach (var diagonal in Diagonals(matrix))
            {
                if (DiagonalHasDifferentValues(diagonal))
                {
                    return false;
                }
            }

            return true;
        }

        private bool DiagonalHasDifferentValues(IEnumerable<int> diagonal)
        {
            var enumerator = diagonal.GetEnumerator();
            enumerator.MoveNext();
            var first = enumerator.Current;

            while (enumerator.MoveNext())
            {
                if (first != enumerator.Current)
                {
                    return true;
                }
            }

            return false;
        }

        private IEnumerable<IEnumerable<int>> Diagonals(int[,] matrix)
        {
            var numRows = matrix.GetLength(0);
            var numCols = matrix.GetLength(1);

            for (int i = numRows - 1; i > 0; i--)
            {
                yield return GetDiagonalValues(i, 0, matrix);
            }

            for (int i = 0; i < numCols; i++)
            {
                yield return GetDiagonalValues(0, i, matrix);
            }
        }

        private IEnumerable<int> GetDiagonalValues(int row, int col, int[,] matrix)
        {
            while (IsInsideMatrix(row, col, matrix))
            {
                yield return matrix[row, col];
                row++;
                col++;
            }
        }

        private bool IsInsideMatrix(int row, int col, int[,] matrix)
        {
            var numRows = matrix.GetLength(0);
            var numCols = matrix.GetLength(1);

            return row < numRows && col < numCols;
        }
    }
}
