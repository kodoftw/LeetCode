namespace _896_MonotonicArray
{
    internal class Solution
    {
        public bool IsMonotonic(int[] A)
        {
            bool isIncreasing = true;
            bool isDecreasing = true;

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i - 1] > A[i])
                    isDecreasing = false;

                if (A[i - 1] < A[i])
                    isIncreasing = false;

                if (isDecreasing == false && isIncreasing == false)
                    return false;
            }

            return true;
        }
    }
}
