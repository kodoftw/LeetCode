using System;
using System.Collections.Generic;

namespace _575_DistributeCandies
{
    internal class Solution
    {
        public int DistributeCandies(int[] candies)
        {
            var distribution = new HashSet<int>();

            foreach (var candy in candies)
            {
                if (distribution.Contains(candy))
                {
                    continue;
                }

                distribution.Add(candy);
            }

            return Math.Min(candies.Length / 2, distribution.Count);
        }
    }
}
