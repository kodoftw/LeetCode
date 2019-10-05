using System;

namespace _812_LargestTriangleArea
{
    internal class Solution
    {
        public double LargestTriangleArea(int[][] points)
        {
            double max = 0;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = 0; j < points.Length; j++)
                {
                    for (int k = 0; k < points.Length; k++)
                    {
                        var area = GetTriangleArea(points[i], points[j], points[k]);
                        if (area > max)
                        {
                            max = area;
                        }
                    }
                }
            }

            return max;
        }

        private double GetTriangleArea(int[] x, int[] y, int[] z)
        {
            return 0.5 * Math.Abs(x[0] * y[1] + y[0] * z[1] + z[0] * x[1] - y[0] * x[1] - z[0] * y[1] - x[0] * z[1]);
        }
    }
}
