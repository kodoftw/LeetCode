using Xunit;

namespace _383_RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.False(solution.CanConstruct("a", "b"));
            Assert.False(solution.CanConstruct("aa", "ab"));
            Assert.True(solution.CanConstruct("aa", "aab"));
        }
    }
}
