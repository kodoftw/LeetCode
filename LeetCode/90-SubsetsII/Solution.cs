using System;
using System.Collections.Generic;

namespace _90_SubsetsII
{
    internal class Solution
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var subsets = new List<IList<int>>() { new List<int>() };

            Array.Sort(nums);

            int countDupSubsets = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    countDupSubsets = subsets.Count;
                }

                int numSubsets = subsets.Count;
                for (int j = numSubsets - countDupSubsets; j < numSubsets; j++)
                {
                    var newSubset = new List<int>(subsets[j]);
                    newSubset.Add(nums[i]);
                    subsets.Add(newSubset);
                }
            }

            return subsets;
        }
    }
}
