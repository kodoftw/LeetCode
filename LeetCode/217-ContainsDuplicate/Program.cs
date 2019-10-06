using Xunit;

namespace _217_ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.ContainsDuplicate(new[] { 1, 2, 3, 1 }));
            Assert.False(solution.ContainsDuplicate(new[] { 1, 2, 3, 4 }));
            Assert.True(solution.ContainsDuplicate(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
        }
    }
}
