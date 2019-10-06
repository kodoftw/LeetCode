using System;

namespace _598_RangeAdditionII
{
    internal class Solution
    {
        public int MaxCount(int m, int n, int[,] ops)
        {
            var len = ops.GetLength(0);
            if (len == 0)
            {
                return m * n;
            }

            int minRow = int.MaxValue;
            int minCol = int.MaxValue;

            for (int i = 0; i < len; i++)
            {
                minRow = Math.Min(minRow, ops[i, 0]);
                minCol = Math.Min(minCol, ops[i, 1]);
            }

            return minRow * minCol;
        }
    }
}
