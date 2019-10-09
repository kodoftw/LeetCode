using System.Collections.Generic;
using System.Linq;

namespace _883_ProjectionAreaOf3DShapes
{
    internal class Solution
    {
        public int ProjectionArea(int[][] grid)
        {
            var maxPerRow = new List<int>();
            int ySum = 0;
            int zSum = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                int max = 0;
                int len = 0;
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] != 0)
                    {
                        len++;
                    }

                    if (grid[i][j] > max)
                    {
                        max = grid[i][j];
                    }

                    if (maxPerRow.Count == j)
                    {
                        maxPerRow.Add(grid[i][j]);
                    }
                    else if (maxPerRow[j] < grid[i][j])
                    {
                        maxPerRow[j] = grid[i][j];
                    }
                }

                ySum += max;
                zSum += len;
            }

            return maxPerRow.Sum() + ySum + zSum;
        }
    }
}
