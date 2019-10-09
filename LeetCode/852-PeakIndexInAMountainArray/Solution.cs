namespace _852_PeakIndexInAMountainArray
{
    internal class Solution
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            int peak = A[0];
            int peakIndex = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > peak)
                {
                    peak = A[i];
                    peakIndex = i;
                }
            }

            return peakIndex;
        }
    }
}
