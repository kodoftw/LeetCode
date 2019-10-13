using Xunit;

namespace _338_CountingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(new[] { 0, 1, 1 }, new Solution().CountBits(2));
            Assert.Equal(new[] { 0, 1, 1, 2, 1, 2 }, new Solution().CountBits(5));
        }
    }
}
