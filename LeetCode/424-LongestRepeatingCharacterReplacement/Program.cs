using Xunit;

namespace _424_LongestRepeatingCharacterReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(4, solution.CharacterReplacement("ABAB", 2));
            Assert.Equal(4, solution.CharacterReplacement("AABABBA", 1));
        }
    }
}
