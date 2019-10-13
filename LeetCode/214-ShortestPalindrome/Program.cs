using Xunit;

namespace _214_ShortestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal("aaacecaaa", new Solution().ShortestPalindrome("aacecaaa"));
            Assert.Equal("dcbabcd", new Solution().ShortestPalindrome("abcd"));
        }
    }
}
