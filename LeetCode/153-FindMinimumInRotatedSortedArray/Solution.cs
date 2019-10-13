using System;

namespace _153_FindMinimumInRotatedSortedArray
{
    internal class Solution
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            else if (nums.Length == 2)
            {
                return Math.Min(nums[0], nums[1]);
            }

            return FindMinUsingBinarySeach(nums, 0, nums.Length);
        }

        private int FindMinUsingBinarySeach(int[] nums, int left, int right)
        {
            int middle = (left + right) / 2;

            if (middle + 1 == nums.Length)
            {
                // Array is sorted!
                return nums[0];
            }
            if (nums[middle] > nums[middle + 1])
            {
                return nums[middle + 1];
            }
            else if (nums[middle] < nums[left])
            {
                return FindMinUsingBinarySeach(nums, left, middle);
            }
            else
            {
                return FindMinUsingBinarySeach(nums, middle, right);
            }
        }
    }
}
