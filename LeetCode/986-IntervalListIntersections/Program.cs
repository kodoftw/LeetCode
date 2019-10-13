﻿using Xunit;

namespace _986_IntervalListIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(
                new[] { new[] { 1, 2 }, new[] { 5, 5 }, new[] { 8, 10 }, new[] { 15, 23 }, new[] { 24, 24 }, new[] { 25, 25 } },
                new Solution().IntervalIntersection(
                    new[] { new[] { 0, 2 }, new[] { 5, 10 }, new[] { 13, 23 }, new[] { 24, 25 } },
                    new[] { new[] { 1, 5 }, new[] { 8, 12 }, new[] { 15, 24 }, new[] { 25, 26 } }));
        }
    }
}
