using Xunit;

namespace _859_BuddyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.BuddyStrings("ab", "ba"));
            Assert.False(solution.BuddyStrings("ab", "ab"));
            Assert.True(solution.BuddyStrings("aa", "aa"));
            Assert.True(solution.BuddyStrings("aaaaaaabc", "aaaaaaacb"));
            Assert.False(solution.BuddyStrings("", "aa"));
        }
    }
}
