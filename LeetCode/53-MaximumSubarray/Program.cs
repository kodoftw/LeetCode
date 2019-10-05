using Xunit;

namespace _53_MaximumSubarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(6, solution.MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }
    }
}
