using System.Collections.Generic;

namespace _496_NextGreaterElementI
{
    internal class Solution
    {
        public int[] NextGreaterElement(int[] findNums, int[] nums)
        {
            var ret = new int[findNums.Length];
            var reverseIndex = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                reverseIndex.Add(nums[i], i);
            }

            for (int i = 0; i < findNums.Length; i++)
            {
                var cur = findNums[i];

                int j = reverseIndex[cur];
                while (j < nums.Length && nums[j] <= cur) j++;

                if (j == nums.Length)
                {
                    ret[i] = -1;
                }
                else
                {
                    ret[i] = nums[j];
                }
            }

            return ret;
        }
    }
}
