using Xunit;

namespace _70_ClimbingStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(2, solution.ClimbStairs(2));
            Assert.Equal(3, solution.ClimbStairs(3));
            Assert.Equal(21, solution.ClimbStairs(7));
        }
    }
}
