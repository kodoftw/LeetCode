using Xunit;

namespace _908_SmallestRangeI
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(0, solution.SmallestRangeI(new[] { 1 }, 0));
            Assert.Equal(6, solution.SmallestRangeI(new[] { 0, 10 }, 2));
            Assert.Equal(0, solution.SmallestRangeI(new[] { 1, 3, 6 }, 3));
        }
    }
}
