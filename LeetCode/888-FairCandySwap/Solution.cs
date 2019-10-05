using System.Collections.Generic;
using System.Linq;

namespace _888_FairCandySwap
{
    internal class Solution
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            var sumAlice = A.Sum();
            var sumBob = B.Sum();

            var target = (sumAlice - sumBob) / 2;

            var aliceSet = new HashSet<int>();

            foreach (var value in A)
            {
                aliceSet.Add(value);
            }

            foreach (var value in B)
            {
                if (aliceSet.Contains(value + target))
                {
                    return new int[2] { value + target, value };
                }
            }

            return new int[2];
        }
    }
}
