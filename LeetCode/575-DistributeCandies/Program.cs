using Xunit;

namespace _575_DistributeCandies
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.DistributeCandies(new[] { 1, 1, 2, 2, 3, 3 }));
            Assert.Equal(2, solution.DistributeCandies(new[] { 1, 1, 2, 3 }));
        }
    }
}
