using System.Collections.Generic;
using Xunit;

namespace _15_3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new List<IList<int>>()
            {
                new List<int>() {-1, -1, 2 },
                new List<int>() { -1, 0, 1 }
            }, solution.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 }));
        }
    }
}
