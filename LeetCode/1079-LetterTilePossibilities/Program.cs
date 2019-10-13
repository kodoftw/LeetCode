using Xunit;

namespace _1079_LetterTilePossibilities
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(8, new Solution().NumTilePossibilities("AAB"));
            Assert.Equal(188, new Solution().NumTilePossibilities("AAABBC"));
        }
    }
}
