using Xunit;

namespace _628_MaximumProductOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(6, solution.MaximumProduct(new[] { 1, 2, 3 }));
            Assert.Equal(24, solution.MaximumProduct(new[] { 1, 2, 3, 4 }));
        }
    }
}
