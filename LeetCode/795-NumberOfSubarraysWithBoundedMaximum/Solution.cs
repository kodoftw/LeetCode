namespace _795_NumberOfSubarraysWithBoundedMaximum
{
    internal class Solution
    {
        public int NumSubarrayBoundedMax(int[] A, int L, int R)
        {
            int num = 0,
                streak = 0,
                start = -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < L)
                {
                    num += streak;
                }
                else if (A[i] > R)
                {
                    streak = 0;
                    start = i;
                }
                else
                {
                    streak = i - start;
                    num += streak;
                }
            }

            return num;
        }
    }
}
