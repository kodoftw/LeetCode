using System;
using System.Collections.Generic;

namespace _448_FindAllNumbersDisappearedInAnArray
{
    internal class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var ret = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var val = Math.Abs(nums[i]) - 1;
                if (nums[val] > 0)
                {
                    nums[val] = -nums[val];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    ret.Add(i + 1);
                }
            }

            return ret;
        }
    }
}
