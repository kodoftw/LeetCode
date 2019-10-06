using Xunit;

namespace _796_RotateString
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.RotateString("abcde", "cdeab"));
            Assert.False(solution.RotateString("abcde", "abced"));
        }
    }
}
