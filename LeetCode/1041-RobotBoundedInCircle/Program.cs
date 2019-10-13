using Xunit;

namespace _1041_RobotBoundedInCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.True(new Solution().IsRobotBounded("GGLLGG"));
            Assert.False(new Solution().IsRobotBounded("GG"));
            Assert.True(new Solution().IsRobotBounded("GL"));
        }
    }
}
