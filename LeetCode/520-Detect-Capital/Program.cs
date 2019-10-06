using Xunit;

namespace _520_Detect_Capital
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.DetectCapitalUse("USA"));
            Assert.False(solution.DetectCapitalUse("FlaG"));
        }
    }
}
