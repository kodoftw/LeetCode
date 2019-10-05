using System.Collections.Generic;

namespace _1_TwoSum
{
    internal class Solution
    {
        private IDictionary<int, int> MatchingIndex = new Dictionary<int, int>();

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (MatchingIndex.ContainsKey(nums[i]))
                {
                    return new int[] { MatchingIndex[nums[i]], i };
                }

                if (!MatchingIndex.ContainsKey(target - nums[i]))
                {
                    MatchingIndex.Add(target - nums[i], i);
                }
            }

            return null;
        }
    }
}
