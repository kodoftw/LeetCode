namespace _463_IslandPerimeter
{
    internal class Solution
    {
        public int IslandPerimeter(int[,] grid)
        {
            var numRows = grid.GetLength(0);
            var numCols = grid.GetLength(1);
            var sum = 0;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (grid[i, j] == 0)
                        continue;

                    sum += 4;
                    if (IsInsideGrid(i + 1, j, grid) && grid[i + 1, j] == 1)
                    {
                        sum += -2;
                    }
                    if (IsInsideGrid(i, j + 1, grid) && grid[i, j + 1] == 1)
                    {
                        sum += -2;
                    }
                }
            }

            return sum;
        }

        private bool IsInsideGrid(int row, int col, int[,] grid)
        {
            var numRows = grid.GetLength(0);
            var numCols = grid.GetLength(1);

            return row < numRows && col < numCols;
        }
    }
}
