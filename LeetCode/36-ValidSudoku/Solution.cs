using System;

namespace _36_ValidSudoku
{
    internal class Solution
    {
        private class SudokuValidator
        {
            private const int GridSize = 9;
            private bool[][] Rows = new bool[GridSize][];
            private bool[][] Columns = new bool[GridSize][];
            private bool[][] Boxes = new bool[GridSize][];

            public SudokuValidator()
            {
                for (int i = 0; i < GridSize; i++)
                {
                    Rows[i] = new bool[GridSize];
                    Columns[i] = new bool[GridSize];
                    Boxes[i] = new bool[GridSize];
                }
            }

            public bool AddCellValueAndReturnIfValid(int cellValue, int row, int column)
            {
                return AddToRowAndReturnIfValid(cellValue, row)
                    && AddToColumnAndReturnIfValid(cellValue, column)
                    && AddToBoxesAndReturnIfValid(cellValue, row, column);
            }

            private bool AddToRowAndReturnIfValid(int cellValue, int row)
            {
                if (Rows[row][cellValue - 1])
                {
                    return false;
                }

                Rows[row][cellValue - 1] = true;
                return true;
            }

            private bool AddToColumnAndReturnIfValid(int cellValue, int column)
            {
                if (Columns[column][cellValue - 1])
                {
                    return false;
                }

                Columns[column][cellValue - 1] = true;
                return true;
            }

            private bool AddToBoxesAndReturnIfValid(int cellValue, int row, int column)
            {
                var boxIndex = CalculateBoxIndex(row, column);

                if (Boxes[boxIndex][cellValue - 1])
                {
                    return false;
                }

                Boxes[boxIndex][cellValue - 1] = true;
                return true;
            }

            private int CalculateBoxIndex(int row, int column)
            {
                return 3 * (row / 3) + (column / 3);
            }
        }

        public bool IsValidSudoku(char[][] board)
        {
            var validator = new SudokuValidator();

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.')
                    {
                        continue;
                    }

                    var cellValue = CharToInt(board[i][j]);
                    if (!validator.AddCellValueAndReturnIfValid(cellValue, i, j))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private int CharToInt(char c)
        {
            return (int)char.GetNumericValue(c);
        }
    }
}
