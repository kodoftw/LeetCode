using Xunit;

namespace _888_FairCandySwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { 1, 2 }, solution.FairCandySwap(new[] { 1, 1 }, new[] { 2, 2 }));
            Assert.Equal(new[] { 1, 2 }, solution.FairCandySwap(new[] { 1, 2 }, new[] { 2, 3 }));
            Assert.Equal(new[] { 2, 3 }, solution.FairCandySwap(new[] { 2 }, new[] { 1, 3 }));
            Assert.Equal(new[] { 5, 4 }, solution.FairCandySwap(new[] { 1, 2, 5 }, new[] { 2, 4 }));
        }
    }
}
