using System.Collections.Generic;

namespace _70_ClimbingStairs
{
    internal class Solution
    {
        private IDictionary<int, int> FibonacciCache = new Dictionary<int, int>() { {1, 1}, {2, 2} };

        public int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;

            for (int i = 3; i <= n; i++)
            {
                FibonacciCache[i] = FibonacciCache[i - 1] + FibonacciCache[i - 2];
            }

            return FibonacciCache[n];
        }
    }
}
