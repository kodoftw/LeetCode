using Xunit;

namespace _594_LongestHarmoniousSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(5, solution.FindLHS(new[] { 1, 3, 2, 2, 5, 2, 3, 7 }));
        }
    }
}
