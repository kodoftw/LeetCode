using Xunit;

namespace _665_NonDecreasingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.CheckPossibility(new[] { 4, 2, 3 }));
            Assert.False(solution.CheckPossibility(new[] { 4, 2, 1 }));
        }
    }
}
