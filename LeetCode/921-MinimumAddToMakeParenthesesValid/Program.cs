using Xunit;

namespace _921_MinimumAddToMakeParenthesesValid
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(1, new Solution().MinAddToMakeValid("(()"));
            Assert.Equal(3, new Solution().MinAddToMakeValid("((("));
            Assert.Equal(0, new Solution().MinAddToMakeValid("()"));
            Assert.Equal(4, new Solution().MinAddToMakeValid("()))(("));
        }
    }
}
