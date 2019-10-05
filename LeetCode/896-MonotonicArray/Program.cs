using Xunit;

namespace _896_MonotonicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.IsMonotonic(new[] { 1, 2, 2, 3 }));
            Assert.True(solution.IsMonotonic(new[] { 6, 5, 4, 4 }));
            Assert.False(solution.IsMonotonic(new[] { 1, 3, 2 }));
            Assert.True(solution.IsMonotonic(new[] { 1, 2, 4, 5 }));
            Assert.True(solution.IsMonotonic(new[] { 1, 1, 1 }));
        }
    }
}
