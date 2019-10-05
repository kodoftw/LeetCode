namespace _26_RemoveDuplicatesFromSortedArray
{
    internal class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int indexLastMax = 0;
            int uniques = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[indexLastMax])
                {
                    // new element
                    if (indexLastMax + 1 != i)
                    {
                        nums[indexLastMax + 1] = nums[i];
                    }
                    indexLastMax++;
                    uniques++;
                }
            }

            return uniques;
        }
    }
}
