using System;

namespace _892_SurfaceAreaOf3DShapes
{
    internal class Solution
    {
        public int SurfaceArea(int[][] grid)
        {
            var sum = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    var height = grid[i][j];

                    if (height == 0)
                        continue;

                    var top = GetGridHeight(i - 1, j, grid);
                    var right = GetGridHeight(i, j + 1, grid);
                    var bottom = GetGridHeight(i + 1, j, grid);
                    var left = GetGridHeight(i, j - 1, grid);

                    var neighbors = Math.Min(height, top)
                        + Math.Min(height, right)
                        + Math.Min(height, bottom)
                        + Math.Min(height, left);

                    sum += 2 + (height * 4) - neighbors;
                }
            }

            return sum;
        }

        private int GetGridHeight(int i, int j, int[][] grid)
        {
            if (i >= 0 && i < grid.Length && j >= 0 && j < grid[i].Length)
                return grid[i][j];

            return 0;
        }
    }
}
