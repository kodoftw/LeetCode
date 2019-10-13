using System;

namespace _915_PartitionArrayIntoDisjointIntervals
{
    internal class Solution
    {
        public int PartitionDisjoint(int[] A)
        {
            int index = 0;
            int leftMax = A[0];
            int max = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < leftMax)
                {
                    leftMax = max;
                    index = i;
                }
                else
                {
                    max = Math.Max(max, A[i]);
                }
            }

            return index + 1;
        }
    }
}
