using System;
using System.Collections.Generic;

namespace _15_3Sum
{
    internal class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || nums[i - 1] != nums[i])
                {
                    // 2sum skipping the ith element
                    int start = i + 1;
                    int end = nums.Length - 1;
                    int target = 0 - nums[i];

                    while (start < end)
                    {
                        var sum = nums[start] + nums[end];
                        if (sum == target)
                        {
                            // match
                            result.Add(new List<int>() { nums[i], nums[start], nums[end] });

                            // move indexes forward
                            // Must move both since they cannot sum the same whilst only one changed
                            // We first skip repeated instances
                            while (start < end && nums[start] == nums[start + 1]) start++;
                            while (start < end && nums[end] == nums[end - 1]) end--;

                            // Then move forward to non-repeated numbers
                            start++;
                            end--;
                        }
                        else if (sum > target)
                        {
                            end--;
                        }
                        else
                        {
                            start++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
