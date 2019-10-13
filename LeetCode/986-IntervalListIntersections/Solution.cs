using System;
using System.Collections.Generic;

namespace _986_IntervalListIntersections
{
    internal class Solution
    {
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            var intervals = new List<int[]>();

            for (int i = 0, j = 0; i < A.Length && j < B.Length;)
            {
                var start = GetIntervalStart(A, B, i, j);
                var end = GetIntervalEnd(A, B, i, j);

                if (start <= end)
                {
                    intervals.Add(new int[2] { start, end });
                }

                if (end == A[i][1])
                    i++;
                if (end == B[j][1])
                    j++;
            }

            return intervals.ToArray();
        }

        private int GetIntervalStart(int[][] A, int[][] B, int i, int j)
        {
            var valueA = A[i][0];
            var valueB = B[j][0];

            return Math.Max(valueA, valueB);
        }

        private int GetIntervalEnd(int[][] A, int[][] B, int i, int j)
        {
            var valueA = A[i][1];
            var valueB = B[j][1];

            return Math.Min(valueA, valueB);
        }
    }
}
