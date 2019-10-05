using Xunit;

namespace _693_BinaryNumberWithAlternatingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.HasAlternatingBits(5));
            Assert.False(solution.HasAlternatingBits(7));
            Assert.False(solution.HasAlternatingBits(11));
            Assert.True(solution.HasAlternatingBits(10));
        }
    }
}
