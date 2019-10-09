using Xunit;

namespace _893_GroupsOfSpecial_EquivalentStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.NumSpecialEquivGroups(new[] { "a", "b", "c", "a", "c", "c" }));
            Assert.Equal(4, solution.NumSpecialEquivGroups(new[] { "aa", "bb", "ab", "ba" }));
            Assert.Equal(3, solution.NumSpecialEquivGroups(new[] { "abc", "acb", "bac", "bca", "cab", "cba" }));
            Assert.Equal(1, solution.NumSpecialEquivGroups(new[] { "abcd", "cdab", "adcb", "cbad" }));
        }
    }
}
