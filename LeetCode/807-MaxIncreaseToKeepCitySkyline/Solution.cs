using System;

namespace _807_MaxIncreaseToKeepCitySkyline
{
    internal class Solution
    {
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            var vertSkyline = new int[grid.Length];
            var horzSkyline = new int[grid[0].Length];

            VisitGrid(grid, (i, j) => {
                vertSkyline[j] = Math.Max(vertSkyline[j], grid[i][j]);
                horzSkyline[i] = Math.Max(horzSkyline[i], grid[i][j]);
            });

            int sum = 0;
            VisitGrid(grid, (i, j) => {
                sum += Math.Min(vertSkyline[j], horzSkyline[i]) - grid[i][j];
            });

            return sum;
        }

        private void VisitGrid(int[][] grid, Action<int, int> action)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    action(i, j);
                }
            }
        }
    }
}
