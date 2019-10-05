using System;
using System.Collections.Generic;

namespace _594_LongestHarmoniousSubsequence
{
    internal class Solution
    {
        private IDictionary<int, int> Subsequences = new Dictionary<int, int>();

        public int FindLHS(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
            {
                return 0;
            }

            int longest = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                IncreaseCount(nums[i]);
            }

            foreach (var key in Subsequences.Keys)
            {
                if (Subsequences.ContainsKey(key + 1))
                {
                    longest = Math.Max(Subsequences[key] + Subsequences[key + 1], longest);
                }
            }

            return longest;
        }

        private void IncreaseCount(int value)
        {
            if (!Subsequences.ContainsKey(value))
            {
                Subsequences[value] = 1;
            }
            else
            {
                Subsequences[value] = Subsequences[value] + 1;
            }
        }
    }
}
