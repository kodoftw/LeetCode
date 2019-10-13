using Xunit;

namespace _780_ReachingPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.True(new Solution().ReachingPoints(1, 1, 3, 5));
            Assert.False(new Solution().ReachingPoints(1, 1, 2, 2));
            Assert.True(new Solution().ReachingPoints(1, 1, 1, 1));
        }
    }
}
