using System.Collections.Generic;

namespace _377_CombinationSumIV
{
    internal class Solution
    {
        private IDictionary<int, int> CombSum = new Dictionary<int, int>() { { 0, 1 } };

        public int CombinationSum4(int[] nums, int target)
        {
            if (CombSum.ContainsKey(target))
                return CombSum[target];

            int sum = 0;
            foreach (var num in nums)
            {
                if (num <= target)
                    sum += CombinationSum4(nums, target - num);
            }

            CombSum[target] = sum;
            return sum;
        }
    }
}
