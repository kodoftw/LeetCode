using Xunit;

namespace _242_ValidAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.IsAnagram("anagram", "nagaram"));
            Assert.False(solution.IsAnagram("rat", "car"));
        }
    }
}
