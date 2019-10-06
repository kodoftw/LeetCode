using Xunit;

namespace _657_RobotReturnToOrigin
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.JudgeCircle("UD"));
            Assert.False(solution.JudgeCircle("LL"));
        }
    }
}
