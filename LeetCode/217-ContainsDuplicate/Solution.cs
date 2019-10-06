using System.Collections.Generic;

namespace _217_ContainsDuplicate
{
    internal class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var checkedNums = new HashSet<int>();

            foreach (var num in nums)
            {
                if (checkedNums.Contains(num))
                {
                    return true;
                }

                checkedNums.Add(num);
            }

            return false;
        }
    }
}
