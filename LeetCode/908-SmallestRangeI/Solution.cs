namespace _908_SmallestRangeI
{
    internal class Solution
    {
        public int SmallestRangeI(int[] A, int K)
        {
            int min;
            int max;

            if (A.Length <= 1) return 0;

            findMinAndMax(A, out min, out max);

            if (min + K > max - K)
                return 0;
            else
                return max - min - 2 * K;
        }

        private void findMinAndMax(int[] a, out int min, out int max)
        {
            min = int.MaxValue;
            max = int.MinValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
        }
    }
}
