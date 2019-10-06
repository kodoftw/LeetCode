using System;

namespace _628_MaximumProductOfThreeNumbers
{
    internal class Solution
    {
        public int MaximumProduct(int[] nums)
        {
            int pos1 = int.MinValue,
                pos2 = int.MinValue,
                pos3 = int.MinValue,
                neg1 = int.MaxValue,
                neg2 = int.MaxValue;

            foreach (var num in nums)
            {
                if (num > pos1)
                {
                    pos3 = pos2;
                    pos2 = pos1;
                    pos1 = num;
                }
                else if (num > pos2)
                {
                    pos3 = pos2;
                    pos2 = num;
                }
                else if (num > pos3)
                {
                    pos3 = num;
                }

                if (num < neg1)
                {
                    neg2 = neg1;
                    neg1 = num;
                }
                else if (num < neg2)
                {
                    neg2 = num;
                }
            }

            return Math.Max(pos1 * pos2 * pos3, neg1 * neg2 * pos1);
        }
    }
}
