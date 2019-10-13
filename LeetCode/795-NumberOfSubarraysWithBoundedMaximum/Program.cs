using Xunit;

namespace _795_NumberOfSubarraysWithBoundedMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.NumSubarrayBoundedMax(new[] { 2, 1, 4, 3 }, 2, 3));
        }
    }
}
