using Xunit;

namespace _9_PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.IsPalindrome(121));
            Assert.False(solution.IsPalindrome(-121));
            Assert.False(solution.IsPalindrome(10));
        }
    }
}
