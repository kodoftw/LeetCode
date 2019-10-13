using Xunit;

namespace _885_SpiralMatrixIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 } },
                new Solution().SpiralMatrixIII(1, 4, 0, 0));
            Assert.Equal(new[] {
                new[] { 1, 4 }, new[] { 1, 5 }, new[] { 2, 5 },
                new[] { 2, 4 }, new[] { 2, 3 }, new[] { 1, 3 },
                new[] { 0, 3 }, new[] { 0, 4 }, new[] { 0, 5 },
                new[] { 3, 5 }, new[] { 3, 4 }, new[] { 3, 3 },
                new[] { 3, 2 }, new[] { 2, 2 }, new[] { 1, 2 },
                new[] { 0, 2 }, new[] { 4, 5 }, new[] { 4, 4 },
                new[] { 4, 3 }, new[] { 4, 2 }, new[] { 4, 1 },
                new[] { 3, 1 }, new[] { 2, 1 }, new[] { 1, 1 },
                new[] { 0, 1 }, new[] { 4, 0 }, new[] { 3, 0 },
                new[] { 2, 0 }, new[] { 1, 0 }, new[] { 0, 0 }
            }, new Solution().SpiralMatrixIII(5, 6, 1, 4));
        }
    }
}
