using System.Collections.Generic;

namespace _447_NumberOfBoomerangs
{
    internal class Solution
    {
        public int NumberOfBoomerangs(int[,] points)
        {
            int res = 0;
            var distMap = new Dictionary<int, int>();
            int numPoints = points.GetLength(0);

            for (int i = 0; i < numPoints; i++)
            {
                for (int j = 0; j < numPoints; j++)
                {
                    if (i == j)
                        continue;

                    var dist = GetDistance(points[i, 0], points[i, 1], points[j, 0], points[j, 1]);
                    distMap[dist] = distMap.ContainsKey(dist) ? distMap[dist] + 1 : 1;
                }

                foreach (var value in distMap.Values)
                {
                    res += value * (value - 1);
                }
                distMap.Clear();
            }

            return res;
        }

        private int GetDistance(int ax, int ay, int bx, int by)
        {
            var x = ax - bx;
            var y = ay - by;

            return x * x + y * y;
        }
    }
}
