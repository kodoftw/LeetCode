namespace _912_SortAnArray
{
    internal class Solution
    {
        public int[] SortArray(int[] nums)
        {
            return MergeSort(nums, 0, nums.Length - 1);
        }

        private int[] MergeSort(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return new int[] { arr[start] };
            }

            int middle = (start + end) / 2;
            var leftArr = MergeSort(arr, start, middle);
            var rightArr = MergeSort(arr, middle + 1, end);

            return MergeArrays(leftArr, rightArr);
        }

        private int[] MergeArrays(int[] leftArr, int[] rightArr)
        {
            var merged = new int[leftArr.Length + rightArr.Length];

            int leftIndex = 0,
                rightIndex = 0,
                mergedIndex = 0;

            while (leftIndex < leftArr.Length && rightIndex < rightArr.Length)
            {
                if (leftArr[leftIndex] < rightArr[rightIndex])
                {
                    merged[mergedIndex++] = leftArr[leftIndex++];
                }
                else
                {
                    merged[mergedIndex++] = rightArr[rightIndex++];
                }
            }

            while (leftIndex < leftArr.Length)
            {
                merged[mergedIndex++] = leftArr[leftIndex++];
            }

            while (rightIndex < rightArr.Length)
            {
                merged[mergedIndex++] = rightArr[rightIndex++];
            }

            return merged;
        }
    }
}
